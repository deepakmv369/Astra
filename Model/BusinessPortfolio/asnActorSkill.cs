using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnActorSkills", Schema = "PortfolioASNS")]
    public class asnActorSkill
    {
        [Key]
        public long asnOrgActorId { get; set; }
        public bool? isActive { get; set; } = false;
        public orgActor? asnOrgActor { get; set; }
        public long? asnSkillParamId { get; set; }
        public skillParam? asnSkillParam { get; set; }
    }
}