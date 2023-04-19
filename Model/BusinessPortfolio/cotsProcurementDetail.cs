using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("cotsProcurementDetails", Schema = "Portfolio")]
    public class cotsProcurementDetail
    {
        [Key]
        public long cotsProcurementDetailId { get; set; }
        public int? cotsProcurementCLTypeId { get; set; }
        public refCLType? cotsProcurementCLType { get; set; }
        public long? procurementdetailRefId { get; set; }
        public procurementDetail? procurementDetailRef { get; set; }
        public string? clName { get; set; }
        public string? clNumber { get; set; }
        public DateTime? clInit { get; set; }
        public DateTime? clExpiry { get; set; }


    }
}