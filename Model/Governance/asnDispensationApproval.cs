using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;

namespace Astra_MK1.Model.Governance
{
    [Table("asnDispensationApprovals", Schema = "GovernanceASNS")]
    public class asnDispensationApproval
    {
        [Key]
        public long asnDispensationApprovalId { get; set; }
        public bool? isActive { get; set; } = false;
        public long? dispensationApprovalStructureId { get; set; }
        public orgStructure? dispensationAprovalStructure { get; set; }
        public long? dispensationAprovalGroupId { get; set; }
        public orgGroup? dispensationAprovalGroup { get; set; }
        public long? dispensationAprovalRoleId { get; set; }
        public orgRole? dispensationAprovalRole { get; set; }
        public long? dispensationForApprovalAsnId { get; set; }
        public dispensationRecord? dispensationForApprovalAsn { get; set; }
        public DateTime? dispensationApprovalDate { get; set; }
        public string? dispensationApproverSignature { get; set; }

    }
}