using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("assetsPortfolio", Schema = "Portfolio")]
    public class assetPortfolio
    {
        [Key]
        public long assetPortfolioId { get; set; }
        public Guid? uniqueAssetId { get; set; }
        public decimal? applicableDepreciation { get; set; }
        public int? assetCategoryId { get; set; }
        public mdAssetCategory? assetCategory { get; set; }
        [Required]
        [MaxLength(100)]
        public string? assetName { get; set; }
        public int? assetPortfolioCategoryId { get; set; }
        public mdPortfolioCategory? assetPortfolioCategory { get; set; }
        public int? assetTypeId { get; set; }
        public mdAssetType? assetType { get; set; }
        public long? assetCapacityDesignId { get; set; }
        public capacityDesign? assetCapacityDesign { get; set; }
        public int? assetComplexityId { get; set; }
        public mdComplexity? assetComplexity { get; set; }
        public int? cumulativeVitalityIndicatorId { get; set; }
        public mdGeneralScale? cumulativeVitalityIndicator { get; set; }
        public int? cumulativeDependencyImpactId { get; set; }
        public mdImpact? cumulativeDependencyImpact { get; set; }
        public decimal? lossPerDay { get; set; }
        public int? utilizationMonitorFrequencyId { get; set; }
        public mdFrequency? utilizationMonitorFrequency { get; set; }
        public string? assetDescription { get; set; }
        public DateTime? inwardDate { get; set; }
        public string? keyWords { get; set; }
        public long? assetManagerId { get; set; }
        public orgStructure? assetManager { get; set; }
        public decimal? operatingCostPerDay { get; set; }
        public long? assetOwnerId { get; set; }
        public orgStructure? assetOwner { get; set; }
        public long? parentAssetId { get; set; }
        public assetPortfolio? parentAsset { get; set; }
        public ICollection<assetPortfolio>? childAssets { get; set; }
        public int? assetStatusId { get; set; }
        public mdPhase? assetStatus { get; set; }
        public int? assetVolumeId { get; set; }
        public mdGeneralScale? assetVolume { get; set; }
        public ICollection<assetCapacityUtilizationRecord>? capacityUtilizationRecords { get; set; }
        public ICollection<asnJobAssetAuth>? asnJobAssetAuths { get; set; }
        public ICollection<procurementDetail>? procurementDetailAssets { get; set; }
        public ICollection<assetComplexRelationAnalysis>? assetComplexRelationBuildingBlocks { get; set; }
        public ICollection<assetComplexRelationAnalysis>? assetComplexRelationSourceAssets { get; set; }
        public ICollection<astraHistory>? assetsHistory { get; set; }
        public ICollection<incidentManagementRecord>? assetIncidentsManagementRecord { get; set; }
        public ICollection<serviceLevel>? assetServiceLevels { get; set; }
        public ICollection<operationalExpenditure>? assetOpExs { get; set; }
        









    }
}