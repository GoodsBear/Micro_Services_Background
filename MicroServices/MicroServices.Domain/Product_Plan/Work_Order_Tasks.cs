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
        /// 任务编号
        /// </summary>
        public string Task_Id { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        public string Task_Name { get; set; }
        /// <summary>
        /// 站点名称
        /// </summary>
        public string Site_Name { get; set; }
        /// <summary>
        /// 生产工单Id
        /// </summary>
        [SugarColumn(ColumnName = "Work_Order_Id")]
        public int? Work_Order_Id { get; set; } // INTEGER类型，如果可为NULL，使用int?
      
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
