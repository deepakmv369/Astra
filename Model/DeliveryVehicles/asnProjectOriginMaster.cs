using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.DeliveryVehicles
{
   [Table("asnProjectOriginsMaster", Schema = "VehiclesASNS")]
    public class asnProjectOriginMaster
    {
        public long asnProjectOriginId { get; set; }
        public bool? isActive { get; set; } = false;
        public projectOrigin? asnProjectOrigin { get; set; }
        public long? asnProjectMasterId { get; set; }
        public projectMaster? asnProjectMaster { get; set; }
    }
}