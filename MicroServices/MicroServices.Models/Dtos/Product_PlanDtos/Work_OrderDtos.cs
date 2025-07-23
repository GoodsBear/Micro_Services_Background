using SqlSugar;

namespace MicroServices.Models.Dtos.Product_PlanDtos
{
    /// <summary>
    /// 工单任务表
    /// </summary>
    public class Work_OrderDtos
    {
        /// <summary>
        /// 工单编号
        /// </summary>
        [SugarColumn(ColumnName = "Order_Id", IsNullable = false)]
        public string Order_Id { get; set; }

        /// <summary>
        /// 工单名称
        /// </summary>
        [SugarColumn(ColumnName = "Order_Name")]
        public string Order_Name { get; set; }

        /// <summary>
        /// 计划Id
        /// </summary>
        [SugarColumn(ColumnName = "Planning_Id")]
        public int? Planning_Id { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 工单进度
        /// </summary>
        [SugarColumn(ColumnName = "Order_Progress")]
        public string Order_Progress { get; set; }

        /// <summary>
        /// 关联计划
        /// </summary>
        public string Planning_Name { get; set; } 
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Product_Name { get; set; }
        /// <summary>
        /// 产品编号
        /// </summary>
        public string Product_Id { get; set; }
        /// <summary>
        /// 规格型号
        /// </summary>
        public string Specification_model { get; set; }
        /// <summary>
        /// 产品类型
        /// </summary>
        public string Finished_Produce_Type { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; } 
        /// <summary>
        /// 需求日期
        /// </summary>
        public DateTime NeedTime { get; set; } 
        /// <summary>
        /// 计划数量
        /// </summary>
        public int PlanNums { get; set; }
        /// <summary>
        /// // 实际生产数量
        /// </summary>
        public int FactProduceNums { get; set; }

        /// <summary>
        /// 计划开工时间
        /// </summary>
        [SugarColumn(ColumnName = "Start_Time")]
        public DateTime? Plan_Start_Time { get; set; } 

        /// <summary>
        /// 计划完工时间
        /// </summary>
        [SugarColumn(ColumnName = "End_Time")]
        public DateTime? Plan_End_Time { get; set; }
        /// <summary>
        /// 实际开工时间
        /// </summary>
        public DateTime Fact_Start_Time { get; set; }
        /// <summary>
        /// 实际完工时间
        /// </summary>
        public DateTime Fact_Finish_Time { get; set; }

        /// <summary>
        /// 工单状态
        /// </summary>
        [SugarColumn(ColumnName = "Status")]
        public int? Status { get; set; } // INTEGER类型，如果可为NULL，使用int?
    }

    public class CreateUpdateWork_OrderDtos
    {
        /// <summary>
        /// 工单编号
        /// </summary>
        [SugarColumn(ColumnName = "Order_Id", IsNullable = false)]
        public string Order_Id { get; set; }

        /// <summary>
        /// 工单名称
        /// </summary>
        [SugarColumn(ColumnName = "Order_Name")]
        public string Order_Name { get; set; }

        /// <summary>
        /// 计划Id
        /// </summary>
        [SugarColumn(ColumnName = "Planning_Id")]
        public int? Planning_Id { get; set; } // INTEGER类型，如果可为NULL，使用int?

        /// <summary>
        /// 工单状态
        /// </summary>
        [SugarColumn(ColumnName = "Status")]
        public int? Status { get; set; } // INTEGER类型，如果可为NULL，使用int?
    }
}
