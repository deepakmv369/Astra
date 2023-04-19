using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.Governance;

namespace Astra_MK1.Model.DeliveryVehicles
{
    [Table("projectMaster", Schema = "Vehicles")]
    public class projectMaster
    {
        [Key]
        public long projectMasterId { get; set; }
        public string? projectDescription { get; set; }
        [MaxLength(50)]
        public string? projectName { get; set; }
        public DateTime? plannedStartDate { get; set; }
        public DateTime? plannedEndDate { get; set; }
        public DateTime? actualStartDate { get; set; }
        public DateTime? actualEndDate { get; set; }
        public ICollection<projectCostCenter>? projectMasterCostCenterItems { get; set; }
        public ICollection<asnProjectOriginMaster>? projectMasterOrigins { get; set; }
        public ICollection<asnProjectOutput>? projectOutputs { get; set; }
        public ICollection<asnProjectStakeholder>? projectStakeholders { get; set; }
        public ICollection<paymentSchedule>? projectPaymentSchedules { get; set; }
        public ICollection<paymentRecord>? projectPaymentRecords { get; set; }
        public ICollection<governedEntity>? projectAsGovernedEntity { get; set; }
    }
}