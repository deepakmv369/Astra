using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("asnIncidentEscalationRoleGroups", Schema = "PortfolioASNS")]
    public class asnIncidentEscalationRoleGroup
    {
        [Key]
        public long asnIncidentEscalationRoleGroupId { get; set; }
        public bool? isActive { get; set; } = false;
        public long asnIncidentEsclationRoleId { get; set; }
        public orgRole? asnIncidentEsclationRole { get; set; }
        public long? asnIncidentEsclationGroupId { get; set; }
        public orgGroup? asnIncidentEsclationGroup { get; set; }
        public long? asnIncidentEsclationlLevelId { get; set; }
        public incidentEsclationModel? asnIncidentEsclationlLevel { get; set; }
    }
}