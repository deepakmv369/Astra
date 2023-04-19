using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdImpacts", Schema = "PortfolioMaster")]
    public class mdImpact
    {
        [Key]
        public int mdImpactId { get; set; }
        [Required]
        [MaxLength(20)]
        public string? qualityIndicator { get; set; }
        [Required]
        public int? quantityIndicator { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioDependencyImpacts { get; set; }
        public ICollection<assetComplexRelationAnalysis>? buildingBlockNonAvailabilityImpacts { get; set; }
        public ICollection<incidentManagementRecord>? incidentsManagementRecordImpacts { get; set; }
    }

}