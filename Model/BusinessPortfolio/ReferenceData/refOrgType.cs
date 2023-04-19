using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refOrgTypes", Schema = "PortfolioRef")]
    public class refOrgType
    {
        [Key]
        public int refOrgTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? orgTypeName { get; set; }
        public ICollection<orgStructure>? orgStructuresType { get; set; }
    }
}