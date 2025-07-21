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
    /// 工单任务表
    /// </summary>
    [SugarTable("Work_Order_Tasks", TableDescription = "工单任务表")]
    public class Work_Order_Tasks : AuditableEntity
    {

        /// <summary>
        /// 生产工单Id
        /// </summary>
        [SugarColumn(ColumnName = "Work_Order_Id")]
        public int? Work_Order_Id { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 工单编号 (主键)
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, ColumnName = "Task_Id", IsNullable = false)]
        public string Task_Id { get; set; }

        /// <summary>
        /// 工单名称
        /// </summary>
        [SugarColumn(ColumnName = "Task_Name")]
        public string Task_Name { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [SugarColumn(ColumnName = "Site_Name")]
        public string Site_Name { get; set; }

        /// <summary>
        /// 工艺流程
        /// </summary>
        [SugarColumn(ColumnName = "ProcessRoute")]
        public string ProcessRoute { get; set; }

        /// <summary>
        /// 工序名称
        /// </summary>
        [SugarColumn(ColumnName = "Process_Name")]
        public string Process_Name { get; set; }

        /// <summary>
        /// 工序编号
        /// </summary>
        [SugarColumn(ColumnName = "Process_Id")]
        public string Process_Id { get; set; }

        /// <summary>
        /// 计划颜色
        /// </summary>
        [SugarColumn(ColumnName = "Tasks_Color")]
        public string Tasks_Color { get; set; }

        /// <summary>
        /// 计划数量
        /// </summary>
        [SugarColumn(ColumnName = "Plan_Nums")]
        public int? Plan_Nums { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 实际数量
        /// </summary>
        [SugarColumn(ColumnName = "Producation_Nums")]
        public int? Producation_Nums { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 计划开始时间
        /// </summary>
        [SugarColumn(ColumnName = "Plan_Start_Time", ColumnDataType = "DATE")]
        public DateTime? Plan_Start_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 计划完成时间
        /// </summary>
        [SugarColumn(ColumnName = "Plan_Finish_Time", ColumnDataType = "DATE")]
        public DateTime? Plan_Finish_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 计划生产时长
        /// </summary>
        [SugarColumn(ColumnName = "Plan_Producation_Time")]
        public string Plan_Producation_Time { get; set; }

        /// <summary>
        /// 实际生产时间
        /// </summary>
        [SugarColumn(ColumnName = "Real_Start_Time", ColumnDataType = "DATE")]
        public DateTime? Real_Start_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 实际结束时间
        /// </summary>
        [SugarColumn(ColumnName = "Real_Finish_Time", ColumnDataType = "DATE")]
        public DateTime? Real_Finish_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 实际生产时长
        /// </summary>
        [SugarColumn(ColumnName = "Real_Producation_Time")]
        public string Real_Producation_Time { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(ColumnName = "Status")]
        public int? Status { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 班组Id
        /// </summary>
        [SugarColumn(ColumnName = "TeamId")]
        public int? TeamId { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 质检人Id
        /// </summary>
        [SugarColumn(ColumnName = "QualityId")]
        public int? QualityId { get; set; } // INTEGER类型，如果可为NULL，使用int?
    }
}
