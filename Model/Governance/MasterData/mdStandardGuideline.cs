using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.Governance;

namespace Astra_MK1.Model.Governance.MasterData
{
    [Table("mdStandardsGuidelines", Schema = "GovernanceMaster")]
    public class mdStandardGuideline
    {
        [Key]
        [Required]
        public int mdStandardGuidelineId { get; set; }
        public string? resourceLocation { get; set; }
        [Required]
        public string? standardGuidelineName { get; set; }
        public ICollection<asnGovernedEntityStandard>? standardGovernedEntityAsn { get; set; }
        public ICollection<mdStandardAttachment>? standardGuidelineAttachments { get; set; }
    }
}