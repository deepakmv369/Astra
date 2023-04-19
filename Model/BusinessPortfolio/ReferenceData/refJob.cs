using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refJobs", Schema = "PortfolioRef")]
    public class refJob
    {
        [Key]
        public int refJobId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? jobName { get; set; }
        public string? jobDescription { get; set; }
        public int? parentJobId { get; set; }
        public refJob? parentJob { get; set; }
        public ICollection<refJob>? childJobs { get; set; }
        public ICollection<asnGroupJob>? asnGroupJobs { get; set; }
        public ICollection<asnJobAssetAuth>? asnJobAssetAuths { get; set; }
        public ICollection<asnRoleJob>? asnRoleJobJobs { get; set; }
        public ICollection<asnMotivational>? asnMotivationalJobs { get; set; }
        public ICollection<asnJobDeliverable>? asnJobDeliverableJobs { get; set; }

    }
}