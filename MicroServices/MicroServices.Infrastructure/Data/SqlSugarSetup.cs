// MicroServices.Infrastructure/Data/SqlSugarSetup.cs
using Dm.util;
using MicroServices.Domain.InStorage;
using MricoServices.Domain.RBAC;
using MricoServices.Shared;
using SqlSugar;

namespace MricoServices.Infrastructure.Data
{
    public static class SqlSugarSetup
    {
        public static ISqlSugarClient GetSqlSugarClient(string connectionString, DbType dbType = DbType.PostgreSQL)
        {
            var db = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = dbType , // 数据库类型，默认为 SQL Server，可根据参数传入
                ConnectionString = connectionString,
                IsAutoCloseConnection = true, // 自动关闭连接
                InitKeyType = InitKeyType.Attribute,
                MoreSettings = new ConnMoreSettings { },
            });

            // 1. 配置实体与数据库表的映射 (如果类名和表名不一致时需要)
            // 示例：db.MappingTables.Add("User", "T_Users"); // 如果 User 实体对应数据库的 T_Users 表
            db.CodeFirst.InitTables(typeof(User));  //  初始化 User 实体对应的数据库表
            db.CodeFirst.InitTables(typeof(Role)); // 初始化 Role 实体对应的数据库表
            db.CodeFirst.InitTables(typeof(UserRole)); // 初始化 UserRole 实体对应的数据库表
            db.CodeFirst.InitTables(typeof(Permission)); // 初始化 Permission 实体对应的数据库表
            db.CodeFirst.InitTables(typeof(RolePermission)); // 初始化 RolePermission 实体对应的数据库表
            db.CodeFirst.InitTables(typeof(Menu)); // 初始化 Menu 实体对应的数据库表
            db.CodeFirst.InitTables(typeof(RoleMenu)); // 初始化 RoleMenu 实体对应的数据库表


            			#region 仓库相关表的数据初始化

			db.CodeFirst.InitTables(typeof(ProductStorage)); // 初始化 产品入库表 实体对应的数据库表
            db.CodeFirst.InitTables(typeof(PurchaseStorage)); // 初始化 采购入库单 实体对应的数据库表
			db.CodeFirst.InitTables(typeof(PurchaseInventoryMaterial)); // 初始化 入库物料单 实体对应的数据库表
			db.CodeFirst.InitTables(typeof(PurchaseTest)); // 初始化 采购检验单 实体对应的数据库表
			db.CodeFirst.InitTables(typeof(ReceiveOrReturn)); // 初始化 退料单编号 实体对应的数据库表
			db.CodeFirst.InitTables(typeof(WareHouse)); // 初始化 仓库 实体对应的数据库表
			db.CodeFirst.InitTables(typeof(WareHouseArea)); // 初始化 库区信息表 实体对应的数据库表
			db.CodeFirst.InitTables(typeof(WareHouseLocation)); // 初始化 库位信息表 实体对应的数据库表
			#endregion

            // 2. 配置全局查询过滤器 (实现软删除的核心)
            // 使用 db.QueryFilter.Add 方法
            db.QueryFilter.AddTableFilter<AuditableEntity>(it => it.IsDeleted == false);

            // 3. 配置 AOP 拦截 (用于自动填充审计字段)
            db.Aop.DataExecuting = (oldValue, entityInfo) =>
            {
                // TODO: 在实际应用中，这里需要从 HttpContextAccessor 或其他身份验证机制中获取当前用户ID和用户名
                // 为了演示，我们暂时使用硬编码的示例值。
                int currentUserId = 1; // 示例用户ID (请根据实际情况替换)
                string currentUserName = "SystemUser"; // 示例用户名 (请根据实际情况替换)

                // 检查实体是否是 AuditableEntity 类型或其子类
                if (entityInfo.EntityValue is AuditableEntity auditableEntity)
                {
                    if (entityInfo.OperationType == DataFilterType.InsertByObject) // 插入操作
                    {
                        auditableEntity.CreatedAt = DateTime.Now;
                        auditableEntity.CreatedBy = currentUserId;
                        auditableEntity.CreatedByUserName = currentUserName;

                        auditableEntity.IsDeleted = false; // 确保新增时默认为未删除
                    }
                    else if (entityInfo.OperationType == DataFilterType.UpdateByObject) // 更新操作
                    {


                        if (auditableEntity.IsDeleted == true && auditableEntity.DeletedAt == null) // 假设 DeletedAt 为空表示首次标记删除
                        {
                            auditableEntity.DeletedAt = DateTime.Now;
                            auditableEntity.DeletedBy = currentUserId;
                            auditableEntity.DeletedByUserName = currentUserName;
                            return;
                        }

                        auditableEntity.UpdatedAt = DateTime.Now;
                        auditableEntity.UpdatedBy = currentUserId;
                        auditableEntity.UpdatedByUserName = currentUserName;
                    }
                }
            };

            return db;
        }
    }
}