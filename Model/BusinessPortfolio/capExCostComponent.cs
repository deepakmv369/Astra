using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("capExCostComponents", Schema = "Portfolio")]
    public class capExCostComponent
    {
        public long refCapExDetailId { get; set; }
        public capExDetail? refCapExDetail { get; set; }
        public long? costComponentId { get; set; }
        public refCostComponent? costComponent { get; set; }
        public decimal? capExCost { get; set; }
        [MaxLength(3)]
        public string? capExCurrencyCode { get; set; }
    }
}