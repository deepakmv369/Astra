using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.Governance
{
    [Table("governanceAttachments", Schema = "Governance")]
    public class governanceAttachment
    {
        [Key]
        public long governanceAttachmentId { get; set; }
        public long? governanceAttachmentForOutputId { get; set; }
        public governanceOutput? governanceAttachmentForOutput  { get; set; }
        public byte[]? attachmentContent { get; set; }
    }
}