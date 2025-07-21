using Dm;
using MricoServices.Shared;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Domain.InStorage
{
/// <summary>
/// 采购入库单
/// </summary>
[SugarTable("PurchaseStorage", TableDescription = "采购入库单表")] // 设置表名和描述
public class PurchaseStorage : AuditableEntity
{
    /// <summary>
    /// 入库单号
    /// </summary>
    [SugarColumn(ColumnName = "InHouseNum", ColumnDescription = "入库单号")]
    public string InHouseNum { get; set; }

    /// <summary>
    /// 入库时间
    /// </summary>
    [SugarColumn(ColumnName = "InDate", ColumnDescription = "入库时间")]
    public Data InDate { get; set; }

    /// <summary>
    /// 供应商（外键）
    /// </summary>
    [SugarColumn(ColumnName = "Supplier", ColumnDescription = "供应商")]
    public int Supplier { get; set; }

    /// <summary>
    /// 采购订单（外键）
    /// </summary>
    [SugarColumn(ColumnName = "PurchaseOrder", ColumnDescription = "采购订单")]
    public int PurchaseOrder { get; set; }

    /// <summary>
    /// 物料检测结果
    /// </summary>
    [SugarColumn(ColumnName = "MaterialTestId", ColumnDescription = "物料检测结果")]
    public TestResult MaterialTestId { get; set; }

    /// <summary>
    /// 收货人
    /// </summary>
    [SugarColumn(ColumnName = "Receiver", ColumnDescription = "收货人")]
    public int Receiver { get; set; }

    /// <summary>
    /// 验货人
    /// </summary>
    [SugarColumn(ColumnName = "Checker", ColumnDescription = "验货人")]
    public int Checker { get; set; }

    /// <summary>
    /// 录入人
    /// </summary>
    [SugarColumn(ColumnName = "Enterer", ColumnDescription = "录入人")]
    public int Enterer { get; set; }

    /// <summary>
    /// 合计金额
    /// </summary>
    [SugarColumn(ColumnName = "TotalAmount", ColumnDescription = "合计金额")]
    public decimal TotalAmount { get; set; }

    /// <summary>
    /// 入库状态（true: 已入库，false: 未入库）
    /// </summary>
    [SugarColumn(ColumnName = "Status", ColumnDescription = "入库状态")]
    public bool Status { get; set; } = false;

    /// <summary>
    /// 备注
    /// </summary>
    [SugarColumn(ColumnName = "Remark", IsNullable = true, ColumnDescription = "备注")]
    public string? Remark { get; set; }
}


/// <summary>
/// 入库物料单
/// </summary>
[SugarTable("PurchaseInventoryMaterial", TableDescription = "入库物料单表")]
public class PurchaseInventoryMaterial : AuditableEntity
{
    /// <summary>
    /// 入库单号
    /// </summary>
    [SugarColumn(ColumnName = "InHouseNum", ColumnDescription = "入库单号")]
    public string InHouseNum { get; set; }

    /// <summary>
    /// 物料编号
    /// </summary>
    [SugarColumn(ColumnName = "MaterialNum", ColumnDescription = "物料编号")]
    public int MaterialNum { get; set; }

    /// <summary>
    /// 条形码
    /// </summary>
    [SugarColumn(ColumnName = "MaterialCode", IsNullable = true, ColumnDescription = "条形码")]
    public string? MaterialCode { get; set; }

    /// <summary>
    /// 物料名称
    /// </summary>
    [SugarColumn(ColumnName = "MaterialName", ColumnDescription = "物料名称")]
    public string MaterialName { get; set; }

    /// <summary>
    /// 单位
    /// </summary>
    [SugarColumn(ColumnName = "MaterialUnit", ColumnDescription = "单位")]
    public string MaterialUnit { get; set; }

    /// <summary>
    /// 数量
    /// </summary>
    [SugarColumn(ColumnName = "MaterialSum", ColumnDescription = "数量")]
    public int MaterialSum { get; set; }

    /// <summary>
    /// 单价
    /// </summary>
    [SugarColumn(ColumnName = "Price", IsNullable = true, ColumnDescription = "单价")]
    public string? Price { get; set; }

    /// <summary>
    /// 仓库编号
    /// </summary>
    [SugarColumn(ColumnName = "WarehouseNum", ColumnDescription = "仓库编号")]
    public string WarehouseNum { get; set; }

    /// <summary>
    /// 库区编号
    /// </summary>
    [SugarColumn(ColumnName = "MaterialAreaId", ColumnDescription = "库区")]
    public string MaterialAreaNum { get; set; }

    /// <summary>
    /// 库位编号
    /// </summary>
    [SugarColumn(ColumnName = "MaterialLocationId", ColumnDescription = "库位编号")]
    public string MaterialLocationNum { get; set; }

    /// <summary>
    /// 物料数量
    /// </summary>
    [SugarColumn(ColumnName = "Quantity", ColumnDescription = "物料数量")]
    public decimal Quantity { get; set; }

    /// <summary>
    /// 物料单位
    /// </summary>
    [SugarColumn(ColumnName = "Unit", ColumnDescription = "物料单位")]
    public string Unit { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    [SugarColumn(ColumnName = "Remark", IsNullable = true, ColumnDescription = "备注")]
    public string? Remark { get; set; }
}



/// <summary>
/// 采购检验单
/// </summary>
[SugarTable("PurchaseTest", TableDescription = "采购检验单表")]
public class PurchaseTest : AuditableEntity
{
    /// <summary>
    /// 检验单号
    /// </summary>
    [SugarColumn(ColumnName = "TestNum", ColumnDescription = "检验单号")]
    public string TestNum { get; set; }

    /// <summary>
    /// 入库单号（外键）
    /// </summary>
    [SugarColumn(ColumnName = "InHouseNum", ColumnDescription = "入库单号")]
    public string InHouseNum { get; set; }

    /// <summary>
    /// 检验时间
    /// </summary>
    [SugarColumn(ColumnName = "TestDate", ColumnDescription = "检验时间")]
    public Data TestDate { get; set; }

    /// <summary>
    /// 检验结果（合格/不合格/待检验）
    /// </summary>
    [SugarColumn(ColumnName = "Result", IsNullable = true, ColumnDescription = "检验结果")]
    public TestResult? Result { get; set; } = TestResult.待检验;

    /// <summary>
    /// 备注
    /// </summary>
    [SugarColumn(ColumnName = "Remark", IsNullable = true, ColumnDescription = "备注")]
    public string? Remark { get; set; }
}



	/// <summary>
	/// 检测结果
	/// </summary>
	public enum TestResult
	{
		合格,
        不合格,
		待检验,
	}









}
