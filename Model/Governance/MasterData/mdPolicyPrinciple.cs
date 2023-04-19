using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.Governance.MasterData
{
    [Table("mdPoliciesPrinciples", Schema = "GovernanceMaster")]
    public class mdPolicyPrinciple
    {
        [Key]
        public long mdPolicyPrincipleId { get; set; }
        [MaxLength(100)]
        public string? policyPrincipleName { get; set; }
        public string? policyPrincipleRationale { get; set; }
        public string? policyPrincipleStatement { get; set; }
        public byte[]? policyPrincipleDocument { get; set; }
    }
}