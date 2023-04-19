using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdComplexities", Schema = "PortfolioMaster")]
    public class mdComplexity
    {
        [Key]
        public int mdComplexityId { get; set; }
        public string? description { get; set; }
        [Required]
        [MaxLength(20)]
        public string? qualityIndicator { get; set; }
        [Required]
        public int? quantityIndicator { get; set; }
        public ICollection<assetPortfolio>? assetComplexities { get; set; }
    }
}