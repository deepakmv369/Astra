using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("locPhones", Schema = "Portfolio")]
    public class locPhone
    {
        [Key]
        public long locPhoneId { get; set; }
        [MaxLength(5)]
        public string? isdCode { get; set; }
        [MaxLength(5)]
        public string? stdCode { get; set; }
        [MaxLength(12)]
        public string? telNumber { get; set; }
        public long? locPhoneTypeId { get; set; }
        public long? orgLocationId { get; set; }
        public orgLocation? orgLocation { get; set; }
        public virtual refPhoneType? locPhoneType { get; set; }

    }
}