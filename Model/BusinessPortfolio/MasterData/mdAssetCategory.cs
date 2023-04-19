using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdAssetCategories", Schema = "PortfolioMaster")]
    public class mdAssetCategory
    {
        [Key]
        public int mdAssetCategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? categoryName { get; set; }
        public string? description { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioCategory { get; set; }
    }
}