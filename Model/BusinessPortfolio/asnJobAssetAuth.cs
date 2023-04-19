using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnJobAssetAuths", Schema = "PortfolioASNS")]
    public class asnJobAssetAuth
    {
        [Key]
        public long asnJobAssetAuthId { get; set; }
        public bool? isActive { get; set; } = false;
        public int? asnAuthAccessLevelId { get; set; }
        public mdAuthAccessLevel? asnAuthAccessLevel { get; set; }
        public int? asnAssetAuthRefJobId { get; set; }
        public refJob? asnAssetAuthRefJob { get; set; }
        public long? asnAssetPortfolioId { get; set; }
        public assetPortfolio? asnAssetPortfolio { get; set; }
        public bool? cascadeAuthToChildAssets { get; set; } = false;
        public bool? cascadeAuthTochildJobs { get; set; } = false;
    }
}