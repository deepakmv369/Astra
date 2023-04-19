using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnJobDeliverables", Schema = "PortfolioASNS")]
    public class asnJobDeliverable
    {
        [Key]
        public long asnJobDeliverableId { get; set; }
        public bool? isActive { get; set; } = false;
        [Required]
        public long asnDeliverableId { get; set; }
        public orgDeliverable? asnDeliverable { get; set; }
        [Required]
        public int asnJobId { get; set; }
        public refJob? asnJob { get; set; }
        public decimal? fulfillmentPercent { get; set; }
    }
}