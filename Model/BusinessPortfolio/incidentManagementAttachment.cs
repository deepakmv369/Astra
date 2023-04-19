using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("incidentManagementAttachments", Schema = "Portfolio")]
    public class incidentManagementAttachment
    {
        [Key]
        public long incidentManagementAttachmentId { get; set; }
        public byte[]? incidentAttachment { get; set; }
        public byte[]? attachmentChecksum { get; set; }
        public DateTime? attachmentDateTime { get; set; }
        public string? attachmentNotes { get; set; }
        public long? attachmentOfManagementRecordId { get; set; }
        public incidentManagementRecord? attachmentOfmanagementRecord { get; set; }
    }
}