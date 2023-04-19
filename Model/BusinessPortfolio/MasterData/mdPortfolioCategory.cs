using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdPortfolioCategories", Schema = "PortfolioMaster")]
    public class mdPortfolioCategory
    {
        [Key]
        public int mdPortfolioCategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? portfolioName { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioCategories { get; set; }
    }
}