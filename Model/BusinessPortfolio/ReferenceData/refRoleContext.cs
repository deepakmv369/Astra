using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refRoleContexts", Schema = "PortfolioRef")]
    public class refRoleContext
    {
        [Key]
        public int refRoleContextId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? roleContextName { get; set; }
        public ICollection<refRole>? roles { get; set; }
    }
}