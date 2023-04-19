using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("paymentSchedules", Schema = "Vehicles")]
    public class paymentSchedule
    {
        [Key]
        public long paymentScheduleId { get; set; }
        public decimal? paymentPercentage { get; set; }
        public DateTime? plannedPaymentDate { get; set; }
        public decimal? paymentAmount { get; set; }
        public string? scheduleRemarks { get; set; }
        public long? paymentScheduleProjectId { get; set; }
        public projectMaster? paymentScheduleProject { get; set; }
    }
}