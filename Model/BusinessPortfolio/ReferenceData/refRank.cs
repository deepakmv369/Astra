using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refRanks", Schema = "PortfolioRef")]
    public class refRank
    {
        [Key]
        public int refRankId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? rankName { get; set; }
        public ICollection<orgRole>? orgRolesRank { get; set; }
    }
}