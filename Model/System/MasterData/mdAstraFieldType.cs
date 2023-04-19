using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.System.MasterData
{
    [Table("mdAstraFieldTypes", Schema = "astraSYSMaster")]
    public class mdAstraFieldType
    {
        [Key]
        public int mdAstraFieldTypeId { get; set; }
        [MaxLength(50)]
        public string? dbFieldTypeName { get; set; }
        public string? codeFieldTypeName { get; set; }
        public decimal? maxLength { get; set; }
        public ICollection<informationObjectField>? fieldTypeOfInformationObjectField { get; set; }
    }
}