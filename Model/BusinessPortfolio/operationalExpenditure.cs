using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("operationalExpenditures", Schema = "Portfolio")]
    public class operationalExpenditure
    {
        [Key]
        public long operationalExpenditureId { get; set; }
        public decimal? opExAmount { get; set; }
        [MaxLength(3)]
        public string? opExCurrency { get; set; }
        public int? operationalExpenditureTypeId { get; set; }
        public refOpExType? operationalExpenditureType { get; set; }
        public int? opExFrequencyID { get; set; }
        public mdFrequency? opExFrequency { get; set; }
        public long? opExDriverId { get; set; }
        public orgDriver? opExDriver { get; set; }
        public long? opExAssetId { get; set; }
        public assetPortfolio? opExAsset { get; set; }
        public ICollection<opExCostComponent>? operationalExpenditureComponents { get; set; }



    }
}