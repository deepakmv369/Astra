using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.Governance
{
    [Table("governanceOutputs", Schema = "Governance")]
    public class governanceOutput
    {
    [Key]
    public long governanceOutputId { get; set; }
    public DateTime? outPutCreationDate { get; set; }
    public long? governanceOutputLogId { get; set; }
    public governanceLog? governanceOutputLog { get; set; }
    public ICollection<governanceAttachment>? governanceOutputAttachments { get; set; }


    }
}