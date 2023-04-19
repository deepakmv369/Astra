using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdGoalTypes", Schema = "PortfolioMaster")]
    public class mdGoalType
    {
    [Key]
    public int mdGoalTypeId { get; set; }
    [MaxLength(50)]
    [Required]
    public string? goalTypeName { get; set; }
    public ICollection<orgGoal>? goalTypeOfGoals { get; set; }
    }
}