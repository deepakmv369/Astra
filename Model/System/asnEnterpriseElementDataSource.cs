using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.System.MasterData;

namespace Astra_MK1.Model.System
{
    [Table("asnEnterpriseElementsDataSources", Schema = "astraSYSASNS")]
    public class asnEnterpriseElementDataSource
    {
        public long asnEnterpriseElementId { get; set; }
        public astraEnterpriseElement? asnEnterpriseElement { get; set; }
        public int asnDataSourceId { get; set; }
        public mdDataSource? asnDataSource { get; set; }
    }
}