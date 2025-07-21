using MricoServices.Shared;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Domain.ToolingFixtures
{
    /// <summary>
    /// 领取工具 表
    /// </summary>
    [SugarTable("ToolingFixturesIssue", TableDescription = "领取工具表")]
    public class ToolingFixturesIssue: AuditableEntity
    {
        public string IssuedTo { get; set; }      // 领取人
        public DateTime IssueDate { get; set; }  // 领取时间
        public int Quantity { get; set; }        // 领取数量

        // 关联工具
        public int ToolingFixtureId { get; set; }
        public ToolingFixture ToolingFixture { get; set; }

        // 关联库位（可选）
        public int? WareHouseId { get; set; }
        //public WareHouse WareHouse { get; set; }
    }
}
