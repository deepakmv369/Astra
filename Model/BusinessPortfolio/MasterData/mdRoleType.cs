using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdRoleTypes", Schema = "PortfolioMaster")]
    public class mdRoleType
    {
        [Key]
        public int mdRoleTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? roleTypeName { get; set; }
        public string? description { get; set; }
        public ICollection<refRole>? roles { get; set; }
        
    }
}