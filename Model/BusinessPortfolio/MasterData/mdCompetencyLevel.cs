using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdCompetencyLevels", Schema = "PortfolioMaster")]
    public class mdCompetencyLevel
    {
        [Key]
        public int mdCompetencyLevelId { get; set; }
        [Required]
        public string? competencyLevel { get; set; }
        public ICollection<skillParam>? skillParamsCompetencies { get; set; }
    }
}