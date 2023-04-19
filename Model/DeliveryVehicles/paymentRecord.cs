using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.DeliveryVehicles.MasterData;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("paymentRecords", Schema = "Vehicles")]
    public class paymentRecord
    {
        [Key]
        public long paymentRecordId { get; set; }
        public DateTime? invoiceDate { get; set; }
        [MaxLength(50)]
        public string? invoiceNumber { get; set; }
        [MaxLength(50)]
        public string? paymentInstrumentNumber { get; set; }
        public int? paymentRecordInstrumentId { get; set; }
        public mdPaymentInstrument? paymentRecordInstrument { get; set; }
        public DateTime? paymentReceiptDate { get; set; }
        [MaxLength(50)]
        public string? paymentReceiptNumber { get; set; }
        public long? paymentRecordProjectId { get; set; }
        public projectMaster? paymentRecordProject { get; set; }
    }
}