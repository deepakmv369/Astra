using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdAuthAccessLevels", Schema = "PortfolioMaster")]
    public class mdAuthAccessLevel
    {
        [Key]
        public int mdAuthAccessLevelId { get; set; }
        public bool? canCreate { get; set; }
        public bool? canRead { get; set; }
        public bool? canUpdate { get; set; }
        public bool? canDelete { get; set; }

        public int? authorityLevelId { get; set; }
        public mdAuthorityLevel? _authorityLevel { get; set; }

        public int? stakeThreshold { get; set; }
        public virtual mdCumulativeStakeCap? MdCumulativeStakeCap { get; set; }
        public ICollection<asnJobAssetAuth>? mdJobAssetAuths { get; set; }

    }
}