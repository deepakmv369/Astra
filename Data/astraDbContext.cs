using Astra_MK1.Model.BusinessPortfolio;
using Astra_MK1.Model.BusinessPortfolio.MasterData;
using Astra_MK1.Model.BusinessPortfolio.ReferenceData;
using Astra_MK1.Model.DeliveryVehicles;
using Astra_MK1.Model.DeliveryVehicles.MasterData;
using Astra_MK1.Model.Governance;
using Astra_MK1.Model.Governance.MasterData;
using Astra_MK1.Model.System;
using Astra_MK1.Model.System.MasterData;
using Microsoft.EntityFrameworkCore;


namespace Astra_MK1.Data
{
    public class astraDbContext : DbContext
    {
        public astraDbContext(DbContextOptions<astraDbContext> opt) : base(opt)
        {
            
        }

        //Portfolio/MasterData
        public DbSet<mdAssetType>? mdAssetTypes { get; set; }
        public DbSet<mdActorType>? mdActorTypes { get; set; }
        public DbSet<mdAssetCategory>? mdAssetCategories { get; set; }
        public DbSet<mdAuthAccessLevel>? mdAuthAccessLevels { get; set; }
        public DbSet<mdAuthorityLevel>? mdAuthorityLevels { get; set; }
        public DbSet<mdCapacityMesaurementUnit>? mdCapacityMeasurementUnits { get; set; }
        public DbSet<mdCapacityUnitMeasurementCategory>? mdCapacityUnitMeasurementCategories { get; set; }
        public DbSet<mdCompetencyLevel>? mdCompetencyLevels { get; set; }
        public DbSet<mdComplexity>? mdComplexities { get; set; }
        public DbSet<mdCumulativeStakeCap>? mdCumulativeStakeCaps { get; set; }
        public DbSet<mdDriverType>? mdDriverTypes { get; set; }
        public DbSet<mdFrequency>? mdFrequencies { get; set; }
        public DbSet<mdGeneralScale>? mdGeneralScales { get; set; }
        public DbSet<mdGoalType>? mdGoalTypes { get; set; }
        public DbSet<mdImpact>? mdImpacts { get; set; }
        public DbSet<mdManagementMethod>? mdManagementMethods { get; set; }
        public DbSet<mdMotivationalDimension>? mdMotivationalDimensions { get; set; }
        public DbSet<mdPhase>? mdPhases { get; set; }
        public DbSet<mdPortfolioCategory>? mdPortfolios { get; set; }
        public DbSet<mdPredicate>? mdPredicates { get; set; }
        public DbSet<mdRoleType>? mdRoleTypes { get; set; }
        public DbSet<mdSecurityQuestion>? mdSecurityQuestions { get; set; }
        public DbSet<mdSkillType>? mdSkillTypes { get; set; }
        public DbSet<mdStake>? mdStakes { get; set; }

        //Portfolio/ReferenceData
        public DbSet<refCLType>? refCLTypes { get; set; }
        public DbSet<refCostComponent>? refCostComponents { get; set; }
        public DbSet<refIncidentStatus>? refIncidentStatuses { get; set; }
        public DbSet<refJob>? refJobs { get; set; }
        public DbSet<refOpExType>? refOpExTypes { get; set; }
        public DbSet<refOrgStatus>? refOrgStatuses { get; set; }
        public DbSet<refOrgType>? refOrgTypes { get; set; }
        public DbSet<refPhoneType>? refPhoneTypes { get; set; }
        public DbSet<refProcurementDocumentType>? refProcurementDocumentTypes { get; set; }
        public DbSet<refProcurementType>? refProcurementTypes { get; set; }
        public DbSet<refRank>? refRanks { get; set; }
        public DbSet<refRole>? refRoles { get; set; }
        public DbSet<refRoleContext>? refRoleContexts { get; set; }
        public DbSet<refSkill>? refSkills { get; set; }
        public DbSet<refTimeUnit>? refTimeUnits { get; set; }

        //Portfolio
        public DbSet<asnActorRole>? asnActorRoles { get; set; }
        public DbSet<alertService>? alertServices { get; set; }
        public DbSet<asnActorSkill>? asnActorSkills { get; set; }
        public DbSet<asnGroupJob>? asnGroupJobs { get; set; }
        public DbSet<asnGroupRole>? asnGroupRoles { get; set; }
        public DbSet<asnGroupSkill>? asnGroupSkills { get; set; }
        public DbSet<asnIncidentEscalationRoleGroup>? asnIncidentEscalationRolesGroups { get; set; }
        public DbSet<asnJobAssetAuth>? asnJobAssetAuths { get; set; }
        public DbSet<asnJobDeliverable>? asnJobDeliverables { get; set; }
        public DbSet<asnMotivational>? asnMotivationals { get; set; }
        public DbSet<asnMotivationalRole>? asnMotivationalRoles { get; set; }
        public DbSet<asnMotivationalSkill>? asnMotivationalSkills { get; set; }
        public DbSet<asnRoleJob>? asnRoleJobs { get; set; }
        public DbSet<asnRoleSkill>? asnRoleSkills { get; set; }
        public DbSet<assetCapacityUtilizationRecord>? assetCapacityUtilizationRecords { get; set; }
        public DbSet<assetComplexRelationAnalysis>? assetComplexRelationsAnalysis { get; set; }
        public DbSet<assetPortfolio>? assetsPortfolio { get; set; }
        public DbSet<astraHistory>? astraHistories { get; set; }
        public DbSet<capacityDesign>? capacityDesigns { get; set; }
        public DbSet<capacitySpending>? capacitySpendings { get; set; }
        public DbSet<capExCostComponent>?  capExCostComponents { get; set; }
        public DbSet<capExDetail>? capExDetails { get; set; }
        public DbSet<cotsProcurementDetail>? cotsProcurementDetails { get; set; }
        public DbSet<incidentEscalationModelGroup>? incidentEscalationModelGroups { get; set; }
        public DbSet<incidentEsclationModel>? incidentEsclationModels { get; set; }
        public DbSet<incidentManagementStatus>? incidentManagementStatuses { get; set; }
        public DbSet<locPhone>? locPhones { get; set; }
        public DbSet<motivationalDimensionOfImportance>? motivationalDimensionOfImportances { get; set; }
        public DbSet<operationalExpenditure>? operationalExpenditures { get; set; }
        public DbSet<orgActor>? orgActors { get; set; }
        public DbSet<orgDeliverable>? orgDeliverables { get; set; }
        public DbSet<orgDriver>? orgDrivers { get; set; }
        public DbSet<orgGoal>? orgGoals { get; set; }
        public DbSet<orgGroup>? orgGroups { get; set; }
        public DbSet<orgLocation>? orgLocations { get; set; }
        public DbSet<orgMilestone>? orgMilestones { get; set; }
        public DbSet<orgRole>? orgRoles { get; set; }
        public DbSet<orgStructure>? orgStructures { get; set; }
        public DbSet<procurementDetail>? procurementDetails { get; set; }
        public DbSet<procurementDoc>? procurementDocs { get; set; }
        public DbSet<serviceLevel>? serviceLevels { get; set; }
        public DbSet<skillParam>? skillParams { get; set; }
        public DbSet<userCredential>? userCredentials { get; set; }

        //DeliveryVehicles/MasterData
        public DbSet<mdPaymentInstrument>? mdPaymentInstruments { get; set; }

        //DeliveryVehicles
        public DbSet<asnProjectCostComponentBudget>? asnProjectCostComponentBudgets { get; set; }
        public DbSet<asnProjectOriginMaster>? asnProjectOriginMasters { get; set; }
        public DbSet<asnProjectOutput>? asnProjectOutputs { get; set; }
        public DbSet<asnProjectStakeholder>? asnProjectStakeholders { get; set; }
        public DbSet<paymentRecord>? paymentRecords { get; set; }
        public DbSet<paymentSchedule>? paymentSchedules { get; set; }
        public DbSet<projectBudget>? projectBudgets { get; set; }
        public DbSet<projectCostCenter>? projectsCostCenter { get; set; }
        public DbSet<projectCostComponent>? projectCostComponents { get; set; }
        public DbSet<projectMaster>? projectMasters { get; set; }
        public DbSet<projectOrigin>? projectOrigins { get; set; }

