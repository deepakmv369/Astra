using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.Governance.MasterData;

namespace Astra_MK1.Model.Governance
{
    [Table("asnGovernedEntityStandards", Schema = "GovernanceASNS")]
    public class asnGovernedEntityStandard
    {
        [Key]
        public long asnGovernedEntityStandardId { get; set; }
        public bool? isActive { get; set; } = false;
        public long? asnGovernedEntityId { get; set; }
        public governedEntity? asnGovernedEntity { get; set; }
        public int? asnGoverningStandardId { get; set; }
        public mdStandardGuideline? asnGoverningStandard { get; set; }
        public int? requiredComplianceId { get; set; }
        public mdGovernanceComplianceLevel? requiredCompliance { get; set; }
    }
}