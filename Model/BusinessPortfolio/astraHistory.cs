using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.System;

namespace Astra_MK1.Model.BusinessPortfolio
{

    public enum actionTypes
    {
        Create,
        Read,
        Update,
        Delete
    }
    [Table("astraHistory", Schema = "Portfolio")]
    public class astraHistory
    {
        [Key]
        public long astraHistoryId { get; set; }
        [Required]
        public actionTypes historyAction { get; set; }
        [Required]
        public DateTime historyDateTime { get; set; }
        public string? actionDescription { get; set; }
        public long? actionByRoleId { get; set; }
        public orgRole? actionByRole { get; set; }
        public long? actionByGroupId { get; set; }
        public orgGroup? actionByGroup { get; set; }
        public long? actionByActorId { get; set; }
        public orgActor? actionByActor { get; set; }
        public long? historyDriverId { get; set; }
        public orgDriver? historyDriver { get; set; }
        public long? historyDeliverableId { get; set; }
        public orgDeliverable? historyDeliverable { get; set; }
        public long? historyGoalId { get; set; }
        public orgGoal? historyGoal { get; set; }
        public long? historyMilestoneId { get; set; }
        public orgMilestone? historyMilestone { get; set; }
        public long? historyStructureId { get; set; }
        public orgStructure? historyStructure { get; set; }
        public long? historyAssetId { get; set; }
        public assetPortfolio? historyAsset { get; set; }
        public long enterpriseElementId { get; set; }
        public astraEnterpriseElement? enterpriseElement { get; set; }


        
    }
}