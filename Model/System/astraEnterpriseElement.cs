using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.System
{
    [Table("astraEnterpriseElements", Schema = "astraSYS")]
    public class astraEnterpriseElement
    {
        [Key]
        public long astraEnterpriseElementId { get; set; }
        [MaxLength(50)]
        public string? dataEntityName { get; set; }
        [MaxLength(100)]
        public string? dataEntityLabel { get; set; }
        public string? dataEntityDescription { get; set; }
        public ICollection<asnEnterpriseElementDataSource>? enterpriseElementDataSourcesAsn { get; set; }
        public ICollection<asnInformationObjectEnterpriseElement>? enterpriseElementInformationObjectAsn { get; set; }
    }   
}