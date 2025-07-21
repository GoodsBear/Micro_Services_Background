using MricoServices.Shared;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Domain.Qualify
{
    /// <summary>
    /// 缺陷位置表
    /// </summary>
    [SugarTable("DefectLocation", TableDescription = "缺陷位置表")]
    public class DefectLocation : AuditableEntity
    {
        /// <summary>
        /// 缺陷位置编码
        /// </summary>
        [SugarColumn(ColumnDescription = "缺陷位置编码")]
        public string? LoactionCode { get; set; }
        /// <summary>
        /// 缺陷位置名称
        /// </summary>
        [SugarColumn(ColumnDescription = "缺陷位置名称")]
        public string? LocationName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(ColumnDescription = "状态", DefaultValue = "true")]
        public bool State { get; set; } = true;
        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnDescription = "备注")]
        public string? Remark { get; set; }
    }
}
