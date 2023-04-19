using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnMotivationalSkills", Schema = "PortfolioASNS")]
    public class asnMotivationalSkill
    {
        [Key]
        public long asnMotivationalSkillId { get; set; }
        public bool? isActive { get; set; } = false;
        [Required]
        public long refAsnMotivationalId { get; set; }
        public asnMotivational? refAsnMotivational { get; set; }
        [Required]
        public long asnSkillParamId { get; set; }
        public skillParam? asnSkillParam { get; set; }
        

    }
}