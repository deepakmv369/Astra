using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnMotivationalRoles", Schema = "PortfolioASNS")]
    public class asnMotivationalRole
    {
        [Key]
        public long asnMotivationalRoleId { get; set; } 
        public bool? isActive { get; set; } = false;
        [Required]
        public int asnAuthorityLevelId { get; set; }
        public mdAuthorityLevel? asnAuthorityLevel { get; set; }
        [Required]
        public long refAsnMotivationalId { get; set; }
        public asnMotivational? refAsnMotivational { get; set; }
        [Required]
        public int stakeholderTypeId { get; set; }
        public mdStake? stakeholderType { get; set; }
        public int? stakeholderRoleId { get; set; }
        public refRole? stakeholderRole { get; set; }
        public long? stakeholderGroupId { get; set; }
        public orgGroup? stakeholderGroup { get; set; }
        public decimal? stakePercent { get; set; }


    }
}