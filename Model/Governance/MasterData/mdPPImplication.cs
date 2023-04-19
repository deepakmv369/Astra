using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio;

namespace Astra_MK1.Model.Governance.MasterData
{
    [Table("mdPPImplications", Schema = "GovernanceMaster")]
    public class mdPPImplication
    {
        [Key]
        public int mdPPImplicationId { get; set; }
        [Required]
        public string? implicationName { get; set; }
        public string? implicationDescription { get; set; }
        public ICollection<orgDriver>? orgDriverRefs { get; set; }
    }
}