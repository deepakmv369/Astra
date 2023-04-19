using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("skillParams", Schema = "Portfolio")]
    public class skillParam
    {
        [Key]
        public long skillParamId { get; set; }
        public int? competencyLevelId { get; set; }
        public mdCompetencyLevel? competencyLevel { get; set; }
        public int? expPredicateId { get; set; }
        public mdPredicate? expPredicate { get; set; }
        public decimal? expValue { get; set; }
        public int? skillId { get; set; }
        public refSkill? Skill { get; set; }
        public int? skillTypeId { get; set; }
        public mdSkillType? skillType { get; set; }
        public ICollection<asnActorSkill>? skillParamsAsn { get; set; }
        public ICollection<asnGroupSkill>? groupSkillsAsn { get; set; }
        public ICollection<asnRoleSkill>? asnRoleSkills { get; set; }
        public ICollection<asnMotivationalSkill>? asnMotivationalSkillParams { get; set; }
        

    }
}