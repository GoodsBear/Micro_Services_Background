using MricoServices.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Domain.InStorage
{
	/// <summary>
	/// 物料库存表
	/// </summary>
	[SqlSugar.SugarTable("Inventory", TableDescription = "库存表")]
	public class Inventory:AuditableEntity
	{
		/// <summary>
		/// 物料编号
		/// </summary>
		[SqlSugar.SugarColumn(ColumnName = "MaterialCode", ColumnDescription = "物料编号")]
		public string MaterialCode { get; set; }
		/// <summary>
		/// 物料名称
		/// </summary>
		[SqlSugar.SugarColumn(ColumnName = "MaterialName", ColumnDescription = "物料名称")]
        public string MaterialName { get; set; }
		/// <summary>
		/// 物料数量
		/// </summary>
		[SqlSugar.SugarColumn(ColumnName = "MaterialSum", ColumnDescription = "物料数量")]
        public int MaterialSum { get; set; }
		/// <summary>
		/// 物料单位
		/// </summary>
		[SqlSugar.SugarColumn(ColumnName = "MaterialUnit", ColumnDescription = "物料单位")]
        public string MaterialUnit { get; set; }
		/// <summary>
		/// 供货商
		/// </summary>
		[SqlSugar.SugarColumn(ColumnName = "Supplier", ColumnDescription = "供货商")]
		public string Supplier { get; set; }
		/// <summary>
		/// 仓库编号
		/// </summary>
		[SqlSugar.SugarColumn(ColumnName = "WarehouseNum", ColumnDescription = "仓库编号")]
        public string WarehouseNum { get; set; }

	}
}
