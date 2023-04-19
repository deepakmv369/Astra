using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Astra_MK1.Migrations
{
    /// <inheritdoc />
    public partial class astraMK1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Portfolio");

            migrationBuilder.EnsureSchema(
                name: "PortfolioASNS");

            migrationBuilder.EnsureSchema(
                name: "astraSYSASNS");

            migrationBuilder.EnsureSchema(
                name: "GovernanceASNS");

            migrationBuilder.EnsureSchema(
                name: "VehiclesASNS");

            migrationBuilder.EnsureSchema(
                name: "astraSYS");

            migrationBuilder.EnsureSchema(
                name: "Governance");

            migrationBuilder.EnsureSchema(
                name: "PortfolioMaster");

            migrationBuilder.EnsureSchema(
                name: "astraSYSMaster");

            migrationBuilder.EnsureSchema(
                name: "GovernanceMaster");

            migrationBuilder.EnsureSchema(
                name: "VehiclesMaster");

            migrationBuilder.EnsureSchema(
                name: "Vehicles");

            migrationBuilder.EnsureSchema(
                name: "PortfolioRef");

            migrationBuilder.CreateTable(
                name: "astraEnterpriseElements",
                schema: "astraSYS",
                columns: table => new
                {
                    astraEnterpriseElementId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataEntityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dataEntityLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    dataEntityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_astraEnterpriseElements", x => x.astraEnterpriseElementId);
                });

            migrationBuilder.CreateTable(
                name: "incidentEscalationModelGroup",
                schema: "Portfolio",
                columns: table => new
                {
                    incidentEscalationModelGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    escalationModelGroupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incidentEscalationModelGroup", x => x.incidentEscalationModelGroupId);
                });

            migrationBuilder.CreateTable(
                name: "mdActorTypes",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdActorTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    actorType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    parentActorTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdActorTypes", x => x.mdActorTypeId);
                    table.ForeignKey(
                        name: "FK_mdActorTypes_mdActorTypes_parentActorTypeId",
                        column: x => x.parentActorTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdActorTypes",
                        principalColumn: "mdActorTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdAssetCategories",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdAssetCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdAssetCategories", x => x.mdAssetCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "mdAssetTypes",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdAssetTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assetType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    depreciation = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    parentAssetID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdAssetTypes", x => x.mdAssetTypeId);
                    table.ForeignKey(
                        name: "FK_mdAssetTypes_mdAssetTypes_parentAssetID",
                        column: x => x.parentAssetID,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAssetTypes",
                        principalColumn: "mdAssetTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdAstraFieldTypes",
                schema: "astraSYSMaster",
                columns: table => new
                {
                    mdAstraFieldTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dbFieldTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    codeFieldTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maxLength = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdAstraFieldTypes", x => x.mdAstraFieldTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mdAuthorityLevels",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdAuthorityLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    authorityLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdAuthorityLevels", x => x.mdAuthorityLevelId);
                });

            migrationBuilder.CreateTable(
                name: "mdCapacityUnitMeasurementCategories",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdCapacityUnitMeasurementCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdCapacityUnitMeasurementCategories", x => x.mdCapacityUnitMeasurementCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "mdCompetencyLevels",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdCompetencyLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    competencyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdCompetencyLevels", x => x.mdCompetencyLevelId);
                });

            migrationBuilder.CreateTable(
                name: "mdComplexities",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdComplexityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qualityIndicator = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    quantityIndicator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdComplexities", x => x.mdComplexityId);
                });

            migrationBuilder.CreateTable(
                name: "mdCumulativeStakeCaps",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdCumulativeStakeCapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    minCap = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    maxCap = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    mdAuthAccessLevelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdCumulativeStakeCaps", x => x.mdCumulativeStakeCapId);
                });

            migrationBuilder.CreateTable(
                name: "mdDataSourceAccessTypes",
                schema: "astraSYSMaster",
                columns: table => new
                {
                    mdDataSourceAccessTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataSourceAccessTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    dataSourceRefDoc = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdDataSourceAccessTypes", x => x.mdDataSourceAccessTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mdDataSourcePriorities",
                schema: "astraSYSMaster",
                columns: table => new
                {
                    mdDataSourcePriorityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    priorityOrder = table.Column<int>(type: "int", nullable: true),
                    priorityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdDataSourcePriorities", x => x.mdDataSourcePriorityId);
                });

            migrationBuilder.CreateTable(
                name: "mdDataSources",
                schema: "astraSYSMaster",
                columns: table => new
                {
                    mdDataSourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dataSourceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dataSourceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isPersisted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdDataSources", x => x.mdDataSourceId);
                });

            migrationBuilder.CreateTable(
                name: "mdDriverTypes",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdDriverTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    driverTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    parentDriverTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdDriverTypes", x => x.mdDriverTypeId);
                    table.ForeignKey(
                        name: "FK_mdDriverTypes_mdDriverTypes_parentDriverTypeId",
                        column: x => x.parentDriverTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdDriverTypes",
                        principalColumn: "mdDriverTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdFrequencies",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdFrequencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rangeStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    rangeEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    specific = table.Column<DateTime>(type: "datetime2", nullable: true),
                    startAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdFrequencies", x => x.mdFrequencyId);
                });

            migrationBuilder.CreateTable(
                name: "mdGeneralScales",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdGeneralScaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qualityIndicator = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    quantityIndicator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdGeneralScales", x => x.mdGeneralScaleId);
                });

            migrationBuilder.CreateTable(
                name: "mdGoalTypes",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdGoalTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    goalTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdGoalTypes", x => x.mdGoalTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mdGovernanceComplianceLevels",
                schema: "GovernanceMaster",
                columns: table => new
                {
                    mdGovernanceComplianceLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    compLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    rank = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdGovernanceComplianceLevels", x => x.mdGovernanceComplianceLevelId);
                });

            migrationBuilder.CreateTable(
                name: "mdImpacts",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdImpactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qualityIndicator = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    quantityIndicator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdImpacts", x => x.mdImpactId);
                });

            migrationBuilder.CreateTable(
                name: "mdInfomationSchemas",
                schema: "astraSYSASNS",
                columns: table => new
                {
                    mdInformationSchemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    informationSchemaName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdInfomationSchemas", x => x.mdInformationSchemaId);
                });

            migrationBuilder.CreateTable(
                name: "mdManagementMethods",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdManagementMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    methodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentMethodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdManagementMethods", x => x.mdManagementMethodId);
                    table.ForeignKey(
                        name: "FK_mdManagementMethods_mdManagementMethods_parentMethodId",
                        column: x => x.parentMethodId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdManagementMethods",
                        principalColumn: "mdManagementMethodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdMotivationalDimensions",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdMotivationalDimensionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dimensionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdMotivationalDimensions", x => x.mdMotivationalDimensionId);
                });

            migrationBuilder.CreateTable(
                name: "mdPaymentInstruments",
                schema: "VehiclesMaster",
                columns: table => new
                {
                    mdPaymentInstrumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentInstrumentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdPaymentInstruments", x => x.mdPaymentInstrumentId);
                });

            migrationBuilder.CreateTable(
                name: "mdPoliciesPrinciples",
                schema: "GovernanceMaster",
                columns: table => new
                {
                    mdPolicyPrincipleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    policyPrincipleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    policyPrincipleRationale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    policyPrincipleStatement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    policyPrincipleDocument = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdPoliciesPrinciples", x => x.mdPolicyPrincipleId);
                });

            migrationBuilder.CreateTable(
                name: "mdPortfolioCategories",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdPortfolioCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    portfolioName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdPortfolioCategories", x => x.mdPortfolioCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "mdPPImplications",
                schema: "GovernanceMaster",
                columns: table => new
                {
                    mdPPImplicationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    implicationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    implicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdPPImplications", x => x.mdPPImplicationId);
                });

            migrationBuilder.CreateTable(
                name: "mdPredicates",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdPredicateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    predicateFormula = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdPredicates", x => x.mdPredicateId);
                });

            migrationBuilder.CreateTable(
                name: "mdRoleTypes",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdRoleTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdRoleTypes", x => x.mdRoleTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mdSecurityQuestions",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdSecurityQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    securityQuestion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdSecurityQuestions", x => x.mdSecurityQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "mdSkillTypes",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdSkillTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    skillTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdSkillTypes", x => x.mdSkillTypeId);
                });

            migrationBuilder.CreateTable(
                name: "mdStakes",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdStakeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stakeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdStakes", x => x.mdStakeId);
                });

            migrationBuilder.CreateTable(
                name: "mdStandardsGuidelines",
                schema: "GovernanceMaster",
                columns: table => new
                {
                    mdStandardGuidelineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    resourceLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    standardGuidelineName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdStandardsGuidelines", x => x.mdStandardGuidelineId);
                });

            migrationBuilder.CreateTable(
                name: "orgLocations",
                schema: "Portfolio",
                columns: table => new
                {
                    orgLocationId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orgAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    blockNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    buildingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    countryAlpha3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    locJurisdiction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    locationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    officeNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    locRegion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    roadNameNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    sameAsParent = table.Column<bool>(type: "bit", nullable: true),
                    streetNameNum = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    stateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    webSite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgLocations", x => x.orgLocationId);
                });

            migrationBuilder.CreateTable(
                name: "orgMilestones",
                schema: "Portfolio",
                columns: table => new
                {
                    orgMilestoneId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    milestoneName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    milestoneDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plannedFor = table.Column<DateTime>(type: "datetime2", nullable: true),
                    achievedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    milestoneSequence = table.Column<int>(type: "int", nullable: true),
                    contributionPercent = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    parentMilestoneId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgMilestones", x => x.orgMilestoneId);
                    table.ForeignKey(
                        name: "FK_orgMilestones_orgMilestones_parentMilestoneId",
                        column: x => x.parentMilestoneId,
                        principalSchema: "Portfolio",
                        principalTable: "orgMilestones",
                        principalColumn: "orgMilestoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "projectMaster",
                schema: "Vehicles",
                columns: table => new
                {
                    projectMasterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    projectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    plannedStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    plannedEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    actualStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    actualEndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectMaster", x => x.projectMasterId);
                });

            migrationBuilder.CreateTable(
                name: "refCLTypes",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refCLTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refCLTypes", x => x.refCLTypeId);
                });

            migrationBuilder.CreateTable(
                name: "refCostComponents",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refCostComponentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    costComponentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    itemRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refCostComponents", x => x.refCostComponentId);
                });

            migrationBuilder.CreateTable(
                name: "refIncidentStatuses",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refIncidentStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    incidentStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refIncidentStatuses", x => x.refIncidentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "refJobs",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refJobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jobName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    jobDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentJobId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refJobs", x => x.refJobId);
                    table.ForeignKey(
                        name: "FK_refJobs_refJobs_parentJobId",
                        column: x => x.parentJobId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refJobs",
                        principalColumn: "refJobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "refOpExTypes",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refOpExTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    opexTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refOpExTypes", x => x.refOpExTypeId);
                });

            migrationBuilder.CreateTable(
                name: "refOrgStatuses",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refOrgStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orgStatusName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refOrgStatuses", x => x.refOrgStatusId);
                });

            migrationBuilder.CreateTable(
                name: "refOrgTypes",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refOrgTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orgTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refOrgTypes", x => x.refOrgTypeId);
                });

            migrationBuilder.CreateTable(
                name: "refPhoneTypes",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refPhoneTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phoneTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refPhoneTypes", x => x.refPhoneTypeId);
                });

            migrationBuilder.CreateTable(
                name: "refProcurementDocumentTypes",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refProcurementDocumentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    procDocName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refProcurementDocumentTypes", x => x.refProcurementDocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "refProcurementTypes",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refProcurementTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    procTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    procTypeDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refProcurementTypes", x => x.refProcurementTypeId);
                });

            migrationBuilder.CreateTable(
                name: "refRanks",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refRankId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refRanks", x => x.refRankId);
                });

            migrationBuilder.CreateTable(
                name: "refRoleContexts",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refRoleContextId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleContextName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refRoleContexts", x => x.refRoleContextId);
                });

            migrationBuilder.CreateTable(
                name: "refSkills",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refSkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    skillName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    skillDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentSkillId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refSkills", x => x.refSkillId);
                    table.ForeignKey(
                        name: "FK_refSkills_refSkills_parentSkillId",
                        column: x => x.parentSkillId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refSkills",
                        principalColumn: "refSkillId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "refTimeUnits",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refTimeUnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    timeUnitName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    timeUnitValue = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refTimeUnits", x => x.refTimeUnitId);
                });

            migrationBuilder.CreateTable(
                name: "incidentEscalationModel",
                schema: "Portfolio",
                columns: table => new
                {
                    incidentEsclationModelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    esclationModelName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    escalationLevel = table.Column<int>(type: "int", nullable: true),
                    incidentEsclationGroupId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incidentEscalationModel", x => x.incidentEsclationModelId);
                    table.ForeignKey(
                        name: "FK_incidentEscalationModel_incidentEscalationModelGroup_incidentEsclationGroupId",
                        column: x => x.incidentEsclationGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "incidentEscalationModelGroup",
                        principalColumn: "incidentEscalationModelGroupId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orgActors",
                schema: "Portfolio",
                columns: table => new
                {
                    orgActorId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uniqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    actorIdentityDomain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    firstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    middleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    actorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mailId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    actorTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgActors", x => x.orgActorId);
                    table.ForeignKey(
                        name: "FK_orgActors_mdActorTypes_actorTypeId",
                        column: x => x.actorTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdActorTypes",
                        principalColumn: "mdActorTypeId");
                });

            migrationBuilder.CreateTable(
                name: "orgDeliverables",
                schema: "Portfolio",
                columns: table => new
                {
                    orgDeliverableId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deliverableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    deliverableDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    deliverableTypeId = table.Column<int>(type: "int", nullable: true),
                    parentDeliverableId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgDeliverables", x => x.orgDeliverableId);
                    table.ForeignKey(
                        name: "FK_orgDeliverables_mdAssetTypes_deliverableTypeId",
                        column: x => x.deliverableTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAssetTypes",
                        principalColumn: "mdAssetTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgDeliverables_orgDeliverables_parentDeliverableId",
                        column: x => x.parentDeliverableId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDeliverables",
                        principalColumn: "orgDeliverableId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "refDeliverables",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refDeliverableId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    deliverableName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    deliverableTypeId = table.Column<int>(type: "int", nullable: true),
                    deliverableDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refDeliverables", x => x.refDeliverableId);
                    table.ForeignKey(
                        name: "FK_refDeliverables_mdAssetTypes_deliverableTypeId",
                        column: x => x.deliverableTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAssetTypes",
                        principalColumn: "mdAssetTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdAuthAccessLevels",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdAuthAccessLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    canCreate = table.Column<bool>(type: "bit", nullable: true),
                    canRead = table.Column<bool>(type: "bit", nullable: true),
                    canUpdate = table.Column<bool>(type: "bit", nullable: true),
                    canDelete = table.Column<bool>(type: "bit", nullable: true),
                    authorityLevelId = table.Column<int>(type: "int", nullable: true),
                    stakeThreshold = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdAuthAccessLevels", x => x.mdAuthAccessLevelId);
                    table.ForeignKey(
                        name: "FK_mdAuthAccessLevels_mdAuthorityLevels_authorityLevelId",
                        column: x => x.authorityLevelId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAuthorityLevels",
                        principalColumn: "mdAuthorityLevelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_mdAuthAccessLevels_mdCumulativeStakeCaps_stakeThreshold",
                        column: x => x.stakeThreshold,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdCumulativeStakeCaps",
                        principalColumn: "mdCumulativeStakeCapId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnDataSourceAccessTypes",
                schema: "astraSYSASNS",
                columns: table => new
                {
                    asnDataSourceAccessTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    asnDataSourceId = table.Column<int>(type: "int", nullable: false),
                    asnAccessTypeId = table.Column<int>(type: "int", nullable: false),
                    asnDataSourcePriorityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnDataSourceAccessTypes", x => x.asnDataSourceAccessTypeId);
                    table.ForeignKey(
                        name: "FK_asnDataSourceAccessTypes_mdDataSourceAccessTypes_asnAccessTypeId",
                        column: x => x.asnAccessTypeId,
                        principalSchema: "astraSYSMaster",
                        principalTable: "mdDataSourceAccessTypes",
                        principalColumn: "mdDataSourceAccessTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnDataSourceAccessTypes_mdDataSourcePriorities_asnDataSourcePriorityId",
                        column: x => x.asnDataSourcePriorityId,
                        principalSchema: "astraSYSMaster",
                        principalTable: "mdDataSourcePriorities",
                        principalColumn: "mdDataSourcePriorityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnDataSourceAccessTypes_mdDataSources_asnDataSourceId",
                        column: x => x.asnDataSourceId,
                        principalSchema: "astraSYSMaster",
                        principalTable: "mdDataSources",
                        principalColumn: "mdDataSourceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnEnterpriseElementsDataSources",
                schema: "astraSYSASNS",
                columns: table => new
                {
                    asnEnterpriseElementId = table.Column<long>(type: "bigint", nullable: false),
                    asnDataSourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnEnterpriseElementsDataSources", x => new { x.asnDataSourceId, x.asnEnterpriseElementId });
                    table.ForeignKey(
                        name: "FK_asnEnterpriseElementsDataSources_astraEnterpriseElements_asnEnterpriseElementId",
                        column: x => x.asnEnterpriseElementId,
                        principalSchema: "astraSYS",
                        principalTable: "astraEnterpriseElements",
                        principalColumn: "astraEnterpriseElementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnEnterpriseElementsDataSources_mdDataSources_asnDataSourceId",
                        column: x => x.asnDataSourceId,
                        principalSchema: "astraSYSMaster",
                        principalTable: "mdDataSources",
                        principalColumn: "mdDataSourceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orgGoals",
                schema: "Portfolio",
                columns: table => new
                {
                    orgGoalId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    goalName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    goalDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plannedFor = table.Column<DateTime>(type: "datetime2", nullable: true),
                    achievedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    orgGoalTypeId = table.Column<int>(type: "int", nullable: true),
                    parentGoalId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgGoals", x => x.orgGoalId);
                    table.ForeignKey(
                        name: "FK_orgGoals_mdGoalTypes_orgGoalTypeId",
                        column: x => x.orgGoalTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGoalTypes",
                        principalColumn: "mdGoalTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgGoals_orgGoals_parentGoalId",
                        column: x => x.parentGoalId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGoals",
                        principalColumn: "orgGoalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "astraInformationObjects",
                schema: "astraSYS",
                columns: table => new
                {
                    astraInformationObjectId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    informationObjectName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    informationObjectLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    informationObjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    informationSchemaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_astraInformationObjects", x => x.astraInformationObjectId);
                    table.ForeignKey(
                        name: "FK_astraInformationObjects_mdInfomationSchemas_informationSchemaId",
                        column: x => x.informationSchemaId,
                        principalSchema: "astraSYSASNS",
                        principalTable: "mdInfomationSchemas",
                        principalColumn: "mdInformationSchemaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdPhases",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdPhaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    phaseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    phaseSequence = table.Column<int>(type: "int", nullable: true),
                    ManagementmethodId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdPhases", x => x.mdPhaseId);
                    table.ForeignKey(
                        name: "FK_mdPhases_mdManagementMethods_ManagementmethodId",
                        column: x => x.ManagementmethodId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdManagementMethods",
                        principalColumn: "mdManagementMethodId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orgDrivers",
                schema: "Portfolio",
                columns: table => new
                {
                    orgDriverId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    odName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    odDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    approvedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    plannedStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    plannedEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    actualStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    actualEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    parentOrgDriverId = table.Column<long>(type: "bigint", nullable: true),
                    driverTypeID = table.Column<int>(type: "int", nullable: true),
                    ppImplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgDrivers", x => x.orgDriverId);
                    table.ForeignKey(
                        name: "FK_orgDrivers_mdDriverTypes_driverTypeID",
                        column: x => x.driverTypeID,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdDriverTypes",
                        principalColumn: "mdDriverTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgDrivers_mdPPImplications_ppImplicationId",
                        column: x => x.ppImplicationId,
                        principalSchema: "GovernanceMaster",
                        principalTable: "mdPPImplications",
                        principalColumn: "mdPPImplicationId");
                    table.ForeignKey(
                        name: "FK_orgDrivers_orgDrivers_parentOrgDriverId",
                        column: x => x.parentOrgDriverId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDrivers",
                        principalColumn: "orgDriverId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "userCredentials",
                schema: "Portfolio",
                columns: table => new
                {
                    userCredentialId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isIntegratedLogin = table.Column<bool>(type: "bit", nullable: false),
                    passwordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    passwordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    passwordExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    securityAnswer = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    securityQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userCredentials", x => x.userCredentialId);
                    table.ForeignKey(
                        name: "FK_userCredentials_mdSecurityQuestions_securityQuestionId",
                        column: x => x.securityQuestionId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdSecurityQuestions",
                        principalColumn: "mdSecurityQuestionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdStandardAttachments",
                schema: "GovernanceMaster",
                columns: table => new
                {
                    mdStandardAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attachmentOfStandardId = table.Column<int>(type: "int", nullable: true),
                    attachmentContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    attachmentTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdStandardAttachments", x => x.mdStandardAttachmentId);
                    table.ForeignKey(
                        name: "FK_mdStandardAttachments_mdStandardsGuidelines_attachmentOfStandardId",
                        column: x => x.attachmentOfStandardId,
                        principalSchema: "GovernanceMaster",
                        principalTable: "mdStandardsGuidelines",
                        principalColumn: "mdStandardGuidelineId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "paymentRecords",
                schema: "Vehicles",
                columns: table => new
                {
                    paymentRecordId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    invoiceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    invoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    paymentInstrumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    paymentRecordInstrumentId = table.Column<int>(type: "int", nullable: true),
                    paymentReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    paymentReceiptNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    paymentRecordProjectId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentRecords", x => x.paymentRecordId);
                    table.ForeignKey(
                        name: "FK_paymentRecords_mdPaymentInstruments_paymentRecordInstrumentId",
                        column: x => x.paymentRecordInstrumentId,
                        principalSchema: "VehiclesMaster",
                        principalTable: "mdPaymentInstruments",
                        principalColumn: "mdPaymentInstrumentId");
                    table.ForeignKey(
                        name: "FK_paymentRecords_projectMaster_paymentRecordProjectId",
                        column: x => x.paymentRecordProjectId,
                        principalSchema: "Vehicles",
                        principalTable: "projectMaster",
                        principalColumn: "projectMasterId");
                });

            migrationBuilder.CreateTable(
                name: "paymentSchedules",
                schema: "Vehicles",
                columns: table => new
                {
                    paymentScheduleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentPercentage = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    plannedPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    paymentAmount = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    scheduleRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paymentScheduleProjectId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentSchedules", x => x.paymentScheduleId);
                    table.ForeignKey(
                        name: "FK_paymentSchedules_projectMaster_paymentScheduleProjectId",
                        column: x => x.paymentScheduleProjectId,
                        principalSchema: "Vehicles",
                        principalTable: "projectMaster",
                        principalColumn: "projectMasterId");
                });

            migrationBuilder.CreateTable(
                name: "projectCostCenter",
                schema: "Vehicles",
                columns: table => new
                {
                    projectCostCenterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    costCenterProjectMasterId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectCostCenter", x => x.projectCostCenterId);
                    table.ForeignKey(
                        name: "FK_projectCostCenter_projectMaster_costCenterProjectMasterId",
                        column: x => x.costCenterProjectMasterId,
                        principalSchema: "Vehicles",
                        principalTable: "projectMaster",
                        principalColumn: "projectMasterId");
                });

            migrationBuilder.CreateTable(
                name: "projectCostComponents",
                schema: "Vehicles",
                columns: table => new
                {
                    projectCostComponentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    costComponentRefId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectCostComponents", x => x.projectCostComponentId);
                    table.ForeignKey(
                        name: "FK_projectCostComponents_refCostComponents_costComponentRefId",
                        column: x => x.costComponentRefId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refCostComponents",
                        principalColumn: "refCostComponentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "locPhones",
                schema: "Portfolio",
                columns: table => new
                {
                    locPhoneId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isdCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    stdCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    telNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    locPhoneTypeId = table.Column<long>(type: "bigint", nullable: true),
                    orgLocationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locPhones", x => x.locPhoneId);
                    table.ForeignKey(
                        name: "FK_locPhones_orgLocations_orgLocationId",
                        column: x => x.orgLocationId,
                        principalSchema: "Portfolio",
                        principalTable: "orgLocations",
                        principalColumn: "orgLocationId");
                    table.ForeignKey(
                        name: "FK_locPhones_refPhoneTypes_locPhoneTypeId",
                        column: x => x.locPhoneTypeId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refPhoneTypes",
                        principalColumn: "refPhoneTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orgRoles",
                schema: "Portfolio",
                columns: table => new
                {
                    orgRoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parentRoleId = table.Column<long>(type: "bigint", nullable: true),
                    roleRankId = table.Column<int>(type: "int", nullable: true),
                    vitalityIndicatorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgRoles", x => x.orgRoleId);
                    table.ForeignKey(
                        name: "FK_orgRoles_mdGeneralScales_vitalityIndicatorId",
                        column: x => x.vitalityIndicatorId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgRoles_orgRoles_parentRoleId",
                        column: x => x.parentRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgRoles_refRanks_roleRankId",
                        column: x => x.roleRankId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refRanks",
                        principalColumn: "refRankId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "refRoles",
                schema: "PortfolioRef",
                columns: table => new
                {
                    refRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    roleDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    roleTypeId = table.Column<int>(type: "int", nullable: true),
                    roleContextId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refRoles", x => x.refRoleId);
                    table.ForeignKey(
                        name: "FK_refRoles_mdRoleTypes_roleTypeId",
                        column: x => x.roleTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdRoleTypes",
                        principalColumn: "mdRoleTypeId");
                    table.ForeignKey(
                        name: "FK_refRoles_refRoleContexts_roleContextId",
                        column: x => x.roleContextId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refRoleContexts",
                        principalColumn: "refRoleContextId");
                });

            migrationBuilder.CreateTable(
                name: "skillParams",
                schema: "Portfolio",
                columns: table => new
                {
                    skillParamId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    competencyLevelId = table.Column<int>(type: "int", nullable: true),
                    expPredicateId = table.Column<int>(type: "int", nullable: true),
                    expValue = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    skillId = table.Column<int>(type: "int", nullable: true),
                    skillTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skillParams", x => x.skillParamId);
                    table.ForeignKey(
                        name: "FK_skillParams_mdCompetencyLevels_competencyLevelId",
                        column: x => x.competencyLevelId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdCompetencyLevels",
                        principalColumn: "mdCompetencyLevelId");
                    table.ForeignKey(
                        name: "FK_skillParams_mdPredicates_expPredicateId",
                        column: x => x.expPredicateId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdPredicates",
                        principalColumn: "mdPredicateId");
                    table.ForeignKey(
                        name: "FK_skillParams_mdSkillTypes_skillTypeId",
                        column: x => x.skillTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdSkillTypes",
                        principalColumn: "mdSkillTypeId");
                    table.ForeignKey(
                        name: "FK_skillParams_refSkills_skillId",
                        column: x => x.skillId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refSkills",
                        principalColumn: "refSkillId");
                });

            migrationBuilder.CreateTable(
                name: "alertServices",
                schema: "Portfolio",
                columns: table => new
                {
                    alertServiceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    alertStartingPoint = table.Column<int>(type: "int", nullable: true),
                    alertFrequencyId = table.Column<int>(type: "int", nullable: true),
                    alertIntervalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alertServices", x => x.alertServiceId);
                    table.ForeignKey(
                        name: "FK_alertServices_mdFrequencies_alertFrequencyId",
                        column: x => x.alertFrequencyId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdFrequencies",
                        principalColumn: "mdFrequencyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_alertServices_refTimeUnits_alertIntervalId",
                        column: x => x.alertIntervalId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refTimeUnits",
                        principalColumn: "refTimeUnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "mdCapacityMeasurementUnits",
                schema: "PortfolioMaster",
                columns: table => new
                {
                    mdCapacityMeasurementUnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryMesaurementUnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    outOf = table.Column<int>(type: "int", nullable: true),
                    timeUnitId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mdCapacityMeasurementUnits", x => x.mdCapacityMeasurementUnitId);
                    table.ForeignKey(
                        name: "FK_mdCapacityMeasurementUnits_refTimeUnits_outOf",
                        column: x => x.outOf,
                        principalSchema: "PortfolioRef",
                        principalTable: "refTimeUnits",
                        principalColumn: "refTimeUnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnJobDeliverables",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnDeliverableId = table.Column<long>(type: "bigint", nullable: false),
                    asnJobId = table.Column<int>(type: "int", nullable: false),
                    asnJobDeliverableId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    fulfillmentPercent = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnJobDeliverables", x => new { x.asnDeliverableId, x.asnJobId });
                    table.ForeignKey(
                        name: "FK_asnJobDeliverables_orgDeliverables_asnDeliverableId",
                        column: x => x.asnDeliverableId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDeliverables",
                        principalColumn: "orgDeliverableId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnJobDeliverables_refJobs_asnJobId",
                        column: x => x.asnJobId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refJobs",
                        principalColumn: "refJobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnProjectOutputs",
                schema: "VehiclesASNS",
                columns: table => new
                {
                    asnProjectOutputId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    asnProjectMasterId = table.Column<long>(type: "bigint", nullable: true),
                    asnProjectGoalId = table.Column<long>(type: "bigint", nullable: true),
                    asnProjectMilestoneId = table.Column<long>(type: "bigint", nullable: true),
                    asnProjectDeliverableId = table.Column<long>(type: "bigint", nullable: true),
                    projectContributionToGoal = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    milestoneContributionToProject = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    deliveryContributionToMilestone = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnProjectOutputs", x => x.asnProjectOutputId);
                    table.ForeignKey(
                        name: "FK_asnProjectOutputs_orgDeliverables_asnProjectDeliverableId",
                        column: x => x.asnProjectDeliverableId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDeliverables",
                        principalColumn: "orgDeliverableId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectOutputs_orgGoals_asnProjectGoalId",
                        column: x => x.asnProjectGoalId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGoals",
                        principalColumn: "orgGoalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectOutputs_orgMilestones_asnProjectMilestoneId",
                        column: x => x.asnProjectMilestoneId,
                        principalSchema: "Portfolio",
                        principalTable: "orgMilestones",
                        principalColumn: "orgMilestoneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectOutputs_projectMaster_asnProjectMasterId",
                        column: x => x.asnProjectMasterId,
                        principalSchema: "Vehicles",
                        principalTable: "projectMaster",
                        principalColumn: "projectMasterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnInformationObjectEnterpriseElements",
                schema: "astraSYSASNS",
                columns: table => new
                {
                    asnEnterpriseElementId = table.Column<long>(type: "bigint", nullable: false),
                    asnInformationObjectId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnInformationObjectEnterpriseElements", x => new { x.asnEnterpriseElementId, x.asnInformationObjectId });
                    table.ForeignKey(
                        name: "FK_asnInformationObjectEnterpriseElements_astraEnterpriseElements_asnEnterpriseElementId",
                        column: x => x.asnEnterpriseElementId,
                        principalSchema: "astraSYS",
                        principalTable: "astraEnterpriseElements",
                        principalColumn: "astraEnterpriseElementId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnInformationObjectEnterpriseElements_astraInformationObjects_asnInformationObjectId",
                        column: x => x.asnInformationObjectId,
                        principalSchema: "astraSYS",
                        principalTable: "astraInformationObjects",
                        principalColumn: "astraInformationObjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "informationObjectFields",
                schema: "astraSYS",
                columns: table => new
                {
                    informationObjectFieldId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fieldName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fieldLabel = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    fieldDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fieldTypeId = table.Column<int>(type: "int", nullable: true),
                    informationObjectRefId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_informationObjectFields", x => x.informationObjectFieldId);
                    table.ForeignKey(
                        name: "FK_informationObjectFields_astraInformationObjects_informationObjectRefId",
                        column: x => x.informationObjectRefId,
                        principalSchema: "astraSYS",
                        principalTable: "astraInformationObjects",
                        principalColumn: "astraInformationObjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_informationObjectFields_mdAstraFieldTypes_fieldTypeId",
                        column: x => x.fieldTypeId,
                        principalSchema: "astraSYSMaster",
                        principalTable: "mdAstraFieldTypes",
                        principalColumn: "mdAstraFieldTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orgStructures",
                schema: "Portfolio",
                columns: table => new
                {
                    orgStructureId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orgName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    parentOrgId = table.Column<long>(type: "bigint", nullable: true),
                    workingStatusId = table.Column<int>(type: "int", nullable: true),
                    commercialStatusId = table.Column<int>(type: "int", nullable: true),
                    orgTypeId = table.Column<int>(type: "int", nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    locationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgStructures", x => x.orgStructureId);
                    table.ForeignKey(
                        name: "FK_orgStructures_mdPhases_workingStatusId",
                        column: x => x.workingStatusId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdPhases",
                        principalColumn: "mdPhaseId");
                    table.ForeignKey(
                        name: "FK_orgStructures_orgLocations_locationId",
                        column: x => x.locationId,
                        principalSchema: "Portfolio",
                        principalTable: "orgLocations",
                        principalColumn: "orgLocationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgStructures_orgStructures_parentOrgId",
                        column: x => x.parentOrgId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgStructures_refOrgStatuses_commercialStatusId",
                        column: x => x.commercialStatusId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refOrgStatuses",
                        principalColumn: "refOrgStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orgStructures_refOrgTypes_orgTypeId",
                        column: x => x.orgTypeId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refOrgTypes",
                        principalColumn: "refOrgTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "motivationalDimensionsOfImportance",
                schema: "Portfolio",
                columns: table => new
                {
                    motivationalDimensionOfImportanceId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dimOrgDriverId = table.Column<long>(type: "bigint", nullable: false),
                    dimensionOfImportanceId = table.Column<int>(type: "int", nullable: false),
                    motivationImportanceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motivationalDimensionsOfImportance", x => x.motivationalDimensionOfImportanceId);
                    table.ForeignKey(
                        name: "FK_motivationalDimensionsOfImportance_mdGeneralScales_motivationImportanceId",
                        column: x => x.motivationImportanceId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_motivationalDimensionsOfImportance_mdMotivationalDimensions_dimensionOfImportanceId",
                        column: x => x.dimensionOfImportanceId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdMotivationalDimensions",
                        principalColumn: "mdMotivationalDimensionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_motivationalDimensionsOfImportance_orgDrivers_dimOrgDriverId",
                        column: x => x.dimOrgDriverId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDrivers",
                        principalColumn: "orgDriverId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "projectOrigins",
                schema: "Vehicles",
                columns: table => new
                {
                    projectOriginId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectOriginDriverId = table.Column<long>(type: "bigint", nullable: true),
                    projectOriginGoalId = table.Column<long>(type: "bigint", nullable: true),
                    projectOriginMilestoneId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectOrigins", x => x.projectOriginId);
                    table.ForeignKey(
                        name: "FK_projectOrigins_orgDrivers_projectOriginDriverId",
                        column: x => x.projectOriginDriverId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDrivers",
                        principalColumn: "orgDriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_projectOrigins_orgGoals_projectOriginGoalId",
                        column: x => x.projectOriginGoalId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGoals",
                        principalColumn: "orgGoalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_projectOrigins_orgMilestones_projectOriginMilestoneId",
                        column: x => x.projectOriginMilestoneId,
                        principalSchema: "Portfolio",
                        principalTable: "orgMilestones",
                        principalColumn: "orgMilestoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "projectBudgets",
                schema: "Vehicles",
                columns: table => new
                {
                    projectBudgetId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    budgetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    budgetCostCenterId = table.Column<long>(type: "bigint", nullable: true),
                    budgetAmount = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    budgetDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currencyAlpha3 = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectBudgets", x => x.projectBudgetId);
                    table.ForeignKey(
                        name: "FK_projectBudgets_projectCostCenter_budgetCostCenterId",
                        column: x => x.budgetCostCenterId,
                        principalSchema: "Vehicles",
                        principalTable: "projectCostCenter",
                        principalColumn: "projectCostCenterId");
                });

            migrationBuilder.CreateTable(
                name: "asnActorRoles",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnActorRoleId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    fullfillmentPct = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    reasonFor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    asnOrgRoleId = table.Column<long>(type: "bigint", nullable: true),
                    asnOrgActorId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnActorRoles", x => x.asnActorRoleId);
                    table.ForeignKey(
                        name: "FK_asnActorRoles_orgActors_asnOrgActorId",
                        column: x => x.asnOrgActorId,
                        principalSchema: "Portfolio",
                        principalTable: "orgActors",
                        principalColumn: "orgActorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnActorRoles_orgRoles_asnOrgRoleId",
                        column: x => x.asnOrgRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnRoleJobs",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnRoleId = table.Column<int>(type: "int", nullable: false),
                    asnJobId = table.Column<int>(type: "int", nullable: false),
                    asnRoleJobId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    contributionPercent = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    roleJobPriority = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnRoleJobs", x => new { x.asnJobId, x.asnRoleId });
                    table.ForeignKey(
                        name: "FK_asnRoleJobs_refJobs_asnJobId",
                        column: x => x.asnJobId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refJobs",
                        principalColumn: "refJobId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnRoleJobs_refRoles_asnRoleId",
                        column: x => x.asnRoleId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refRoles",
                        principalColumn: "refRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnActorSkills",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnOrgActorId = table.Column<long>(type: "bigint", nullable: false),
                    asnSkillParamId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnActorSkills", x => new { x.asnOrgActorId, x.asnSkillParamId });
                    table.ForeignKey(
                        name: "FK_asnActorSkills_orgActors_asnOrgActorId",
                        column: x => x.asnOrgActorId,
                        principalSchema: "Portfolio",
                        principalTable: "orgActors",
                        principalColumn: "orgActorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnActorSkills_skillParams_asnSkillParamId",
                        column: x => x.asnSkillParamId,
                        principalSchema: "Portfolio",
                        principalTable: "skillParams",
                        principalColumn: "skillParamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnRoleSkill",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnRoleId = table.Column<int>(type: "int", nullable: false),
                    asnSkillParamId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnRoleSkill", x => new { x.asnRoleId, x.asnSkillParamId });
                    table.ForeignKey(
                        name: "FK_asnRoleSkill_refRoles_asnRoleId",
                        column: x => x.asnRoleId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refRoles",
                        principalColumn: "refRoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnRoleSkill_skillParams_asnSkillParamId",
                        column: x => x.asnSkillParamId,
                        principalSchema: "Portfolio",
                        principalTable: "skillParams",
                        principalColumn: "skillParamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "capacityDesigns",
                schema: "Portfolio",
                columns: table => new
                {
                    capacityDesignId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    capacityMeasurementUnitId = table.Column<int>(type: "int", nullable: true),
                    designedCapacity = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    effectiveCapacity = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capacityDesigns", x => x.capacityDesignId);
                    table.ForeignKey(
                        name: "FK_capacityDesigns_mdCapacityMeasurementUnits_capacityMeasurementUnitId",
                        column: x => x.capacityMeasurementUnitId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdCapacityMeasurementUnits",
                        principalColumn: "mdCapacityMeasurementUnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnMotivationals",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnMotivationalId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    fulfillmentPercent = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    asnDeliverableId = table.Column<long>(type: "bigint", nullable: false),
                    asnGoalId = table.Column<long>(type: "bigint", nullable: false),
                    asnOperationId = table.Column<int>(type: "int", nullable: true),
                    asnMilestoneId = table.Column<long>(type: "bigint", nullable: false),
                    asnOrgDriverId = table.Column<long>(type: "bigint", nullable: true),
                    asnOrgStructureId = table.Column<long>(type: "bigint", nullable: true),
                    thisPriorityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnMotivationals", x => x.asnMotivationalId);
                    table.ForeignKey(
                        name: "FK_asnMotivationals_mdGeneralScales_thisPriorityId",
                        column: x => x.thisPriorityId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationals_orgDeliverables_asnDeliverableId",
                        column: x => x.asnDeliverableId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDeliverables",
                        principalColumn: "orgDeliverableId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationals_orgDrivers_asnOrgDriverId",
                        column: x => x.asnOrgDriverId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDrivers",
                        principalColumn: "orgDriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationals_orgGoals_asnGoalId",
                        column: x => x.asnGoalId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGoals",
                        principalColumn: "orgGoalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationals_orgMilestones_asnMilestoneId",
                        column: x => x.asnMilestoneId,
                        principalSchema: "Portfolio",
                        principalTable: "orgMilestones",
                        principalColumn: "orgMilestoneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationals_orgStructures_asnOrgStructureId",
                        column: x => x.asnOrgStructureId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationals_refJobs_asnOperationId",
                        column: x => x.asnOperationId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refJobs",
                        principalColumn: "refJobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orgGroups",
                schema: "Portfolio",
                columns: table => new
                {
                    orgGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    orgGroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    groupPurpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    orgStructId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orgGroups", x => x.orgGroupId);
                    table.ForeignKey(
                        name: "FK_orgGroups_orgStructures_orgStructId",
                        column: x => x.orgStructId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnProjectOriginsMaster",
                schema: "VehiclesASNS",
                columns: table => new
                {
                    asnProjectOriginId = table.Column<long>(type: "bigint", nullable: false),
                    asnProjectMasterId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnProjectOriginsMaster", x => new { x.asnProjectMasterId, x.asnProjectOriginId });
                    table.ForeignKey(
                        name: "FK_asnProjectOriginsMaster_projectMaster_asnProjectMasterId",
                        column: x => x.asnProjectMasterId,
                        principalSchema: "Vehicles",
                        principalTable: "projectMaster",
                        principalColumn: "projectMasterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectOriginsMaster_projectOrigins_asnProjectOriginId",
                        column: x => x.asnProjectOriginId,
                        principalSchema: "Vehicles",
                        principalTable: "projectOrigins",
                        principalColumn: "projectOriginId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnProjectCostComponentBudgets",
                schema: "VehiclesASNS",
                columns: table => new
                {
                    asnBudgetId = table.Column<long>(type: "bigint", nullable: false),
                    asnCostComponentId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnProjectCostComponentBudgets", x => new { x.asnBudgetId, x.asnCostComponentId });
                    table.ForeignKey(
                        name: "FK_asnProjectCostComponentBudgets_projectBudgets_asnBudgetId",
                        column: x => x.asnBudgetId,
                        principalSchema: "Vehicles",
                        principalTable: "projectBudgets",
                        principalColumn: "projectBudgetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectCostComponentBudgets_projectCostComponents_asnCostComponentId",
                        column: x => x.asnCostComponentId,
                        principalSchema: "Vehicles",
                        principalTable: "projectCostComponents",
                        principalColumn: "projectCostComponentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "assetsPortfolio",
                schema: "Portfolio",
                columns: table => new
                {
                    assetPortfolioId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    uniqueAssetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    applicableDepreciation = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: true),
                    assetCategoryId = table.Column<int>(type: "int", nullable: true),
                    assetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    assetPortfolioCategoryId = table.Column<int>(type: "int", nullable: true),
                    assetTypeId = table.Column<int>(type: "int", nullable: true),
                    assetCapacityDesignId = table.Column<long>(type: "bigint", nullable: true),
                    assetComplexityId = table.Column<int>(type: "int", nullable: true),
                    cumulativeVitalityIndicatorId = table.Column<int>(type: "int", nullable: true),
                    cumulativeDependencyImpactId = table.Column<int>(type: "int", nullable: true),
                    lossPerDay = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    utilizationMonitorFrequencyId = table.Column<int>(type: "int", nullable: true),
                    assetDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inwardDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    keyWords = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    assetManagerId = table.Column<long>(type: "bigint", nullable: true),
                    operatingCostPerDay = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    assetOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    parentAssetId = table.Column<long>(type: "bigint", nullable: true),
                    assetStatusId = table.Column<int>(type: "int", nullable: true),
                    assetVolumeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assetsPortfolio", x => x.assetPortfolioId);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_assetsPortfolio_parentAssetId",
                        column: x => x.parentAssetId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_capacityDesigns_assetCapacityDesignId",
                        column: x => x.assetCapacityDesignId,
                        principalSchema: "Portfolio",
                        principalTable: "capacityDesigns",
                        principalColumn: "capacityDesignId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdAssetCategories_assetCategoryId",
                        column: x => x.assetCategoryId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAssetCategories",
                        principalColumn: "mdAssetCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdAssetTypes_assetTypeId",
                        column: x => x.assetTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAssetTypes",
                        principalColumn: "mdAssetTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdComplexities_assetComplexityId",
                        column: x => x.assetComplexityId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdComplexities",
                        principalColumn: "mdComplexityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdFrequencies_utilizationMonitorFrequencyId",
                        column: x => x.utilizationMonitorFrequencyId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdFrequencies",
                        principalColumn: "mdFrequencyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdGeneralScales_assetVolumeId",
                        column: x => x.assetVolumeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdGeneralScales_cumulativeVitalityIndicatorId",
                        column: x => x.cumulativeVitalityIndicatorId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdImpacts_cumulativeDependencyImpactId",
                        column: x => x.cumulativeDependencyImpactId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdImpacts",
                        principalColumn: "mdImpactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdPhases_assetStatusId",
                        column: x => x.assetStatusId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdPhases",
                        principalColumn: "mdPhaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_mdPortfolioCategories_assetPortfolioCategoryId",
                        column: x => x.assetPortfolioCategoryId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdPortfolioCategories",
                        principalColumn: "mdPortfolioCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_orgStructures_assetManagerId",
                        column: x => x.assetManagerId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetsPortfolio_orgStructures_assetOwnerId",
                        column: x => x.assetOwnerId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "capacitySpendings",
                schema: "Portfolio",
                columns: table => new
                {
                    capacitySpendingId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assetCapacitySpendingId = table.Column<long>(type: "bigint", nullable: true),
                    CapacitySpending = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    capacitySpendingMeasurementId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capacitySpendings", x => x.capacitySpendingId);
                    table.ForeignKey(
                        name: "FK_capacitySpendings_capacityDesigns_assetCapacitySpendingId",
                        column: x => x.assetCapacitySpendingId,
                        principalSchema: "Portfolio",
                        principalTable: "capacityDesigns",
                        principalColumn: "capacityDesignId");
                    table.ForeignKey(
                        name: "FK_capacitySpendings_mdCapacityMeasurementUnits_capacitySpendingMeasurementId",
                        column: x => x.capacitySpendingMeasurementId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdCapacityMeasurementUnits",
                        principalColumn: "mdCapacityMeasurementUnitId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnMotivationalSkills",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnMotivationalSkillId = table.Column<long>(type: "bigint", nullable: false),
                    asnSkillParamId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    refAsnMotivationalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnMotivationalSkills", x => new { x.asnMotivationalSkillId, x.asnSkillParamId });
                    table.ForeignKey(
                        name: "FK_asnMotivationalSkills_asnMotivationals_refAsnMotivationalId",
                        column: x => x.refAsnMotivationalId,
                        principalSchema: "PortfolioASNS",
                        principalTable: "asnMotivationals",
                        principalColumn: "asnMotivationalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationalSkills_skillParams_asnSkillParamId",
                        column: x => x.asnSkillParamId,
                        principalSchema: "Portfolio",
                        principalTable: "skillParams",
                        principalColumn: "skillParamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnGroupJobs",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnGroupJobId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    asnGroupJoborgGroupId = table.Column<long>(type: "bigint", nullable: false),
                    asnGroupRefJobId = table.Column<int>(type: "int", nullable: false),
                    contributionPercentage = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    jobPriority = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnGroupJobs", x => x.asnGroupJobId);
                    table.ForeignKey(
                        name: "FK_asnGroupJobs_orgGroups_asnGroupJoborgGroupId",
                        column: x => x.asnGroupJoborgGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnGroupJobs_refJobs_asnGroupRefJobId",
                        column: x => x.asnGroupRefJobId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refJobs",
                        principalColumn: "refJobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnGroupRoles",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnOrgGroupId = table.Column<long>(type: "bigint", nullable: false),
                    asnOrgRoleId = table.Column<long>(type: "bigint", nullable: false),
                    asnGroupRoleId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnGroupRoles", x => new { x.asnOrgGroupId, x.asnOrgRoleId });
                    table.ForeignKey(
                        name: "FK_asnGroupRoles_orgGroups_asnOrgGroupId",
                        column: x => x.asnOrgGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnGroupRoles_orgRoles_asnOrgRoleId",
                        column: x => x.asnOrgRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnGroupSkills",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnOrgGroupId = table.Column<long>(type: "bigint", nullable: false),
                    asnSkillParamId = table.Column<long>(type: "bigint", nullable: false),
                    asnGroupSkillId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnGroupSkills", x => new { x.asnOrgGroupId, x.asnSkillParamId });
                    table.ForeignKey(
                        name: "FK_asnGroupSkills_orgGroups_asnOrgGroupId",
                        column: x => x.asnOrgGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnGroupSkills_skillParams_asnSkillParamId",
                        column: x => x.asnSkillParamId,
                        principalSchema: "Portfolio",
                        principalTable: "skillParams",
                        principalColumn: "skillParamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnIncidentEscalationRoleGroups",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnIncidentEscalationRoleGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    asnIncidentEsclationRoleId = table.Column<long>(type: "bigint", nullable: false),
                    asnIncidentEsclationGroupId = table.Column<long>(type: "bigint", nullable: true),
                    asnIncidentEsclationlLevelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnIncidentEscalationRoleGroups", x => x.asnIncidentEscalationRoleGroupId);
                    table.ForeignKey(
                        name: "FK_asnIncidentEscalationRoleGroups_incidentEscalationModel_asnIncidentEsclationlLevelId",
                        column: x => x.asnIncidentEsclationlLevelId,
                        principalSchema: "Portfolio",
                        principalTable: "incidentEscalationModel",
                        principalColumn: "incidentEsclationModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnIncidentEscalationRoleGroups_orgGroups_asnIncidentEsclationGroupId",
                        column: x => x.asnIncidentEsclationGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnIncidentEscalationRoleGroups_orgRoles_asnIncidentEsclationRoleId",
                        column: x => x.asnIncidentEsclationRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnMotivationalRoles",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnAuthorityLevelId = table.Column<int>(type: "int", nullable: false),
                    refAsnMotivationalId = table.Column<long>(type: "bigint", nullable: false),
                    stakeholderTypeId = table.Column<int>(type: "int", nullable: false),
                    stakeholderRoleId = table.Column<int>(type: "int", nullable: false),
                    stakeholderGroupId = table.Column<long>(type: "bigint", nullable: false),
                    asnMotivationalRoleId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    stakePercent = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnMotivationalRoles", x => new { x.asnAuthorityLevelId, x.refAsnMotivationalId, x.stakeholderTypeId, x.stakeholderRoleId, x.stakeholderGroupId });
                    table.ForeignKey(
                        name: "FK_asnMotivationalRoles_asnMotivationals_refAsnMotivationalId",
                        column: x => x.refAsnMotivationalId,
                        principalSchema: "PortfolioASNS",
                        principalTable: "asnMotivationals",
                        principalColumn: "asnMotivationalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationalRoles_mdAuthorityLevels_asnAuthorityLevelId",
                        column: x => x.asnAuthorityLevelId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAuthorityLevels",
                        principalColumn: "mdAuthorityLevelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationalRoles_mdStakes_stakeholderTypeId",
                        column: x => x.stakeholderTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdStakes",
                        principalColumn: "mdStakeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationalRoles_orgGroups_stakeholderGroupId",
                        column: x => x.stakeholderGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnMotivationalRoles_refRoles_stakeholderRoleId",
                        column: x => x.stakeholderRoleId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refRoles",
                        principalColumn: "refRoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnProjectStakeholders",
                schema: "VehiclesASNS",
                columns: table => new
                {
                    asnProjectStakeholderId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    asnStakeProjectMasterId = table.Column<long>(type: "bigint", nullable: true),
                    asnStakeOrgStructureId = table.Column<long>(type: "bigint", nullable: true),
                    asnStakeOrgGroupId = table.Column<long>(type: "bigint", nullable: true),
                    asnStakeOrgRoleId = table.Column<long>(type: "bigint", nullable: true),
                    asnStakeTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnProjectStakeholders", x => x.asnProjectStakeholderId);
                    table.ForeignKey(
                        name: "FK_asnProjectStakeholders_mdStakes_asnStakeTypeId",
                        column: x => x.asnStakeTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdStakes",
                        principalColumn: "mdStakeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectStakeholders_orgGroups_asnStakeOrgGroupId",
                        column: x => x.asnStakeOrgGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectStakeholders_orgRoles_asnStakeOrgRoleId",
                        column: x => x.asnStakeOrgRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectStakeholders_orgStructures_asnStakeOrgStructureId",
                        column: x => x.asnStakeOrgStructureId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnProjectStakeholders_projectMaster_asnStakeProjectMasterId",
                        column: x => x.asnStakeProjectMasterId,
                        principalSchema: "Vehicles",
                        principalTable: "projectMaster",
                        principalColumn: "projectMasterId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "governingEntities",
                schema: "Governance",
                columns: table => new
                {
                    governingEntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    governingEntityStructureId = table.Column<long>(type: "bigint", nullable: true),
                    governingEntityGroupId = table.Column<long>(type: "bigint", nullable: true),
                    governingEntityRoleId = table.Column<long>(type: "bigint", nullable: true),
                    governingRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governingEntities", x => x.governingEntityId);
                    table.ForeignKey(
                        name: "FK_governingEntities_orgGroups_governingEntityGroupId",
                        column: x => x.governingEntityGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_governingEntities_orgRoles_governingEntityRoleId",
                        column: x => x.governingEntityRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_governingEntities_orgStructures_governingEntityStructureId",
                        column: x => x.governingEntityStructureId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "incidentManagementStatuses",
                schema: "Portfolio",
                columns: table => new
                {
                    incidentManagementStatusId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statusNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    statusDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    incidentStatusRefId = table.Column<int>(type: "int", nullable: true),
                    assignedToOrgStructureId = table.Column<long>(type: "bigint", nullable: true),
                    assignedToOrgGroupId = table.Column<long>(type: "bigint", nullable: true),
                    assignedToOrgRoleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incidentManagementStatuses", x => x.incidentManagementStatusId);
                    table.ForeignKey(
                        name: "FK_incidentManagementStatuses_orgGroups_assignedToOrgGroupId",
                        column: x => x.assignedToOrgGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_incidentManagementStatuses_orgRoles_assignedToOrgRoleId",
                        column: x => x.assignedToOrgRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_incidentManagementStatuses_orgStructures_assignedToOrgStructureId",
                        column: x => x.assignedToOrgStructureId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_incidentManagementStatuses_refIncidentStatuses_incidentStatusRefId",
                        column: x => x.incidentStatusRefId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refIncidentStatuses",
                        principalColumn: "refIncidentStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnJobAssetAuths",
                schema: "PortfolioASNS",
                columns: table => new
                {
                    asnAuthAccessLevelId = table.Column<int>(type: "int", nullable: false),
                    asnAssetAuthRefJobId = table.Column<int>(type: "int", nullable: false),
                    asnAssetPortfolioId = table.Column<long>(type: "bigint", nullable: false),
                    asnJobAssetAuthId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    cascadeAuthToChildAssets = table.Column<bool>(type: "bit", nullable: true),
                    cascadeAuthTochildJobs = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnJobAssetAuths", x => new { x.asnAssetPortfolioId, x.asnAssetAuthRefJobId, x.asnAuthAccessLevelId });
                    table.ForeignKey(
                        name: "FK_asnJobAssetAuths_assetsPortfolio_asnAssetPortfolioId",
                        column: x => x.asnAssetPortfolioId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnJobAssetAuths_mdAuthAccessLevels_asnAuthAccessLevelId",
                        column: x => x.asnAuthAccessLevelId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAuthAccessLevels",
                        principalColumn: "mdAuthAccessLevelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnJobAssetAuths_refJobs_asnAssetAuthRefJobId",
                        column: x => x.asnAssetAuthRefJobId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refJobs",
                        principalColumn: "refJobId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "assetCapacityUtilizationRecords",
                schema: "Portfolio",
                columns: table => new
                {
                    assetCapacityUtilizationRecordId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assetRecordId = table.Column<long>(type: "bigint", nullable: false),
                    utilizationAsOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    utilizationEffeciency = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    utilizationPct = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assetCapacityUtilizationRecords", x => x.assetCapacityUtilizationRecordId);
                    table.ForeignKey(
                        name: "FK_assetCapacityUtilizationRecords_assetsPortfolio_assetRecordId",
                        column: x => x.assetRecordId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId");
                });

            migrationBuilder.CreateTable(
                name: "assetComplexRelationAnalysis",
                schema: "Portfolio",
                columns: table => new
                {
                    assetComplexRelationAnalysisId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    buildingBlockVitalityId = table.Column<int>(type: "int", nullable: true),
                    assetBuildingBlockId = table.Column<long>(type: "bigint", nullable: true),
                    buildingBlockCapacityUtilization = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    isAggregated = table.Column<bool>(type: "bit", nullable: true),
                    isChild = table.Column<bool>(type: "bit", nullable: true),
                    isComposed = table.Column<bool>(type: "bit", nullable: true),
                    buildingBlockNonAvailabilityImpactId = table.Column<int>(type: "int", nullable: true),
                    fullfilmentPercent = table.Column<decimal>(type: "decimal(6,2)", precision: 6, scale: 2, nullable: true),
                    sourceAssetId = table.Column<long>(type: "bigint", nullable: true),
                    fulfillmentWeightageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assetComplexRelationAnalysis", x => x.assetComplexRelationAnalysisId);
                    table.ForeignKey(
                        name: "FK_assetComplexRelationAnalysis_assetsPortfolio_assetBuildingBlockId",
                        column: x => x.assetBuildingBlockId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId");
                    table.ForeignKey(
                        name: "FK_assetComplexRelationAnalysis_assetsPortfolio_sourceAssetId",
                        column: x => x.sourceAssetId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetComplexRelationAnalysis_mdGeneralScales_buildingBlockVitalityId",
                        column: x => x.buildingBlockVitalityId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetComplexRelationAnalysis_mdGeneralScales_fulfillmentWeightageId",
                        column: x => x.fulfillmentWeightageId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_assetComplexRelationAnalysis_mdImpacts_buildingBlockNonAvailabilityImpactId",
                        column: x => x.buildingBlockNonAvailabilityImpactId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdImpacts",
                        principalColumn: "mdImpactId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "astraHistory",
                schema: "Portfolio",
                columns: table => new
                {
                    astraHistoryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    historyAction = table.Column<int>(type: "int", nullable: false),
                    historyDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    actionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actionByRoleId = table.Column<long>(type: "bigint", nullable: true),
                    actionByGroupId = table.Column<long>(type: "bigint", nullable: true),
                    actionByActorId = table.Column<long>(type: "bigint", nullable: true),
                    historyDriverId = table.Column<long>(type: "bigint", nullable: true),
                    historyDeliverableId = table.Column<long>(type: "bigint", nullable: true),
                    historyGoalId = table.Column<long>(type: "bigint", nullable: true),
                    historyMilestoneId = table.Column<long>(type: "bigint", nullable: true),
                    historyStructureId = table.Column<long>(type: "bigint", nullable: true),
                    historyAssetId = table.Column<long>(type: "bigint", nullable: true),
                    enterpriseElementId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_astraHistory", x => x.astraHistoryId);
                    table.ForeignKey(
                        name: "FK_astraHistory_assetsPortfolio_historyAssetId",
                        column: x => x.historyAssetId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_astraEnterpriseElements_enterpriseElementId",
                        column: x => x.enterpriseElementId,
                        principalSchema: "astraSYS",
                        principalTable: "astraEnterpriseElements",
                        principalColumn: "astraEnterpriseElementId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgActors_actionByActorId",
                        column: x => x.actionByActorId,
                        principalSchema: "Portfolio",
                        principalTable: "orgActors",
                        principalColumn: "orgActorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgDeliverables_historyDeliverableId",
                        column: x => x.historyDeliverableId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDeliverables",
                        principalColumn: "orgDeliverableId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgDrivers_historyDriverId",
                        column: x => x.historyDriverId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDrivers",
                        principalColumn: "orgDriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgGoals_historyGoalId",
                        column: x => x.historyGoalId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGoals",
                        principalColumn: "orgGoalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgGroups_actionByGroupId",
                        column: x => x.actionByGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgMilestones_historyMilestoneId",
                        column: x => x.historyMilestoneId,
                        principalSchema: "Portfolio",
                        principalTable: "orgMilestones",
                        principalColumn: "orgMilestoneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgRoles_actionByRoleId",
                        column: x => x.actionByRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_astraHistory_orgStructures_historyStructureId",
                        column: x => x.historyStructureId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "operationalExpenditures",
                schema: "Portfolio",
                columns: table => new
                {
                    operationalExpenditureId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    opExAmount = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    opExCurrency = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    operationalExpenditureTypeId = table.Column<int>(type: "int", nullable: true),
                    opExFrequencyID = table.Column<int>(type: "int", nullable: true),
                    opExDriverId = table.Column<long>(type: "bigint", nullable: true),
                    opExAssetId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operationalExpenditures", x => x.operationalExpenditureId);
                    table.ForeignKey(
                        name: "FK_operationalExpenditures_assetsPortfolio_opExAssetId",
                        column: x => x.opExAssetId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_operationalExpenditures_mdFrequencies_opExFrequencyID",
                        column: x => x.opExFrequencyID,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdFrequencies",
                        principalColumn: "mdFrequencyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_operationalExpenditures_orgDrivers_opExDriverId",
                        column: x => x.opExDriverId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDrivers",
                        principalColumn: "orgDriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_operationalExpenditures_refOpExTypes_operationalExpenditureTypeId",
                        column: x => x.operationalExpenditureTypeId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refOpExTypes",
                        principalColumn: "refOpExTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "procurementDetails",
                schema: "Portfolio",
                columns: table => new
                {
                    procurementDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    procurementAlertId = table.Column<long>(type: "bigint", nullable: true),
                    procurementTypeRefId = table.Column<int>(type: "int", nullable: false),
                    procurementPhaseId = table.Column<int>(type: "int", nullable: true),
                    procurementRealizationRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    procurementSourceRef = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    procurementSubjectDriverId = table.Column<long>(type: "bigint", nullable: true),
                    procurementSubjectMilestoneId = table.Column<long>(type: "bigint", nullable: true),
                    procurementSubjectAssetId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procurementDetails", x => x.procurementDetailId);
                    table.ForeignKey(
                        name: "FK_procurementDetails_alertServices_procurementAlertId",
                        column: x => x.procurementAlertId,
                        principalSchema: "Portfolio",
                        principalTable: "alertServices",
                        principalColumn: "alertServiceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_procurementDetails_assetsPortfolio_procurementSubjectAssetId",
                        column: x => x.procurementSubjectAssetId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_procurementDetails_mdPhases_procurementPhaseId",
                        column: x => x.procurementPhaseId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdPhases",
                        principalColumn: "mdPhaseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_procurementDetails_orgDrivers_procurementSubjectDriverId",
                        column: x => x.procurementSubjectDriverId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDrivers",
                        principalColumn: "orgDriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_procurementDetails_orgMilestones_procurementSubjectMilestoneId",
                        column: x => x.procurementSubjectMilestoneId,
                        principalSchema: "Portfolio",
                        principalTable: "orgMilestones",
                        principalColumn: "orgMilestoneId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_procurementDetails_refProcurementTypes_procurementTypeRefId",
                        column: x => x.procurementTypeRefId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refProcurementTypes",
                        principalColumn: "refProcurementTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "serviceLevels",
                schema: "Portfolio",
                columns: table => new
                {
                    serviceLevelId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    serviceLevelForAssetId = table.Column<long>(type: "bigint", nullable: true),
                    serviceLevelForAssetTypeId = table.Column<int>(type: "int", nullable: true),
                    serviceLevelSeverity = table.Column<int>(type: "int", nullable: true),
                    serviceLevelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maxResponseTime = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    maxResponseTimeUnitId = table.Column<int>(type: "int", nullable: true),
                    maxResolutionTime = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    maxResolutionTimeUnitId = table.Column<int>(type: "int", nullable: true),
                    parentServiceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    serviceEsclationModelId = table.Column<long>(type: "bigint", nullable: true),
                    serviceEsclationModelGroupId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviceLevels", x => x.serviceLevelId);
                    table.ForeignKey(
                        name: "FK_serviceLevels_assetsPortfolio_serviceLevelForAssetId",
                        column: x => x.serviceLevelForAssetId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId");
                    table.ForeignKey(
                        name: "FK_serviceLevels_incidentEscalationModelGroup_serviceEsclationModelGroupId",
                        column: x => x.serviceEsclationModelGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "incidentEscalationModelGroup",
                        principalColumn: "incidentEscalationModelGroupId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serviceLevels_incidentEscalationModel_serviceEsclationModelId",
                        column: x => x.serviceEsclationModelId,
                        principalSchema: "Portfolio",
                        principalTable: "incidentEscalationModel",
                        principalColumn: "incidentEsclationModelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serviceLevels_mdAssetTypes_serviceLevelForAssetTypeId",
                        column: x => x.serviceLevelForAssetTypeId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdAssetTypes",
                        principalColumn: "mdAssetTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serviceLevels_refTimeUnits_maxResolutionTimeUnitId",
                        column: x => x.maxResolutionTimeUnitId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refTimeUnits",
                        principalColumn: "refTimeUnitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serviceLevels_refTimeUnits_maxResponseTimeUnitId",
                        column: x => x.maxResponseTimeUnitId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refTimeUnits",
                        principalColumn: "refTimeUnitId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_serviceLevels_serviceLevels_parentServiceLevelId",
                        column: x => x.parentServiceLevelId,
                        principalSchema: "Portfolio",
                        principalTable: "serviceLevels",
                        principalColumn: "serviceLevelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "opExCostComponents",
                schema: "Portfolio",
                columns: table => new
                {
                    costComponentOfOpExId = table.Column<long>(type: "bigint", nullable: false),
                    costComponentRefId = table.Column<long>(type: "bigint", nullable: false),
                    componentCost = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_opExCostComponents", x => new { x.costComponentOfOpExId, x.costComponentRefId });
                    table.ForeignKey(
                        name: "FK_opExCostComponents_operationalExpenditures_costComponentOfOpExId",
                        column: x => x.costComponentOfOpExId,
                        principalSchema: "Portfolio",
                        principalTable: "operationalExpenditures",
                        principalColumn: "operationalExpenditureId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_opExCostComponents_refCostComponents_costComponentRefId",
                        column: x => x.costComponentRefId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refCostComponents",
                        principalColumn: "refCostComponentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "capExDetails",
                schema: "Portfolio",
                columns: table => new
                {
                    capExDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalCapExpenditure = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    refProcurementDetailId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capExDetails", x => x.capExDetailId);
                    table.ForeignKey(
                        name: "FK_capExDetails_procurementDetails_refProcurementDetailId",
                        column: x => x.refProcurementDetailId,
                        principalSchema: "Portfolio",
                        principalTable: "procurementDetails",
                        principalColumn: "procurementDetailId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cotsProcurementDetails",
                schema: "Portfolio",
                columns: table => new
                {
                    cotsProcurementDetailId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cotsProcurementCLTypeId = table.Column<int>(type: "int", nullable: true),
                    procurementdetailRefId = table.Column<long>(type: "bigint", nullable: true),
                    clName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clInit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    clExpiry = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cotsProcurementDetails", x => x.cotsProcurementDetailId);
                    table.ForeignKey(
                        name: "FK_cotsProcurementDetails_procurementDetails_procurementdetailRefId",
                        column: x => x.procurementdetailRefId,
                        principalSchema: "Portfolio",
                        principalTable: "procurementDetails",
                        principalColumn: "procurementDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cotsProcurementDetails_refCLTypes_cotsProcurementCLTypeId",
                        column: x => x.cotsProcurementCLTypeId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refCLTypes",
                        principalColumn: "refCLTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "governedEntities",
                schema: "Governance",
                columns: table => new
                {
                    governedEntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    governedEntityProcurementId = table.Column<long>(type: "bigint", nullable: true),
                    governedEntityProjectId = table.Column<long>(type: "bigint", nullable: true),
                    governedEntityDeliverableId = table.Column<long>(type: "bigint", nullable: true),
                    entityRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parentGovernedEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governedEntities", x => x.governedEntityId);
                    table.ForeignKey(
                        name: "FK_governedEntities_governedEntities_parentGovernedEntityId",
                        column: x => x.parentGovernedEntityId,
                        principalSchema: "Governance",
                        principalTable: "governedEntities",
                        principalColumn: "governedEntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_governedEntities_orgDeliverables_governedEntityDeliverableId",
                        column: x => x.governedEntityDeliverableId,
                        principalSchema: "Portfolio",
                        principalTable: "orgDeliverables",
                        principalColumn: "orgDeliverableId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_governedEntities_procurementDetails_governedEntityProcurementId",
                        column: x => x.governedEntityProcurementId,
                        principalSchema: "Portfolio",
                        principalTable: "procurementDetails",
                        principalColumn: "procurementDetailId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_governedEntities_projectMaster_governedEntityProjectId",
                        column: x => x.governedEntityProjectId,
                        principalSchema: "Vehicles",
                        principalTable: "projectMaster",
                        principalColumn: "projectMasterId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "procurementDocs",
                schema: "Portfolio",
                columns: table => new
                {
                    procurementDocId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    refProcurementDetailId = table.Column<long>(type: "bigint", nullable: true),
                    procurementDocumentTypeId = table.Column<int>(type: "int", nullable: true),
                    procurementDocName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    procurementDocNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    procurementDocLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procurementDocs", x => x.procurementDocId);
                    table.ForeignKey(
                        name: "FK_procurementDocs_procurementDetails_refProcurementDetailId",
                        column: x => x.refProcurementDetailId,
                        principalSchema: "Portfolio",
                        principalTable: "procurementDetails",
                        principalColumn: "procurementDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_procurementDocs_refProcurementDocumentTypes_procurementDocumentTypeId",
                        column: x => x.procurementDocumentTypeId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refProcurementDocumentTypes",
                        principalColumn: "refProcurementDocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "incidentManagementRecords",
                schema: "Portfolio",
                columns: table => new
                {
                    incidentManagementRecordId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    incidentRecordDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    incidentDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    incidentImpactId = table.Column<int>(type: "int", nullable: true),
                    incidentPriorityId = table.Column<int>(type: "int", nullable: true),
                    incidentManagementRecordServiceLevelId = table.Column<long>(type: "bigint", nullable: true),
                    incidentManagementRecordStatusId = table.Column<long>(type: "bigint", nullable: false),
                    incidentSubjectId = table.Column<long>(type: "bigint", nullable: true),
                    parentIncidentId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incidentManagementRecords", x => x.incidentManagementRecordId);
                    table.ForeignKey(
                        name: "FK_incidentManagementRecords_assetsPortfolio_incidentSubjectId",
                        column: x => x.incidentSubjectId,
                        principalSchema: "Portfolio",
                        principalTable: "assetsPortfolio",
                        principalColumn: "assetPortfolioId");
                    table.ForeignKey(
                        name: "FK_incidentManagementRecords_incidentManagementRecords_parentIncidentId",
                        column: x => x.parentIncidentId,
                        principalSchema: "Portfolio",
                        principalTable: "incidentManagementRecords",
                        principalColumn: "incidentManagementRecordId");
                    table.ForeignKey(
                        name: "FK_incidentManagementRecords_incidentManagementStatuses_incidentManagementRecordStatusId",
                        column: x => x.incidentManagementRecordStatusId,
                        principalSchema: "Portfolio",
                        principalTable: "incidentManagementStatuses",
                        principalColumn: "incidentManagementStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_incidentManagementRecords_mdGeneralScales_incidentPriorityId",
                        column: x => x.incidentPriorityId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdGeneralScales",
                        principalColumn: "mdGeneralScaleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_incidentManagementRecords_mdImpacts_incidentImpactId",
                        column: x => x.incidentImpactId,
                        principalSchema: "PortfolioMaster",
                        principalTable: "mdImpacts",
                        principalColumn: "mdImpactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_incidentManagementRecords_serviceLevels_incidentManagementRecordServiceLevelId",
                        column: x => x.incidentManagementRecordServiceLevelId,
                        principalSchema: "Portfolio",
                        principalTable: "serviceLevels",
                        principalColumn: "serviceLevelId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "capExCostComponents",
                schema: "Portfolio",
                columns: table => new
                {
                    refCapExDetailId = table.Column<long>(type: "bigint", nullable: false),
                    costComponentId = table.Column<long>(type: "bigint", nullable: false),
                    capExCost = table.Column<decimal>(type: "decimal(15,2)", precision: 15, scale: 2, nullable: true),
                    capExCurrencyCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_capExCostComponents", x => new { x.refCapExDetailId, x.costComponentId });
                    table.ForeignKey(
                        name: "FK_capExCostComponents_capExDetails_refCapExDetailId",
                        column: x => x.refCapExDetailId,
                        principalSchema: "Portfolio",
                        principalTable: "capExDetails",
                        principalColumn: "capExDetailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_capExCostComponents_refCostComponents_costComponentId",
                        column: x => x.costComponentId,
                        principalSchema: "PortfolioRef",
                        principalTable: "refCostComponents",
                        principalColumn: "refCostComponentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnGovernedEntityStandards",
                schema: "GovernanceASNS",
                columns: table => new
                {
                    asnGovernedEntityStandardId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    asnGovernedEntityId = table.Column<long>(type: "bigint", nullable: true),
                    asnGoverningStandardId = table.Column<int>(type: "int", nullable: true),
                    requiredComplianceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnGovernedEntityStandards", x => x.asnGovernedEntityStandardId);
                    table.ForeignKey(
                        name: "FK_asnGovernedEntityStandards_governedEntities_asnGovernedEntityId",
                        column: x => x.asnGovernedEntityId,
                        principalSchema: "Governance",
                        principalTable: "governedEntities",
                        principalColumn: "governedEntityId",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_asnGovernedEntityStandards_mdGovernanceComplianceLevels_requiredComplianceId",
                        column: x => x.requiredComplianceId,
                        principalSchema: "GovernanceMaster",
                        principalTable: "mdGovernanceComplianceLevels",
                        principalColumn: "mdGovernanceComplianceLevelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_asnGovernedEntityStandards_mdStandardsGuidelines_asnGoverningStandardId",
                        column: x => x.asnGoverningStandardId,
                        principalSchema: "GovernanceMaster",
                        principalTable: "mdStandardsGuidelines",
                        principalColumn: "mdStandardGuidelineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "asnGovernedGovernings",
                schema: "GovernanceASNS",
                columns: table => new
                {
                    asnGovernedEntityId = table.Column<long>(type: "bigint", nullable: false),
                    asnGoverningEntityId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnGovernedGovernings", x => new { x.asnGovernedEntityId, x.asnGoverningEntityId });
                    table.ForeignKey(
                        name: "FK_asnGovernedGovernings_governedEntities_asnGovernedEntityId",
                        column: x => x.asnGovernedEntityId,
                        principalSchema: "Governance",
                        principalTable: "governedEntities",
                        principalColumn: "governedEntityId");
                    table.ForeignKey(
                        name: "FK_asnGovernedGovernings_governingEntities_asnGoverningEntityId",
                        column: x => x.asnGoverningEntityId,
                        principalSchema: "Governance",
                        principalTable: "governingEntities",
                        principalColumn: "governingEntityId");
                });

            migrationBuilder.CreateTable(
                name: "governanceLogs",
                schema: "Governance",
                columns: table => new
                {
                    governanceLogId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    governanceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    governanceSubjectId = table.Column<long>(type: "bigint", nullable: true),
                    governanceResultId = table.Column<int>(type: "int", nullable: true),
                    governanceRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governanceLogs", x => x.governanceLogId);
                    table.ForeignKey(
                        name: "FK_governanceLogs_governedEntities_governanceSubjectId",
                        column: x => x.governanceSubjectId,
                        principalSchema: "Governance",
                        principalTable: "governedEntities",
                        principalColumn: "governedEntityId");
                    table.ForeignKey(
                        name: "FK_governanceLogs_mdGovernanceComplianceLevels_governanceResultId",
                        column: x => x.governanceResultId,
                        principalSchema: "GovernanceMaster",
                        principalTable: "mdGovernanceComplianceLevels",
                        principalColumn: "mdGovernanceComplianceLevelId");
                });

            migrationBuilder.CreateTable(
                name: "incidentManagementAttachments",
                schema: "Portfolio",
                columns: table => new
                {
                    incidentManagementAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    incidentAttachment = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    attachmentChecksum = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    attachmentDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    attachmentNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    attachmentOfManagementRecordId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incidentManagementAttachments", x => x.incidentManagementAttachmentId);
                    table.ForeignKey(
                        name: "FK_incidentManagementAttachments_incidentManagementRecords_attachmentOfManagementRecordId",
                        column: x => x.attachmentOfManagementRecordId,
                        principalSchema: "Portfolio",
                        principalTable: "incidentManagementRecords",
                        principalColumn: "incidentManagementRecordId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "asnGoverningEntityLogs",
                schema: "GovernanceASNS",
                columns: table => new
                {
                    asnGoverningEntityId = table.Column<long>(type: "bigint", nullable: false),
                    asnGovernanceLogId = table.Column<long>(type: "bigint", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    governingEntitySignature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnGoverningEntityLogs", x => new { x.asnGovernanceLogId, x.asnGoverningEntityId });
                    table.ForeignKey(
                        name: "FK_asnGoverningEntityLogs_governanceLogs_asnGovernanceLogId",
                        column: x => x.asnGovernanceLogId,
                        principalSchema: "Governance",
                        principalTable: "governanceLogs",
                        principalColumn: "governanceLogId");
                    table.ForeignKey(
                        name: "FK_asnGoverningEntityLogs_governingEntities_asnGoverningEntityId",
                        column: x => x.asnGoverningEntityId,
                        principalSchema: "Governance",
                        principalTable: "governingEntities",
                        principalColumn: "governingEntityId");
                });

            migrationBuilder.CreateTable(
                name: "dispensationRecords",
                schema: "Governance",
                columns: table => new
                {
                    dispensationRecordId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    preGovernanceDispensationId = table.Column<long>(type: "bigint", nullable: true),
                    postGovernanceDispensationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dispensationRecords", x => x.dispensationRecordId);
                    table.ForeignKey(
                        name: "FK_dispensationRecords_governanceLogs_postGovernanceDispensationId",
                        column: x => x.postGovernanceDispensationId,
                        principalSchema: "Governance",
                        principalTable: "governanceLogs",
                        principalColumn: "governanceLogId");
                    table.ForeignKey(
                        name: "FK_dispensationRecords_governedEntities_preGovernanceDispensationId",
                        column: x => x.preGovernanceDispensationId,
                        principalSchema: "Governance",
                        principalTable: "governedEntities",
                        principalColumn: "governedEntityId");
                });

            migrationBuilder.CreateTable(
                name: "governanceOutputs",
                schema: "Governance",
                columns: table => new
                {
                    governanceOutputId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    outPutCreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    governanceOutputLogId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governanceOutputs", x => x.governanceOutputId);
                    table.ForeignKey(
                        name: "FK_governanceOutputs_governanceLogs_governanceOutputLogId",
                        column: x => x.governanceOutputLogId,
                        principalSchema: "Governance",
                        principalTable: "governanceLogs",
                        principalColumn: "governanceLogId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "asnDispensationApprovals",
                schema: "GovernanceASNS",
                columns: table => new
                {
                    asnDispensationApprovalId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    dispensationApprovalStructureId = table.Column<long>(type: "bigint", nullable: true),
                    dispensationAprovalGroupId = table.Column<long>(type: "bigint", nullable: true),
                    dispensationAprovalRoleId = table.Column<long>(type: "bigint", nullable: true),
                    dispensationForApprovalAsnId = table.Column<long>(type: "bigint", nullable: true),
                    dispensationApprovalDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dispensationApproverSignature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnDispensationApprovals", x => x.asnDispensationApprovalId);
                    table.ForeignKey(
                        name: "FK_asnDispensationApprovals_dispensationRecords_dispensationForApprovalAsnId",
                        column: x => x.dispensationForApprovalAsnId,
                        principalSchema: "Governance",
                        principalTable: "dispensationRecords",
                        principalColumn: "dispensationRecordId");
                    table.ForeignKey(
                        name: "FK_asnDispensationApprovals_orgGroups_dispensationAprovalGroupId",
                        column: x => x.dispensationAprovalGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId");
                    table.ForeignKey(
                        name: "FK_asnDispensationApprovals_orgRoles_dispensationAprovalRoleId",
                        column: x => x.dispensationAprovalRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId");
                    table.ForeignKey(
                        name: "FK_asnDispensationApprovals_orgStructures_dispensationApprovalStructureId",
                        column: x => x.dispensationApprovalStructureId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId");
                });

            migrationBuilder.CreateTable(
                name: "asnDispensationRequestors",
                schema: "GovernanceASNS",
                columns: table => new
                {
                    asnDispensationRequestorId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    dispensationRequestorStructureId = table.Column<long>(type: "bigint", nullable: true),
                    dispensationRequestorGroupId = table.Column<long>(type: "bigint", nullable: true),
                    dispensationRequestorRoleId = table.Column<long>(type: "bigint", nullable: true),
                    dispensationRequestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    dispensationOfRequestorId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asnDispensationRequestors", x => x.asnDispensationRequestorId);
                    table.ForeignKey(
                        name: "FK_asnDispensationRequestors_dispensationRecords_dispensationOfRequestorId",
                        column: x => x.dispensationOfRequestorId,
                        principalSchema: "Governance",
                        principalTable: "dispensationRecords",
                        principalColumn: "dispensationRecordId");
                    table.ForeignKey(
                        name: "FK_asnDispensationRequestors_orgGroups_dispensationRequestorGroupId",
                        column: x => x.dispensationRequestorGroupId,
                        principalSchema: "Portfolio",
                        principalTable: "orgGroups",
                        principalColumn: "orgGroupId");
                    table.ForeignKey(
                        name: "FK_asnDispensationRequestors_orgRoles_dispensationRequestorRoleId",
                        column: x => x.dispensationRequestorRoleId,
                        principalSchema: "Portfolio",
                        principalTable: "orgRoles",
                        principalColumn: "orgRoleId");
                    table.ForeignKey(
                        name: "FK_asnDispensationRequestors_orgStructures_dispensationRequestorStructureId",
                        column: x => x.dispensationRequestorStructureId,
                        principalSchema: "Portfolio",
                        principalTable: "orgStructures",
                        principalColumn: "orgStructureId");
                });

            migrationBuilder.CreateTable(
                name: "governanceAttachments",
                schema: "Governance",
                columns: table => new
                {
                    governanceAttachmentId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    governanceAttachmentForOutputId = table.Column<long>(type: "bigint", nullable: true),
                    attachmentContent = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_governanceAttachments", x => x.governanceAttachmentId);
                    table.ForeignKey(
                        name: "FK_governanceAttachments_governanceOutputs_governanceAttachmentForOutputId",
                        column: x => x.governanceAttachmentForOutputId,
                        principalSchema: "Governance",
                        principalTable: "governanceOutputs",
                        principalColumn: "governanceOutputId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_alertServices_alertFrequencyId",
                schema: "Portfolio",
                table: "alertServices",
                column: "alertFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_alertServices_alertIntervalId",
                schema: "Portfolio",
                table: "alertServices",
                column: "alertIntervalId");

            migrationBuilder.CreateIndex(
                name: "IX_asnActorRoles_asnOrgActorId_asnOrgRoleId",
                schema: "PortfolioASNS",
                table: "asnActorRoles",
                columns: new[] { "asnOrgActorId", "asnOrgRoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_asnActorRoles_asnOrgRoleId",
                schema: "PortfolioASNS",
                table: "asnActorRoles",
                column: "asnOrgRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnActorSkills_asnSkillParamId",
                schema: "PortfolioASNS",
                table: "asnActorSkills",
                column: "asnSkillParamId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDataSourceAccessTypes_asnAccessTypeId",
                schema: "astraSYSASNS",
                table: "asnDataSourceAccessTypes",
                column: "asnAccessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDataSourceAccessTypes_asnDataSourceId",
                schema: "astraSYSASNS",
                table: "asnDataSourceAccessTypes",
                column: "asnDataSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDataSourceAccessTypes_asnDataSourcePriorityId",
                schema: "astraSYSASNS",
                table: "asnDataSourceAccessTypes",
                column: "asnDataSourcePriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationApprovals_dispensationApprovalStructureId_dispensationAprovalGroupId_dispensationAprovalRoleId",
                schema: "GovernanceASNS",
                table: "asnDispensationApprovals",
                columns: new[] { "dispensationApprovalStructureId", "dispensationAprovalGroupId", "dispensationAprovalRoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationApprovals_dispensationAprovalGroupId",
                schema: "GovernanceASNS",
                table: "asnDispensationApprovals",
                column: "dispensationAprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationApprovals_dispensationAprovalRoleId",
                schema: "GovernanceASNS",
                table: "asnDispensationApprovals",
                column: "dispensationAprovalRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationApprovals_dispensationForApprovalAsnId",
                schema: "GovernanceASNS",
                table: "asnDispensationApprovals",
                column: "dispensationForApprovalAsnId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationRequestors_dispensationOfRequestorId",
                schema: "GovernanceASNS",
                table: "asnDispensationRequestors",
                column: "dispensationOfRequestorId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationRequestors_dispensationRequestorGroupId",
                schema: "GovernanceASNS",
                table: "asnDispensationRequestors",
                column: "dispensationRequestorGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationRequestors_dispensationRequestorRoleId",
                schema: "GovernanceASNS",
                table: "asnDispensationRequestors",
                column: "dispensationRequestorRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnDispensationRequestors_dispensationRequestorStructureId_dispensationRequestorGroupId_dispensationRequestorRoleId",
                schema: "GovernanceASNS",
                table: "asnDispensationRequestors",
                columns: new[] { "dispensationRequestorStructureId", "dispensationRequestorGroupId", "dispensationRequestorRoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_asnEnterpriseElementsDataSources_asnEnterpriseElementId",
                schema: "astraSYSASNS",
                table: "asnEnterpriseElementsDataSources",
                column: "asnEnterpriseElementId");

            migrationBuilder.CreateIndex(
                name: "IX_asnGovernedEntityStandards_asnGovernedEntityId",
                schema: "GovernanceASNS",
                table: "asnGovernedEntityStandards",
                column: "asnGovernedEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_asnGovernedEntityStandards_asnGoverningStandardId_requiredComplianceId",
                schema: "GovernanceASNS",
                table: "asnGovernedEntityStandards",
                columns: new[] { "asnGoverningStandardId", "requiredComplianceId" });

            migrationBuilder.CreateIndex(
                name: "IX_asnGovernedEntityStandards_requiredComplianceId",
                schema: "GovernanceASNS",
                table: "asnGovernedEntityStandards",
                column: "requiredComplianceId");

            migrationBuilder.CreateIndex(
                name: "IX_asnGovernedGovernings_asnGoverningEntityId",
                schema: "GovernanceASNS",
                table: "asnGovernedGovernings",
                column: "asnGoverningEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_asnGoverningEntityLogs_asnGoverningEntityId",
                schema: "GovernanceASNS",
                table: "asnGoverningEntityLogs",
                column: "asnGoverningEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_asnGroupJobs_asnGroupJoborgGroupId_asnGroupRefJobId",
                schema: "PortfolioASNS",
                table: "asnGroupJobs",
                columns: new[] { "asnGroupJoborgGroupId", "asnGroupRefJobId" });

            migrationBuilder.CreateIndex(
                name: "IX_asnGroupJobs_asnGroupRefJobId",
                schema: "PortfolioASNS",
                table: "asnGroupJobs",
                column: "asnGroupRefJobId");

            migrationBuilder.CreateIndex(
                name: "IX_asnGroupRoles_asnOrgRoleId",
                schema: "PortfolioASNS",
                table: "asnGroupRoles",
                column: "asnOrgRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnGroupSkills_asnSkillParamId",
                schema: "PortfolioASNS",
                table: "asnGroupSkills",
                column: "asnSkillParamId");

            migrationBuilder.CreateIndex(
                name: "IX_asnIncidentEscalationRoleGroups_asnIncidentEsclationGroupId",
                schema: "PortfolioASNS",
                table: "asnIncidentEscalationRoleGroups",
                column: "asnIncidentEsclationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_asnIncidentEscalationRoleGroups_asnIncidentEsclationlLevelId",
                schema: "PortfolioASNS",
                table: "asnIncidentEscalationRoleGroups",
                column: "asnIncidentEsclationlLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_asnIncidentEscalationRoleGroups_asnIncidentEsclationRoleId",
                schema: "PortfolioASNS",
                table: "asnIncidentEscalationRoleGroups",
                column: "asnIncidentEsclationRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnInformationObjectEnterpriseElements_asnInformationObjectId",
                schema: "astraSYSASNS",
                table: "asnInformationObjectEnterpriseElements",
                column: "asnInformationObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_asnJobAssetAuths_asnAssetAuthRefJobId",
                schema: "PortfolioASNS",
                table: "asnJobAssetAuths",
                column: "asnAssetAuthRefJobId");

            migrationBuilder.CreateIndex(
                name: "IX_asnJobAssetAuths_asnAuthAccessLevelId",
                schema: "PortfolioASNS",
                table: "asnJobAssetAuths",
                column: "asnAuthAccessLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_asnJobDeliverables_asnJobId",
                schema: "PortfolioASNS",
                table: "asnJobDeliverables",
                column: "asnJobId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationalRoles_refAsnMotivationalId",
                schema: "PortfolioASNS",
                table: "asnMotivationalRoles",
                column: "refAsnMotivationalId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationalRoles_stakeholderGroupId",
                schema: "PortfolioASNS",
                table: "asnMotivationalRoles",
                column: "stakeholderGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationalRoles_stakeholderRoleId",
                schema: "PortfolioASNS",
                table: "asnMotivationalRoles",
                column: "stakeholderRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationalRoles_stakeholderTypeId",
                schema: "PortfolioASNS",
                table: "asnMotivationalRoles",
                column: "stakeholderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationals_asnDeliverableId",
                schema: "PortfolioASNS",
                table: "asnMotivationals",
                column: "asnDeliverableId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationals_asnGoalId",
                schema: "PortfolioASNS",
                table: "asnMotivationals",
                column: "asnGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationals_asnMilestoneId",
                schema: "PortfolioASNS",
                table: "asnMotivationals",
                column: "asnMilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationals_asnOperationId",
                schema: "PortfolioASNS",
                table: "asnMotivationals",
                column: "asnOperationId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationals_asnOrgDriverId",
                schema: "PortfolioASNS",
                table: "asnMotivationals",
                column: "asnOrgDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationals_asnOrgStructureId",
                schema: "PortfolioASNS",
                table: "asnMotivationals",
                column: "asnOrgStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationals_thisPriorityId",
                schema: "PortfolioASNS",
                table: "asnMotivationals",
                column: "thisPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationalSkills_asnSkillParamId",
                schema: "PortfolioASNS",
                table: "asnMotivationalSkills",
                column: "asnSkillParamId");

            migrationBuilder.CreateIndex(
                name: "IX_asnMotivationalSkills_refAsnMotivationalId",
                schema: "PortfolioASNS",
                table: "asnMotivationalSkills",
                column: "refAsnMotivationalId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectCostComponentBudgets_asnCostComponentId",
                schema: "VehiclesASNS",
                table: "asnProjectCostComponentBudgets",
                column: "asnCostComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectOriginsMaster_asnProjectOriginId",
                schema: "VehiclesASNS",
                table: "asnProjectOriginsMaster",
                column: "asnProjectOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectOutputs_asnProjectDeliverableId",
                schema: "VehiclesASNS",
                table: "asnProjectOutputs",
                column: "asnProjectDeliverableId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectOutputs_asnProjectGoalId",
                schema: "VehiclesASNS",
                table: "asnProjectOutputs",
                column: "asnProjectGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectOutputs_asnProjectMasterId_asnProjectGoalId_asnProjectMilestoneId_asnProjectDeliverableId",
                schema: "VehiclesASNS",
                table: "asnProjectOutputs",
                columns: new[] { "asnProjectMasterId", "asnProjectGoalId", "asnProjectMilestoneId", "asnProjectDeliverableId" });

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectOutputs_asnProjectMilestoneId",
                schema: "VehiclesASNS",
                table: "asnProjectOutputs",
                column: "asnProjectMilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectStakeholders_asnStakeOrgGroupId",
                schema: "VehiclesASNS",
                table: "asnProjectStakeholders",
                column: "asnStakeOrgGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectStakeholders_asnStakeOrgRoleId",
                schema: "VehiclesASNS",
                table: "asnProjectStakeholders",
                column: "asnStakeOrgRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectStakeholders_asnStakeOrgStructureId",
                schema: "VehiclesASNS",
                table: "asnProjectStakeholders",
                column: "asnStakeOrgStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectStakeholders_asnStakeProjectMasterId_asnStakeOrgStructureId_asnStakeOrgGroupId_asnStakeOrgRoleId",
                schema: "VehiclesASNS",
                table: "asnProjectStakeholders",
                columns: new[] { "asnStakeProjectMasterId", "asnStakeOrgStructureId", "asnStakeOrgGroupId", "asnStakeOrgRoleId" });

            migrationBuilder.CreateIndex(
                name: "IX_asnProjectStakeholders_asnStakeTypeId",
                schema: "VehiclesASNS",
                table: "asnProjectStakeholders",
                column: "asnStakeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_asnRoleJobs_asnRoleId",
                schema: "PortfolioASNS",
                table: "asnRoleJobs",
                column: "asnRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_asnRoleSkill_asnSkillParamId",
                schema: "PortfolioASNS",
                table: "asnRoleSkill",
                column: "asnSkillParamId");

            migrationBuilder.CreateIndex(
                name: "IX_assetCapacityUtilizationRecords_assetRecordId",
                schema: "Portfolio",
                table: "assetCapacityUtilizationRecords",
                column: "assetRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_assetComplexRelationAnalysis_assetBuildingBlockId",
                schema: "Portfolio",
                table: "assetComplexRelationAnalysis",
                column: "assetBuildingBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_assetComplexRelationAnalysis_buildingBlockNonAvailabilityImpactId",
                schema: "Portfolio",
                table: "assetComplexRelationAnalysis",
                column: "buildingBlockNonAvailabilityImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_assetComplexRelationAnalysis_buildingBlockVitalityId",
                schema: "Portfolio",
                table: "assetComplexRelationAnalysis",
                column: "buildingBlockVitalityId");

            migrationBuilder.CreateIndex(
                name: "IX_assetComplexRelationAnalysis_fulfillmentWeightageId",
                schema: "Portfolio",
                table: "assetComplexRelationAnalysis",
                column: "fulfillmentWeightageId");

            migrationBuilder.CreateIndex(
                name: "IX_assetComplexRelationAnalysis_sourceAssetId",
                schema: "Portfolio",
                table: "assetComplexRelationAnalysis",
                column: "sourceAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetCapacityDesignId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetCapacityDesignId",
                unique: true,
                filter: "[assetCapacityDesignId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetCategoryId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetComplexityId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetComplexityId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetManagerId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetOwnerId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetPortfolioCategoryId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetPortfolioCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetStatusId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetTypeId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_assetVolumeId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "assetVolumeId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_cumulativeDependencyImpactId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "cumulativeDependencyImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_cumulativeVitalityIndicatorId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "cumulativeVitalityIndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_parentAssetId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "parentAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_assetsPortfolio_utilizationMonitorFrequencyId",
                schema: "Portfolio",
                table: "assetsPortfolio",
                column: "utilizationMonitorFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_actionByActorId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "actionByActorId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_actionByGroupId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "actionByGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_actionByRoleId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "actionByRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_enterpriseElementId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "enterpriseElementId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_historyAssetId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "historyAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_historyDeliverableId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "historyDeliverableId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_historyDriverId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "historyDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_historyGoalId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "historyGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_historyMilestoneId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "historyMilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_astraHistory_historyStructureId",
                schema: "Portfolio",
                table: "astraHistory",
                column: "historyStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_astraInformationObjects_informationSchemaId",
                schema: "astraSYS",
                table: "astraInformationObjects",
                column: "informationSchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_capacityDesigns_capacityMeasurementUnitId",
                schema: "Portfolio",
                table: "capacityDesigns",
                column: "capacityMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_capacitySpendings_assetCapacitySpendingId",
                schema: "Portfolio",
                table: "capacitySpendings",
                column: "assetCapacitySpendingId");

            migrationBuilder.CreateIndex(
                name: "IX_capacitySpendings_capacitySpendingMeasurementId",
                schema: "Portfolio",
                table: "capacitySpendings",
                column: "capacitySpendingMeasurementId",
                unique: true,
                filter: "[capacitySpendingMeasurementId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_capExCostComponents_costComponentId",
                schema: "Portfolio",
                table: "capExCostComponents",
                column: "costComponentId");

            migrationBuilder.CreateIndex(
                name: "IX_capExDetails_refProcurementDetailId",
                schema: "Portfolio",
                table: "capExDetails",
                column: "refProcurementDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_cotsProcurementDetails_cotsProcurementCLTypeId",
                schema: "Portfolio",
                table: "cotsProcurementDetails",
                column: "cotsProcurementCLTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_cotsProcurementDetails_procurementdetailRefId",
                schema: "Portfolio",
                table: "cotsProcurementDetails",
                column: "procurementdetailRefId");

            migrationBuilder.CreateIndex(
                name: "IX_dispensationRecords_postGovernanceDispensationId",
                schema: "Governance",
                table: "dispensationRecords",
                column: "postGovernanceDispensationId");

            migrationBuilder.CreateIndex(
                name: "IX_dispensationRecords_preGovernanceDispensationId",
                schema: "Governance",
                table: "dispensationRecords",
                column: "preGovernanceDispensationId");

            migrationBuilder.CreateIndex(
                name: "IX_governanceAttachments_governanceAttachmentForOutputId",
                schema: "Governance",
                table: "governanceAttachments",
                column: "governanceAttachmentForOutputId");

            migrationBuilder.CreateIndex(
                name: "IX_governanceLogs_governanceResultId",
                schema: "Governance",
                table: "governanceLogs",
                column: "governanceResultId");

            migrationBuilder.CreateIndex(
                name: "IX_governanceLogs_governanceSubjectId",
                schema: "Governance",
                table: "governanceLogs",
                column: "governanceSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_governanceOutputs_governanceOutputLogId",
                schema: "Governance",
                table: "governanceOutputs",
                column: "governanceOutputLogId");

            migrationBuilder.CreateIndex(
                name: "IX_governedEntities_governedEntityDeliverableId",
                schema: "Governance",
                table: "governedEntities",
                column: "governedEntityDeliverableId");

            migrationBuilder.CreateIndex(
                name: "IX_governedEntities_governedEntityProcurementId",
                schema: "Governance",
                table: "governedEntities",
                column: "governedEntityProcurementId");

            migrationBuilder.CreateIndex(
                name: "IX_governedEntities_governedEntityProjectId",
                schema: "Governance",
                table: "governedEntities",
                column: "governedEntityProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_governedEntities_parentGovernedEntityId",
                schema: "Governance",
                table: "governedEntities",
                column: "parentGovernedEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_governingEntities_governingEntityGroupId",
                schema: "Governance",
                table: "governingEntities",
                column: "governingEntityGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_governingEntities_governingEntityRoleId",
                schema: "Governance",
                table: "governingEntities",
                column: "governingEntityRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_governingEntities_governingEntityStructureId",
                schema: "Governance",
                table: "governingEntities",
                column: "governingEntityStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentEscalationModel_incidentEsclationGroupId",
                schema: "Portfolio",
                table: "incidentEscalationModel",
                column: "incidentEsclationGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementAttachments_attachmentOfManagementRecordId",
                schema: "Portfolio",
                table: "incidentManagementAttachments",
                column: "attachmentOfManagementRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementRecords_incidentImpactId",
                schema: "Portfolio",
                table: "incidentManagementRecords",
                column: "incidentImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementRecords_incidentManagementRecordId_incidentManagementRecordStatusId_incidentSubjectId",
                schema: "Portfolio",
                table: "incidentManagementRecords",
                columns: new[] { "incidentManagementRecordId", "incidentManagementRecordStatusId", "incidentSubjectId" },
                unique: true,
                filter: "[incidentSubjectId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementRecords_incidentManagementRecordServiceLevelId",
                schema: "Portfolio",
                table: "incidentManagementRecords",
                column: "incidentManagementRecordServiceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementRecords_incidentManagementRecordStatusId",
                schema: "Portfolio",
                table: "incidentManagementRecords",
                column: "incidentManagementRecordStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementRecords_incidentPriorityId",
                schema: "Portfolio",
                table: "incidentManagementRecords",
                column: "incidentPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementRecords_incidentSubjectId",
                schema: "Portfolio",
                table: "incidentManagementRecords",
                column: "incidentSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementRecords_parentIncidentId",
                schema: "Portfolio",
                table: "incidentManagementRecords",
                column: "parentIncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementStatuses_assignedToOrgGroupId",
                schema: "Portfolio",
                table: "incidentManagementStatuses",
                column: "assignedToOrgGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementStatuses_assignedToOrgRoleId",
                schema: "Portfolio",
                table: "incidentManagementStatuses",
                column: "assignedToOrgRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementStatuses_assignedToOrgStructureId",
                schema: "Portfolio",
                table: "incidentManagementStatuses",
                column: "assignedToOrgStructureId");

            migrationBuilder.CreateIndex(
                name: "IX_incidentManagementStatuses_incidentStatusRefId",
                schema: "Portfolio",
                table: "incidentManagementStatuses",
                column: "incidentStatusRefId");

            migrationBuilder.CreateIndex(
                name: "IX_informationObjectFields_fieldTypeId",
                schema: "astraSYS",
                table: "informationObjectFields",
                column: "fieldTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_informationObjectFields_informationObjectRefId",
                schema: "astraSYS",
                table: "informationObjectFields",
                column: "informationObjectRefId");

            migrationBuilder.CreateIndex(
                name: "IX_locPhones_locPhoneTypeId",
                schema: "Portfolio",
                table: "locPhones",
                column: "locPhoneTypeId",
                unique: true,
                filter: "[locPhoneTypeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_locPhones_orgLocationId",
                schema: "Portfolio",
                table: "locPhones",
                column: "orgLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_mdActorTypes_parentActorTypeId",
                schema: "PortfolioMaster",
                table: "mdActorTypes",
                column: "parentActorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_mdAssetTypes_parentAssetID",
                schema: "PortfolioMaster",
                table: "mdAssetTypes",
                column: "parentAssetID");

            migrationBuilder.CreateIndex(
                name: "IX_mdAuthAccessLevels_authorityLevelId",
                schema: "PortfolioMaster",
                table: "mdAuthAccessLevels",
                column: "authorityLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_mdAuthAccessLevels_stakeThreshold",
                schema: "PortfolioMaster",
                table: "mdAuthAccessLevels",
                column: "stakeThreshold",
                unique: true,
                filter: "[stakeThreshold] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_mdCapacityMeasurementUnits_outOf",
                schema: "PortfolioMaster",
                table: "mdCapacityMeasurementUnits",
                column: "outOf");

            migrationBuilder.CreateIndex(
                name: "IX_mdDriverTypes_parentDriverTypeId",
                schema: "PortfolioMaster",
                table: "mdDriverTypes",
                column: "parentDriverTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_mdManagementMethods_parentMethodId",
                schema: "PortfolioMaster",
                table: "mdManagementMethods",
                column: "parentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_mdPhases_ManagementmethodId",
                schema: "PortfolioMaster",
                table: "mdPhases",
                column: "ManagementmethodId");

            migrationBuilder.CreateIndex(
                name: "IX_mdStandardAttachments_attachmentOfStandardId",
                schema: "GovernanceMaster",
                table: "mdStandardAttachments",
                column: "attachmentOfStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_motivationalDimensionsOfImportance_dimensionOfImportanceId",
                schema: "Portfolio",
                table: "motivationalDimensionsOfImportance",
                column: "dimensionOfImportanceId");

            migrationBuilder.CreateIndex(
                name: "IX_motivationalDimensionsOfImportance_dimOrgDriverId",
                schema: "Portfolio",
                table: "motivationalDimensionsOfImportance",
                column: "dimOrgDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_motivationalDimensionsOfImportance_motivationImportanceId",
                schema: "Portfolio",
                table: "motivationalDimensionsOfImportance",
                column: "motivationImportanceId");

            migrationBuilder.CreateIndex(
                name: "IX_operationalExpenditures_operationalExpenditureTypeId",
                schema: "Portfolio",
                table: "operationalExpenditures",
                column: "operationalExpenditureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_operationalExpenditures_opExAssetId",
                schema: "Portfolio",
                table: "operationalExpenditures",
                column: "opExAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_operationalExpenditures_opExDriverId",
                schema: "Portfolio",
                table: "operationalExpenditures",
                column: "opExDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_operationalExpenditures_opExFrequencyID",
                schema: "Portfolio",
                table: "operationalExpenditures",
                column: "opExFrequencyID");

            migrationBuilder.CreateIndex(
                name: "IX_opExCostComponents_costComponentRefId",
                schema: "Portfolio",
                table: "opExCostComponents",
                column: "costComponentRefId");

            migrationBuilder.CreateIndex(
                name: "IX_orgActors_actorTypeId",
                schema: "Portfolio",
                table: "orgActors",
                column: "actorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_orgDeliverables_deliverableTypeId",
                schema: "Portfolio",
                table: "orgDeliverables",
                column: "deliverableTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_orgDeliverables_parentDeliverableId",
                schema: "Portfolio",
                table: "orgDeliverables",
                column: "parentDeliverableId");

            migrationBuilder.CreateIndex(
                name: "IX_orgDrivers_driverTypeID",
                schema: "Portfolio",
                table: "orgDrivers",
                column: "driverTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_orgDrivers_parentOrgDriverId",
                schema: "Portfolio",
                table: "orgDrivers",
                column: "parentOrgDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_orgDrivers_ppImplicationId",
                schema: "Portfolio",
                table: "orgDrivers",
                column: "ppImplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_orgGoals_orgGoalTypeId",
                schema: "Portfolio",
                table: "orgGoals",
                column: "orgGoalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_orgGoals_parentGoalId",
                schema: "Portfolio",
                table: "orgGoals",
                column: "parentGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_orgGroups_orgStructId",
                schema: "Portfolio",
                table: "orgGroups",
                column: "orgStructId");

            migrationBuilder.CreateIndex(
                name: "IX_orgMilestones_parentMilestoneId",
                schema: "Portfolio",
                table: "orgMilestones",
                column: "parentMilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_orgRoles_parentRoleId",
                schema: "Portfolio",
                table: "orgRoles",
                column: "parentRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_orgRoles_roleRankId",
                schema: "Portfolio",
                table: "orgRoles",
                column: "roleRankId");

            migrationBuilder.CreateIndex(
                name: "IX_orgRoles_vitalityIndicatorId",
                schema: "Portfolio",
                table: "orgRoles",
                column: "vitalityIndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_orgStructures_commercialStatusId",
                schema: "Portfolio",
                table: "orgStructures",
                column: "commercialStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_orgStructures_locationId",
                schema: "Portfolio",
                table: "orgStructures",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_orgStructures_orgTypeId",
                schema: "Portfolio",
                table: "orgStructures",
                column: "orgTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_orgStructures_parentOrgId",
                schema: "Portfolio",
                table: "orgStructures",
                column: "parentOrgId");

            migrationBuilder.CreateIndex(
                name: "IX_orgStructures_workingStatusId",
                schema: "Portfolio",
                table: "orgStructures",
                column: "workingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_paymentRecords_paymentRecordInstrumentId",
                schema: "Vehicles",
                table: "paymentRecords",
                column: "paymentRecordInstrumentId");

            migrationBuilder.CreateIndex(
                name: "IX_paymentRecords_paymentRecordProjectId",
                schema: "Vehicles",
                table: "paymentRecords",
                column: "paymentRecordProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_paymentSchedules_paymentScheduleProjectId",
                schema: "Vehicles",
                table: "paymentSchedules",
                column: "paymentScheduleProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDetails_procurementAlertId",
                schema: "Portfolio",
                table: "procurementDetails",
                column: "procurementAlertId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDetails_procurementPhaseId",
                schema: "Portfolio",
                table: "procurementDetails",
                column: "procurementPhaseId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDetails_procurementSubjectAssetId",
                schema: "Portfolio",
                table: "procurementDetails",
                column: "procurementSubjectAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDetails_procurementSubjectDriverId",
                schema: "Portfolio",
                table: "procurementDetails",
                column: "procurementSubjectDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDetails_procurementSubjectMilestoneId",
                schema: "Portfolio",
                table: "procurementDetails",
                column: "procurementSubjectMilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDetails_procurementTypeRefId",
                schema: "Portfolio",
                table: "procurementDetails",
                column: "procurementTypeRefId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDocs_procurementDocumentTypeId",
                schema: "Portfolio",
                table: "procurementDocs",
                column: "procurementDocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_procurementDocs_refProcurementDetailId",
                schema: "Portfolio",
                table: "procurementDocs",
                column: "refProcurementDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_projectBudgets_budgetCostCenterId",
                schema: "Vehicles",
                table: "projectBudgets",
                column: "budgetCostCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_projectCostCenter_costCenterProjectMasterId",
                schema: "Vehicles",
                table: "projectCostCenter",
                column: "costCenterProjectMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_projectCostComponents_costComponentRefId",
                schema: "Vehicles",
                table: "projectCostComponents",
                column: "costComponentRefId");

            migrationBuilder.CreateIndex(
                name: "IX_projectOrigins_projectOriginDriverId",
                schema: "Vehicles",
                table: "projectOrigins",
                column: "projectOriginDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_projectOrigins_projectOriginGoalId",
                schema: "Vehicles",
                table: "projectOrigins",
                column: "projectOriginGoalId");

            migrationBuilder.CreateIndex(
                name: "IX_projectOrigins_projectOriginMilestoneId",
                schema: "Vehicles",
                table: "projectOrigins",
                column: "projectOriginMilestoneId");

            migrationBuilder.CreateIndex(
                name: "IX_refDeliverables_deliverableTypeId",
                schema: "PortfolioRef",
                table: "refDeliverables",
                column: "deliverableTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_refJobs_parentJobId",
                schema: "PortfolioRef",
                table: "refJobs",
                column: "parentJobId");

            migrationBuilder.CreateIndex(
                name: "IX_refRoles_roleContextId",
                schema: "PortfolioRef",
                table: "refRoles",
                column: "roleContextId");

            migrationBuilder.CreateIndex(
                name: "IX_refRoles_roleTypeId",
                schema: "PortfolioRef",
                table: "refRoles",
                column: "roleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_refSkills_parentSkillId",
                schema: "PortfolioRef",
                table: "refSkills",
                column: "parentSkillId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceLevels_maxResolutionTimeUnitId",
                schema: "Portfolio",
                table: "serviceLevels",
                column: "maxResolutionTimeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceLevels_maxResponseTimeUnitId",
                schema: "Portfolio",
                table: "serviceLevels",
                column: "maxResponseTimeUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceLevels_parentServiceLevelId",
                schema: "Portfolio",
                table: "serviceLevels",
                column: "parentServiceLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceLevels_serviceEsclationModelGroupId",
                schema: "Portfolio",
                table: "serviceLevels",
                column: "serviceEsclationModelGroupId",
                unique: true,
                filter: "[serviceEsclationModelGroupId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_serviceLevels_serviceEsclationModelId",
                schema: "Portfolio",
                table: "serviceLevels",
                column: "serviceEsclationModelId",
                unique: true,
                filter: "[serviceEsclationModelId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_serviceLevels_serviceLevelForAssetId",
                schema: "Portfolio",
                table: "serviceLevels",
                column: "serviceLevelForAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_serviceLevels_serviceLevelForAssetTypeId",
                schema: "Portfolio",
                table: "serviceLevels",
                column: "serviceLevelForAssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_skillParams_competencyLevelId",
                schema: "Portfolio",
                table: "skillParams",
                column: "competencyLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_skillParams_expPredicateId",
                schema: "Portfolio",
                table: "skillParams",
                column: "expPredicateId");

            migrationBuilder.CreateIndex(
                name: "IX_skillParams_skillId",
                schema: "Portfolio",
                table: "skillParams",
                column: "skillId");

            migrationBuilder.CreateIndex(
                name: "IX_skillParams_skillTypeId",
                schema: "Portfolio",
                table: "skillParams",
                column: "skillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_userCredentials_securityQuestionId",
                schema: "Portfolio",
                table: "userCredentials",
                column: "securityQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asnActorRoles",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnActorSkills",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnDataSourceAccessTypes",
                schema: "astraSYSASNS");

            migrationBuilder.DropTable(
                name: "asnDispensationApprovals",
                schema: "GovernanceASNS");

            migrationBuilder.DropTable(
                name: "asnDispensationRequestors",
                schema: "GovernanceASNS");

            migrationBuilder.DropTable(
                name: "asnEnterpriseElementsDataSources",
                schema: "astraSYSASNS");

            migrationBuilder.DropTable(
                name: "asnGovernedEntityStandards",
                schema: "GovernanceASNS");

            migrationBuilder.DropTable(
                name: "asnGovernedGovernings",
                schema: "GovernanceASNS");

            migrationBuilder.DropTable(
                name: "asnGoverningEntityLogs",
                schema: "GovernanceASNS");

            migrationBuilder.DropTable(
                name: "asnGroupJobs",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnGroupRoles",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnGroupSkills",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnIncidentEscalationRoleGroups",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnInformationObjectEnterpriseElements",
                schema: "astraSYSASNS");

            migrationBuilder.DropTable(
                name: "asnJobAssetAuths",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnJobDeliverables",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnMotivationalRoles",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnMotivationalSkills",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnProjectCostComponentBudgets",
                schema: "VehiclesASNS");

            migrationBuilder.DropTable(
                name: "asnProjectOriginsMaster",
                schema: "VehiclesASNS");

            migrationBuilder.DropTable(
                name: "asnProjectOutputs",
                schema: "VehiclesASNS");

            migrationBuilder.DropTable(
                name: "asnProjectStakeholders",
                schema: "VehiclesASNS");

            migrationBuilder.DropTable(
                name: "asnRoleJobs",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "asnRoleSkill",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "assetCapacityUtilizationRecords",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "assetComplexRelationAnalysis",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "astraHistory",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "capacitySpendings",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "capExCostComponents",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "cotsProcurementDetails",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "governanceAttachments",
                schema: "Governance");

            migrationBuilder.DropTable(
                name: "incidentManagementAttachments",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "informationObjectFields",
                schema: "astraSYS");

            migrationBuilder.DropTable(
                name: "locPhones",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "mdCapacityUnitMeasurementCategories",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdPoliciesPrinciples",
                schema: "GovernanceMaster");

            migrationBuilder.DropTable(
                name: "mdStandardAttachments",
                schema: "GovernanceMaster");

            migrationBuilder.DropTable(
                name: "motivationalDimensionsOfImportance",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "opExCostComponents",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "paymentRecords",
                schema: "Vehicles");

            migrationBuilder.DropTable(
                name: "paymentSchedules",
                schema: "Vehicles");

            migrationBuilder.DropTable(
                name: "procurementDocs",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "refDeliverables",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "userCredentials",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "mdDataSourceAccessTypes",
                schema: "astraSYSMaster");

            migrationBuilder.DropTable(
                name: "mdDataSourcePriorities",
                schema: "astraSYSMaster");

            migrationBuilder.DropTable(
                name: "dispensationRecords",
                schema: "Governance");

            migrationBuilder.DropTable(
                name: "mdDataSources",
                schema: "astraSYSMaster");

            migrationBuilder.DropTable(
                name: "governingEntities",
                schema: "Governance");

            migrationBuilder.DropTable(
                name: "mdAuthAccessLevels",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "asnMotivationals",
                schema: "PortfolioASNS");

            migrationBuilder.DropTable(
                name: "projectBudgets",
                schema: "Vehicles");

            migrationBuilder.DropTable(
                name: "projectCostComponents",
                schema: "Vehicles");

            migrationBuilder.DropTable(
                name: "projectOrigins",
                schema: "Vehicles");

            migrationBuilder.DropTable(
                name: "mdStakes",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "refRoles",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "skillParams",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "astraEnterpriseElements",
                schema: "astraSYS");

            migrationBuilder.DropTable(
                name: "orgActors",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "capExDetails",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "refCLTypes",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "governanceOutputs",
                schema: "Governance");

            migrationBuilder.DropTable(
                name: "incidentManagementRecords",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "astraInformationObjects",
                schema: "astraSYS");

            migrationBuilder.DropTable(
                name: "mdAstraFieldTypes",
                schema: "astraSYSMaster");

            migrationBuilder.DropTable(
                name: "refPhoneTypes",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "mdStandardsGuidelines",
                schema: "GovernanceMaster");

            migrationBuilder.DropTable(
                name: "mdMotivationalDimensions",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "operationalExpenditures",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "mdPaymentInstruments",
                schema: "VehiclesMaster");

            migrationBuilder.DropTable(
                name: "refProcurementDocumentTypes",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "mdSecurityQuestions",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdAuthorityLevels",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdCumulativeStakeCaps",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "refJobs",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "projectCostCenter",
                schema: "Vehicles");

            migrationBuilder.DropTable(
                name: "refCostComponents",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "orgGoals",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "mdRoleTypes",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "refRoleContexts",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "mdCompetencyLevels",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdPredicates",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdSkillTypes",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "refSkills",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "mdActorTypes",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "governanceLogs",
                schema: "Governance");

            migrationBuilder.DropTable(
                name: "incidentManagementStatuses",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "serviceLevels",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "mdInfomationSchemas",
                schema: "astraSYSASNS");

            migrationBuilder.DropTable(
                name: "refOpExTypes",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "mdGoalTypes",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "governedEntities",
                schema: "Governance");

            migrationBuilder.DropTable(
                name: "mdGovernanceComplianceLevels",
                schema: "GovernanceMaster");

            migrationBuilder.DropTable(
                name: "orgGroups",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "orgRoles",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "refIncidentStatuses",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "incidentEscalationModel",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "orgDeliverables",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "procurementDetails",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "projectMaster",
                schema: "Vehicles");

            migrationBuilder.DropTable(
                name: "refRanks",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "incidentEscalationModelGroup",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "alertServices",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "assetsPortfolio",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "orgDrivers",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "orgMilestones",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "refProcurementTypes",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "capacityDesigns",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "mdAssetCategories",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdAssetTypes",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdComplexities",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdFrequencies",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdGeneralScales",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdImpacts",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdPortfolioCategories",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "orgStructures",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "mdDriverTypes",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdPPImplications",
                schema: "GovernanceMaster");

            migrationBuilder.DropTable(
                name: "mdCapacityMeasurementUnits",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "mdPhases",
                schema: "PortfolioMaster");

            migrationBuilder.DropTable(
                name: "orgLocations",
                schema: "Portfolio");

            migrationBuilder.DropTable(
                name: "refOrgStatuses",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "refOrgTypes",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "refTimeUnits",
                schema: "PortfolioRef");

            migrationBuilder.DropTable(
                name: "mdManagementMethods",
                schema: "PortfolioMaster");
        }
    }
}
