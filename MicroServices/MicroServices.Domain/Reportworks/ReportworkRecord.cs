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
        [SugarColumn(ColumnDescription = "生产工单id", IsNullable = false)] 
        public int Work_Order_Id { get; set; }

        /// <summary>
        /// 工单任务id
        /// </summary>
        [SugarColumn(ColumnDescription = "工单任务id", IsNullable = false)]
        public int Work_Order_Tasks_Id { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [SugarColumn(ColumnDescription = "站点id", IsNullable = false)]
        public int SiteId { get; set; }

        /// <summary>
        /// 工艺路线id
        /// </summary>
        [SugarColumn(ColumnDescription = "工艺路线id", IsNullable = false)]
        public int ProcessRouteId { get; set; }

        /// <summary>
        /// 工序id
        /// </summary>
        [SugarColumn(ColumnDescription = "工序id", IsNullable = false)] 
        public int ProcessId { get; set; }

        /// <summary>
        /// 班组id
        /// </summary>
        [SugarColumn(ColumnDescription = "班组id", IsNullable = false)]
        public int TeamId { get; set; }

        /// <summary>
        /// 报工人员
        /// </summary>
        [SugarColumn(ColumnDescription = "报工人员", IsNullable = false)]
        public string ReportingPerson { get; set; }

        /// <summary>
        /// 报工数量
        /// </summary>
        [SugarColumn(ColumnDescription = "报工数量", IsNullable = false)] 
        public int ReportingQuantity { get; set; }

        /// <summary>
        /// 报工时间
        /// </summary>
        [SugarColumn(ColumnDescription = "报工时间", IsNullable = false)] 
        public DateTime ReportingDate { get; set; }

        /// <summary>
        /// 质检时间
        /// </summary>
        [SugarColumn(ColumnDescription = "质检时间", IsNullable = true)] 
        public DateTime? QualityDate { get; set; }

        /// <summary>
        /// 合格数量
        /// </summary>
        [SugarColumn(ColumnDescription = "合格", IsNullable = true)] 
        public int? Qualified { get; set; }

        /// <summary>
        /// 不合格数量
        /// </summary>
        [SugarColumn(ColumnDescription = "不合格数量", IsNullable = true)] 
        public int? Unqualified { get; set; }

        /// <summary>
        /// 合格率
        /// </summary>
        [SugarColumn(ColumnDescription = "合格率", IsNullable = true)]
        public string? QualifiedRate { get; set; }

        /// <summary>
        /// 检测结果
        /// </summary>
        [SugarColumn(ColumnDescription = "检测结果", IsNullable = false)] 
        public string InspectionResult { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(ColumnDescription = "状态", IsNullable = false)] 
        public int Status { get; set; }
    }
}
