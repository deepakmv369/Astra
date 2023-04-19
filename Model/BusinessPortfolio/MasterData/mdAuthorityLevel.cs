using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdAuthorityLevels", Schema = "PortfolioMaster")]
    public class mdAuthorityLevel
    {
        [Key]
        public int mdAuthorityLevelId { get; set; }
        [MaxLength(50)]
        public string? authorityLevel { get; set; }
        public ICollection<mdAuthAccessLevel>? authorityAccessLevels { get; set; }
        public ICollection<asnMotivationalRole>? asnMotivationalRoleAuthorityAccessLevels { get; set; }
    }
}