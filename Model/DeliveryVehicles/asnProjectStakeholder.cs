using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("asnProjectStakeholders", Schema = "VehiclesASNS")]
    public class asnProjectStakeholder
    {
        [Key]
        public long asnProjectStakeholderId { get; set; }
        public bool? isActive { get; set; } = false;
        public long? asnStakeProjectMasterId { get; set; }
        public projectMaster? asnStakeProjectMaster { get; set; }
        public long? asnStakeOrgStructureId { get; set; }
        public orgStructure? asnStakeOrgStructure { get; set; }
        public long? asnStakeOrgGroupId { get; set; }
        public orgGroup? asnStakeOrgGroup { get; set; }
        public long? asnStakeOrgRoleId { get; set; }
        public orgRole? asnStakeOrgRole { get; set; }
        public int? asnStakeTypeId { get; set; }
        public mdStake? asnStakeType { get; set; }
    }
}