using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnRoleSkill", Schema = "PortfolioASNS")]
    public class asnRoleSkill
    {
        public int asnRoleId { get; set; }
        public bool? isActive { get; set; } = false;
        public refRole? asnRole { get; set; }
        public long? asnSkillParamId { get; set; }
        public skillParam? asnSkillParam { get; set; }
    }
}