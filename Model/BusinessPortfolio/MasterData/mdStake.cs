using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.DeliveryVehicles;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdStakes", Schema = "PortfolioMaster")]
    public class mdStake
    {
        [Key]
        public int mdStakeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? stakeName { get; set; }
        public ICollection<asnMotivationalRole>? asnMotivationalRoleStakeholderTypes { get; set; }
        public ICollection<asnProjectStakeholder>? asnProjectStakeholderStakes { get; set; }
    }
}