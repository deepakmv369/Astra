using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdDriverTypes", Schema = "PortfolioMaster")]
    public class mdDriverType
    {
        [Key]
        [Required]
        public int mdDriverTypeId { get; set; }
        [MaxLength(50)]
        public string? driverTypeName { get; set; }
        public int? parentDriverTypeId { get; set; }
        public mdDriverType? parentDriverType { get; set; }
        public ICollection<mdDriverType>? childDriverTypes { get; set; }
        public ICollection<orgDriver>? OrgDriverRefs { get; set; }
    }
}