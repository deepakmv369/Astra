using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("capacitySpendings", Schema = "Portfolio")]
    public class capacitySpending
    {
        [Key]
        public long capacitySpendingId { get; set; }
        public long? assetCapacitySpendingId { get; set; }
        public capacityDesign? assetCapacitySpending { get; set; }
        public decimal? CapacitySpending { get; set; }
        public int? capacitySpendingMeasurementId { get; set; }
        public mdCapacityMesaurementUnit? capacitySpendingMeasurement { get; set; }

    }
}