using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refDeliverables", Schema = "PortfolioRef")]
    public class refDeliverable
    {
        [Key]
        public long refDeliverableId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? deliverableName { get; set; }
        public int? deliverableTypeId { get; set; }
        public mdAssetType? deliverableType { get; set; }
        public string? deliverableDescription { get; set; }
    
    }
}