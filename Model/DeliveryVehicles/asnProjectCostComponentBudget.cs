using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("asnProjectCostComponentBudgets", Schema = "VehiclesASNS")]
    public class asnProjectCostComponentBudget
    {
        public long asnBudgetId { get; set; }
        public bool? isActive { get; set; } = false;
        public projectBudget? asnBudget { get; set; }
        public long? asnCostComponentId { get; set; }
        public projectCostComponent? asnCostComponent { get; set; }
    }
}