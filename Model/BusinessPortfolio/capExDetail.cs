using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("capExDetails", Schema = "Portfolio")]
    public class capExDetail
    {
        [Key]
        public long capExDetailId { get; set; }
        public decimal? totalCapExpenditure { get; set; }
        public long? refProcurementDetailId { get; set; }
        public procurementDetail? refProcurementDetail { get; set; }
        public ICollection<capExCostComponent>? costComponents { get; set; }

    }
}