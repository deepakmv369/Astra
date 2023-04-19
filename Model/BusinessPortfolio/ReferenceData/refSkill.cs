using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refSkills", Schema = "PortfolioRef")]
    public class refSkill
    {
        [Key]
        public int refSkillId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? skillName { get; set; }
        public string? skillDescription { get; set; }
        public int? parentSkillId { get; set; }
        public refSkill? parentSkill { get; set; }
        public ICollection<refSkill>? childSkills { get; set; }
        public ICollection<skillParam>? skillParamSkills { get; set; }
    }
}