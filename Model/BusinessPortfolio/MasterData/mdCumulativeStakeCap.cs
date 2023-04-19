using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdCumulativeStakeCaps", Schema = "PortfolioMaster")]
    public class mdCumulativeStakeCap
    {
        [Key]
        public int mdCumulativeStakeCapId { get; set; }
        public decimal? minCap { get; set; } = Convert.ToDecimal(001.00);
        public decimal? maxCap { get; set; } = Convert.ToDecimal(100.00);
        public int? mdAuthAccessLevelId { get; set; }
        public virtual mdAuthAccessLevel? MdAuthAccessLevel { get; set; }
    }
}