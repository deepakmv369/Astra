using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.DeliveryVehicles;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgGoals", Schema = "Portfolio")]
    public class orgGoal
    {
        [Key]
        public long orgGoalId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? goalName { get; set; }
        public string? goalDescription { get; set; }
        public DateTime? plannedFor { get; set; }
        public DateTime? achievedOn { get; set; }
        public int? orgGoalTypeId { get; set; }
        public mdGoalType? orgGoalType { get; set; }
        public long? parentGoalId { get; set; }
        public orgGoal? parentGoal { get; set; }
        public ICollection<orgGoal>? childGoals { get; set; }
        public ICollection<asnMotivational>? asnMotivationalGoals { get; set; }
        public ICollection<astraHistory>? goalsHistory { get; set; }
        public ICollection<projectOrigin>? goalsOfProjectsOrigins { get; set; }
        public ICollection<asnProjectOutput>? goalsOfProjects { get; set; }
    }
}