using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("projectCostCenter", Schema = "Vehicles")]
    public class projectCostCenter
    {
        [Key]
        public long projectCostCenterId { get; set; }
        public long? costCenterProjectMasterId { get; set; }
        public projectMaster? costCenterProjectMaster { get; set; }
        public ICollection<projectBudget>? projectCostsAtCostCenter { get; set; }

    }
}