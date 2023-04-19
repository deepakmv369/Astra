using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdFrequencies", Schema = "PortfolioMaster")]
    public class mdFrequency
    {
        [Key]
        public int mdFrequencyId { get; set; }
        public DateTime? rangeStart { get; set; }
        public DateTime? rangeEnd { get; set; }
        public DateTime? specific { get; set; }
        public DateTime? startAt { get; set; }
        public ICollection<alertService>? alertServicesFrequency { get; set; }
        public ICollection<assetPortfolio>? assetPortfolioFrequeny { get; set; }
        public ICollection<operationalExpenditure>? frequenciesOpEx { get; set; }

    }
}