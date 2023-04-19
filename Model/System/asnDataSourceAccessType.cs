using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.System.MasterData;

namespace Astra_MK1.Model.System
{
    [Table("asnDataSourceAccessTypes", Schema = "astraSYSASNS")]
    public class asnDataSourceAccessType
    {
        [Key]
        public int asnDataSourceAccessTypeId { get; set; }
        public bool? isActive { get; set; }
        public int asnDataSourceId { get; set; }
        public mdDataSource? asnDataSource { get; set; }
        public int asnAccessTypeId { get; set; }
        public mdDataSourceAccessType? asnAccessType { get; set; }
        public int asnDataSourcePriorityId { get; set; }
        public mdDataSourcePriority? asnDataSourcePriority { get; set; }
    }
}