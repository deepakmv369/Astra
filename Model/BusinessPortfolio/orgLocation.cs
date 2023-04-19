using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgLocations", Schema = "Portfolio")]
    public class orgLocation
    {
        [Key]
        public long orgLocationId { get; set; }
        [MaxLength(100)]
        public string? orgAddress { get; set; }
        [MaxLength(50)]
        public string? blockNum { get; set; }
        [MaxLength(50)]
        public string? buildingName { get; set; }
        [MaxLength(3)]
        public string? countryAlpha3 { get; set; }
        [MaxLength(50)]
        public string? locJurisdiction { get; set; }
        [MaxLength(50)]
        public string? locationName { get; set; }
        [MaxLength(10)]
        public string? officeNumber { get; set; }
        [MaxLength(50)]
        public string? locRegion { get; set; }
        [MaxLength(50)]
        public string? roadNameNum { get; set; }
        public bool? sameAsParent { get; set; } = false;
        [MaxLength(50)]
        public string? streetNameNum { get; set; }
        [MaxLength(50)]
        public string? stateName { get; set; }
        [MaxLength(50)]
        public string? webSite { get; set; }
        public ICollection<locPhone>? locPhones { get; set; }
        public ICollection<orgStructure>? orgStructures { get; set; }
    }
}