        //Governance
        public DbSet<mdGovernanceComplianceLevel>? mdGovernanceComplianceLevels { get; set; }  
        public DbSet<mdPolicyPrinciple>? mdPolicyPrinciples { get; set; }
        public DbSet<mdPPImplication>? mdPPImplications { get; set; }
        public DbSet<mdStandardAttachment>? mdStandardAttachments { get; set; }
        public DbSet<mdStandardGuideline>? mdStandardsGuidelines { get; set; }
        public DbSet<asnDispensationApproval>? asnDispensationApprovals { get; set; }
        public DbSet<asnDispensationRequestor>? asnDispensationRequestors { get; set; }
        public DbSet<asnGovernedEntityStandard>? asnGovernedEntityStandards { get; set; }
        public DbSet<asnGovernedGoverning>? asnGovernedGovernings { get; set; }
        public DbSet<asnGoverningEntityLog>? asnGoverningEntityLogs { get; set; }
        public DbSet<dispensationRecord>? dispensationRecords { get; set; }
        public DbSet<governanceAttachment>? governanceAttachments { get; set; }
        public DbSet<governanceLog>? governanceLogs { get; set; }
        public DbSet<governanceOutput>? governanceOutputs { get; set; }
        public DbSet<governingEntity>? governingEntities { get; set; }
        public DbSet<governedEntity>? governedEntities { get; set; }

