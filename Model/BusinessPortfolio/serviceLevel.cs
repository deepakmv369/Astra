using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("serviceLevels", Schema = "Portfolio")]
    public class serviceLevel
    {
        [Key]
        public long serviceLevelId { get; set; }
        public long? serviceLevelForAssetId { get; set; }
        public assetPortfolio? serviceLevelForAsset { get; set; }
        public int? serviceLevelForAssetTypeId { get; set; }
        public mdAssetType? serviceLevelForAssetType { get; set; }
        public int? serviceLevelSeverity { get; set; }
        public string? serviceLevelName { get; set; }
        public decimal? maxResponseTime { get; set; }
        public int? maxResponseTimeUnitId { get; set; }
        public refTimeUnit? maxResponseTimeUnit { get; set; }
        public decimal? maxResolutionTime { get; set; }
        public int? maxResolutionTimeUnitId { get; set; }
        public refTimeUnit? maxResolutionTimeUnit { get; set; }
        public long? parentServiceLevelId { get; set; }
        public serviceLevel? parentServiceLevel { get; set; }
        public long? serviceEsclationModelId { get; set; }
        public incidentEsclationModel? serviceEsclationModel { get; set; }
        public long? serviceEsclationModelGroupId { get; set; }
        public incidentEscalationModelGroup? serviceEsclationModelGroup { get; set; }
        public ICollection<serviceLevel>? childServiceLevels { get; set; }
        public ICollection<incidentManagementRecord>? incidentServiceLevels { get; set; }
    }
}