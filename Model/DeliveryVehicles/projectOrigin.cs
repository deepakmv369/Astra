using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("projectOrigins", Schema = "Vehicles")]
    public class projectOrigin
    {
        [Key]
        public long projectOriginId { get; set; }
        public long? projectOriginDriverId { get; set; }
        public orgDriver? projectOriginDriver { get; set; } //Project is Originated from an Organization Driver
        public long? projectOriginGoalId { get; set; } //Project is originated from  Goal under an Driver
        public orgGoal? projectOriginGoal { get; set; }
        public long? projectOriginMilestoneId { get; set; }//Project is originated from a Milestone under Goal of a Driver
        public orgMilestone? projectOriginMilestone { get; set; }
        public ICollection<asnProjectOriginMaster>? projectOriginMasters { get; set; }
    }
}