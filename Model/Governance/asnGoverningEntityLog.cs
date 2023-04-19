using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.Governance
{
    //Association between governingEntity and governanceLog
    [Table("asnGoverningEntityLogs", Schema = "GovernanceASNS")]
    public class asnGoverningEntityLog
    {
        public long asnGoverningEntityId { get; set; }
        public bool? isActive { get; set; } = false;
        public governingEntity? asnGoverningEntity { get; set; }
        public long asnGovernanceLogId { get; set; }
        public governanceLog? asnGovernanceLog { get; set; }
        public string? governingEntitySignature { get; set; }
    }
}