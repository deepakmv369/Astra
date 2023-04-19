using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;
using Astra_MK1.Model.DeliveryVehicles;

namespace Astra_MK1.Model.Governance
{
    [Table("governedEntities", Schema = "Governance")]
    public class governedEntity
    {
        [Key]
        public long governedEntityId { get; set; }
        public long? governedEntityProcurementId { get; set; }
        public procurementDetail? governedEntityProcurement { get; set; }
        public long? governedEntityProjectId { get; set; }
        public projectMaster? governedEntityProject { get; set; }
        public long? governedEntityDeliverableId { get; set; }
        public orgDeliverable? governedEntityDeliverable { get; set; }
        public string? entityRemarks { get; set; }
        public long? parentGovernedEntityId { get; set; }
        public governedEntity? parentGovernedEntity { get; set; }
        public ICollection<asnGovernedGoverning>? governedEntityAsn { get; set; }
        public ICollection<governanceLog>? entityGovernanceLogs { get; set; }
        public ICollection<governedEntity>? childGovernedEntities { get; set; }
        public ICollection<asnGovernedEntityStandard>? governedEntityStandardsAsn { get; set; }
        public ICollection<dispensationRecord>? governedEntityDispensation { get; set; }
    }
}