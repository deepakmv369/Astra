using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.System.MasterData;

namespace Astra_MK1.Model.System
{
    [Table("informationObjectFields", Schema = "astraSYS")]
    public class informationObjectField
    {
        [Key]
        public long informationObjectFieldId { get; set; }
        [MaxLength(50)]
        public string? fieldName { get; set; }
        [MaxLength(100)]
        public string? fieldLabel { get; set; }
        public string? fieldDescription { get; set; }
        public int? fieldTypeId { get; set; }
        public mdAstraFieldType? fieldType { get; set; }
        public long? informationObjectRefId { get; set; }
        public astraInformationObject? informationObjectRef { get; set; }
    }
}