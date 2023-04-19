using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;
using Astra_MK1.Model.DeliveryVehicles;
using Astra_MK1.Model.Governance;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgRoles", Schema = "Portfolio")]
    public class orgRole
    {
        [Key]
        public long orgRoleId { get; set; }
        public long? parentRoleId { get; set; }
        public orgRole? parentRole { get; set; }
        public ICollection<orgRole>? childRoles { get; set; }
        public int? roleRankId { get; set; }
        public refRank? roleRank { get; set; }
        public int? vitalityIndicatorId { get; set; }
        public mdGeneralScale? vitalityIndicator { get; set; }
        public ICollection<asnActorRole>? roleOfActors { get; set; }
        public ICollection<asnGroupRole>? orgRoleGroupsAsn { get; set; }
        public ICollection<asnIncidentEscalationRoleGroup>? asnIncidentEscalationRoles { get; set; }
        public ICollection<astraHistory>? rolesHistory { get; set; }
        public ICollection<incidentManagementStatus>? orgRoleIncidents { get; set; }
        public ICollection<asnProjectStakeholder>? roleStakeInProjects { get; set; }
        public ICollection<asnDispensationApproval>? roleOfDispensationApproval { get; set; }
        public ICollection<asnDispensationRequestor>? roleOfDispensationRequestor { get; set; }
        public ICollection<governingEntity>? roleGoverningEntity { get; set; }
    }
}