using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    //Contract and/or Licence types
    [Table("refCLTypes", Schema = "PortfolioRef")]
    public class refCLType
    {
        [Key]
        public int refCLTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? clTypeName { get; set; }
        public string? description { get; set; }
        public ICollection<cotsProcurementDetail>? procurementDetailsCOTS { get; set; }
    }
}