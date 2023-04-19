using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refOpExTypes", Schema = "PortfolioRef")]
    public class refOpExType
    {
        [Key]
        public int refOpExTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? opexTypeName { get; set; }
        public ICollection<operationalExpenditure>? opExTypeExpenditures { get; set; }
    }
}