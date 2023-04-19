using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("projectCostComponents", Schema = "Vehicles")]
    public class projectCostComponent
    {
        [Key]
        public long projectCostComponentId { get; set; }
        public long? costComponentRefId { get; set; }
        public refCostComponent? costComponentRef { get; set; }
        public ICollection<asnProjectCostComponentBudget>? costComponentBudgetAsns { get; set; }


    }
}