using MricoServices.Shared;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Domain.Sites
{
    /// <summary>
    /// 站点设备表
    /// </summary>
    public class SiteEquipment : AuditableEntity
    {
        [SugarColumn(ColumnDescription = "设备编号", Length = 20)]
        public string EquipmentCode { get; set; }

        [SugarColumn(ColumnDescription = "站点外键id")]
        public long SitesId { get; set; }

        [SugarColumn(ColumnDescription = "设备名称")]
        public string EquipmentName { get; set; }

        [SugarColumn(ColumnDescription = "规格型号")]
        public string Size { get; set; }

        [SugarColumn(ColumnDescription = "设备类型外键")]
        public long EquipmentTypeId { get; set; }

        [SugarColumn(ColumnDescription = "状态 true:启用,false:禁用")]
        public bool State { get; set; }
    }
}
