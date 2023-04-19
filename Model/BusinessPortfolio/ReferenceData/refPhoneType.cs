using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refPhoneTypes", Schema = "PortfolioRef")]
    public class refPhoneType
    {
        [Key]
        public long refPhoneTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? phoneTypeName { get; set; }
        public virtual locPhone? locPhone { get; set; }
    }
}