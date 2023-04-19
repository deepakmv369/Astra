using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("assetComplexRelationAnalysis", Schema = "Portfolio")]
    public class assetComplexRelationAnalysis
    {
        [Key]
        public long assetComplexRelationAnalysisId { get; set; }
        public int? buildingBlockVitalityId { get; set; }
        public mdGeneralScale? buildingBlockVitality { get; set; }
        public long? assetBuildingBlockId { get; set; }
        public assetPortfolio? assetBuildingBlock { get; set; }
        public decimal? buildingBlockCapacityUtilization { get; set; }
        public bool? isAggregated { get; set; }
        public bool? isChild { get; set; }
        public bool? isComposed { get; set; }
        public int? buildingBlockNonAvailabilityImpactId { get; set; }
        public mdImpact? buildingBlockNonAvailabilityImpact { get; set; }
        public decimal? fullfilmentPercent { get; set; }
        public long? sourceAssetId { get; set; }
        public assetPortfolio? sourceAsset { get; set; }
        public int? fulfillmentWeightageId { get; set; }
        public mdGeneralScale? fulfillmentWeightage { get; set; }
        

    }
}