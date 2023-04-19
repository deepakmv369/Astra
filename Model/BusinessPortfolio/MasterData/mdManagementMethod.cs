using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdManagementMethods", Schema = "PortfolioMaster")]
    public class mdManagementMethod
    {
        [Key]
        public int mdManagementMethodId { get; set; }
        [Required]
        public string? methodName { get; set; }
        public string? description { get; set; }
        public int? parentMethodId { get; set; }
        public mdManagementMethod? parentMethod { get; set; }
        public ICollection<mdManagementMethod>? childMethods { get; set; }
        public ICollection<mdPhase>? phases { get; set; }



    }
}