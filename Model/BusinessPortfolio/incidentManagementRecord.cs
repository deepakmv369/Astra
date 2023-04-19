using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("incidentManagementRecords", Schema = "Portfolio")]
    public class incidentManagementRecord
    {
        [Key]
        public long incidentManagementRecordId { get; set; }
        public string? incidentRecordDescription { get; set; }
        public DateTime? incidentDateTime { get; set; }
        public int? incidentImpactId { get; set; }
        public mdImpact? incidentImpact { get; set; }
        public int? incidentPriorityId { get; set; }
        public mdGeneralScale? incidentPriority { get; set; }
        public long? incidentManagementRecordServiceLevelId { get; set; }
        public serviceLevel? incidementManagementRecordServiceLevel { get; set; }
        public long incidentManagementRecordStatusId { get; set; }
        public incidentManagementStatus? incidentManagementRecordStatus { get; set; }
        public long? incidentSubjectId { get; set; }
        public assetPortfolio? incidentSubject { get; set; }
        public long? parentIncidentId { get; set; }
        public incidentManagementRecord? parentIncident { get; set; }
        public ICollection<incidentManagementRecord>? childIncidentRecords { get; set; }
        public ICollection<incidentManagementAttachment>? managementRecordAttachments { get; set; }
        




    }
}