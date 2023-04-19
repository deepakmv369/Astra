using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;

namespace Astra_MK1.Model.BusinessPortfolio.MasterData
{
    [Table("mdCapacityUnitMeasurementCategories", Schema = "PortfolioMaster")]
    public class mdCapacityUnitMeasurementCategory
    {
        [Key]
        public int mdCapacityUnitMeasurementCategoryId { get; set; }
        public string? categoryName { get; set; }
               
    }
}