using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("alertServices", Schema = "Portfolio")]
    public class alertService
    {
        [Key]
        public long alertServiceId { get; set; }
        public int? alertStartingPoint { get; set; }
        public int? alertFrequencyId { get; set; }
        public mdFrequency? alertFrequency { get; set; }
        public int? alertIntervalId { get; set; }
        public refTimeUnit? alertInterval { get; set; }
        public ICollection<procurementDetail>? procurementDetailAlerts { get; set; }

    }
}