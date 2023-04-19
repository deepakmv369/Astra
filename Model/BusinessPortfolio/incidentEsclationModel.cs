using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("incidentEscalationModel", Schema = "Portfolio")]
    public class incidentEsclationModel
    {
        [Key]
        public long incidentEsclationModelId { get; set; }
        [MaxLength(50)]
        public string? esclationModelName { get; set; }
        public int? escalationLevel { get; set; }
        public long? incidentEsclationGroupId { get; set; }
        public incidentEscalationModelGroup? incidentEsclationGroup { get; set; }
        public virtual serviceLevel? esclationOfServiceLevel { get; set; }
        public ICollection<asnIncidentEscalationRoleGroup>? incidentEsclationLevelRoleAsn { get; set; }
    }
}