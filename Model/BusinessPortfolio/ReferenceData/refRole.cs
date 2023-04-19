using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refRoles", Schema = "PortfolioRef")]
    public class refRole
    {
        [Key]
        public int refRoleId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? roleName { get; set; }
        public string? roleDescription { get; set; }
        public int? roleTypeId { get; set; }
        public mdRoleType? roleType { get; set; }
        public int? roleContextId { get; set; }
        public refRoleContext? roleContext { get; set; }
        public ICollection<asnRoleSkill>? asnRoleSkillsRole { get; set; }
        public ICollection<asnRoleJob>? asnRoleJobRoles { get; set; }
        public ICollection<asnMotivationalRole>? asnMotivationalRoleRoles { get; set; }
    }
}