using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("assetCapacityUtilizationRecords", Schema = "Portfolio")]
    public class assetCapacityUtilizationRecord
    {
        [Key]
        public long assetCapacityUtilizationRecordId { get; set; }
        [Required]
        public long assetRecordId { get; set; }
        public assetPortfolio? assetRecord { get; set; }
        public DateTime? utilizationAsOn { get; set; }
        public decimal? utilizationEffeciency { get; set; }
        public decimal? utilizationPct { get; set; }
    }
}