using SqlSugar;

namespace MicroServices.Models.Dtos.Product_PlanDtos
{
    /// <summary>
    /// 生产计划列表DTO
    /// </summary>
    public class Production_PlanDto
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        [SugarColumn(ColumnName = "Planning_Id", IsNullable = false)]
        public string Planning_Id { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [SugarColumn(ColumnName = "Planning_Name")]
        public string Planning_Name { get; set; }

        /// <summary>
        /// 工单数量
        /// </summary>
        [SugarColumn(ColumnName = "Order_Nums")]
        public int Order_Nums { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [SugarColumn(ColumnName = "From_Type")]
        public int From_Type { get; set; }

        /// <summary>
        /// 来源编号
        /// </summary>
        [SugarColumn(ColumnName = "Sales_Order_Id")]
        public int Sales_Order_Id { get; set; }

        /// <summary>
        /// 物料外键Id
        /// </summary>
        [SugarColumn(ColumnName = "Name_Finished_Product_Id", IsNullable = false)]
        public int Name_Finished_Product_Id { get; set; }

        /// <summary>
        /// 成品编号（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Name_Finished_Product_Number")]
        public string Name_Finished_Product_Number { get; set; }

        /// <summary>
        /// 成品名称（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Name_Finished_Product_Name", IsNullable = false)]
        public string Name_Finished_Product_Name { get; set; }

        /// <summary>
        /// 规格型号（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Specification_model")]
        public string Specification_model { get; set; }

        /// <summary>
        /// 成品类型（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Finished_Produce_Type")]
        public string Finished_Produce_Type { get; set; }

        /// <summary>
        /// 单位（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Unit")]
        public int Unit { get; set; }

        /// <summary>
        /// 计划数量(物料)
        /// </summary>
        [SugarColumn(ColumnName = "Plan_Nums")]
        public int Plan_Nums { get; set; }

        /// <summary>
        /// 开工时间
        /// </summary>
        [SugarColumn(ColumnName = "Start_Time", ColumnDataType = "DATE")]
        public DateTime? Start_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 完工时间
        /// </summary>
        [SugarColumn(ColumnName = "End_Time", ColumnDataType = "DATE")]
        public DateTime? End_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 需求日期
        /// </summary>
        [SugarColumn(ColumnName = "Need_Days", ColumnDataType = "DATE")]
        public DateTime? Need_Days { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnName = "Remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(ColumnName = "State")]
        public int? State { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 附件
        /// </summary>
        [SugarColumn(ColumnName = "Annex")]
        public string Annex { get; set; }

        /// <summary>
        /// BomId
        /// </summary>
        [SugarColumn(ColumnName = "BomId")]
        public int? BomId { get; set; } // INTEGER类型，如果可为NULL，使用int?
    }

    public class CreateUpdateProductionPlanDto
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        [SugarColumn(ColumnName = "Planning_Id", IsNullable = false)]
        public string Planning_Id { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [SugarColumn(ColumnName = "Planning_Name")]
        public string Planning_Name { get; set; }

        /// <summary>
        /// 工单数量
        /// </summary>
        [SugarColumn(ColumnName = "Order_Nums")]
        public int Order_Nums { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [SugarColumn(ColumnName = "From_Type")]
        public int From_Type { get; set; }

        /// <summary>
        /// 来源编号
        /// </summary>
        [SugarColumn(ColumnName = "Sales_Order_Id")]
        public int Sales_Order_Id { get; set; }

        /// <summary>
        /// 物料外键Id
        /// </summary>
        [SugarColumn(ColumnName = "Name_Finished_Product_Id", IsNullable = false)]
        public int Name_Finished_Product_Id { get; set; }

        /// <summary>
        /// 成品编号（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Name_Finished_Product_Number")]
        public string Name_Finished_Product_Number { get; set; }

        /// <summary>
        /// 规格型号（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Specification_model")]
        public string Specification_model { get; set; }

        /// <summary>
        /// 成品类型（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Finished_Produce_Type")]
        public string Finished_Produce_Type { get; set; }

        /// <summary>
        /// 单位（物料）
        /// </summary>
        [SugarColumn(ColumnName = "Unit")]
        public int Unit { get; set; }

        /// <summary>
        /// 计划数量(物料)
        /// </summary>
        [SugarColumn(ColumnName = "Plan_Nums")]
        public int Plan_Nums { get; set; }

        /// <summary>
        /// 开工时间
        /// </summary>
        [SugarColumn(ColumnName = "Start_Time", ColumnDataType = "DATE")]
        public DateTime? Start_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 完工时间
        /// </summary>
        [SugarColumn(ColumnName = "End_Time", ColumnDataType = "DATE")]
        public DateTime? End_Time { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 需求日期
        /// </summary>
        [SugarColumn(ColumnName = "Need_Days", ColumnDataType = "DATE")]
        public DateTime? Need_Days { get; set; } // DATE类型，允许为NULL，使用DateTime?

        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnName = "Remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(ColumnName = "State")]
        public int? State { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 附件
        /// </summary>
        [SugarColumn(ColumnName = "Annex")]
        public string Annex { get; set; }

        /// <summary>
        /// BomId
        /// </summary>
        [SugarColumn(ColumnName = "BomId")]
        public int? BomId { get; set; } // INTEGER类型，如果可为NULL，使用int?
    }

}
