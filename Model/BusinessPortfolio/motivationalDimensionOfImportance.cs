using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("motivationalDimensionsOfImportance", Schema = "Portfolio")]
    public class motivationalDimensionOfImportance
    {
        [Key]
        public long motivationalDimensionOfImportanceId { get; set; }
        [Required]
        public long? dimOrgDriverId { get; set; }
        public orgDriver? dimOrgDriver { get; set; }
        [Required]
        public int? dimensionOfImportanceId { get; set; }
        public mdMotivationalDimension? dimensionofImportance { get; set; }
        public int? motivationImportanceId { get; set; }
        public mdGeneralScale? motivationImportance { get; set; }


    }

    
}