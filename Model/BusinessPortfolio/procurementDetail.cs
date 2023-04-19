using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;
using Astra_MK1.Model.Governance;

namespace Astra_MK1.Model.BusinessPortfolio
{
    [Table("procurementDetails", Schema = "Portfolio")]
    public class procurementDetail
    {
        [Key]
        public long procurementDetailId { get; set; }
        public long? procurementAlertId { get; set; }
        public int procurementTypeRefId { get; set; }
        public refProcurementType? procurementTypeRef { get; set; }
        public alertService? procurementAlert { get; set; }
        public int? procurementPhaseId { get; set; }
        public mdPhase? procurementPhase { get; set; }
        public string? procurementRealizationRef { get; set; }
        public string? procurementSourceRef { get; set; }
        public long? procurementSubjectDriverId { get; set; }
        public orgDriver? procurementSubjectDriver { get; set; }
        public long? procurementSubjectMilestoneId { get; set; }
        public orgMilestone? procurementSubjectMilestone { get; set; }
        public long? procurementSubjectAssetId { get; set; }
        public assetPortfolio? procurementSubjectAsset { get; set; }
        public ICollection<capExDetail>? capExProcurements { get; set; }
        public ICollection<cotsProcurementDetail>? refCOTS { get; set; }
        public ICollection<procurementDoc>? procurementDocuments { get; set; }
        public ICollection<governedEntity>? procurementAsGovernedEntity { get; set; }
    }
}