using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnGroupSkills", Schema = "PortfolioASNS")]
    public class asnGroupSkill
    {
        [Key]
        public long asnGroupSkillId { get; set; }
        public bool? isActive { get; set; } = false;
        [Required]
        public long asnOrgGroupId { get; set; }
        public orgGroup? asnOrgGroup { get; set; }
        [Required]
        public long asnSkillParamId { get; set; }
        public skillParam? asnSkillParam { get; set; }

    }
}