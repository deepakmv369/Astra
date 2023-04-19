using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refOrgStatuses", Schema = "PortfolioRef")]
    public class refOrgStatus
    {
        [Key]
        public int refOrgStatusId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? orgStatusName { get; set; }
        public ICollection<orgStructure>? orgStructuresStatus { get; set; }
        
    }
}