using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.System.MasterData
{
    [Table("mdDataSources", Schema = "astraSYSMaster")]
    public class mdDataSource
    {
        [Key]
        public int mdDataSourceId { get; set; }
        public string? dataSourceName { get; set; }
        public string? dataSourceDescription { get; set; }
        public bool? isPersisted { get; set; }
        public ICollection<asnDataSourceAccessType>? dataSourceAccessTypesAsn { get; set; }
        public ICollection<asnEnterpriseElementDataSource>? dataSourceEnterpriseElementsAsn { get; set; }
    }
}