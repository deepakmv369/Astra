using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.System.MasterData;

namespace Astra_MK1.Model.System
{
    [Table("astraInformationObjects", Schema = "astraSYS")]
    public class astraInformationObject
    {
        [Key]
        public long astraInformationObjectId { get; set; }
        [MaxLength(50)]
        public string? informationObjectName { get; set; }
        [MaxLength(100)]
        public string? informationObjectLabel { get; set; }
        public string? informationObjectDescription { get; set; }
        public int informationSchemaId { get; set; }
        public mdInformationSchema? informationSchema { get; set; }
        public ICollection<asnInformationObjectEnterpriseElement>? informationObjectEnterpriseElementAsn { get; set; }
        public ICollection<informationObjectField>? astraInformationObjectFields { get; set; }

    }
}