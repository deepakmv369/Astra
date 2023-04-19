using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;

namespace Astra_MK1.Model.Governance
{
    [Table("governingEntities", Schema = "Governance")]
    public class governingEntity
    {
        [Key]
        public long governingEntityId { get; set; }
        public long? governingEntityStructureId { get; set; }
        public orgStructure? governingEntityStructure { get; set; } 
        public long? governingEntityGroupId { get; set; }
        public orgGroup? governingEntityGroup { get; set; }
        public long? governingEntityRoleId { get; set; }
        public orgRole? governingEntityRole { get; set; }
        public string? governingRemarks { get; set; }
        public ICollection<asnGovernedGoverning>? governingEntityAsn { get; set; }
        public ICollection<asnGoverningEntityLog>? governingEntityLogAsn { get; set; }
    }
}