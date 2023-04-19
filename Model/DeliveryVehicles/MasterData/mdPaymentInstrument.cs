using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.DeliveryVehicles.MasterData
{
    [Table("mdPaymentInstruments", Schema = "VehiclesMaster")]
    public class mdPaymentInstrument
    {
        [Key]
        public int mdPaymentInstrumentId { get; set; }
        [MaxLength(50)]
        public string? paymentInstrumentName { get; set; }
        public ICollection<paymentRecord>? instrumentsOfPayments { get; set; }
    }
}