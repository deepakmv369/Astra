using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdGeneralScales", Schema = "PortfolioMaster")]
    public class mdGeneralScale
    {
        [Key]
        public int mdGeneralScaleId { get; set; }
        [Required]
        [MaxLength(20)]
        public string? qualityIndicator { get; set; }
        [Required]
        public int? quantityIndicator { get; set; }
        public ICollection<orgRole>? orgRolesGeneralScale { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioGeneralSaclesCVI { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioGeneralSaclesVol { get; set; }
        public ICollection<asnMotivational>? asnMotivationalPriorities { get; set; }
        public ICollection<assetComplexRelationAnalysis>? assetComplexRelationVitalities { get; set; }
        public ICollection<assetComplexRelationAnalysis>? assetComplexRelationfulfillmentWeightages { get; set; }
        public ICollection<motivationalDimensionOfImportance>? motivationalDimensionImportances { get; set; }
        public ICollection<incidentManagementRecord>? incidentManagementRecordsPriority { get; set; }
        
    }
}