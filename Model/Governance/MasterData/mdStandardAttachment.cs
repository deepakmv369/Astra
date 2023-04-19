using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.Governance.MasterData
{
    [Table("mdStandardAttachments", Schema = "GovernanceMaster")]
    public class mdStandardAttachment
    {
        [Key]
        public long mdStandardAttachmentId { get; set; }
        public int? attachmentOfStandardId { get; set; }
        public mdStandardGuideline? attachmentOfStandard { get; set; }
        public byte[]? attachmentContent { get; set; }
        [MaxLength(100)]
        public string? attachmentTitle { get; set; }


    }
}