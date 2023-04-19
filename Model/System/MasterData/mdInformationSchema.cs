using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.System.MasterData
{
    [Table("mdInfomationSchemas", Schema = "astraSYSASNS")]
    public class mdInformationSchema
    {
        [Key]
        public int mdInformationSchemaId { get; set; }
        public string? informationSchemaName { get; set; }
        public ICollection<astraInformationObject>? schemaOfInfoObjects { get; set; }
        
    }
}