using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.DeliveryVehicles;
using Astra_MK1.Model.Governance;
using Astra_MK1.Model.Governance.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("orgDrivers", Schema = "Portfolio")]
    public class orgDriver
    {
        [Key]
        [Required]
        public long orgDriverId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? odName { get; set; } 
        [MaxLength(200)]
        public string? odDescription { get; set; } 
        [Required]
        public DateTime? createdOn { get; set; }
        public DateTime? approvedOn { get; set; }
        public DateTime? plannedStart { get; set; }
        public DateTime? plannedEnd { get; set; }
        public DateTime? actualStart { get; set; }
        public DateTime? actualEnd { get; set; }
        public long? parentOrgDriverId { get; set; }
        public virtual orgDriver? parentOrgDriver { get; set; }
        public virtual ICollection<orgDriver>? childOrgDrivers { get; set; }
        public int? driverTypeID { get; set; }
        public mdDriverType? driverType { get; set; }
        public int? ppImplicationId { get; set; }
        public mdPPImplication? ppImplicationRef { get; set; }
        public ICollection<asnMotivational>? asnMotivationalDrivers { get; set; }
        public ICollection<procurementDetail>? procurementDetailDrivers { get; set; }
        public ICollection<motivationalDimensionOfImportance>? dimensionalImportances { get; set; }
        public ICollection<astraHistory>? driversHistory { get; set; }
        public ICollection<operationalExpenditure>? driverOpExs { get; set; }
        public ICollection<projectOrigin>? driversOfProjectsOrigin { get; set; }

        

    }
}
