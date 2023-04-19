using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refProcurementDocumentTypes", Schema = "PortfolioRef")]
    public class refProcurementDocumentType
    {
        [Key]
        public int refProcurementDocumentTypeId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? procDocName { get; set; }
        public ICollection<procurementDoc>? procurementDocumentTypes { get; set; }
    }
}