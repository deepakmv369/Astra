using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio.ReferenceData
{
    [Table("refTimeUnits", Schema = "PortfolioRef")]
    public class refTimeUnit
    {
    [Key]
    public int refTimeUnitId { get; set; }
    public string? timeUnitName { get; set; }
    public decimal? timeUnitValue { get; set; } 
    public ICollection<mdCapacityMesaurementUnit>? capacityMeasurementUnits { get; set; }
    public ICollection<alertService>? alertServicesTimeUnit { get; set; }
    public ICollection<serviceLevel>? timeUnitMaxResponse { get; set; }
    public ICollection<serviceLevel>? timeUnitMaxResolution { get; set; }
    }
    
}