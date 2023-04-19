using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdAssetTypes", Schema = "PortfolioMaster")]
    public class mdAssetType
    {
        [Key]
        public int mdAssetTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? assetType { get; set; } 
        public decimal? depreciation { get; set; } = Convert.ToDecimal(0.00);
        public int? parentAssetID { get; set; }
        public mdAssetType? parentAsset { get; set; }
        public ICollection<mdAssetType>? childAssetTypes { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioAssetTypes { get; set; }
        public ICollection<refDeliverable>? refDeliverableTypes { get; set; }
        public ICollection<orgDeliverable>? orgDeliverableTypes { get; set; }
        public ICollection<serviceLevel>? assetTypeServiceLevels { get; set; }
    }
}