using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;
using Astra_MK1.Model.DeliveryVehicles;
using Astra_MK1.Model.Governance;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgStructures", Schema = "Portfolio")]
    public class orgStructure
    {
        [Key]
        public long orgStructureId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? orgName { get; set; }
        public long? parentOrgId { get; set; }
        public orgStructure? parentOrg { get; set; }
        public ICollection<orgStructure>? childOrgs { get; set; }
        public int? workingStatusId { get; set; }
        public mdPhase? workingStatus { get; set; }
        public int? commercialStatusId { get; set; }
        public refOrgStatus? commercialStatus { get; set; }
        public int? orgTypeId { get; set; }
        public refOrgType? orgType { get; set; }
        public string? remarks { get; set; }
        public long? locationId { get; set; }
        public orgLocation? location { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioOrgStructureManager { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioOrgStructureOwner { get; set; }
        public ICollection<orgGroup>? orgGroupStructures { get; set; }
        public ICollection<asnMotivational>? asnMotivationalStructures { get; set; }
        public ICollection<astraHistory>? structuresHistory { get; set; }
        public ICollection<incidentManagementStatus>? orgStructureIncidents { get; set; }
        public ICollection<asnProjectStakeholder>? structureStakeInProjects { get; set; }
        public ICollection<asnDispensationApproval>? structureOfDispensationApproval { get; set; }
        public ICollection<asnDispensationRequestor>? structureOfDispensationRequestor { get; set; }
        public ICollection<governingEntity>? structureGoverningEntity { get; set; }
    }
}