using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("opExCostComponents", Schema = "Portfolio")]
    public class opExCostComponent
    {
        public decimal componentCost { get; set; }
        public long? costComponentOfOpExId { get; set; }
        public operationalExpenditure? costComponentOfOpEx { get; set; }
        public long? costComponentRefId { get; set; }
        public refCostComponent? costComponentRef { get; set; }
    }
}