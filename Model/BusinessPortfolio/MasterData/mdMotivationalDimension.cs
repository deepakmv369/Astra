using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdMotivationalDimensions", Schema = "PortfolioMaster")]
    public class mdMotivationalDimension
    {
        [Key]
        public int mdMotivationalDimensionId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? dimensionName { get; set; }
        public string? description { get; set; }
        public ICollection<motivationalDimensionOfImportance>? motivationalDimensions { get; set; }

    }
}