        //System/MasterData
        public DbSet<mdDataSource>? mdDataSources { get; set; }
        public DbSet<mdDataSourceAccessType>? mdDataSourceAccessTypes { get; set; }
        public DbSet<mdDataSourcePriority>? mdDataSourcePriorities { get; set; }
        public DbSet<mdInformationSchema>? mdInformationSchemas { get; set; }
        //System
        public DbSet<asnDataSourceAccessType>? asnDataSourceAccessTypes { get; set; }
        public DbSet<asnEnterpriseElementDataSource>? asnEnterpriseElementDataSources { get; set; }
        public DbSet<asnInformationObjectEnterpriseElement>? asnInformationObjectEnterpriseElements { get; set; }
        public DbSet<astraEnterpriseElement>? astraEnterpriseElements { get; set; }
        public DbSet<astraInformationObject>? astraInformationObjects { get; set; }
        public DbSet<informationObjectField>? informationObjectFields { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<mdAssetType>().Property(d => d.depreciation).HasPrecision(6, 2);
            modelBuilder.Entity<refTimeUnit>().Property(t => t.timeUnitValue).HasPrecision(10, 2);
            modelBuilder.Entity<mdCumulativeStakeCap>().Property(p => p.minCap).HasPrecision(10, 2);
            modelBuilder.Entity<mdCumulativeStakeCap>().Property(p => p.maxCap).HasPrecision(10, 2);

            modelBuilder.Entity<mdAssetType>()
            .HasOne<mdAssetType>(s => s.parentAsset)
            .WithMany(a => a.childAssetTypes)
            .HasForeignKey(p => p.parentAssetID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<mdAuthAccessLevel>()
            .HasOne<mdAuthorityLevel>(a => a._authorityLevel)
            .WithMany(l => l.authorityAccessLevels)
            .HasForeignKey(t => t.authorityLevelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<mdAuthAccessLevel>()
            .HasOne<mdCumulativeStakeCap> (m => m.MdCumulativeStakeCap)
            .WithOne(c => c.MdAuthAccessLevel)
            .HasForeignKey<mdAuthAccessLevel>(a => a.stakeThreshold)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgDriver>()
            .HasOne<orgDriver>(o => o.parentOrgDriver)
            .WithMany(d => d.childOrgDrivers)
            .HasForeignKey(od => od.parentOrgDriverId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgDriver>()
            .HasOne<mdDriverType>(m => m.driverType)
            .WithMany(o => o.OrgDriverRefs)
            .HasForeignKey(s => s.driverTypeID)
            .OnDelete(DeleteBehavior.Restrict); 

            modelBuilder.Entity<orgDriver>()
            .HasOne<mdPPImplication>(p => p.ppImplicationRef)
            .WithMany(pp => pp.orgDriverRefs)
            .HasForeignKey(pf => pf.ppImplicationId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<mdActorType>()
            .HasOne<mdActorType> (a => a.parentActorType)
            .WithMany(b => b.childActorTypes)
            .HasForeignKey(c => c.parentActorTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<mdDriverType>()
            .HasOne<mdDriverType>(dt => dt.parentDriverType)
            .WithMany(d => d.childDriverTypes)
            .HasForeignKey(ds => ds.parentDriverTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<mdCapacityMesaurementUnit>()
            .HasOne<refTimeUnit> (t => t.timeUnit)
            .WithMany(ts => ts.capacityMeasurementUnits)
            .HasForeignKey(m => m.timeUnitId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<mdCapacityMesaurementUnit>()
            .HasOne<refTimeUnit> (t => t.timeUnit)
            .WithMany(ts => ts.capacityMeasurementUnits)
            .HasForeignKey(m => m.outOf)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<mdManagementMethod>()
            .HasOne<mdManagementMethod> (m => m.parentMethod)
            .WithMany(p => p.childMethods)
            .HasForeignKey(f => f.parentMethodId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<mdPhase>()
            .HasOne<mdManagementMethod> (p => p.managementMethod)
            .WithMany(p => p.phases)
            .HasForeignKey(m => m.ManagementmethodId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<refJob>()
            .HasOne<refJob> (r => r.parentJob)
            .WithMany(j => j.childJobs)
            .HasForeignKey(b => b.parentJobId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<refRole>()
            .HasOne<mdRoleType> (r => r.roleType)
            .WithMany(d => d.roles)
            .HasForeignKey(p => p.roleTypeId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<refRole>()
            .HasOne<refRoleContext> (c => c.roleContext)
            .WithMany(x => x.roles)
            .HasForeignKey(r => r.roleContextId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<refSkill>()
            .HasOne<refSkill> (f => f.parentSkill)
            .WithMany(l => l.childSkills)
            .HasForeignKey(s => s.parentSkillId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgActor>()
            .HasOne<mdActorType> (a => a.actorType)
            .WithMany(t => t.mdorgActorsTypes)
            .HasForeignKey(o => o.actorTypeId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<userCredential>()
            .HasOne<mdSecurityQuestion> (s => s.securityQuestion)
            .WithMany(q => q._userCredentials)
            .HasForeignKey(u => u.securityQuestionId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgStructure>()
            .HasOne<orgStructure> (o => o.parentOrg)
            .WithMany(p => p.childOrgs)
            .HasForeignKey(g => g.parentOrgId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgStructure>()
            .HasOne<mdPhase> (w => w.workingStatus)
            .WithMany(t => t.orgStructuresPhase)
            .HasForeignKey(p => p.workingStatusId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<orgStructure>()
            .HasOne<refOrgType> (o => o.orgType)
            .WithMany(t => t.orgStructuresType)
            .HasForeignKey(s => s.orgTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgStructure>()
            .HasOne<refOrgStatus> (t => t.commercialStatus)
            .WithMany(c => c.orgStructuresStatus)
            .HasForeignKey(f => f.commercialStatusId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgStructure>()
            .HasOne<orgLocation> (l => l.location)
            .WithMany (o => o.orgStructures)
            .HasForeignKey(n => n.locationId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgRole>()
            .HasOne<orgRole> (r => r.parentRole)
            .WithMany (m => m.childRoles)
            .HasForeignKey (p => p.parentRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgRole>()
            .HasOne<mdGeneralScale> (g=> g.vitalityIndicator)
            .WithMany (v => v.orgRolesGeneralScale)
            .HasForeignKey(s => s.vitalityIndicatorId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgRole>()
            .HasOne<refRank> (r => r.roleRank)
            .WithMany (k => k.orgRolesRank)
            .HasForeignKey (n => n.roleRankId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnActorRole>().Property(p => p.fullfillmentPct).HasPrecision(6, 2);
            modelBuilder.Entity<asnActorRole>().HasIndex(ra => new {ra.asnOrgActorId, ra.asnOrgRoleId});

            modelBuilder.Entity<asnActorRole>()
            .HasOne<orgRole>(a => a.asnOrgRole)
            .WithMany(b => b.roleOfActors)
            .HasForeignKey(c => c.asnOrgRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnActorRole>()
            .HasOne<orgActor> (a => a.asnOrgActor)
            .WithMany(b => b.actorOfRoles)
            .HasForeignKey(c => c.asnOrgActorId)
            .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<alertService>()
            .HasOne<mdFrequency> (f => f.alertFrequency)
            .WithMany(m => m.alertServicesFrequency)
            .HasForeignKey(s => s.alertFrequencyId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<alertService>()
            .HasOne<refTimeUnit> (t => t.alertInterval)
            .WithMany(i => i.alertServicesTimeUnit)
            .HasForeignKey(t => t.alertIntervalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<capacityDesign>().Property(d => d.designedCapacity).HasPrecision(15, 2);
            modelBuilder.Entity<capacityDesign>().Property(d => d.effectiveCapacity).HasPrecision(15, 2);

            modelBuilder.Entity<capacityDesign>()
            .HasOne<mdCapacityMesaurementUnit> (m => m.capacityMeasurementUnit)
            .WithMany(c => c.capacityDesignUnits)
            .HasForeignKey(u => u.capacityMeasurementUnitId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>().Property(d => d.applicableDepreciation).HasPrecision(8, 2);
            modelBuilder.Entity<assetPortfolio>().Property(d => d.lossPerDay).HasPrecision(15, 2);
            modelBuilder.Entity<assetPortfolio>().Property(d => d.operatingCostPerDay).HasPrecision(15, 2);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdAssetCategory> (m => m.assetCategory)
            .WithMany (a => a.assetPortfolioCategory)
            .HasForeignKey (c => c.assetCategoryId)
            .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdPortfolioCategory>(m => m.assetPortfolioCategory)
            .WithMany(p => p.assetPortfolioCategories)
            .HasForeignKey(c => c.assetPortfolioCategoryId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdAssetType> (m => m.assetType)
            .WithMany(a => a.assetPortfolioAssetTypes)
            .HasForeignKey(t => t.assetTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<capacityDesign>(a => a.assetCapacityDesign)
            .WithOne(b => b.assetPortfolioCapacity)
            .HasForeignKey<assetPortfolio>(c => c.assetCapacityDesignId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdComplexity> (m => m.assetComplexity)
            .WithMany(c => c.assetComplexities)
            .HasForeignKey(f => f.assetComplexityId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdGeneralScale> (m => m.cumulativeVitalityIndicator)
            .WithMany (g => g.assetPortfolioGeneralSaclesCVI)
            .HasForeignKey(s => s.cumulativeVitalityIndicatorId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdImpact> (m => m.cumulativeDependencyImpact)
            .WithMany (i => i.assetPortfolioDependencyImpacts)
            .HasForeignKey(f => f.cumulativeDependencyImpactId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdFrequency>(m => m.utilizationMonitorFrequency)
            .WithMany(f => f.assetPortfolioFrequeny)
            .HasForeignKey(q => q.utilizationMonitorFrequencyId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<orgStructure>(o => o.assetManager)
            .WithMany(s => s.assetPortfolioOrgStructureManager)
            .HasForeignKey(f => f.assetManagerId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<orgStructure>(o => o.assetOwner)
            .WithMany(s => s.assetPortfolioOrgStructureOwner)
            .HasForeignKey(f => f.assetOwnerId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<assetPortfolio>(a => a.parentAsset)
            .WithMany (b => b.childAssets)
            .HasForeignKey(c => c.parentAssetId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdPhase> (m => m.assetStatus)
            .WithMany(p => p.assetPortfolioPhase)
            .HasForeignKey(f => f.assetStatusId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetPortfolio>()
            .HasOne<mdGeneralScale> (m => m.assetVolume)
            .WithMany(g => g.assetPortfolioGeneralSaclesVol)
            .HasForeignKey(s => s.assetVolumeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetCapacityUtilizationRecord>().Property(t => t.utilizationEffeciency).HasPrecision(6, 2);
            modelBuilder.Entity<assetCapacityUtilizationRecord>().Property(t => t.utilizationPct).HasPrecision(6, 2);

            modelBuilder.Entity<assetCapacityUtilizationRecord>()
            .HasOne<assetPortfolio>(a => a.assetRecord)
            .WithMany(b => b.capacityUtilizationRecords)
            .HasForeignKey(c => c.assetRecordId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<skillParam>().Property(t => t.expValue).HasPrecision(5, 2);

            modelBuilder.Entity<skillParam>()
            .HasOne<mdCompetencyLevel> (m => m.competencyLevel)
            .WithMany(c => c.skillParamsCompetencies)
            .HasForeignKey(l => l.competencyLevelId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<skillParam>()
            .HasOne<mdPredicate> (a => a.expPredicate)
            .WithMany(b => b.skillParamsPredicates)
            .HasForeignKey(c => c.expPredicateId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<skillParam>()
            .HasOne<refSkill>(a => a.Skill)
            .WithMany(b => b.skillParamSkills)
            .HasForeignKey(c => c.skillId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<skillParam>()
            .HasOne<mdSkillType>(m => m.skillType)
            .WithMany(s => s.skillParamSkillTypes)
            .HasForeignKey(t => t.skillTypeId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnActorSkill>().HasKey(k => new {k.asnOrgActorId, k.asnSkillParamId});
            modelBuilder.Entity<asnActorSkill>()
            .HasOne<orgActor>(a => a.asnOrgActor)
            .WithMany(b => b.orgActorSkillsAsn)
            .HasForeignKey(c => c.asnOrgActorId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnActorSkill>()
            .HasOne<skillParam>(a => a.asnSkillParam)
            .WithMany(b => b.skillParamsAsn)
            .HasForeignKey(c => c.asnSkillParamId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<refDeliverable>()
            .HasOne<mdAssetType> (m => m.deliverableType)
            .WithMany(a => a.refDeliverableTypes)
            .HasForeignKey(t => t.deliverableTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgGroup>()
            .HasOne<orgStructure> (a => a.orgStruct)
            .WithMany (b => b.orgGroupStructures)
            .HasForeignKey(c => c.orgStructId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGroupRole>().HasKey(g => new {g.asnOrgGroupId, g.asnOrgRoleId});
            modelBuilder.Entity<asnGroupRole>()
            .HasOne<orgGroup> (a => a.asnOrgGroup)
            .WithMany(b => b.orgGroupRoleAsn)
            .HasForeignKey(c => c.asnOrgGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGroupRole>()
            .HasOne<orgRole>(a => a.asnOrgRole)
            .WithMany(b => b.orgRoleGroupsAsn)
            .HasForeignKey(c => c.asnOrgRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGroupSkill>().HasKey(g => new {g.asnOrgGroupId, g.asnSkillParamId});
            modelBuilder.Entity<asnGroupSkill>()
            .HasOne<orgGroup>(a => a.asnOrgGroup)
            .WithMany(b => b.GroupSkillsAsn)
            .HasForeignKey(c => c.asnOrgGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGroupSkill>()
            .HasOne<skillParam> (a => a.asnSkillParam)
            .WithMany(b => b.groupSkillsAsn)
            .HasForeignKey(c => c.asnSkillParamId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGroupJob>().HasIndex(g => new{g.asnGroupJoborgGroupId, g.asnGroupRefJobId});
            modelBuilder.Entity<asnGroupJob>().Property(p => p.contributionPercentage).HasPrecision(6, 2);
            
            modelBuilder.Entity<asnGroupJob>()
            .HasOne<refJob>(a => a.asnGroupRefJob)
            .WithMany(b => b.asnGroupJobs)
            .HasForeignKey(c => c.asnGroupRefJobId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGroupJob>()
            .HasOne<orgGroup>(a => a.asnGroupJoborgGroup)
            .WithMany(b => b.GroupJobsAsn)
            .HasForeignKey(c => c.asnGroupJoborgGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnIncidentEscalationRoleGroup>()
            .HasOne<orgRole> (o => o.asnIncidentEsclationRole)
            .WithMany(r => r.asnIncidentEscalationRoles)
            .HasForeignKey(l => l.asnIncidentEsclationRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnIncidentEscalationRoleGroup>()
            .HasOne<orgGroup>(a => a.asnIncidentEsclationGroup)
            .WithMany(b => b.groupIncidentEsclationAsn)
            .HasForeignKey(c => c.asnIncidentEsclationGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnIncidentEscalationRoleGroup>()
            .HasOne<incidentEsclationModel> (a => a.asnIncidentEsclationlLevel)
            .WithMany(b => b.incidentEsclationLevelRoleAsn)
            .HasForeignKey(c => c.asnIncidentEsclationlLevelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnJobAssetAuth>().HasKey(j => new{j.asnAssetPortfolioId, j.asnAssetAuthRefJobId, j.asnAuthAccessLevelId});

            modelBuilder.Entity<asnJobAssetAuth>()
            .HasOne<mdAuthAccessLevel>(a => a.asnAuthAccessLevel)
            .WithMany(b => b.mdJobAssetAuths)
            .HasForeignKey(c => c.asnAuthAccessLevelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnJobAssetAuth>()
            .HasOne<refJob>(a => a.asnAssetAuthRefJob)
            .WithMany(b => b.asnJobAssetAuths)
            .HasForeignKey(c => c.asnAssetAuthRefJobId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnJobAssetAuth>()
            .HasOne<assetPortfolio>(a => a.asnAssetPortfolio)
            .WithMany(b => b.asnJobAssetAuths)
            .HasForeignKey(c => c.asnAssetPortfolioId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<locPhone>()
            .HasOne<orgLocation> (o => o.orgLocation)
            .WithMany(r => r.locPhones)
            .HasForeignKey(g => g.orgLocationId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<locPhone>()
            .HasOne<refPhoneType> (r => r.locPhoneType)
            .WithOne(p => p.locPhone)
            .HasForeignKey<locPhone>(t => t.locPhoneTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnRoleSkill>().HasKey(r => new {r.asnRoleId, r.asnSkillParamId});
            
            modelBuilder.Entity<asnRoleSkill>()
            .HasOne<refRole> (r => r.asnRole)
            .WithMany(s => s.asnRoleSkillsRole)
            .HasForeignKey(k => k.asnRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnRoleSkill>()
            .HasOne<skillParam> (s => s.asnSkillParam)
            .WithMany (k => k.asnRoleSkills)
            .HasForeignKey(p => p.asnSkillParamId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnRoleJob>().HasKey(r => new {r.asnJobId, r.asnRoleId});
            modelBuilder.Entity<asnRoleJob>().Property(c => c.contributionPercent).HasPrecision(6, 2);
            modelBuilder.Entity<asnRoleJob>()
            .HasOne<refRole> (r => r.asnRole)
            .WithMany(o => o.asnRoleJobRoles)
            .HasForeignKey(l => l.asnRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnRoleJob>()
            .HasOne<refJob> (j => j.asnJob)
            .WithMany(j => j.asnRoleJobJobs)
            .HasForeignKey(b => b.asnJobId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgGoal>()
            .HasOne<orgGoal> (o => o.parentGoal)
            .WithMany(g => g.childGoals)
            .HasForeignKey(l => l.parentGoalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgGoal>()
            .HasOne<mdGoalType> (a => a.orgGoalType)
            .WithMany(b => b.goalTypeOfGoals)
            .HasForeignKey(c => c.orgGoalTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgMilestone>().Property(m => m.contributionPercent).HasPrecision(6, 2);
            modelBuilder.Entity<orgMilestone>()
            .HasOne<orgMilestone> (o => o.parentMilestone)
            .WithMany(g => g.childMilestones)
            .HasForeignKey(m => m.parentMilestoneId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgDeliverable>()
            .HasOne<mdAssetType> (m => m.deliverableType)
            .WithMany(a => a.orgDeliverableTypes)
            .HasForeignKey(t => t.deliverableTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<orgDeliverable>()
            .HasOne<orgDeliverable> (o => o.parentDeliverable)
            .WithMany (p => p.childDeliverables)
            .HasForeignKey(t => t.parentDeliverableId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivational>().Property(m => m.fulfillmentPercent).HasPrecision(6, 2);
            // modelBuilder.Entity<asnMotivational>()
            // .HasKey(a => new {a.asnDeliverableId, a.asnGoalId, a.asnOperationId, a.asnMilestoneId, a.asnOrgDriverId, a.asnOrgStructureId, a.thisPriorityId});
            modelBuilder.Entity<asnMotivational>()
            .HasOne<orgDeliverable>(o => o.asnDeliverable)
            .WithMany(m => m.asnMotivationalDeliverables)
            .HasForeignKey(d => d.asnDeliverableId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivational>()
            .HasOne<orgGoal>(o => o.asnGoal)
            .WithMany(r => r.asnMotivationalGoals)
            .HasForeignKey(g => g.asnGoalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivational>()
            .HasOne<refJob> (a => a.asnOperation)
            .WithMany(s => s.asnMotivationalJobs)
            .HasForeignKey(n => n.asnOperationId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivational>()
            .HasOne<orgMilestone>(a => a.asnMilestone)
            .WithMany(s => s.asnMotivationalMilestones)
            .HasForeignKey(n => n.asnMilestoneId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivational>()
            .HasOne<orgDriver> (a => a.asnOrgDriver)
            .WithMany(s => s.asnMotivationalDrivers)
            .HasForeignKey(n => n.asnOrgDriverId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivational>()
            .HasOne<orgStructure> (a => a.asnOrgStructure)
            .WithMany(s => s.asnMotivationalStructures)
            .HasForeignKey(n => n.asnOrgStructureId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivational>()
            .HasOne<mdGeneralScale> (a => a.thisPriority)
            .WithMany(s => s.asnMotivationalPriorities)
            .HasForeignKey(n => n.thisPriorityId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivationalRole>().Property(a => a.stakePercent).HasPrecision(6, 2);
            
            modelBuilder.Entity<asnMotivationalRole>()
            .HasKey(a => new{a.asnAuthorityLevelId, a.refAsnMotivationalId, a.stakeholderTypeId, a.stakeholderRoleId, a.stakeholderGroupId});
            modelBuilder.Entity<asnMotivationalRole>()
            .HasOne<mdAuthorityLevel> (a => a.asnAuthorityLevel)
            .WithMany (b => b.asnMotivationalRoleAuthorityAccessLevels)
            .HasForeignKey(c => c.asnAuthorityLevelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivationalRole>()
            .HasOne<asnMotivational> (a => a.refAsnMotivational)
            .WithMany(b => b.refAsnMotivationalRoles)
            .HasForeignKey(c => c.refAsnMotivationalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivationalRole>()
            .HasOne<mdStake> (a => a.stakeholderType)
            .WithMany (b => b.asnMotivationalRoleStakeholderTypes)
            .HasForeignKey(c => c.stakeholderTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivationalRole>()
            .HasOne<refRole>(a => a.stakeholderRole)
            .WithMany (b => b.asnMotivationalRoleRoles)
            .HasForeignKey(c => c.stakeholderRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivationalRole>()
            .HasOne<orgGroup> (a => a.stakeholderGroup)
            .WithMany (b => b.asnMotivationalRoleGroups)
            .HasForeignKey(c => c.stakeholderGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            // modelBuilder.Entity<asnIncidentEsclationModelLevel>().HasKey(a => new {a.incidentModelId, a.incidentLevelId});
            // modelBuilder.Entity<asnIncidentEsclationModelLevel>()
            // .HasOne<incidentEsclationModel> (a => a.incidentModel)
            // .WithMany(b => b.incidentEsclationModels)
            // .HasForeignKey(c => c.incidentModelId)
            // .OnDelete(DeleteBehavior.SetNull);

            // modelBuilder.Entity<asnIncidentEsclationModelLevel>()
            // .HasOne<incidentEsclationLevel>(a => a.incidentLevel)
            // .WithMany(b => b.incidentEsclationLevels)
            // .HasForeignKey(c => c.incidentLevelId)
            // .OnDelete(DeleteBehavior.SetNull);


            modelBuilder.Entity<asnMotivationalSkill>().HasKey(a => new {a.asnMotivationalSkillId, a.asnSkillParamId});
            modelBuilder.Entity<asnMotivationalSkill>()
            .HasOne<asnMotivational> (a => a.refAsnMotivational)
            .WithMany(b => b.refAsnMotivationalSkills)
            .HasForeignKey(c => c.refAsnMotivationalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivationalSkill>()
            .HasOne<skillParam> (a => a.asnSkillParam)
            .WithMany(b => b.asnMotivationalSkillParams)
            .HasForeignKey(c => c.asnSkillParamId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnMotivationalRole>().Property(a => a.stakePercent).HasPrecision(6, 2);

            modelBuilder.Entity<asnJobDeliverable>().HasKey(a => new {a.asnDeliverableId, a.asnJobId});
            modelBuilder.Entity<asnJobDeliverable>().Property(a => a.fulfillmentPercent).HasPrecision(6, 2);
            
            modelBuilder.Entity<asnJobDeliverable>()
            .HasOne<orgDeliverable> (a => a.asnDeliverable)
            .WithMany(b => b.asnOrgDeliverables)
            .HasForeignKey(c => c.asnDeliverableId)
            .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<asnJobDeliverable>()
            .HasOne<refJob> (a => a.asnJob)
            .WithMany(b => b.asnJobDeliverableJobs)
            .HasForeignKey(c => c.asnJobId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<capExDetail>().Property(a => a.totalCapExpenditure).HasPrecision(15, 2);

            modelBuilder.Entity<capExDetail>()
            .HasOne<procurementDetail>(a => a.refProcurementDetail)
            .WithMany (b => b.capExProcurements)
            .HasForeignKey(c => c.refProcurementDetailId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDetail>()
            .HasOne<mdPhase>(a => a.procurementPhase)
            .WithMany(b => b.procurementDetailPhases)
            .HasForeignKey(c => c.procurementPhaseId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDetail>()
            .HasOne<orgDriver> (a => a.procurementSubjectDriver)
            .WithMany(b => b.procurementDetailDrivers)
            .HasForeignKey(c => c.procurementSubjectDriverId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDetail>()
            .HasOne<orgMilestone> (a => a.procurementSubjectMilestone)
            .WithMany(b => b.procurementDetailMilestones)
            .HasForeignKey(c => c.procurementSubjectMilestoneId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDetail>()
            .HasOne<assetPortfolio> (a => a.procurementSubjectAsset)
            .WithMany(b => b.procurementDetailAssets)
            .HasForeignKey(c => c.procurementSubjectAssetId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDetail>()
            .HasOne<alertService>(a => a.procurementAlert)
            .WithMany(b => b.procurementDetailAlerts)
            .HasForeignKey(c => c.procurementAlertId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDetail>()
            .HasOne<refProcurementType>(a => a.procurementTypeRef)
            .WithMany(b => b.procurementDetailTypeRefs)
            .HasForeignKey(c => c.procurementTypeRefId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<cotsProcurementDetail>()
            .HasOne<refCLType> (a => a.cotsProcurementCLType)
            .WithMany(b => b.procurementDetailsCOTS)
            .HasForeignKey(c => c.cotsProcurementCLTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<cotsProcurementDetail>()
            .HasOne<procurementDetail>(a => a.procurementDetailRef)
            .WithMany(b => b.refCOTS)
            .HasForeignKey(c => c.procurementdetailRefId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDoc>()
            .HasOne<procurementDetail>(a => a.refProcurementDetail)
            .WithMany(b => b.procurementDocuments)
            .HasForeignKey(c => c.refProcurementDetailId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<procurementDoc>()
            .HasOne<refProcurementDocumentType>(a => a.procurementDocumentType)
            .WithMany(b => b.procurementDocumentTypes)
            .HasForeignKey(c => c.procurementDocumentTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<capExCostComponent>().Property(a => a.capExCost).HasPrecision(15,2);
            modelBuilder.Entity<capExCostComponent>().HasKey(a => new {a.refCapExDetailId, a.costComponentId});
            modelBuilder.Entity<capExCostComponent>()
            .HasOne<capExDetail> (a => a.refCapExDetail)
            .WithMany(b => b.costComponents)
            .HasForeignKey(c => c.refCapExDetailId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<capExCostComponent>()
            .HasOne<refCostComponent> (a => a.costComponent)
            .WithMany(b => b.refCapExCostComponents)
            .HasForeignKey(c => c.costComponentId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetComplexRelationAnalysis>()
            .HasOne<mdGeneralScale> (a => a.buildingBlockVitality)
            .WithMany(b => b.assetComplexRelationVitalities)
            .HasForeignKey(c => c.buildingBlockVitalityId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetComplexRelationAnalysis>()
            .HasOne<assetPortfolio> (a => a.assetBuildingBlock)
            .WithMany(b => b.assetComplexRelationBuildingBlocks)
            .HasForeignKey(c => c.assetBuildingBlockId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<assetComplexRelationAnalysis>().Property(a => a.buildingBlockCapacityUtilization).HasPrecision(6, 2);

            modelBuilder.Entity<assetComplexRelationAnalysis>()
            .HasOne<mdImpact> ( a => a.buildingBlockNonAvailabilityImpact)
            .WithMany (b => b.buildingBlockNonAvailabilityImpacts)
            .HasForeignKey(c => c.buildingBlockNonAvailabilityImpactId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetComplexRelationAnalysis>().Property(a => a.fullfilmentPercent).HasPrecision(6, 2);

            modelBuilder.Entity<assetComplexRelationAnalysis>()
            .HasOne<assetPortfolio> (a => a.sourceAsset)
            .WithMany(b => b.assetComplexRelationSourceAssets)
            .HasForeignKey(c => c.sourceAssetId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<assetComplexRelationAnalysis>()
            .HasOne<mdGeneralScale> (a => a.fulfillmentWeightage)
            .WithMany(b => b.assetComplexRelationfulfillmentWeightages)
            .HasForeignKey(c => c.fulfillmentWeightageId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<capacitySpending>().Property(a => a.CapacitySpending).HasPrecision(6, 2);

            modelBuilder.Entity<capacitySpending>()
            .HasOne<mdCapacityMesaurementUnit>(a => a.capacitySpendingMeasurement)
            .WithOne(b => b.capacitySpendingUnit)
            .HasForeignKey<capacitySpending>(c => c.capacitySpendingMeasurementId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<capacitySpending>()
            .HasOne<capacityDesign> (a => a.assetCapacitySpending)
            .WithMany(b => b.capacityDesignSpendings)
            .HasForeignKey(c => c.assetCapacitySpendingId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<incidentEsclationModel>()
            .HasOne<incidentEscalationModelGroup>(a => a.incidentEsclationGroup)
            .WithMany(b => b.incidentEsclationModelGroups)
            .HasForeignKey(c => c.incidentEsclationGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<motivationalDimensionOfImportance>()
            .HasOne<orgDriver> (a => a.dimOrgDriver)
            .WithMany (b => b.dimensionalImportances)
            .HasForeignKey(c => c.dimOrgDriverId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<motivationalDimensionOfImportance>()
            .HasOne<mdMotivationalDimension>(a => a.dimensionofImportance)
            .WithMany (b => b.motivationalDimensions)
            .HasForeignKey(c => c.dimensionOfImportanceId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<motivationalDimensionOfImportance>()
            .HasOne<mdGeneralScale> (a => a.motivationImportance)
            .WithMany (b => b.motivationalDimensionImportances)
            .HasForeignKey(c => c.motivationImportanceId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgRole>(a => a.actionByRole)
            .WithMany(b => b.rolesHistory)
            .HasForeignKey(c => c.actionByRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgGroup> (a => a.actionByGroup)
            .WithMany (b => b.groupsHistory)
            .HasForeignKey(c => c.actionByGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgActor> (a => a.actionByActor)
            .WithMany (b => b.actorsHistory)
            .HasForeignKey(c => c.actionByActorId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgDriver> (a => a.historyDriver)
            .WithMany (b => b.driversHistory)
            .HasForeignKey(c => c.historyDriverId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgDeliverable> (a => a.historyDeliverable)
            .WithMany(b => b.deliverablesHistory)
            .HasForeignKey(c => c.historyDeliverableId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgGoal> (a => a.historyGoal)
            .WithMany(b => b.goalsHistory)
            .HasForeignKey(c => c.historyGoalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgMilestone> (a => a.historyMilestone)
            .WithMany(b => b.milestonesHistory)
            .HasForeignKey(c => c.historyMilestoneId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<orgStructure> (a => a.historyStructure)
            .WithMany(b => b.structuresHistory)
            .HasForeignKey(c => c.historyStructureId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraHistory>()
            .HasOne<assetPortfolio> (a => a.historyAsset)
            .WithMany(b => b.assetsHistory)
            .HasForeignKey(c => c.historyAssetId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<serviceLevel>().Property(a => a.maxResponseTime).HasPrecision(5, 2);
            modelBuilder.Entity<serviceLevel>().Property(b => b.maxResolutionTime).HasPrecision(5, 2);
            modelBuilder.Entity<serviceLevel>()
            .HasOne<assetPortfolio> (a => a.serviceLevelForAsset)
            .WithMany (b => b.assetServiceLevels)
            .HasForeignKey(c => c.serviceLevelForAssetId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<serviceLevel>()
            .HasOne<refTimeUnit> (a => a.maxResponseTimeUnit)
            .WithMany(b => b.timeUnitMaxResponse)
            .HasForeignKey(c => c.maxResponseTimeUnitId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<serviceLevel>()
            .HasOne<refTimeUnit> (a => a.maxResolutionTimeUnit)
            .WithMany(b => b.timeUnitMaxResolution)
            .HasForeignKey(c => c.maxResolutionTimeUnitId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<serviceLevel>()
            .HasOne<serviceLevel> (a => a.parentServiceLevel)
            .WithMany(b => b.childServiceLevels)
            .HasForeignKey(c => c.parentServiceLevelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<serviceLevel>()
            .HasOne<incidentEsclationModel> (a => a.serviceEsclationModel)
            .WithOne(b => b.esclationOfServiceLevel)
            .HasForeignKey<serviceLevel> (c => c.serviceEsclationModelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<serviceLevel>()
            .HasOne<incidentEscalationModelGroup> (a => a.serviceEsclationModelGroup)
            .WithOne(b => b.esclationGroupOfServiceLevel)
            .HasForeignKey<serviceLevel>(c => c.serviceEsclationModelGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<serviceLevel>()
            .HasOne<mdAssetType> (a => a.serviceLevelForAssetType)
            .WithMany(b => b.assetTypeServiceLevels)
            .HasForeignKey(c => c.serviceLevelForAssetTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<operationalExpenditure>().Property(a => a.opExAmount).HasPrecision(15, 2);
            modelBuilder.Entity<operationalExpenditure>()
            .HasOne<refOpExType> (a => a.operationalExpenditureType)
            .WithMany(b => b.opExTypeExpenditures)
            .HasForeignKey(c => c.operationalExpenditureTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<operationalExpenditure>()
            .HasOne<mdFrequency> (a => a.opExFrequency)
            .WithMany(b => b.frequenciesOpEx)
            .HasForeignKey(c => c.opExFrequencyID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<operationalExpenditure>()
            .HasOne<orgDriver> (a => a.opExDriver)
            .WithMany (b => b.driverOpExs)
            .HasForeignKey(c => c.opExDriverId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<operationalExpenditure>()
            .HasOne<assetPortfolio> (a => a.opExAsset)
            .WithMany(b => b.assetOpExs)
            .HasForeignKey(c => c.opExAssetId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<opExCostComponent>().Property(a => a.componentCost).HasPrecision(15,2);
            modelBuilder.Entity<opExCostComponent>().HasKey(b => new {b.costComponentOfOpExId, b.costComponentRefId});
            modelBuilder.Entity<opExCostComponent>()
            .HasOne<operationalExpenditure>(a => a.costComponentOfOpEx)
            .WithMany(b => b.operationalExpenditureComponents)
            .HasForeignKey(c => c.costComponentOfOpExId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<opExCostComponent>()
            .HasOne<refCostComponent>(a => a.costComponentRef)
            .WithMany(b => b.refOpExCostComponents)
            .HasForeignKey(c => c.costComponentRefId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementStatus>()
            .HasOne<refIncidentStatus> (a => a.incidentStatusRef)
            .WithMany(b => b.incidentStatusesManagement)
            .HasForeignKey(c => c.incidentStatusRefId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementStatus>()
            .HasOne<orgStructure> (a => a.assignedToOrgStructure)
            .WithMany(b => b.orgStructureIncidents)
            .HasForeignKey(c => c.assignedToOrgStructureId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementStatus>()
            .HasOne<orgGroup> (a => a.assiginedToOrgGroup)
            .WithMany(b => b.orgGroupIncidents)
            .HasForeignKey(c => c.assignedToOrgGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementStatus>()
            .HasOne<orgRole>(a => a.assignedToOrgRole)
            .WithMany(b => b.orgRoleIncidents)
            .HasForeignKey(c => c.assignedToOrgRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementRecord>().HasIndex(a => new {a.incidentManagementRecordId, 
            a.incidentManagementRecordStatusId, a.incidentSubjectId}).IsUnique();
            modelBuilder.Entity<incidentManagementRecord>()
            .HasOne<mdImpact> (a => a.incidentImpact)
            .WithMany(b => b.incidentsManagementRecordImpacts)
            .HasForeignKey(c => c.incidentImpactId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementRecord>()
            .HasOne<mdGeneralScale> ( a => a.incidentPriority)
            .WithMany(b => b.incidentManagementRecordsPriority)
            .HasForeignKey(c => c.incidentPriorityId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementRecord>()
            .HasOne<serviceLevel>(a => a.incidementManagementRecordServiceLevel)
            .WithMany(b => b.incidentServiceLevels)
            .HasForeignKey(c => c.incidentManagementRecordServiceLevelId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementRecord>()
            .HasOne<incidentManagementStatus>(a => a.incidentManagementRecordStatus)
            .WithMany(b => b.incidentManagementRecordStatuses)
            .HasForeignKey(c => c.incidentManagementRecordStatusId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<incidentManagementRecord>()
            .HasOne<assetPortfolio> (a => a.incidentSubject)
            .WithMany(b => b.assetIncidentsManagementRecord)
            .HasForeignKey(c => c.incidentSubjectId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<incidentManagementAttachment>()
            .HasOne<incidentManagementRecord> (a => a.attachmentOfmanagementRecord)
            .WithMany(b => b.managementRecordAttachments)
            .HasForeignKey(c => c.attachmentOfManagementRecordId)
            .OnDelete(DeleteBehavior.SetNull);

            //Delivery Vehicles

            modelBuilder.Entity<asnProjectCostComponentBudget>().HasKey(a => new {a.asnBudgetId, a.asnCostComponentId});
            modelBuilder.Entity<asnProjectCostComponentBudget>()
            .HasOne<projectBudget> (a => a.asnBudget)
            .WithMany(b => b.budgetCostComponentAsns)
            .HasForeignKey(c => c.asnBudgetId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectCostComponentBudget>()
            .HasOne<projectCostComponent>(a => a.asnCostComponent)
            .WithMany(b => b.costComponentBudgetAsns)
            .HasForeignKey(c => c.asnCostComponentId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectOriginMaster>().HasKey(a => new {a.asnProjectMasterId, a.asnProjectOriginId});
           
            modelBuilder.Entity<asnProjectOriginMaster>()
            .HasOne<projectMaster>(a => a.asnProjectMaster)
            .WithMany(b => b.projectMasterOrigins)
            .HasForeignKey(c => c.asnProjectMasterId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectOriginMaster>()
            .HasOne<projectOrigin>(a => a.asnProjectOrigin)
            .WithMany (b => b.projectOriginMasters)
            .HasForeignKey(c => c.asnProjectOriginId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectOutput>().HasIndex(a => new {a.asnProjectMasterId, a.asnProjectGoalId, 
            a.asnProjectMilestoneId, a.asnProjectDeliverableId});
            modelBuilder.Entity<asnProjectOutput>().Property(a => a.projectContributionToGoal).HasPrecision(6, 2);
            modelBuilder.Entity<asnProjectOutput>().Property(a => a.milestoneContributionToProject).HasPrecision(6, 2);
            modelBuilder.Entity<asnProjectOutput>().Property(a => a.deliveryContributionToMilestone).HasPrecision(6, 2);

            modelBuilder.Entity<asnProjectOutput>()
            .HasOne<projectMaster>(a => a.asnProjectMaster)
            .WithMany(b => b.projectOutputs)
            .HasForeignKey(c => c.asnProjectMasterId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectOutput>()
            .HasOne<orgGoal> (a => a.asnProjectGoal)
            .WithMany(b => b.goalsOfProjects)
            .HasForeignKey(c => c.asnProjectGoalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectOutput>()
            .HasOne<orgMilestone>(a => a.asnProjectMilestone)
            .WithMany(b => b.milestonesOfProjectGoals)
            .HasForeignKey(c => c.asnProjectMilestoneId)    
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectOutput>()
            .HasOne<orgDeliverable>(a => a.asnProjectDeliverable)
            .WithMany(b => b.deliverablesOfProjectMilestones)
            .HasForeignKey(c => c.asnProjectDeliverableId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectStakeholder>()
            .HasIndex(a => new {a.asnStakeProjectMasterId, a.asnStakeOrgStructureId,
                              a.asnStakeOrgGroupId, a.asnStakeOrgRoleId });
            
            modelBuilder.Entity<asnProjectStakeholder>()
            .HasOne<projectMaster>(a => a.asnStakeProjectMaster)
            .WithMany(b => b.projectStakeholders)
            .HasForeignKey(c => c.asnStakeProjectMasterId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectStakeholder>()
            .HasOne<orgStructure>(a => a.asnStakeOrgStructure)
            .WithMany(b => b.structureStakeInProjects)
            .HasForeignKey(c => c.asnStakeOrgStructureId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectStakeholder>()
            .HasOne<orgGroup>(a => a.asnStakeOrgGroup)
            .WithMany(b => b.GroupStakeInProjects)
            .HasForeignKey(c => c.asnStakeOrgGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectStakeholder>()
            .HasOne<orgRole>(a => a.asnStakeOrgRole)
            .WithMany(b => b.roleStakeInProjects)
            .HasForeignKey(c => c.asnStakeOrgRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnProjectStakeholder>()
            .HasOne<mdStake>(a => a.asnStakeType)
            .WithMany(b => b.asnProjectStakeholderStakes)
            .HasForeignKey(c => c.asnStakeTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<paymentRecord>()
            .HasOne<projectMaster>(a => a.paymentRecordProject)
            .WithMany(b => b.projectPaymentRecords)
            .HasForeignKey(c => c.paymentRecordProjectId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<paymentRecord>()
            .HasOne<mdPaymentInstrument> (a => a.paymentRecordInstrument)
            .WithMany(b => b.instrumentsOfPayments)
            .HasForeignKey(c => c.paymentRecordInstrumentId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<paymentSchedule>().Property(a => a.paymentPercentage).HasPrecision(15, 2);
            modelBuilder.Entity<paymentSchedule>().Property(a => a.paymentAmount).HasPrecision(15, 2);
            modelBuilder.Entity<paymentSchedule>()
            .HasOne<projectMaster> (a => a.paymentScheduleProject)
            .WithMany(b => b.projectPaymentSchedules)
            .HasForeignKey(c => c.paymentScheduleProjectId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<projectBudget>().Property(a => a.budgetAmount).HasPrecision(15, 2);
            modelBuilder.Entity<projectBudget>()
            .HasOne<projectCostCenter> (a => a.budgetCostCenter)
            .WithMany(b => b.projectCostsAtCostCenter)
            .HasForeignKey(c => c.budgetCostCenterId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<projectCostComponent>()
            .HasOne<refCostComponent>(a => a.costComponentRef)
            .WithMany(b => b.refProjectCostComponents)
            .HasForeignKey(c => c.costComponentRefId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<projectCostCenter>()
            .HasOne<projectMaster>(a => a.costCenterProjectMaster)
            .WithMany(b => b.projectMasterCostCenterItems)
            .HasForeignKey(c => c.costCenterProjectMasterId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<projectOrigin>()
            .HasOne<orgDriver>(a => a.projectOriginDriver)
            .WithMany(b => b.driversOfProjectsOrigin)
            .HasForeignKey(c => c.projectOriginDriverId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<projectOrigin>()
            .HasOne<orgGoal>(a => a.projectOriginGoal)
            .WithMany(b => b.goalsOfProjectsOrigins)
            .HasForeignKey(c => c.projectOriginGoalId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<projectOrigin>()
            .HasOne<orgMilestone>(a => a.projectOriginMilestone)
            .WithMany(b => b.milestonesOfProjectsOrigins)
            .HasForeignKey(c => c.projectOriginMilestoneId)
            .OnDelete(DeleteBehavior.Restrict);

            //Governance/MasterData
            modelBuilder.Entity<mdStandardAttachment>()
            .HasOne<mdStandardGuideline> (a => a.attachmentOfStandard)
            .WithMany(b => b.standardGuidelineAttachments)
            .HasForeignKey(c => c.attachmentOfStandardId)
            .OnDelete(DeleteBehavior.SetNull);

            //Governance

            modelBuilder.Entity<asnDispensationApproval>()
            .HasIndex(a => new { a.dispensationApprovalStructureId, a.dispensationAprovalGroupId, a.dispensationAprovalRoleId});
           
            modelBuilder.Entity<asnDispensationApproval>()
            .HasOne<orgStructure>( a => a.dispensationAprovalStructure)
            .WithMany(b => b.structureOfDispensationApproval)
            .HasForeignKey(c => c.dispensationApprovalStructureId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnDispensationApproval>()
            .HasOne<orgGroup>(a => a.dispensationAprovalGroup)
            .WithMany(b => b.groupOfDispensationApproval)
            .HasForeignKey(c => c.dispensationAprovalGroupId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnDispensationApproval>()
            .HasOne<orgRole>(a => a.dispensationAprovalRole)
            .WithMany(b => b.roleOfDispensationApproval)
            .HasForeignKey(c => c.dispensationAprovalRoleId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnDispensationApproval>()
            .HasOne<dispensationRecord> (a => a.dispensationForApprovalAsn)
            .WithMany(b => b.dispensationApprovalAsn)
            .HasForeignKey(c => c.dispensationForApprovalAsnId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnDispensationRequestor>()
            .HasIndex(a => new {a.dispensationRequestorStructureId, a.dispensationRequestorGroupId, a.dispensationRequestorRoleId});

            modelBuilder.Entity<asnDispensationRequestor>()
            .HasOne<orgStructure>(a => a.dispensationRequestorStructure)
            .WithMany(b => b.structureOfDispensationRequestor)
            .HasForeignKey(c => c.dispensationRequestorStructureId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnDispensationRequestor>()
            .HasOne<orgGroup> (a => a.dispensationRequestorGroup)
            .WithMany(b => b.groupOfDispensationRequestor)
            .HasForeignKey(c => c.dispensationRequestorGroupId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnDispensationRequestor>()
            .HasOne<orgRole> (a => a.dispensationRequestorRole)
            .WithMany(b => b.roleOfDispensationRequestor)
            .HasForeignKey(c => c.dispensationRequestorRoleId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnDispensationRequestor>()
            .HasOne<dispensationRecord> (a => a.dispensationOfRequestor)
            .WithMany(b => b.dispensationRequestAsn)
            .HasForeignKey(c => c.dispensationOfRequestorId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnGovernedEntityStandard>()
            .HasIndex(a => new {a.asnGoverningStandardId, a.requiredComplianceId});

            modelBuilder.Entity<asnGovernedEntityStandard>()
            .HasOne<governedEntity>(a => a.asnGovernedEntity)
            .WithMany(b => b.governedEntityStandardsAsn)
            .HasForeignKey(c => c.asnGovernedEntityId)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<asnGovernedEntityStandard>()
            .HasOne<mdStandardGuideline>(a => a.asnGoverningStandard)
            .WithMany(b => b.standardGovernedEntityAsn)
            .HasForeignKey(c => c.asnGoverningStandardId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGovernedEntityStandard>()
            .HasOne<mdGovernanceComplianceLevel> (a => a.requiredCompliance)
            .WithMany(b => b.complianceForGovernedStandards)
            .HasForeignKey(c => c.requiredComplianceId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnGovernedGoverning>()
            .HasKey(a => new {a.asnGovernedEntityId, a.asnGoverningEntityId});
            
            modelBuilder.Entity<asnGovernedGoverning>()
            .HasOne<governedEntity>(a => a.asnGovernedEntity)
            .WithMany(b => b.governedEntityAsn)
            .HasForeignKey(c => c.asnGovernedEntityId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnGovernedGoverning>()
            .HasOne<governingEntity>( a => a.asnGoverningEntity)
            .WithMany(b => b.governingEntityAsn)
            .HasForeignKey(c => c.asnGoverningEntityId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnGoverningEntityLog>()
            .HasKey(a => new { a.asnGovernanceLogId, a.asnGoverningEntityId});

            modelBuilder.Entity<asnGoverningEntityLog>()
            .HasOne<governanceLog> (a => a.asnGovernanceLog)
            .WithMany(b => b.governingLogEntityAsn)
            .HasForeignKey(c => c.asnGovernanceLogId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<asnGoverningEntityLog>()
            .HasOne<governingEntity>(a => a.asnGoverningEntity)
            .WithMany(b => b.governingEntityLogAsn)
            .HasForeignKey(c => c.asnGoverningEntityId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<dispensationRecord>()
            .HasOne<governedEntity>(a => a.preGovernanceDispensation)
            .WithMany(b => b.governedEntityDispensation)
            .HasForeignKey(c => c.preGovernanceDispensationId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<dispensationRecord>()
            .HasOne<governanceLog>(a => a.postGovernanceDispensation)
            .WithMany(b => b.governanceLogDispensations)
            .HasForeignKey(c => c.postGovernanceDispensationId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<governanceAttachment>()
            .HasOne<governanceOutput>(a => a.governanceAttachmentForOutput)
            .WithMany(b => b.governanceOutputAttachments)
            .HasForeignKey(c => c.governanceAttachmentForOutputId)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<governanceLog>()
            .HasOne<governedEntity>(a => a.governanceSubject)
            .WithMany(b => b.entityGovernanceLogs)
            .HasForeignKey(c => c.governanceSubjectId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<governanceLog>()
            .HasOne<mdGovernanceComplianceLevel> (a => a.governanceResult)
            .WithMany(b => b.governanceCompliances)
            .HasForeignKey(c => c.governanceResultId)
            .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<governanceOutput>()
            .HasOne<governanceLog>(a => a.governanceOutputLog)
            .WithMany(b => b.governanceLogOutputs)
            .HasForeignKey(c => c.governanceOutputLogId)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<governingEntity>()
            .HasOne<orgStructure>(a => a.governingEntityStructure)
            .WithMany(b => b.structureGoverningEntity)
            .HasForeignKey(c => c.governingEntityStructureId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<governingEntity>()
            .HasOne<orgGroup>(a => a.governingEntityGroup)
            .WithMany(b => b.groupGoverningEntity)
            .HasForeignKey(c => c.governingEntityGroupId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<governingEntity>()
            .HasOne<orgRole>(a => a.governingEntityRole)
            .WithMany(b => b.roleGoverningEntity)
            .HasForeignKey(c => c.governingEntityRoleId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<governedEntity>()
            .HasOne<procurementDetail>(a => a.governedEntityProcurement)
            .WithMany(b => b.procurementAsGovernedEntity)
            .HasForeignKey(c => c.governedEntityProcurementId)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<governedEntity>()
            .HasOne<orgDeliverable>(a => a.governedEntityDeliverable)
            .WithMany(b => b.deliverableAsGovernedEntity)
            .HasForeignKey(c => c.governedEntityDeliverableId)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<governedEntity>()
            .HasOne<projectMaster>(a => a.governedEntityProject)
            .WithMany(b => b.projectAsGovernedEntity)
            .HasForeignKey(c => c.governedEntityProjectId)
            .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<governedEntity>()
            .HasOne<governedEntity>(a => a.parentGovernedEntity)
            .WithMany(b => b.childGovernedEntities)
            .HasForeignKey(c => c.parentGovernedEntityId)
            .OnDelete(DeleteBehavior.Restrict);

            //System
            modelBuilder.Entity<mdAstraFieldType>().Property(a => a.maxLength).HasPrecision(15, 2);

            modelBuilder.Entity<asnDataSourceAccessType>()
            .HasOne<mdDataSource> (a => a.asnDataSource)
            .WithMany(b => b.dataSourceAccessTypesAsn)
            .HasForeignKey(c => c.asnDataSourceId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnDataSourceAccessType>()
            .HasOne<mdDataSourceAccessType> (a => a.asnAccessType)
            .WithMany(b => b.accessTypeDataSourceAsn)
            .HasForeignKey(c => c.asnAccessTypeId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnDataSourceAccessType>()
            .HasOne<mdDataSourcePriority> (a => a.asnDataSourcePriority)
            .WithMany(b => b.dataSourcePriorityAccessTypeAsn)
            .HasForeignKey(c => c.asnDataSourcePriorityId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnEnterpriseElementDataSource>()
            .HasKey(a => new {a.asnDataSourceId, a.asnEnterpriseElementId});

            modelBuilder.Entity<asnEnterpriseElementDataSource>()
            .HasOne<astraEnterpriseElement>(a => a.asnEnterpriseElement)
            .WithMany(b => b.enterpriseElementDataSourcesAsn)
            .HasForeignKey(c => c.asnEnterpriseElementId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnEnterpriseElementDataSource>()
            .HasOne<mdDataSource>(a => a.asnDataSource)
            .WithMany(b => b.dataSourceEnterpriseElementsAsn)
            .HasForeignKey(c => c.asnDataSourceId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnInformationObjectEnterpriseElement>()
            .HasKey(a => new {a.asnEnterpriseElementId, a.asnInformationObjectId});

            modelBuilder.Entity<asnInformationObjectEnterpriseElement>()
            .HasOne<astraInformationObject> (a => a.asnInformationObject)
            .WithMany(b => b.informationObjectEnterpriseElementAsn)
            .HasForeignKey(c => c.asnInformationObjectId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<asnInformationObjectEnterpriseElement>()
            .HasOne<astraEnterpriseElement>(a => a.asnEnterpriseElement)
            .WithMany(b => b.enterpriseElementInformationObjectAsn)
            .HasForeignKey(c => c.asnEnterpriseElementId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<astraInformationObject>()
            .HasOne<mdInformationSchema>(a => a.informationSchema)
            .WithMany(b => b.schemaOfInfoObjects)
            .HasForeignKey(c => c.informationSchemaId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<informationObjectField>()
            .HasOne<astraInformationObject>(a => a.informationObjectRef)
            .WithMany(b => b.astraInformationObjectFields)
            .HasForeignKey(c => c.informationObjectRefId)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<informationObjectField>()
            .HasOne<mdAstraFieldType>(a => a.fieldType)
            .WithMany(b => b.fieldTypeOfInformationObjectField)
            .HasForeignKey(c => c.fieldTypeId)
            .OnDelete(DeleteBehavior.Restrict);

        }
    }
}