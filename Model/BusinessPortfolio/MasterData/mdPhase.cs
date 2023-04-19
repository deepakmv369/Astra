using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdPhases", Schema = "PortfolioMaster")]
    public class mdPhase
    {
        [Key]
        public int mdPhaseId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? phaseName { get; set; }
        public int? phaseSequence { get; set; }
        public int? ManagementmethodId { get; set; }
        public mdManagementMethod? managementMethod { get; set; }
        public ICollection<orgStructure>? orgStructuresPhase { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioPhase { get; set; }
        public ICollection<procurementDetail>? procurementDetailPhases { get; set; }
    }
}