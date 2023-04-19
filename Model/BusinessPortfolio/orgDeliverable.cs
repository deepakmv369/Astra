using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.DeliveryVehicles;
using Astra_MK1.Model.Governance;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgDeliverables", Schema = "Portfolio")]
    public class orgDeliverable
    {
        [Key]
        public long orgDeliverableId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? deliverableName { get; set; }
        public string? deliverableDescription { get; set; }
        public int? deliverableTypeId { get; set; }
        public mdAssetType? deliverableType { get; set; }
        public long? parentDeliverableId { get; set; }
        public orgDeliverable? parentDeliverable { get; set; }
        public ICollection<orgDeliverable>? childDeliverables { get; set; }
        public ICollection<asnMotivational>? asnMotivationalDeliverables { get; set; }
        public ICollection<asnJobDeliverable>? asnOrgDeliverables { get; set; }
        public ICollection<astraHistory>? deliverablesHistory { get; set; }
        public ICollection<asnProjectOutput>? deliverablesOfProjectMilestones { get; set; }
        public ICollection<governedEntity>? deliverableAsGovernedEntity { get; set; }
    }
}