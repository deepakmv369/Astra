using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refProcurementTypes", Schema = "PortfolioRef")]
    public class refProcurementType
    {
        [Key]
        public int refProcurementTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? procTypeName { get; set; }
        public string? procTypeDescription { get; set; }
        public ICollection<procurementDetail>? procurementDetailTypeRefs { get; set; }
    }
}