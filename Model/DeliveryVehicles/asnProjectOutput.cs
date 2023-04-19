using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("asnProjectOutputs", Schema = "VehiclesASNS")]
    public class asnProjectOutput
    {
        [Key]
        public long asnProjectOutputId { get; set; }
        public bool? isActive { get; set; } = false;
        public long? asnProjectMasterId { get; set; }
        public projectMaster? asnProjectMaster { get; set; }
        public long? asnProjectGoalId { get; set; }
        public orgGoal? asnProjectGoal { get; set; }
        public long? asnProjectMilestoneId { get; set; }
        public orgMilestone? asnProjectMilestone { get; set; }
        public long? asnProjectDeliverableId { get; set; }
        public orgDeliverable? asnProjectDeliverable { get; set; }
        public decimal? projectContributionToGoal { get; set; }
        public decimal? milestoneContributionToProject { get; set; }
        public decimal? deliveryContributionToMilestone { get; set; }

    }
}