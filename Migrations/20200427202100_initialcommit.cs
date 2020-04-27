using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPG_API.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    IsOfficial = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CampaignNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CampaignID = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CampaignNotes_Campaigns_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaigns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlchemicalItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlchemicalItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AlchemicalItems_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlchemicalSubstances",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlchemicalSubstances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AlchemicalSubstances_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ammunitions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AttackType = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: false),
                    DefaultReliability = table.Column<int>(nullable: false),
                    Concealment = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammunitions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ammunitions_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArmorEnhancements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StoppingPower = table.Column<int>(nullable: false),
                    BludgeoningResistant = table.Column<bool>(nullable: false),
                    SlashingResistant = table.Column<bool>(nullable: false),
                    PiercingResistant = table.Column<bool>(nullable: false),
                    Availability = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorEnhancements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArmorEnhancements_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StoppingPower = table.Column<int>(nullable: false),
                    DefaultReliability = table.Column<int>(nullable: false),
                    Availability = table.Column<int>(nullable: false),
                    EnhancementSlots = table.Column<int>(nullable: false),
                    EncumberanceValue = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    WeightClassification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Armors_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AttackModifiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackModifiers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AttackModifiers_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BladeOils",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Effects = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BladeOils", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BladeOils_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bombs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AttackType = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bombs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bombs_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CommonCovers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StoppingPower = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonCovers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CommonCovers_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CraftingComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Rarity = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    ForageDC = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    CraftingComponentType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftingComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CraftingComponents_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CraftingDiagrams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CraftingDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Investment = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    SkillLevel = table.Column<int>(nullable: false),
                    CraftingDiagramCategory = table.Column<int>(nullable: false),
                    ObjectReferenceID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftingDiagrams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CraftingDiagrams_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CriticalLevels",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    BeatDefenseByValue = table.Column<int>(nullable: false),
                    CriticalWoundType = table.Column<int>(nullable: false),
                    BonusDamage = table.Column<int>(nullable: false),
                    MonsterAnatomyType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriticalLevels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CriticalLevels_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CriticalTables",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Roll = table.Column<string>(nullable: true),
                    RollType = table.Column<string>(nullable: true),
                    EffectTitle = table.Column<string>(nullable: true),
                    EffectDescription = table.Column<string>(nullable: true),
                    Stabilized = table.Column<string>(nullable: true),
                    Treated = table.Column<string>(nullable: true),
                    CriticalWoundType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriticalTables", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CriticalTables_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DamageLocations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Roll = table.Column<string>(nullable: true),
                    Penalty = table.Column<int>(nullable: false),
                    DamageModifier = table.Column<decimal>(nullable: false),
                    IsMonster = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageLocations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DamageLocations_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DefiningSkillLinks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    DefiningSkillID = table.Column<int>(nullable: false),
                    NextDefiningSkillID = table.Column<int>(nullable: true),
                    PathName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefiningSkillLinks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DefiningSkillLinks_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DerivedStatistic",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DerivedStatisticCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DerivedStatistic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DerivedStatistic_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Effects_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Formulaes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AlchemyDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true),
                    SkillLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulaes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Formulaes_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Fumbles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Roll = table.Column<string>(nullable: true),
                    RollType = table.Column<string>(nullable: true),
                    Result = table.Column<string>(nullable: true),
                    FumbleType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fumbles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Fumbles_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GeneralGears",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    GeneralGearClassification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralGears", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GeneralGears_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Glyphs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glyphs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Glyphs_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hexs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    Danger = table.Column<string>(nullable: true),
                    RequirementToLift = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hexs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hexs_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invocations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Defense = table.Column<string>(nullable: true),
                    Deity = table.Column<string>(nullable: true),
                    SkillLevel = table.Column<int>(nullable: false),
                    SpellTypeClassification = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invocations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Invocations_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LightLevelModifiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Level = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightLevelModifiers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LightLevelModifiers_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monsters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Threat = table.Column<string>(nullable: true),
                    Bounty = table.Column<decimal>(nullable: false),
                    ArmorValue = table.Column<int>(nullable: false),
                    Height = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Environment = table.Column<string>(nullable: true),
                    Intelligence = table.Column<string>(nullable: true),
                    Organization = table.Column<string>(nullable: true),
                    MonsterType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monsters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Monsters_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mount_Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Athletics = table.Column<int>(nullable: true),
                    ControlMod = table.Column<int>(nullable: false),
                    Speed = table.Column<string>(nullable: true),
                    Health = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mount_Vehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mount_Vehicles_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MountOutfits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    MountOutfitClassification = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountOutfits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MountOutfits_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mutagens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    MutagenSource = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    AlchemyDC = table.Column<int>(nullable: false),
                    MinorMutation = table.Column<string>(nullable: true),
                    MutagenType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mutagens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mutagens_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlacesOfPowers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Benefit = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacesOfPowers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlacesOfPowers_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DefaultVigorValue = table.Column<int>(nullable: false),
                    ProfessionCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Professions_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RaceType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Races_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RammingSizeModifiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RammingSizeModifiers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RammingSizeModifiers_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RangeAndTargetDCs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    TargetDC = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Range = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangeAndTargetDCs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RangeAndTargetDCs_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rituals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    PreperationTime = table.Column<string>(nullable: true),
                    DifficultyCheck = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    SpellDifficultyClassification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rituals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rituals_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Runes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Runes_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Defense = table.Column<string>(nullable: true),
                    SpellDifficultyClassification = table.Column<int>(nullable: false),
                    SpellTypeClassification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Spells_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StatisticCategory = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Statistics_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ToolKits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: false),
                    Concealment = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolKits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ToolKits_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Traps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traps", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Traps_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AttackType = table.Column<string>(nullable: true),
                    WeaponAccuracy = table.Column<int>(nullable: false),
                    Availability = table.Column<int>(nullable: false),
                    Damage = table.Column<string>(nullable: true),
                    DefaultReliability = table.Column<int>(nullable: false),
                    HandsRequired = table.Column<int>(nullable: false),
                    Range = table.Column<string>(nullable: true),
                    Concealment = table.Column<int>(nullable: false),
                    Enhancements = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    WeaponClassification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Weapons_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WitcherDecoctions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WitcherDecoctions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WitcherDecoctions_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WitcherPotions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Effects = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Toxicity = table.Column<decimal>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WitcherPotions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WitcherPotions_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WitcherSigns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SpellTypeClassification = table.Column<int>(nullable: false),
                    StaminaCost = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Defense = table.Column<string>(nullable: true),
                    WitcherSignClassification = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WitcherSigns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WitcherSigns_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Availability = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    ForageDC = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    AlchemicalSubstanceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ingredients_AlchemicalSubstances_AlchemicalSubstanceID",
                        column: x => x.AlchemicalSubstanceID,
                        principalTable: "AlchemicalSubstances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredients_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArmorCovers",
                columns: table => new
                {
                    ArmorID = table.Column<int>(nullable: false),
                    ArmorClassification = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorCovers", x => new { x.ArmorID, x.ArmorClassification });
                    table.ForeignKey(
                        name: "FK_ArmorCovers_Armors_ArmorID",
                        column: x => x.ArmorID,
                        principalTable: "Armors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorCovers_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BombFormulaes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    BombID = table.Column<int>(nullable: false),
                    CraftDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Investment = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BombFormulaes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BombFormulaes_Bombs_BombID",
                        column: x => x.BombID,
                        principalTable: "Bombs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BombFormulaes_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CampaignCovers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CampaignID = table.Column<int>(nullable: false),
                    CommonCoverID = table.Column<int>(nullable: false),
                    StoppingPower = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignCovers", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CampaignCovers_Campaigns_CampaignID",
                        column: x => x.CampaignID,
                        principalTable: "Campaigns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampaignCovers_CommonCovers_CommonCoverID",
                        column: x => x.CommonCoverID,
                        principalTable: "CommonCovers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CraftingDiagramComponents",
                columns: table => new
                {
                    CraftingDiagramID = table.Column<int>(nullable: false),
                    CraftingComponentID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftingDiagramComponents", x => new { x.CraftingDiagramID, x.CraftingComponentID });
                    table.ForeignKey(
                        name: "FK_CraftingDiagramComponents_CraftingComponents_CraftingCompone~",
                        column: x => x.CraftingComponentID,
                        principalTable: "CraftingComponents",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CraftingDiagramComponents_CraftingDiagrams_CraftingDiagramID",
                        column: x => x.CraftingDiagramID,
                        principalTable: "CraftingDiagrams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CraftingDiagramComponents_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AmmunitionEffects",
                columns: table => new
                {
                    AmmunitionID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmmunitionEffects", x => new { x.AmmunitionID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_AmmunitionEffects_Ammunitions_AmmunitionID",
                        column: x => x.AmmunitionID,
                        principalTable: "Ammunitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmmunitionEffects_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmmunitionEffects_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArmorEffects",
                columns: table => new
                {
                    ArmorID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorEffects", x => new { x.ArmorID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_ArmorEffects_Armors_ArmorID",
                        column: x => x.ArmorID,
                        principalTable: "Armors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorEffects_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorEffects_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormulaeComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    FormulaeID = table.Column<int>(nullable: false),
                    AlchemyCategory = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulaeComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FormulaeComponents_Formulaes_FormulaeID",
                        column: x => x.FormulaeID,
                        principalTable: "Formulaes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormulaeComponents_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    SkillBase = table.Column<string>(nullable: true),
                    GeneralGearID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Services_GeneralGears_GeneralGearID",
                        column: x => x.GeneralGearID,
                        principalTable: "GeneralGears",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Services_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CampaignMonsters",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    INT = table.Column<int>(nullable: false),
                    REF = table.Column<int>(nullable: false),
                    DEX = table.Column<int>(nullable: false),
                    BODY = table.Column<int>(nullable: false),
                    SPD = table.Column<int>(nullable: false),
                    EMP = table.Column<int>(nullable: false),
                    CRA = table.Column<int>(nullable: false),
                    WILL = table.Column<int>(nullable: false),
                    LUCK = table.Column<int>(nullable: false),
                    STUN = table.Column<int>(nullable: false),
                    RUN = table.Column<int>(nullable: false),
                    LEAP = table.Column<int>(nullable: false),
                    STA = table.Column<int>(nullable: false),
                    ENC = table.Column<int>(nullable: false),
                    REC = table.Column<int>(nullable: false),
                    HP = table.Column<int>(nullable: false),
                    Vigor = table.Column<int>(nullable: false),
                    IsDead = table.Column<bool>(nullable: false),
                    CurrentLocation = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampaignMonsters", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CampaignMonsters_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterAbilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterAbilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterAbilities_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterAbilities_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterDerivedStatistics",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false),
                    DerivedStatisticID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Value = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterDerivedStatistics", x => new { x.MonsterID, x.DerivedStatisticID });
                    table.ForeignKey(
                        name: "FK_MonsterDerivedStatistics_DerivedStatistic_DerivedStatisticID",
                        column: x => x.DerivedStatisticID,
                        principalTable: "DerivedStatistic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterDerivedStatistics_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterDerivedStatistics_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterInformations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterInformations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterInformations_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterInformations_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterLoots",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterLoots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterLoots_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterLoots_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterVulnerabilities",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterVulnerabilities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterVulnerabilities_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterVulnerabilities_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterWeapons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    RateOfFire = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterWeapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterWeapons_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterWeapons_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSheets",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    ImprovementPoints = table.Column<int>(nullable: false),
                    RaceID = table.Column<int>(nullable: false),
                    ProfessionID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSheets", x => x.CharacterSheetID);
                    table.ForeignKey(
                        name: "FK_CharacterSheets_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSheets_Races_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Races",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RacialPerks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    RaceID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RacialPerks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RacialPerks_Races_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Races",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RacialPerks_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RitualComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    RitualID = table.Column<int>(nullable: false),
                    ComponentName = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RitualComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RitualComponents_Rituals_RitualID",
                        column: x => x.RitualID,
                        principalTable: "Rituals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RitualComponents_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DefiningSkills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    StatisticID = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsBaseSkill = table.Column<bool>(nullable: false),
                    ProfessionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefiningSkills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DefiningSkills_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefiningSkills_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DefiningSkills_Statistics_StatisticID",
                        column: x => x.StatisticID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonsterStatistics",
                columns: table => new
                {
                    MonsterID = table.Column<int>(nullable: false),
                    StatisticID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterStatistics", x => new { x.MonsterID, x.StatisticID });
                    table.ForeignKey(
                        name: "FK_MonsterStatistics_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterStatistics_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonsterStatistics_Statistics_StatisticID",
                        column: x => x.StatisticID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PointsPerLevel = table.Column<int>(nullable: false),
                    SkillCategory = table.Column<int>(nullable: false),
                    StatisticID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skills_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Skills_Statistics_StatisticID",
                        column: x => x.StatisticID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrapDiagrams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    TrapID = table.Column<int>(nullable: false),
                    CraftDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Investment = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrapDiagrams", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrapDiagrams_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrapDiagrams_Traps_TrapID",
                        column: x => x.TrapID,
                        principalTable: "Traps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeaponEffects",
                columns: table => new
                {
                    WeaponID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponEffects", x => new { x.WeaponID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_WeaponEffects_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponEffects_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeaponEffects_Weapons_WeaponID",
                        column: x => x.WeaponID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BombFormulaeComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    BombFormulaeID = table.Column<int>(nullable: false),
                    ComponentName = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BombFormulaeComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BombFormulaeComponents_BombFormulaes_BombFormulaeID",
                        column: x => x.BombFormulaeID,
                        principalTable: "BombFormulaes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BombFormulaeComponents_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAlchemicalItems",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    AlchemicalItemID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAlchemicalItems", x => new { x.CharacterSheetID, x.AlchemicalItemID });
                    table.ForeignKey(
                        name: "FK_CharacterAlchemicalItems_AlchemicalItems_AlchemicalItemID",
                        column: x => x.AlchemicalItemID,
                        principalTable: "AlchemicalItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAlchemicalItems_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAmmunitions",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    AmmunitionID = table.Column<int>(nullable: false),
                    Reliability = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    AmmunitionEnhancementsID = table.Column<int>(nullable: true),
                    IsEquipped = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAmmunitions", x => new { x.CharacterSheetID, x.AmmunitionID });
                    table.ForeignKey(
                        name: "FK_CharacterAmmunitions_Ammunitions_AmmunitionID",
                        column: x => x.AmmunitionID,
                        principalTable: "Ammunitions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAmmunitions_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterArmors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    ArmorID = table.Column<int>(nullable: false),
                    StoppingPower = table.Column<int>(nullable: false),
                    EnhancementSlotsOpen = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    IsEquipped = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterArmors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterArmors_Armors_ArmorID",
                        column: x => x.ArmorID,
                        principalTable: "Armors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterArmors_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterBladeOil",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    BladeOilID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterBladeOil", x => new { x.CharacterSheetID, x.BladeOilID });
                    table.ForeignKey(
                        name: "FK_CharacterBladeOil_BladeOils_BladeOilID",
                        column: x => x.BladeOilID,
                        principalTable: "BladeOils",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterBladeOil_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterBombs",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    BombID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterBombs", x => new { x.CharacterSheetID, x.BombID });
                    table.ForeignKey(
                        name: "FK_CharacterBombs_Bombs_BombID",
                        column: x => x.BombID,
                        principalTable: "Bombs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterBombs_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterCampaignNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterCampaignNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterCampaignNotes_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterDerivedStatistics",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    DerivedStatisticID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDerivedStatistics", x => new { x.CharacterSheetID, x.DerivedStatisticID });
                    table.ForeignKey(
                        name: "FK_CharacterDerivedStatistics_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterDerivedStatistics_DerivedStatistic_DerivedStatistic~",
                        column: x => x.DerivedStatisticID,
                        principalTable: "DerivedStatistic",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterEarlyLifeNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEarlyLifeNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterEarlyLifeNotes_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterEffects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    CurrentDuration = table.Column<int>(nullable: false),
                    CurrentValue = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEffects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterEffects_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterEffects_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterFormulaes",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    FormulaeID = table.Column<int>(nullable: false),
                    RetainedByMemory = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFormulaes", x => new { x.CharacterSheetID, x.FormulaeID });
                    table.ForeignKey(
                        name: "FK_CharacterFormulaes_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFormulaes_Formulaes_FormulaeID",
                        column: x => x.FormulaeID,
                        principalTable: "Formulaes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterGeneralGears",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    GeneralGearID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterGeneralGears", x => new { x.CharacterSheetID, x.GeneralGearID });
                    table.ForeignKey(
                        name: "FK_CharacterGeneralGears_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterGeneralGears_GeneralGears_GeneralGearID",
                        column: x => x.GeneralGearID,
                        principalTable: "GeneralGears",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterHexs",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    HexID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterHexs", x => new { x.CharacterSheetID, x.HexID });
                    table.ForeignKey(
                        name: "FK_CharacterHexs_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterHexs_Hexs_HexID",
                        column: x => x.HexID,
                        principalTable: "Hexs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterInvocations",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    InvocationID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterInvocations", x => new { x.CharacterSheetID, x.InvocationID });
                    table.ForeignKey(
                        name: "FK_CharacterInvocations_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterInvocations_Invocations_InvocationID",
                        column: x => x.InvocationID,
                        principalTable: "Invocations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterLifeEvents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Decade = table.Column<int>(nullable: false),
                    Event = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterLifeEvents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterLifeEvents_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMount_Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Mounts_VehicleID = table.Column<int>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Mount_VehicleID = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMount_Vehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterMount_Vehicles_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMount_Vehicles_Mount_Vehicles_Mount_VehicleID",
                        column: x => x.Mount_VehicleID,
                        principalTable: "Mount_Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMutagens",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    MutagenID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMutagens", x => new { x.CharacterSheetID, x.MutagenID });
                    table.ForeignKey(
                        name: "FK_CharacterMutagens_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMutagens_Mutagens_MutagenID",
                        column: x => x.MutagenID,
                        principalTable: "Mutagens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterNotes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterNotes_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterRituals",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    RitualID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterRituals", x => new { x.CharacterSheetID, x.RitualID });
                    table.ForeignKey(
                        name: "FK_CharacterRituals_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterRituals_Rituals_RitualID",
                        column: x => x.RitualID,
                        principalTable: "Rituals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterServices",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    ServiceID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterServices", x => new { x.CharacterSheetID, x.ServiceID });
                    table.ForeignKey(
                        name: "FK_CharacterServices_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterServices_Services_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Services",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSpells",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    SpellID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSpells", x => new { x.CharacterSheetID, x.SpellID });
                    table.ForeignKey(
                        name: "FK_CharacterSpells_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSpells_Spells_SpellID",
                        column: x => x.SpellID,
                        principalTable: "Spells",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterStatistics",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    StatisticID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStatistics", x => new { x.CharacterSheetID, x.StatisticID });
                    table.ForeignKey(
                        name: "FK_CharacterStatistics_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterStatistics_Statistics_StatisticID",
                        column: x => x.StatisticID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSubstances",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    SubstanceID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSubstances", x => new { x.CharacterSheetID, x.SubstanceID });
                    table.ForeignKey(
                        name: "FK_CharacterSubstances_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSubstances_Ingredients_SubstanceID",
                        column: x => x.SubstanceID,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterToolKits",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    ToolKitID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterToolKits", x => new { x.CharacterSheetID, x.ToolKitID });
                    table.ForeignKey(
                        name: "FK_CharacterToolKits_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterToolKits_ToolKits_ToolKitID",
                        column: x => x.ToolKitID,
                        principalTable: "ToolKits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterTraps",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    TrapID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTraps", x => new { x.CharacterSheetID, x.TrapID });
                    table.ForeignKey(
                        name: "FK_CharacterTraps_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTraps_Traps_TrapID",
                        column: x => x.TrapID,
                        principalTable: "Traps",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWeapons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WeaponID = table.Column<int>(nullable: false),
                    Reliability = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    IsEquipped = table.Column<bool>(nullable: false),
                    HasAmmunition = table.Column<bool>(nullable: false),
                    WeaponEnhancementsID = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWeapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterWeapons_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWeapons_Weapons_WeaponID",
                        column: x => x.WeaponID,
                        principalTable: "Weapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWitcherDecoctions",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WitcherDecoctionID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWitcherDecoctions", x => new { x.CharacterSheetID, x.WitcherDecoctionID });
                    table.ForeignKey(
                        name: "FK_CharacterWitcherDecoctions_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWitcherDecoctions_WitcherDecoctions_WitcherDecoctio~",
                        column: x => x.WitcherDecoctionID,
                        principalTable: "WitcherDecoctions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWitcherPotions",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WitcherPotionID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWitcherPotions", x => new { x.CharacterSheetID, x.WitcherPotionID });
                    table.ForeignKey(
                        name: "FK_CharacterWitcherPotions_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWitcherPotions_WitcherPotions_WitcherPotionID",
                        column: x => x.WitcherPotionID,
                        principalTable: "WitcherPotions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWitcherSigns",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WitcherSignID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWitcherSigns", x => new { x.CharacterSheetID, x.WitcherSignID });
                    table.ForeignKey(
                        name: "FK_CharacterWitcherSigns_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWitcherSigns_WitcherSigns_WitcherSignID",
                        column: x => x.WitcherSignID,
                        principalTable: "WitcherSigns",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterDefiningSkills",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    DefiningSkillID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDefiningSkills", x => new { x.CharacterSheetID, x.DefiningSkillID });
                    table.ForeignKey(
                        name: "FK_CharacterDefiningSkills_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterDefiningSkills_DefiningSkills_DefiningSkillID",
                        column: x => x.DefiningSkillID,
                        principalTable: "DefiningSkills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DefiningSkillTables",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    DefiningSkillID = table.Column<int>(nullable: false),
                    FirstColumn = table.Column<string>(nullable: true),
                    FirstColumnValue = table.Column<string>(nullable: true),
                    SecondColumn = table.Column<string>(nullable: true),
                    SecondColumnValue = table.Column<string>(nullable: true),
                    DefiningSkillFilter = table.Column<string>(nullable: true),
                    DefiningSkillTableType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefiningSkillTables", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DefiningSkillTables_DefiningSkills_DefiningSkillID",
                        column: x => x.DefiningSkillID,
                        principalTable: "DefiningSkills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefiningSkillTables_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    SkillID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => new { x.CharacterSheetID, x.SkillID });
                    table.ForeignKey(
                        name: "FK_CharacterSkills_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonsterSkills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    MonsterID = table.Column<int>(nullable: false),
                    SkillID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonsterSkills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MonsterSkills_Monsters_MonsterID",
                        column: x => x.MonsterID,
                        principalTable: "Monsters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterSkills_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonsterSkills_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SkillPackages",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    ProfessionID = table.Column<int>(nullable: false),
                    SkillName = table.Column<string>(nullable: true),
                    SkillID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillPackages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SkillPackages_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillPackages_Skills_SkillID",
                        column: x => x.SkillID,
                        principalTable: "Skills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SkillPackages_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TrapDiagramComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Deleted = table.Column<bool>(nullable: false),
                    SourceID = table.Column<int>(nullable: true),
                    TrapDiagramID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    ComponentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrapDiagramComponents", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrapDiagramComponents_Sources_SourceID",
                        column: x => x.SourceID,
                        principalTable: "Sources",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrapDiagramComponents_TrapDiagrams_TrapDiagramID",
                        column: x => x.TrapDiagramID,
                        principalTable: "TrapDiagrams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterArmorEffects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterArmorID = table.Column<int>(nullable: false),
                    EffectName = table.Column<string>(nullable: true),
                    EffectDescription = table.Column<string>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterArmorEffects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterArmorEffects_CharacterArmors_CharacterArmorID",
                        column: x => x.CharacterArmorID,
                        principalTable: "CharacterArmors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterArmorEnhancements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    ArmorEnhancementID = table.Column<int>(nullable: false),
                    IsEquipped = table.Column<bool>(nullable: false),
                    CharacterArmorID = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterArmorEnhancements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterArmorEnhancements_ArmorEnhancements_ArmorEnhancemen~",
                        column: x => x.ArmorEnhancementID,
                        principalTable: "ArmorEnhancements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterArmorEnhancements_CharacterArmors_CharacterArmorID",
                        column: x => x.CharacterArmorID,
                        principalTable: "CharacterArmors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterArmorEnhancements_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterGlyphs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    GlyphID = table.Column<int>(nullable: false),
                    CharacterArmorID = table.Column<int>(nullable: true),
                    IsEquipped = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterGlyphs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterGlyphs_CharacterArmors_CharacterArmorID",
                        column: x => x.CharacterArmorID,
                        principalTable: "CharacterArmors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterGlyphs_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterGlyphs_Glyphs_GlyphID",
                        column: x => x.GlyphID,
                        principalTable: "Glyphs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWeaponEffects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterWeaponID = table.Column<int>(nullable: false),
                    EffectName = table.Column<string>(nullable: true),
                    EffectDescription = table.Column<string>(nullable: true),
                    CharacterArmorID = table.Column<int>(nullable: true),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWeaponEffects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterWeaponEffects_CharacterArmors_CharacterArmorID",
                        column: x => x.CharacterArmorID,
                        principalTable: "CharacterArmors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMountOutfits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterMount_VehicleID = table.Column<int>(nullable: false),
                    MountOutfitID = table.Column<int>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMountOutfits", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterMountOutfits_CharacterMount_Vehicles_CharacterMount~",
                        column: x => x.CharacterMount_VehicleID,
                        principalTable: "CharacterMount_Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMountOutfits_MountOutfits_MountOutfitID",
                        column: x => x.MountOutfitID,
                        principalTable: "MountOutfits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterRunes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    RuneID = table.Column<int>(nullable: false),
                    CharacterWeaponID = table.Column<int>(nullable: true),
                    IsEquipped = table.Column<bool>(nullable: false),
                    Deleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterRunes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CharacterRunes_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterRunes_CharacterWeapons_CharacterWeaponID",
                        column: x => x.CharacterWeaponID,
                        principalTable: "CharacterWeapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterRunes_Runes_RuneID",
                        column: x => x.RuneID,
                        principalTable: "Runes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlchemicalItems_SourceID",
                table: "AlchemicalItems",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_AlchemicalSubstances_SourceID",
                table: "AlchemicalSubstances",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionEffects_EffectID",
                table: "AmmunitionEffects",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_AmmunitionEffects_SourceID",
                table: "AmmunitionEffects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Ammunitions_SourceID",
                table: "Ammunitions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorCovers_SourceID",
                table: "ArmorCovers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEffects_EffectID",
                table: "ArmorEffects",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEffects_SourceID",
                table: "ArmorEffects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ArmorEnhancements_SourceID",
                table: "ArmorEnhancements",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Armors_SourceID",
                table: "Armors",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_AttackModifiers_SourceID",
                table: "AttackModifiers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_BladeOils_SourceID",
                table: "BladeOils",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_BombFormulaeID",
                table: "BombFormulaeComponents",
                column: "BombFormulaeID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaeComponents_SourceID",
                table: "BombFormulaeComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaes_BombID",
                table: "BombFormulaes",
                column: "BombID");

            migrationBuilder.CreateIndex(
                name: "IX_BombFormulaes_SourceID",
                table: "BombFormulaes",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Bombs_SourceID",
                table: "Bombs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCovers_CampaignID",
                table: "CampaignCovers",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignCovers_CommonCoverID",
                table: "CampaignCovers",
                column: "CommonCoverID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignMonsters_MonsterID",
                table: "CampaignMonsters",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_CampaignNotes_CampaignID",
                table: "CampaignNotes",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAlchemicalItems_AlchemicalItemID",
                table: "CharacterAlchemicalItems",
                column: "AlchemicalItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAmmunitions_AmmunitionID",
                table: "CharacterAmmunitions",
                column: "AmmunitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEffects_CharacterArmorID",
                table: "CharacterArmorEffects",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_ArmorEnhancementID",
                table: "CharacterArmorEnhancements",
                column: "ArmorEnhancementID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_CharacterArmorID",
                table: "CharacterArmorEnhancements",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_CharacterSheetID",
                table: "CharacterArmorEnhancements",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmors_ArmorID",
                table: "CharacterArmors",
                column: "ArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmors_CharacterSheetID",
                table: "CharacterArmors",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterBladeOil_BladeOilID",
                table: "CharacterBladeOil",
                column: "BladeOilID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterBombs_BombID",
                table: "CharacterBombs",
                column: "BombID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCampaignNotes_CharacterSheetID",
                table: "CharacterCampaignNotes",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDefiningSkills_DefiningSkillID",
                table: "CharacterDefiningSkills",
                column: "DefiningSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDerivedStatistics_DerivedStatisticID",
                table: "CharacterDerivedStatistics",
                column: "DerivedStatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEarlyLifeNotes_CharacterSheetID",
                table: "CharacterEarlyLifeNotes",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEffects_CharacterSheetID",
                table: "CharacterEffects",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEffects_EffectID",
                table: "CharacterEffects",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFormulaes_FormulaeID",
                table: "CharacterFormulaes",
                column: "FormulaeID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGeneralGears_GeneralGearID",
                table: "CharacterGeneralGears",
                column: "GeneralGearID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGlyphs_CharacterArmorID",
                table: "CharacterGlyphs",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGlyphs_CharacterSheetID",
                table: "CharacterGlyphs",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterGlyphs_GlyphID",
                table: "CharacterGlyphs",
                column: "GlyphID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterHexs_HexID",
                table: "CharacterHexs",
                column: "HexID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterInvocations_InvocationID",
                table: "CharacterInvocations",
                column: "InvocationID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterLifeEvents_CharacterSheetID",
                table: "CharacterLifeEvents",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMount_Vehicles_CharacterSheetID",
                table: "CharacterMount_Vehicles",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMount_Vehicles_Mount_VehicleID",
                table: "CharacterMount_Vehicles",
                column: "Mount_VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMountOutfits_CharacterMount_VehicleID",
                table: "CharacterMountOutfits",
                column: "CharacterMount_VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMountOutfits_MountOutfitID",
                table: "CharacterMountOutfits",
                column: "MountOutfitID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMutagens_MutagenID",
                table: "CharacterMutagens",
                column: "MutagenID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterNotes_CharacterSheetID",
                table: "CharacterNotes",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRituals_RitualID",
                table: "CharacterRituals",
                column: "RitualID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRunes_CharacterSheetID",
                table: "CharacterRunes",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRunes_CharacterWeaponID",
                table: "CharacterRunes",
                column: "CharacterWeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRunes_RuneID",
                table: "CharacterRunes",
                column: "RuneID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterServices_ServiceID",
                table: "CharacterServices",
                column: "ServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_ProfessionID",
                table: "CharacterSheets",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSheets_RaceID",
                table: "CharacterSheets",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_SkillID",
                table: "CharacterSkills",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSpells_SpellID",
                table: "CharacterSpells",
                column: "SpellID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterStatistics_StatisticID",
                table: "CharacterStatistics",
                column: "StatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSubstances_SubstanceID",
                table: "CharacterSubstances",
                column: "SubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterToolKits_ToolKitID",
                table: "CharacterToolKits",
                column: "ToolKitID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTraps_TrapID",
                table: "CharacterTraps",
                column: "TrapID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeaponEffects_CharacterArmorID",
                table: "CharacterWeaponEffects",
                column: "CharacterArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeapons_CharacterSheetID",
                table: "CharacterWeapons",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeapons_WeaponID",
                table: "CharacterWeapons",
                column: "WeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWitcherDecoctions_WitcherDecoctionID",
                table: "CharacterWitcherDecoctions",
                column: "WitcherDecoctionID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWitcherPotions_WitcherPotionID",
                table: "CharacterWitcherPotions",
                column: "WitcherPotionID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWitcherSigns_WitcherSignID",
                table: "CharacterWitcherSigns",
                column: "WitcherSignID");

            migrationBuilder.CreateIndex(
                name: "IX_CommonCovers_SourceID",
                table: "CommonCovers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingComponents_SourceID",
                table: "CraftingComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingDiagramComponents_CraftingComponentID",
                table: "CraftingDiagramComponents",
                column: "CraftingComponentID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingDiagramComponents_SourceID",
                table: "CraftingDiagramComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingDiagrams_SourceID",
                table: "CraftingDiagrams",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CriticalLevels_SourceID",
                table: "CriticalLevels",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_CriticalTables_SourceID",
                table: "CriticalTables",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DamageLocations_SourceID",
                table: "DamageLocations",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkillLinks_SourceID",
                table: "DefiningSkillLinks",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_ProfessionID",
                table: "DefiningSkills",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_SourceID",
                table: "DefiningSkills",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_StatisticID",
                table: "DefiningSkills",
                column: "StatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkillTables_DefiningSkillID",
                table: "DefiningSkillTables",
                column: "DefiningSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkillTables_SourceID",
                table: "DefiningSkillTables",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_DerivedStatistic_SourceID",
                table: "DerivedStatistic",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Effects_SourceID",
                table: "Effects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaeComponents_FormulaeID",
                table: "FormulaeComponents",
                column: "FormulaeID");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaeComponents_SourceID",
                table: "FormulaeComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Formulaes_SourceID",
                table: "Formulaes",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Fumbles_SourceID",
                table: "Fumbles",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralGears_SourceID",
                table: "GeneralGears",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Glyphs_SourceID",
                table: "Glyphs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Hexs_SourceID",
                table: "Hexs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_AlchemicalSubstanceID",
                table: "Ingredients",
                column: "AlchemicalSubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_SourceID",
                table: "Ingredients",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Invocations_SourceID",
                table: "Invocations",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_LightLevelModifiers_SourceID",
                table: "LightLevelModifiers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAbilities_MonsterID",
                table: "MonsterAbilities",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterAbilities_SourceID",
                table: "MonsterAbilities",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterDerivedStatistics_DerivedStatisticID",
                table: "MonsterDerivedStatistics",
                column: "DerivedStatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterDerivedStatistics_SourceID",
                table: "MonsterDerivedStatistics",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterInformations_MonsterID",
                table: "MonsterInformations",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterInformations_SourceID",
                table: "MonsterInformations",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLoots_MonsterID",
                table: "MonsterLoots",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterLoots_SourceID",
                table: "MonsterLoots",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Monsters_SourceID",
                table: "Monsters",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSkills_MonsterID",
                table: "MonsterSkills",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSkills_SkillID",
                table: "MonsterSkills",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterSkills_SourceID",
                table: "MonsterSkills",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterStatistics_SourceID",
                table: "MonsterStatistics",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterStatistics_StatisticID",
                table: "MonsterStatistics",
                column: "StatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterVulnerabilities_MonsterID",
                table: "MonsterVulnerabilities",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterVulnerabilities_SourceID",
                table: "MonsterVulnerabilities",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterWeapons_MonsterID",
                table: "MonsterWeapons",
                column: "MonsterID");

            migrationBuilder.CreateIndex(
                name: "IX_MonsterWeapons_SourceID",
                table: "MonsterWeapons",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Mount_Vehicles_SourceID",
                table: "Mount_Vehicles",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_MountOutfits_SourceID",
                table: "MountOutfits",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Mutagens_SourceID",
                table: "Mutagens",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_PlacesOfPowers_SourceID",
                table: "PlacesOfPowers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Professions_SourceID",
                table: "Professions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SourceID",
                table: "Races",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RacialPerks_RaceID",
                table: "RacialPerks",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_RacialPerks_SourceID",
                table: "RacialPerks",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RammingSizeModifiers_SourceID",
                table: "RammingSizeModifiers",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RangeAndTargetDCs_SourceID",
                table: "RangeAndTargetDCs",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_RitualComponents_RitualID",
                table: "RitualComponents",
                column: "RitualID");

            migrationBuilder.CreateIndex(
                name: "IX_RitualComponents_SourceID",
                table: "RitualComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Rituals_SourceID",
                table: "Rituals",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Runes_SourceID",
                table: "Runes",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_GeneralGearID",
                table: "Services",
                column: "GeneralGearID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_SourceID",
                table: "Services",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPackages_ProfessionID",
                table: "SkillPackages",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPackages_SkillID",
                table: "SkillPackages",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPackages_SourceID",
                table: "SkillPackages",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_SourceID",
                table: "Skills",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_StatisticID",
                table: "Skills",
                column: "StatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SourceID",
                table: "Spells",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_SourceID",
                table: "Statistics",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_ToolKits_SourceID",
                table: "ToolKits",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_SourceID",
                table: "TrapDiagramComponents",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagramComponents_TrapDiagramID",
                table: "TrapDiagramComponents",
                column: "TrapDiagramID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagrams_SourceID",
                table: "TrapDiagrams",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_TrapDiagrams_TrapID",
                table: "TrapDiagrams",
                column: "TrapID");

            migrationBuilder.CreateIndex(
                name: "IX_Traps_SourceID",
                table: "Traps",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponEffects_EffectID",
                table: "WeaponEffects",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_WeaponEffects_SourceID",
                table: "WeaponEffects",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_SourceID",
                table: "Weapons",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_WitcherDecoctions_SourceID",
                table: "WitcherDecoctions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_WitcherPotions_SourceID",
                table: "WitcherPotions",
                column: "SourceID");

            migrationBuilder.CreateIndex(
                name: "IX_WitcherSigns_SourceID",
                table: "WitcherSigns",
                column: "SourceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmmunitionEffects");

            migrationBuilder.DropTable(
                name: "ArmorCovers");

            migrationBuilder.DropTable(
                name: "ArmorEffects");

            migrationBuilder.DropTable(
                name: "AttackModifiers");

            migrationBuilder.DropTable(
                name: "BombFormulaeComponents");

            migrationBuilder.DropTable(
                name: "CampaignCovers");

            migrationBuilder.DropTable(
                name: "CampaignMonsters");

            migrationBuilder.DropTable(
                name: "CampaignNotes");

            migrationBuilder.DropTable(
                name: "CharacterAlchemicalItems");

            migrationBuilder.DropTable(
                name: "CharacterAmmunitions");

            migrationBuilder.DropTable(
                name: "CharacterArmorEffects");

            migrationBuilder.DropTable(
                name: "CharacterArmorEnhancements");

            migrationBuilder.DropTable(
                name: "CharacterBladeOil");

            migrationBuilder.DropTable(
                name: "CharacterBombs");

            migrationBuilder.DropTable(
                name: "CharacterCampaignNotes");

            migrationBuilder.DropTable(
                name: "CharacterDefiningSkills");

            migrationBuilder.DropTable(
                name: "CharacterDerivedStatistics");

            migrationBuilder.DropTable(
                name: "CharacterEarlyLifeNotes");

            migrationBuilder.DropTable(
                name: "CharacterEffects");

            migrationBuilder.DropTable(
                name: "CharacterFormulaes");

            migrationBuilder.DropTable(
                name: "CharacterGeneralGears");

            migrationBuilder.DropTable(
                name: "CharacterGlyphs");

            migrationBuilder.DropTable(
                name: "CharacterHexs");

            migrationBuilder.DropTable(
                name: "CharacterInvocations");

            migrationBuilder.DropTable(
                name: "CharacterLifeEvents");

            migrationBuilder.DropTable(
                name: "CharacterMountOutfits");

            migrationBuilder.DropTable(
                name: "CharacterMutagens");

            migrationBuilder.DropTable(
                name: "CharacterNotes");

            migrationBuilder.DropTable(
                name: "CharacterRituals");

            migrationBuilder.DropTable(
                name: "CharacterRunes");

            migrationBuilder.DropTable(
                name: "CharacterServices");

            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "CharacterSpells");

            migrationBuilder.DropTable(
                name: "CharacterStatistics");

            migrationBuilder.DropTable(
                name: "CharacterSubstances");

            migrationBuilder.DropTable(
                name: "CharacterToolKits");

            migrationBuilder.DropTable(
                name: "CharacterTraps");

            migrationBuilder.DropTable(
                name: "CharacterWeaponEffects");

            migrationBuilder.DropTable(
                name: "CharacterWitcherDecoctions");

            migrationBuilder.DropTable(
                name: "CharacterWitcherPotions");

            migrationBuilder.DropTable(
                name: "CharacterWitcherSigns");

            migrationBuilder.DropTable(
                name: "CraftingDiagramComponents");

            migrationBuilder.DropTable(
                name: "CriticalLevels");

            migrationBuilder.DropTable(
                name: "CriticalTables");

            migrationBuilder.DropTable(
                name: "DamageLocations");

            migrationBuilder.DropTable(
                name: "DefiningSkillLinks");

            migrationBuilder.DropTable(
                name: "DefiningSkillTables");

            migrationBuilder.DropTable(
                name: "FormulaeComponents");

            migrationBuilder.DropTable(
                name: "Fumbles");

            migrationBuilder.DropTable(
                name: "LightLevelModifiers");

            migrationBuilder.DropTable(
                name: "MonsterAbilities");

            migrationBuilder.DropTable(
                name: "MonsterDerivedStatistics");

            migrationBuilder.DropTable(
                name: "MonsterInformations");

            migrationBuilder.DropTable(
                name: "MonsterLoots");

            migrationBuilder.DropTable(
                name: "MonsterSkills");

            migrationBuilder.DropTable(
                name: "MonsterStatistics");

            migrationBuilder.DropTable(
                name: "MonsterVulnerabilities");

            migrationBuilder.DropTable(
                name: "MonsterWeapons");

            migrationBuilder.DropTable(
                name: "PlacesOfPowers");

            migrationBuilder.DropTable(
                name: "RacialPerks");

            migrationBuilder.DropTable(
                name: "RammingSizeModifiers");

            migrationBuilder.DropTable(
                name: "RangeAndTargetDCs");

            migrationBuilder.DropTable(
                name: "RitualComponents");

            migrationBuilder.DropTable(
                name: "SkillPackages");

            migrationBuilder.DropTable(
                name: "TrapDiagramComponents");

            migrationBuilder.DropTable(
                name: "WeaponEffects");

            migrationBuilder.DropTable(
                name: "BombFormulaes");

            migrationBuilder.DropTable(
                name: "CommonCovers");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "AlchemicalItems");

            migrationBuilder.DropTable(
                name: "Ammunitions");

            migrationBuilder.DropTable(
                name: "ArmorEnhancements");

            migrationBuilder.DropTable(
                name: "BladeOils");

            migrationBuilder.DropTable(
                name: "Glyphs");

            migrationBuilder.DropTable(
                name: "Hexs");

            migrationBuilder.DropTable(
                name: "Invocations");

            migrationBuilder.DropTable(
                name: "CharacterMount_Vehicles");

            migrationBuilder.DropTable(
                name: "MountOutfits");

            migrationBuilder.DropTable(
                name: "Mutagens");

            migrationBuilder.DropTable(
                name: "CharacterWeapons");

            migrationBuilder.DropTable(
                name: "Runes");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "ToolKits");

            migrationBuilder.DropTable(
                name: "CharacterArmors");

            migrationBuilder.DropTable(
                name: "WitcherDecoctions");

            migrationBuilder.DropTable(
                name: "WitcherPotions");

            migrationBuilder.DropTable(
                name: "WitcherSigns");

            migrationBuilder.DropTable(
                name: "CraftingComponents");

            migrationBuilder.DropTable(
                name: "CraftingDiagrams");

            migrationBuilder.DropTable(
                name: "DefiningSkills");

            migrationBuilder.DropTable(
                name: "Formulaes");

            migrationBuilder.DropTable(
                name: "DerivedStatistic");

            migrationBuilder.DropTable(
                name: "Monsters");

            migrationBuilder.DropTable(
                name: "Rituals");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TrapDiagrams");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Bombs");

            migrationBuilder.DropTable(
                name: "Mount_Vehicles");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "GeneralGears");

            migrationBuilder.DropTable(
                name: "AlchemicalSubstances");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Traps");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Sources");
        }
    }
}
