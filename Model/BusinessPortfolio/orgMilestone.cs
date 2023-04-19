using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.DeliveryVehicles;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgMilestones", Schema = "Portfolio")]
    public class orgMilestone
    {
        [Key]
        public long orgMilestoneId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? milestoneName { get; set; }
        public string? milestoneDescription { get; set; }
        public DateTime? plannedFor { get; set; }
        public DateTime? achievedOn { get; set; }
        public int? milestoneSequence { get; set; }
        public decimal? contributionPercent { get; set; }
        public long? parentMilestoneId { get; set; }
        public orgMilestone? parentMilestone { get; set; }
        public ICollection<orgMilestone>? childMilestones { get; set; }
        public ICollection<asnMotivational>? asnMotivationalMilestones { get; set; }
        public ICollection<procurementDetail>? procurementDetailMilestones { get; set; }
        public ICollection<astraHistory>? milestonesHistory { get; set; }
        public ICollection<projectOrigin>? milestonesOfProjectsOrigins { get; set; }
        public ICollection<asnProjectOutput>? milestonesOfProjectGoals { get; set; }
    }
}