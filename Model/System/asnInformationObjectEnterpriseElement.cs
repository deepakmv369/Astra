using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.System
{
    [Table("asnInformationObjectEnterpriseElements", Schema = "astraSYSASNS")]
    public class asnInformationObjectEnterpriseElement
    {
        public bool? isActive { get; set; }
        public long asnEnterpriseElementId { get; set; }
        public astraEnterpriseElement? asnEnterpriseElement { get; set; }
        public long asnInformationObjectId { get; set; }
        public astraInformationObject? asnInformationObject { get; set; }
    }
}