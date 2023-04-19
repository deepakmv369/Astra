using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("incidentEscalationModelGroup", Schema = "Portfolio")]
    public class incidentEscalationModelGroup
    {
        [Key]
        public long incidentEscalationModelGroupId { get; set; }
        public bool isActive { get; set; } = false;
        [MaxLength(100)]
        public string? escalationModelGroupName { get; set; }
        public virtual serviceLevel? esclationGroupOfServiceLevel { get; set; }
        public ICollection<incidentEsclationModel>? incidentEsclationModelGroups { get; set; }


        

    }
}