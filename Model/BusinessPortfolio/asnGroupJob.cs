using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnGroupJobs", Schema = "PortfolioASNS")]
    public class asnGroupJob
    {
        [Key]
        public long asnGroupJobId { get; set; }
        public bool? isActive { get; set; } = false;
        [Required]
        public long? asnGroupJoborgGroupId { get; set; }
        public orgGroup? asnGroupJoborgGroup { get; set; }
        [Required]
        public int? asnGroupRefJobId { get; set; }
        public refJob? asnGroupRefJob { get; set; }
        public decimal? contributionPercentage { get; set; } = Convert.ToDecimal(0.00);
        public int? jobPriority { get; set; }

    }
}