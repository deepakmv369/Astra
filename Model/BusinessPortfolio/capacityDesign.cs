using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("capacityDesigns", Schema = "Portfolio")]
    public class capacityDesign
    {
        [Key]
        public long capacityDesignId { get; set; }
        public int? capacityMeasurementUnitId { get; set; }
        public mdCapacityMesaurementUnit? capacityMeasurementUnit { get; set; }
        public decimal? designedCapacity { get; set; }
        public decimal? effectiveCapacity { get; set; }
        public string? remarks { get; set; }
        public virtual assetPortfolio? assetPortfolioCapacity { get; set; }
        // public long? assetPortfolioCapacityDesignId { get; set; }
        public ICollection<capacitySpending>? capacityDesignSpendings { get; set; }

        
    }

}