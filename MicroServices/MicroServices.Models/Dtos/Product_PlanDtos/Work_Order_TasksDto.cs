using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Models.Dtos.Product_PlanDtos
{
    /// <summary>
    /// 生产工单表
    /// </summary>
    public class Work_Order_TasksDto
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

        public string Work_Order_Name { get; set; } // 工单名称

        public string Work_Order_Id_Name { get; set; } // 工单编号

        public string ProcessRoute_Name { get; set; } // 工艺路线名称

        public string ProcessName { get; set; } // 工序名称

        public string ProcessId { get; set; } // 工序编号

        public string TaskColor { get; set; } // 任务颜色

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

        public string PlanProductLong { get; set; } // 计划生产时长
        /// <summary>
        /// 实际开工时间
        /// </summary>
        public DateTime Fact_Start_Time { get; set; }
        /// <summary>
        /// 实际完工时间
        /// </summary>
        public DateTime Fact_Finish_Time { get; set; }

        public string FactProductLong { get; set; } // 实际生产时长

        public int TaskStatus { get; set; } // 任务状态
    }

    public class CreateUpdateWork_Order_TasksDtos
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

        public int? TaskStatus { get; set; } // 任务状态

    }
}
