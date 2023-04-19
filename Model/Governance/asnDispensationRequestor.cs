using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;

namespace Astra_MK1.Model.Governance
{
    [Table("asnDispensationRequestors", Schema = "GovernanceASNS")]
    public class asnDispensationRequestor
    {
        [Key]
        public long asnDispensationRequestorId { get; set; }
        public bool? isActive { get; set; } = false;
        public long? dispensationRequestorStructureId { get; set; }
        public orgStructure? dispensationRequestorStructure { get; set; }
        public long? dispensationRequestorGroupId { get; set; }
        public orgGroup? dispensationRequestorGroup { get; set; }
        public long? dispensationRequestorRoleId { get; set; }
        public orgRole? dispensationRequestorRole { get; set; }
        public DateTime? dispensationRequestDate { get; set; }
        public long dispensationOfRequestorId { get; set; }
        public dispensationRecord? dispensationOfRequestor { get; set; }
    }
}