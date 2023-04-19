using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnGroupRoles", Schema = "PortfolioASNS")]
    public class asnGroupRole
    {
        [Key]
        public long asnGroupRoleId { get; set; }
        public bool? isActive { get; set; } = false;
        [Required]
        public long asnOrgGroupId { get; set; }
        public orgGroup? asnOrgGroup { get; set; }
        [Required]
        public long asnOrgRoleId { get; set; }
        public orgRole? asnOrgRole { get; set; }
    }
}