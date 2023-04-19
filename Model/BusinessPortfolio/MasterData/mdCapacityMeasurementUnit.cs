using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdCapacityMeasurementUnits", Schema = "PortfolioMaster")]
    public class mdCapacityMesaurementUnit
    {
        [Key]
        public int mdCapacityMeasurementUnitId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? categoryMesaurementUnitName { get; set; }
        public string? remarks { get; set; }
        public int? outOf { get; set; }
        public int? timeUnitId { get; set; }
        public refTimeUnit? timeUnit { get; set; }

        public capacitySpending? capacitySpendingUnit { get; set; }
        public ICollection<capacityDesign>? capacityDesignUnits { get; set; }

    }
}