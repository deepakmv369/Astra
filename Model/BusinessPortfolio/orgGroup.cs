using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.DeliveryVehicles;
using Astra_MK1.Model.Governance;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgGroups", Schema = "Portfolio")]
    public class orgGroup
    {
        [Key]
        public long orgGroupId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? orgGroupName { get; set; }
        public string? groupPurpose { get; set; }
        public bool? isActive { get; set; } = false;
        public long? orgStructId { get; set; }
        public orgStructure? orgStruct { get; set; }
        public ICollection<asnGroupRole>? orgGroupRoleAsn { get; set; }
        public ICollection<asnGroupSkill>? GroupSkillsAsn { get; set; }
        public ICollection<asnGroupJob>? GroupJobsAsn { get; set; }
        public ICollection<asnMotivationalRole>? asnMotivationalRoleGroups { get; set; }
        public ICollection<astraHistory>? groupsHistory { get; set; }
        public ICollection<incidentManagementStatus>? orgGroupIncidents { get; set; }
        public ICollection<asnProjectStakeholder>? GroupStakeInProjects { get; set; }
        public ICollection<asnDispensationApproval>? groupOfDispensationApproval { get; set; }
        public ICollection<asnDispensationRequestor>? groupOfDispensationRequestor { get; set; }
        public ICollection<governingEntity>? groupGoverningEntity { get; set; }
        public ICollection<asnIncidentEscalationRoleGroup>? groupIncidentEsclationAsn { get; set; }
    }

}