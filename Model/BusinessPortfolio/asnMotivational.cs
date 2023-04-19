using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnMotivationals", Schema = "PortfolioASNS")]
    public class asnMotivational
    {
        [Key]
        public long asnMotivationalId { get; set; }
        public bool? isActive { get; set; } = false;
        public decimal? fulfillmentPercent { get; set; }
        [Required]
        public long? asnDeliverableId { get; set; }
        public orgDeliverable? asnDeliverable { get; set; }
        [Required]
        public long? asnGoalId { get; set; }
        public orgGoal? asnGoal { get; set; }

        public int? asnOperationId { get; set; }
        public refJob? asnOperation { get; set; }

        public long asnMilestoneId { get; set; }
        public orgMilestone? asnMilestone { get; set; }
        public long? asnOrgDriverId { get; set; }
        public orgDriver? asnOrgDriver { get; set; }
        public long? asnOrgStructureId { get; set; }
        public orgStructure? asnOrgStructure { get; set; }
        public int? thisPriorityId { get; set; }   
        public mdGeneralScale? thisPriority { get; set; }     
        public ICollection<asnMotivationalRole>? refAsnMotivationalRoles { get; set; }
        public ICollection<asnMotivationalSkill>? refAsnMotivationalSkills { get; set; }

    }
}