using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("incidentManagementStatuses", Schema = "Portfolio")]
    public class incidentManagementStatus
    {
        [Key]
        public long incidentManagementStatusId { get; set; }
        public string? statusNotes { get; set; }
        public DateTime? statusDate { get; set; }
        public int? incidentStatusRefId { get; set; }
        public refIncidentStatus? incidentStatusRef { get; set; }
        public long? assignedToOrgStructureId { get; set; }
        public orgStructure? assignedToOrgStructure { get; set; }
        public long? assignedToOrgGroupId { get; set; }
        public orgGroup? assiginedToOrgGroup { get; set; }
        public long? assignedToOrgRoleId { get; set; }
        public orgRole? assignedToOrgRole { get; set; }
        public ICollection<incidentManagementRecord>? incidentManagementRecordStatuses { get; set; }
    }
}