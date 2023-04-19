using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("projectBudgets", Schema = "Vehicles")]
    public class projectBudget
    {
        [Key]
        public long projectBudgetId { get; set; }
        [MaxLength(100)]
        public string? budgetName { get; set; }
        public long? budgetCostCenterId { get; set; }
        public projectCostCenter? budgetCostCenter { get; set; }
        public decimal? budgetAmount { get; set; }
        public string? budgetDescription { get; set; }
        [MaxLength(3)]
        public string? currencyAlpha3 { get; set; }
        public ICollection<asnProjectCostComponentBudget>? budgetCostComponentAsns { get; set; }
    }
}