using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnActorRoles", Schema = "PortfolioASNS")]
    public class asnActorRole
    {
        [Key]
        public long asnActorRoleId { get; set; }
        public bool? isActive { get; set; } = false;
        public decimal? fullfillmentPct { get; set; }
        public string? reasonFor { get; set; }
        public long? asnOrgRoleId { get; set; }
        public orgRole? asnOrgRole { get; set; }
        public long? asnOrgActorId { get; set; }
        public orgActor? asnOrgActor { get; set; }

        
        
    }
}