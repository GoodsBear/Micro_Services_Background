using MricoServices.Shared;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Domain.Product_Plan
{
    /// <summary>
    /// 生产工单表
    /// </summary>
    [SugarTable("Work_Order", TableDescription = "生产工单表")]
    public class Work_Order : AuditableEntity
    {
        /// <summary>
        /// 工单编号
        /// </summary>
        [SugarColumn(ColumnName = "Order_Id", IsNullable = false)]
        public string Order_Id { get; set; }

        /// <summary>
        /// 工单名称
        /// </summary>
        [SugarColumn(ColumnName = "Order_Name")]
        public string Order_Name { get; set; }

        /// <summary>
        /// 计划Id
        /// </summary>
        [SugarColumn(ColumnName = "Planning_Id")]
        public int? Planning_Id { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 工单进度
        /// </summary>
        [SugarColumn(ColumnName = "Order_Progress")]
        public string Order_Progress { get; set; }

        /// <summary>
        /// 工单状态
        /// </summary>
        [SugarColumn(ColumnName = "Status")]
        public int? Status { get; set; } // INTEGER类型，如果可为NULL，使用int?
    }
}
