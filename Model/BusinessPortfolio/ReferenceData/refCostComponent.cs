using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.DeliveryVehicles;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refCostComponents", Schema = "PortfolioRef")]
    public class refCostComponent
    {
        [Key]
        public long refCostComponentId { get; set; }
        public string? costComponentName { get; set; }
        public string? itemRemarks { get; set; }

        public ICollection<capExCostComponent>? refCapExCostComponents { get; set; } 
        public ICollection<opExCostComponent>? refOpExCostComponents { get; set; }
        public ICollection<projectCostComponent>? refProjectCostComponents { get; set; }
    }
}