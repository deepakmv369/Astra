using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.Governance.MasterData
{
    [Table("mdGovernanceComplianceLevels", Schema = "GovernanceMaster")]
    public class mdGovernanceComplianceLevel
    {
        [Key]
        public int mdGovernanceComplianceLevelId { get; set; }
        [Required]
        public string? compLevel { get; set; }
        public string? description { get; set; }
        [Required]
        public int? rank { get; set; }
        public ICollection<governanceLog>? governanceCompliances { get; set; }
        public ICollection<asnGovernedEntityStandard>? complianceForGovernedStandards { get; set; }
        


    }
}