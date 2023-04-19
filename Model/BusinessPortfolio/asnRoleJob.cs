using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnRoleJobs", Schema = "PortfolioASNS")]
    public class asnRoleJob
    {
        public long asnRoleJobId { get; set; }
        public bool? isActive { get; set; } = false;
        public int? asnRoleId { get; set; }
        public refRole? asnRole { get; set; }
        public int? asnJobId { get; set; }
        public refJob? asnJob { get; set; }
        public decimal? contributionPercent { get; set; }
        public int roleJobPriority { get; set; }
    }
}