using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refIncidentStatuses", Schema = "PortfolioRef")]
    public class refIncidentStatus
    {
        [Key]
        public int refIncidentStatusId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? incidentStatusName { get; set; }
        public ICollection<incidentManagementStatus>? incidentStatusesManagement { get; set; }
    }
}