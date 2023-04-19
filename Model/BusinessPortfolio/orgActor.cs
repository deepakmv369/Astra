using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgActors", Schema = "Portfolio")]
    public class orgActor
    {
        [Key]
        public long orgActorId { get; set; }
        [Required]
        public Guid? uniqueId { get; set; }
        [MaxLength(100)]
        //Fully qualified domain name of LDAP
        public string? actorIdentityDomain { get; set; }
        [Required]
        [MaxLength(50)]
        public string? firstName { get; set; }
        [MaxLength(50)]
        public string? middleName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? lastName { get; set; }
        public string? actorDescription { get; set; }
        [Required]
        [MaxLength(50)]
        public string? mailId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? userName { get; set; }
        [Required]
        public int? actorTypeId { get; set; }
        public mdActorType? actorType { get; set; }
        public ICollection<asnActorRole>? actorOfRoles { get; set; }
        public ICollection<asnActorSkill>? orgActorSkillsAsn { get; set; }
        public ICollection<astraHistory>? actorsHistory { get; set; }


    }
}