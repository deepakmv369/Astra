using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.System.MasterData
{
    [Table("mdDataSourceAccessTypes", Schema = "astraSYSMaster")]
    public class mdDataSourceAccessType
    {
        [Key]
        public int mdDataSourceAccessTypeId { get; set; }
        [MaxLength(50)]
        public string? dataSourceAccessTypeName { get; set; }
        public byte[]? dataSourceRefDoc { get; set; }
        public ICollection<asnDataSourceAccessType>? accessTypeDataSourceAsn { get; set; }
    }
}