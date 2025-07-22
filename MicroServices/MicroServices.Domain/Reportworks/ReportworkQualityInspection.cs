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
    /// 报工质检
    /// </summary>
    [SugarTable("ReportworkQualityInspection", TableDescription = "报工质检表")]
    public class ReportworkQualityInspection : AuditableEntity
    {
        /// <summary>
        /// 报工记录关联ID（关联 ReportworkRecord 表主键）
        /// 用于关联对应的报工记录
        /// </summary>
        [SugarColumn(ColumnDescription = "ReportworkRecordId", IsPrimaryKey = true)]
        public int ReportworkRecordId { get; set; }
        /// <summary>
        /// 产品id
        /// </summary>
        [SugarColumn(ColumnDescription = "ProductId", IsPrimaryKey = true)]
        public int ProductId {  get; set; }

        /// <summary>
        /// 检验单名称
        /// 对应页面中的“检验单名称”字段
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionSheetName")]
        public string InspectionSheetName { get; set; }

        /// <summary>
        /// 检验单号
        /// 唯一标识检验单，如页面中的“JYDxxx”格式
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionSheetNo")]
        public string InspectionSheetNo { get; set; }

        /// <summary>
        /// 检验类型（如页面中的“首检”）
        /// 标记质检的类型，可扩展枚举
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionType")]
        public int InspectionTypeId { get; set; }

        ///// <summary>
        ///// 检验部门（如页面中的“质检部门”）
        ///// 记录执行质检的部门
        ///// </summary>
        //[SugarColumn(ColumnDescription = "InspectionDept")]
        //public string InspectionDept { get; set; }

        ///// <summary>
        ///// 检验人（如页面中的“李丽丽”）
        ///// 记录执行质检的人员姓名
        ///// </summary>
        //[SugarColumn(ColumnDescription = "Inspector")]
        //public string Inspector { get; set; }

        /// <summary>
        /// 检测数量
        /// 同报工记录中的报工数量，用于质检核对
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionQuantity")]
        public int InspectionQuantity { get; set; }

        /// <summary>
        /// 合格数量
        /// 记录质检判定的合格产品数量
        /// </summary>
        [SugarColumn(ColumnDescription = "QualifiedQuantity")]
        public int QualifiedQuantity { get; set; }

        /// <summary>
        /// 不合格数量
        /// 记录质检判定的不合格产品数量
        /// </summary>
        [SugarColumn(ColumnDescription = "UnqualifiedQuantity")]
        public int UnqualifiedQuantity { get; set; }

        /// <summary>
        /// 合格率（格式如页面中的“60%”）
        /// 存储质检合格率，可通过计算或直接存储
        /// </summary>
        [SugarColumn(ColumnDescription = "QualifiedRate")]
        public string QualifiedRate { get; set; }

        /// <summary>
        /// 检测结果（如页面中的“合格”）
        /// 标记整体质检结论，可扩展枚举
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionResult")]
        public string InspectionResult { get; set; }

        /// <summary>
        /// 质检状态（如页面中的“未质检/已质检”）
        /// 标记质检流程状态，可通过枚举管理
        /// </summary>
        [SugarColumn(ColumnDescription = "QualityStatus")]
        public string QualityStatus { get; set; }
    }

    /// <summary>
    /// 报工质检类型表
    /// </summary>
    [SugarTable("InspectionType", TableDescription = "报工质检类型表")]
    public class InspectionType : AuditableEntity
    {
        /// <summary>
        /// 检验类型名称（如页面中的“首检”）
        /// 标记质检的类型，可扩展枚举
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionTypeName")]
        public int InspectionTypeName { get; set; }
    }

    /// <summary>
    /// 检验项目表
    /// </summary>
    [SugarTable("InspectionItem ", TableDescription = "检验项目表")]
    public class InspectionItem : AuditableEntity
    {
        /// <summary>
        /// 检测项目名称
        /// </summary>
        [SugarColumn(ColumnDescription = "ItemName")]
        public string ItemName { get; set; }

        /// <summary>
        /// 检测项目编号
        /// </summary>
        [SugarColumn(ColumnDescription = "ItemCode")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 检测类型（如：尺寸、外观、性能等）
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionItemTypeId")]
        public int InspectionItemTypeId { get; set; }

        /// <summary>
        /// 检测工具（如：卡尺、显微镜等）(工装夹具类型表 )
        /// </summary>
        [SugarColumn(ColumnDescription = "ToolingFixtureTypeId")]
        public int ToolingFixtureTypeId { get; set; }

        /// <summary>
        /// 检测要求（文字描述检测规范）
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionRequirement")]
        public string InspectionRequirement { get; set; }

        /// <summary>
        /// 标准值（检测的基准数值）
        /// </summary>
        [SugarColumn(ColumnDescription = "StandardValue")]
        public string StandardValue { get; set; }

        /// <summary>
        /// 单位（如：mm、kg、℃等）
        /// </summary>
        [SugarColumn(ColumnDescription = "Unit")]
        public int UnitId { get; set; }

        /// <summary>
        /// 误差上限
        /// </summary>
        [SugarColumn(ColumnDescription = "ToleranceUpper", IsNullable = true)]
        public decimal? ToleranceUpper { get; set; }

        /// <summary>
        /// 误差下限
        /// </summary>
        [SugarColumn(ColumnDescription = "ToleranceLower", IsNullable = true)]
        public decimal? ToleranceLower { get; set; }

        /// <summary>
        /// 致命缺陷数
        /// </summary>
        [SugarColumn(ColumnDescription = "CriticalDefectCount")]
        public int CriticalDefectCount { get; set; }

        /// <summary>
        /// 严重缺陷数
        /// </summary>
        [SugarColumn(ColumnDescription = "SeriousDefectCount")]
        public int SeriousDefectCount { get; set; }

        /// <summary>
        /// 轻微缺陷数
        /// </summary>
        [SugarColumn(ColumnDescription = "MinorDefectCount")]
        public int MinorDefectCount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnDescription = "Remarks")]
        public string Remarks { get; set; }

    }

    /// <summary>
    /// 检测项目类型表
    /// </summary>
    [SugarTable("InspectionItemType", TableDescription = "检测项目类型表")]
    public class InspectionItemType : AuditableEntity
    {
        /// <summary>
        /// 检验类型名称（如页面中的“首检”）
        /// 标记质检的类型，可扩展枚举
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionItemTypeName")]
        public int InspectionItemTypeName { get; set; }
    }

    /// <summary>
    /// 检验结果表
    /// 记录单次检验的统计结果、缺陷率及结论
    /// </summary>
    [SugarTable("InspectionResult", TableDescription = "检验结果表")]
    public class InspectionResult : AuditableEntity
    {
        /// <summary>
        /// 关联的检验项目ID（外键，关联检验单主表）
        /// 用于串联“检验单 - 检验结果”数据
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionSheetId")]
        public string InspectionSheetId { get; set; }

        /// <summary>
        /// 检测数量
        /// 对应页面“检测数量”字段
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionQuantity")]
        public int InspectionQuantity { get; set; }

        /// <summary>
        /// 合格数量
        /// 对应页面“合格数量”字段
        /// </summary>
        [SugarColumn(ColumnDescription = "QualifiedQuantity")]
        public int QualifiedQuantity { get; set; }

        /// <summary>
        /// 不合格数量
        /// 对应页面“不合格数量”字段
        /// </summary>
        [SugarColumn(ColumnDescription = "UnqualifiedQuantity")]
        public int UnqualifiedQuantity { get; set; }

        /// <summary>
        /// 致命缺陷率（格式如：0%）
        /// 对应页面“致命缺陷率”字段
        /// </summary>
        [SugarColumn(ColumnDescription = "CriticalDefectRate")]
        public string  CriticalDefectRate { get; set; }

        /// <summary>
        /// 严重缺陷率（格式如：0%）
        /// 对应页面“严重缺陷率”字段
        /// </summary>
        [SugarColumn(ColumnDescription = "SeriousDefectRate")]
        public string SeriousDefectRate { get; set; }

        /// <summary>
        /// 轻微缺陷率（格式如：0%）
        /// 对应页面“轻微缺陷率”字段
        /// </summary>
        [SugarColumn(ColumnDescription = "MinorDefectRate")]
        public string MinorDefectRate { get; set; }

        /// <summary>
        /// 检测结果（如：合格、不合格）
        /// 对应页面“检测结果”字段，可通过枚举管理
        /// </summary>
        [SugarColumn(ColumnDescription = "InspectionConclusion")]
        public string InspectionConclusion { get; set; }

        /// <summary>
        /// 备注
        /// 对应页面“备注”输入框，用于扩展说明
        /// </summary>
        [SugarColumn(ColumnDescription = "Remarks")]
        public string Remarks { get; set; }
    }
}
