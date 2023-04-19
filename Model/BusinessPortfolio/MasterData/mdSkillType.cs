using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdSkillTypes", Schema = "PortfolioMaster")]
    public class mdSkillType
    {
        [Key]
        public int mdSkillTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? skillTypeName { get; set; }
        public ICollection<skillParam>? skillParamSkillTypes { get; set; }
    }
}