using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("procurementDocs", Schema = "Portfolio")]
    public class procurementDoc
    {
        [Key]
        public long procurementDocId { get; set; }
        public long? refProcurementDetailId { get; set; }
        public procurementDetail? refProcurementDetail { get; set; }
        public int? procurementDocumentTypeId { get; set; }
        public refProcurementDocumentType? procurementDocumentType { get; set; }
        public string? procurementDocName { get; set; }
        public string? procurementDocNumber { get; set; }
        public string? procurementDocLocation { get; set; }
    }
}