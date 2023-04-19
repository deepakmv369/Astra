using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;

namespace Astra_MK1.Model.Governance
{
    [Table("dispensationRecords", Schema = "Governance")]
    public class dispensationRecord
    {
        [Key]
        public long dispensationRecordId { get; set; }
        public long? preGovernanceDispensationId { get; set; }
        public governedEntity? preGovernanceDispensation { get; set; }
        public long? postGovernanceDispensationId { get; set; }
        public governanceLog? postGovernanceDispensation { get; set; }
        public ICollection<asnDispensationRequestor>? dispensationRequestAsn { get; set; }
        public ICollection<asnDispensationApproval>? dispensationApprovalAsn { get; set; }
    }
}