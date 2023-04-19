using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdPredicates", Schema = "PortfolioMaster")]
    public class mdPredicate
    {
        [Key]
        public int mdPredicateId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? predicateFormula { get; set; }
        public ICollection<skillParam>? skillParamsPredicates { get; set; }
    }
}