using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdActorTypes", Schema = "PortfolioMaster")]
    public class mdActorType
    {
        [Key]
        public int mdActorTypeId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? actorType { get; set; }
        public int? parentActorTypeId { get; set; }
        public mdActorType? parentActorType { get; set; }
        public ICollection<mdActorType>? childActorTypes { get; set; }
        public ICollection<orgActor>? mdorgActorsTypes { get; set; }
    }
}