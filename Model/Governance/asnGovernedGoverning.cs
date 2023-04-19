using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.Governance
{
    [Table("asnGovernedGovernings", Schema = "GovernanceASNS")]
    public class asnGovernedGoverning
    {
        public long asnGovernedEntityId { get; set; }
        public bool? isActive { get; set; } = false;
        public governedEntity? asnGovernedEntity { get; set; }
        public long asnGoverningEntityId { get; set; }
        public governingEntity? asnGoverningEntity { get; set; }
    }
}