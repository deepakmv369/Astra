using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.Governance.MasterData;

namespace Astra_MK1.Model.Governance
{
    [Table("governanceLogs", Schema = "Governance")]
    public class governanceLog
    {
        [Key]
        public long governanceLogId { get; set; }
        public DateTime? governanceDate { get; set; }
        public long? governanceSubjectId { get; set; }
        public governedEntity? governanceSubject { get; set; }
        public int? governanceResultId { get; set; }
        public mdGovernanceComplianceLevel? governanceResult { get; set; }
        public string? governanceRemarks { get; set; }
        public ICollection<asnGoverningEntityLog>? governingLogEntityAsn { get; set; }
        public ICollection<dispensationRecord>? governanceLogDispensations { get; set; }
        public ICollection<governanceOutput>? governanceLogOutputs { get; set; }
        

    }
}