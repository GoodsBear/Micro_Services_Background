using MricoServices.Shared;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Domain.Reportworks
{
    /// <summary>
    /// 报工记录表
    /// </summary>
    [SugarTable("ReportworkRecord", TableDescription = "报工记录表")]
    public class ReportworkRecord : AuditableEntity
    {
        /// <summary>
        /// 生产工单id
        /// </summary>
        [SugarColumn(ColumnName = "生产工单id")]
        public string Work_Order_Id { get; set; }
        /// <summary>
        /// 工单任务id
        /// </summary>
        [SugarColumn(ColumnName = "工单任务id")]
        public int Work_Order_Tasks_Id { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [SugarColumn(ColumnName = "站点id")]
        public string SiteId { get; set; }

        /// <summary>
        /// 工艺路线id
        /// </summary>
        [SugarColumn(ColumnName = "工艺路线id")]
        public string ProcessRouteId { get; set; }

        /// <summary>
        /// 工序id
        /// </summary>
        [SugarColumn(ColumnName = "工序id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 班组id
        /// </summary>
        [SugarColumn(ColumnName = "班组名称")]
        public string TeamId { get; set; }
        /// <summary>
        /// 报工人员
        /// </summary>
        [SugarColumn(ColumnName = "报工人员")]
        public string ReportingPerson { get; set; }

        /// <summary>
        /// 报工数量
        /// </summary>
        [SugarColumn(ColumnName = "报工数量")]
        public int ReportingQuantity { get; set; }
        /// <summary>
        /// 报工时间
        /// </summary>
        [SugarColumn(ColumnName = "报工时间")]
        public DateTime ReportingDate { get; set; }
        /// <summary>
        /// 质检时间
        /// </summary>
        [SugarColumn(ColumnName = "质检时间")]
        public DateTime? QualityDate { get; set; }
        /// <summary>
        /// 合格数量
        /// </summary>
        [SugarColumn(ColumnName = "合格")]
        public int Qualified { get; set; }

        /// <summary>
        /// 不合格数量
        /// </summary>
        [SugarColumn(ColumnName = "不合格数量")]
        public int Unqualified { get; set; }

        /// <summary>
        /// 合格率
        /// </summary>
        [SugarColumn(ColumnName = "合格率")]
        public string QualifiedRate { get; set; }

        /// <summary>
        /// 检测结果
        /// </summary>
        [SugarColumn(ColumnName = "检测结果")]
        public string InspectionResult { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(ColumnName = "状态")]
        public int Status { get; set; }
    }
}
