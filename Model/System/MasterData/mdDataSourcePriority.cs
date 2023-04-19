using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.System.MasterData
{
    [Table("mdDataSourcePriorities", Schema = "astraSYSMaster")]
    public class mdDataSourcePriority
    {
        [Key]
        public int mdDataSourcePriorityId { get; set; }
        public int? priorityOrder { get; set; }
        public string? priorityName { get; set; }
        public ICollection<asnDataSourceAccessType>? dataSourcePriorityAccessTypeAsn { get; set; }
    }
}