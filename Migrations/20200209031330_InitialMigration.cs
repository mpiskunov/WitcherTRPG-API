using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WitcherTRPGWebApplication.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlchemicalItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlchemicalItems", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ammunitions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AttackType = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    DefaultReliability = table.Column<int>(nullable: false),
                    Concealment = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammunitions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ArmorEnhancements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StoppingPower = table.Column<int>(nullable: false),
                    BludgeoningResistant = table.Column<bool>(nullable: false),
                    SlashingResistant = table.Column<bool>(nullable: false),
                    PiercingResistant = table.Column<bool>(nullable: false),
                    Availability = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorEnhancements", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Armors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StoppingPower = table.Column<int>(nullable: false),
                    DefaultReliability = table.Column<int>(nullable: false),
                    Availability = table.Column<string>(nullable: true),
                    EnhancementSlots = table.Column<int>(nullable: false),
                    EncumberanceValue = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ArmorCategoryID = table.Column<int>(nullable: false),
                    WeightCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AttackModifiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttackModifiers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CommonCovers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    StoppingPower = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonCovers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CraftingComponents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Rarity = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    ForageDC = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftingComponents", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CraftingDiagrams",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    CraftingDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Investment = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    SkillLevelID = table.Column<int>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftingDiagrams", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DamageLocations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(nullable: true),
                    Roll = table.Column<string>(nullable: true),
                    Penalty = table.Column<int>(nullable: false),
                    DamageModifier = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageLocations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Effects",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Effects", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Formulaes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AlchemyDC = table.Column<int>(nullable: false),
                    Time = table.Column<string>(nullable: true),
                    Cost = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formulaes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "GeneralGears",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: true),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralGears", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hexs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    Danger = table.Column<string>(nullable: true),
                    RequirementToLift = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hexs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LightLevelModifiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightLevelModifiers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Mount_Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Athletics = table.Column<int>(nullable: true),
                    ControlMod = table.Column<int>(nullable: false),
                    Speed = table.Column<string>(nullable: true),
                    Health = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mount_Vehicles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MountOutfits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    ClassificationTypeID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MountOutfits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PriestInvocations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: false),
                    Range = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Defense = table.Column<string>(nullable: true),
                    Deity = table.Column<string>(nullable: true),
                    SkillLevelID = table.Column<int>(nullable: false),
                    SpellCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriestInvocations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Professions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DefaultVigorValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    RaceCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RammingSizeModifiers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RammingSizeModifiers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RangeAndTargetDCs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    TargetDC = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RangeAndTargetDCs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Rituals",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    PreperationTime = table.Column<string>(nullable: true),
                    DifficultyCheck = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Components = table.Column<string>(nullable: true),
                    AlternateComponents = table.Column<string>(nullable: true),
                    DifficultyTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rituals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    SkillBase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    StaminaCost = table.Column<int>(nullable: false),
                    Effect = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Defense = table.Column<string>(nullable: true),
                    SkillLevelID = table.Column<int>(nullable: false),
                    SpellCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    StatisticTypeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Substances",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(nullable: false),
                    Rarity = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    ForageDC = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Substances", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ToolKits",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Availability = table.Column<string>(nullable: true),
                    Concealment = table.Column<string>(nullable: true),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToolKits", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AttackType = table.Column<string>(nullable: true),
                    WeaponAccuracy = table.Column<int>(nullable: false),
                    Availability = table.Column<string>(nullable: true),
                    Damage = table.Column<string>(nullable: true),
                    DefaultReliability = table.Column<int>(nullable: false),
                    HandsRequired = table.Column<int>(nullable: false),
                    Range = table.Column<string>(nullable: true),
                    Concealment = table.Column<string>(nullable: true),
                    Enhancements = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    WeaponCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "WitcherSigns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    TypeID = table.Column<int>(nullable: false),
                    StaminaType = table.Column<string>(nullable: true),
                    Effect = table.Column<string>(nullable: true),
                    Range = table.Column<string>(nullable: true),
                    Duration = table.Column<string>(nullable: true),
                    Defense = table.Column<string>(nullable: true),
                    SignClassificationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WitcherSigns", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CraftingDiagramComponents",
                columns: table => new
                {
                    CraftingDiagramID = table.Column<int>(nullable: false),
                    CraftingComponentID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftingDiagramComponents", x => new { x.CraftingDiagramID, x.CraftingComponentID });
                    table.ForeignKey(
                        name: "FK_CraftingDiagramComponents_CraftingComponents_CraftingComponentID",
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
                });

            migrationBuilder.CreateTable(
                name: "EffectPackages",
                columns: table => new
                {
                    EffectPackageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EffectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EffectPackages", x => x.EffectPackageID);
                    table.ForeignKey(
                        name: "FK_EffectPackages_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSheets",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Vigor = table.Column<int>(nullable: false),
                    ImprovementPoints = table.Column<int>(nullable: false),
                    Encumbrance = table.Column<decimal>(nullable: false),
                    Clothing = table.Column<string>(nullable: true),
                    Personality = table.Column<string>(nullable: true),
                    HairStyle = table.Column<string>(nullable: true),
                    Affectations = table.Column<string>(nullable: true),
                    ValuedPerson = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    FeelingsOnPeople = table.Column<string>(nullable: true),
                    RaceID = table.Column<int>(nullable: false),
                    ProfessionID = table.Column<int>(nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                });

            migrationBuilder.CreateTable(
                name: "DefiningSkills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatisticID = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PreviousSkillID = table.Column<int>(nullable: true),
                    FollowingSkillID = table.Column<int>(nullable: true),
                    IsBaseSkill = table.Column<bool>(nullable: false),
                    ProfessionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefiningSkills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DefiningSkills_Statistics_FollowingSkillID",
                        column: x => x.FollowingSkillID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DefiningSkills_Statistics_PreviousSkillID",
                        column: x => x.PreviousSkillID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DefiningSkills_Professions_ProfessionID",
                        column: x => x.ProfessionID,
                        principalTable: "Professions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DefiningSkills_Statistics_StatisticID",
                        column: x => x.StatisticID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SkillTypeID = table.Column<int>(nullable: false),
                    StatisticID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Skills_Statistics_StatisticID",
                        column: x => x.StatisticID,
                        principalTable: "Statistics",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormulaeComponents",
                columns: table => new
                {
                    FormulaeID = table.Column<int>(nullable: false),
                    SubstanceID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormulaeComponents", x => new { x.FormulaeID, x.SubstanceID });
                    table.ForeignKey(
                        name: "FK_FormulaeComponents_Formulaes_FormulaeID",
                        column: x => x.FormulaeID,
                        principalTable: "Formulaes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormulaeComponents_Substances_SubstanceID",
                        column: x => x.SubstanceID,
                        principalTable: "Substances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAlchemicalItems",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    AlchemicalItemID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
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
                    IsEquipped = table.Column<bool>(nullable: false)
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
                    CharacterSheetID = table.Column<int>(nullable: false),
                    ArmorID = table.Column<int>(nullable: false),
                    StoppingPower = table.Column<int>(nullable: false),
                    EnhancementSlotsOpen = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    IsEquipped = table.Column<bool>(nullable: false),
                    EffectPackageID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterArmors", x => new { x.CharacterSheetID, x.ArmorID });
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
                    table.ForeignKey(
                        name: "FK_CharacterArmors_EffectPackages_EffectPackageID",
                        column: x => x.EffectPackageID,
                        principalTable: "EffectPackages",
                        principalColumn: "EffectPackageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterCampaignNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false)
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
                name: "CharacterEarlyLifeNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false)
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
                    CharacterSheetID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    CurrentDuration = table.Column<int>(nullable: false),
                    CurrentValue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEffects", x => new { x.CharacterSheetID, x.EffectID });
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
                    FormulaeID = table.Column<int>(nullable: false)
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
                    Amount = table.Column<int>(nullable: true)
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
                    HexID = table.Column<int>(nullable: false)
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
                name: "CharacterLifeEvents",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Decade = table.Column<int>(nullable: false),
                    Event = table.Column<string>(nullable: true)
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
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Mounts_VehicleID = table.Column<int>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Mount_VehicleID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMount_Vehicles", x => new { x.CharacterSheetID, x.Mounts_VehicleID });
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
                name: "CharacterNotes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterSheetID = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false)
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
                name: "CharacterPriestInvocations",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    PriestInvocationID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterPriestInvocations", x => new { x.CharacterSheetID, x.PriestInvocationID });
                    table.ForeignKey(
                        name: "FK_CharacterPriestInvocations_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterPriestInvocations_PriestInvocations_PriestInvocationID",
                        column: x => x.PriestInvocationID,
                        principalTable: "PriestInvocations",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterRituals",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    RitualID = table.Column<int>(nullable: false)
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
                    ServiceID = table.Column<int>(nullable: false)
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
                    SpellID = table.Column<int>(nullable: false)
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
                    Value = table.Column<int>(nullable: false)
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
                    SubstanceID = table.Column<int>(nullable: false)
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
                        name: "FK_CharacterSubstances_Substances_SubstanceID",
                        column: x => x.SubstanceID,
                        principalTable: "Substances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterToolKits",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    ToolKitID = table.Column<int>(nullable: false),
                    Amount = table.Column<int>(nullable: false)
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
                name: "CharacterWeapons",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WeaponID = table.Column<int>(nullable: false),
                    Reliability = table.Column<int>(nullable: false),
                    Weight = table.Column<decimal>(nullable: false),
                    IsEquipped = table.Column<bool>(nullable: false),
                    HasAmmunition = table.Column<bool>(nullable: false),
                    WeaponEnhancementsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWeapons", x => new { x.CharacterSheetID, x.WeaponID });
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
                name: "CharacterWitcherSigns",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    WitcherSignID = table.Column<int>(nullable: false)
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
                    Value = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterDefiningSkills", x => new { x.CharacterSheetID, x.DefiningSkillID });
                    table.ForeignKey(
                        name: "FK_CharacterDefiningSkills_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CharacterDefiningSkills_DefiningSkills_DefiningSkillID",
                        column: x => x.DefiningSkillID,
                        principalTable: "DefiningSkills",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    SkillID = table.Column<int>(nullable: false),
                    Value = table.Column<int>(nullable: false)
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
                name: "SkillPackages",
                columns: table => new
                {
                    ProfessionID = table.Column<int>(nullable: false),
                    SkillID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillPackages", x => new { x.ProfessionID, x.SkillID });
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterArmorEffect",
                columns: table => new
                {
                    CharacterArmorID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    CurrentDuration = table.Column<int>(nullable: false),
                    CurrentValue = table.Column<int>(nullable: false),
                    CharacterArmorCharacterSheetID = table.Column<int>(nullable: true),
                    CharacterArmorArmorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterArmorEffect", x => new { x.CharacterArmorID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_CharacterArmorEffect_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterArmorEffect_CharacterArmors_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                        columns: x => new { x.CharacterArmorCharacterSheetID, x.CharacterArmorArmorID },
                        principalTable: "CharacterArmors",
                        principalColumns: new[] { "CharacterSheetID", "ArmorID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterArmorEnhancements",
                columns: table => new
                {
                    CharacterSheetID = table.Column<int>(nullable: false),
                    ArmorEnhancementID = table.Column<int>(nullable: false),
                    IsEquipped = table.Column<bool>(nullable: false),
                    CharacterArmorID = table.Column<int>(nullable: true),
                    CharacterArmorCharacterSheetID = table.Column<int>(nullable: true),
                    CharacterArmorArmorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterArmorEnhancements", x => new { x.CharacterSheetID, x.ArmorEnhancementID });
                    table.ForeignKey(
                        name: "FK_CharacterArmorEnhancements_ArmorEnhancements_ArmorEnhancementID",
                        column: x => x.ArmorEnhancementID,
                        principalTable: "ArmorEnhancements",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterArmorEnhancements_CharacterSheets_CharacterSheetID",
                        column: x => x.CharacterSheetID,
                        principalTable: "CharacterSheets",
                        principalColumn: "CharacterSheetID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterArmorEnhancements_CharacterArmors_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                        columns: x => new { x.CharacterArmorCharacterSheetID, x.CharacterArmorArmorID },
                        principalTable: "CharacterArmors",
                        principalColumns: new[] { "CharacterSheetID", "ArmorID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMountOutfits",
                columns: table => new
                {
                    CharacterMount_VehicleID = table.Column<int>(nullable: false),
                    MountOutfitID = table.Column<int>(nullable: false),
                    CharacterMount_VehicleCharacterSheetID = table.Column<int>(nullable: false),
                    CharacterMount_VehicleMounts_VehicleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMountOutfits", x => new { x.CharacterMount_VehicleID, x.MountOutfitID });
                    table.ForeignKey(
                        name: "FK_CharacterMountOutfits_MountOutfits_MountOutfitID",
                        column: x => x.MountOutfitID,
                        principalTable: "MountOutfits",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMountOutfits_CharacterMount_Vehicles_CharacterMount_VehicleCharacterSheetID_CharacterMount_VehicleMounts_VehicleID",
                        columns: x => new { x.CharacterMount_VehicleCharacterSheetID, x.CharacterMount_VehicleMounts_VehicleID },
                        principalTable: "CharacterMount_Vehicles",
                        principalColumns: new[] { "CharacterSheetID", "Mounts_VehicleID" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterWeaponEffect",
                columns: table => new
                {
                    CharacterWeaponID = table.Column<int>(nullable: false),
                    EffectID = table.Column<int>(nullable: false),
                    CurrentDuration = table.Column<int>(nullable: false),
                    CurrentValue = table.Column<int>(nullable: false),
                    CharacterWeaponCharacterSheetID = table.Column<int>(nullable: true),
                    CharacterWeaponWeaponID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterWeaponEffect", x => new { x.CharacterWeaponID, x.EffectID });
                    table.ForeignKey(
                        name: "FK_CharacterWeaponEffect_Effects_EffectID",
                        column: x => x.EffectID,
                        principalTable: "Effects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterWeaponEffect_CharacterWeapons_CharacterWeaponCharacterSheetID_CharacterWeaponWeaponID",
                        columns: x => new { x.CharacterWeaponCharacterSheetID, x.CharacterWeaponWeaponID },
                        principalTable: "CharacterWeapons",
                        principalColumns: new[] { "CharacterSheetID", "WeaponID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAlchemicalItems_AlchemicalItemID",
                table: "CharacterAlchemicalItems",
                column: "AlchemicalItemID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAmmunitions_AmmunitionID",
                table: "CharacterAmmunitions",
                column: "AmmunitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEffect_EffectID",
                table: "CharacterArmorEffect",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEffect_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEffect",
                columns: new[] { "CharacterArmorCharacterSheetID", "CharacterArmorArmorID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_ArmorEnhancementID",
                table: "CharacterArmorEnhancements",
                column: "ArmorEnhancementID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmorEnhancements_CharacterArmorCharacterSheetID_CharacterArmorArmorID",
                table: "CharacterArmorEnhancements",
                columns: new[] { "CharacterArmorCharacterSheetID", "CharacterArmorArmorID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmors_ArmorID",
                table: "CharacterArmors",
                column: "ArmorID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterArmors_EffectPackageID",
                table: "CharacterArmors",
                column: "EffectPackageID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterCampaignNotes_CharacterSheetID",
                table: "CharacterCampaignNotes",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterDefiningSkills_DefiningSkillID",
                table: "CharacterDefiningSkills",
                column: "DefiningSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEarlyLifeNotes_CharacterSheetID",
                table: "CharacterEarlyLifeNotes",
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
                name: "IX_CharacterHexs_HexID",
                table: "CharacterHexs",
                column: "HexID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterLifeEvents_CharacterSheetID",
                table: "CharacterLifeEvents",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMount_Vehicles_Mount_VehicleID",
                table: "CharacterMount_Vehicles",
                column: "Mount_VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMountOutfits_MountOutfitID",
                table: "CharacterMountOutfits",
                column: "MountOutfitID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMountOutfits_CharacterMount_VehicleCharacterSheetID_CharacterMount_VehicleMounts_VehicleID",
                table: "CharacterMountOutfits",
                columns: new[] { "CharacterMount_VehicleCharacterSheetID", "CharacterMount_VehicleMounts_VehicleID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterNotes_CharacterSheetID",
                table: "CharacterNotes",
                column: "CharacterSheetID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterPriestInvocations_PriestInvocationID",
                table: "CharacterPriestInvocations",
                column: "PriestInvocationID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterRituals_RitualID",
                table: "CharacterRituals",
                column: "RitualID");

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
                name: "IX_CharacterWeaponEffect_EffectID",
                table: "CharacterWeaponEffect",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeaponEffect_CharacterWeaponCharacterSheetID_CharacterWeaponWeaponID",
                table: "CharacterWeaponEffect",
                columns: new[] { "CharacterWeaponCharacterSheetID", "CharacterWeaponWeaponID" });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWeapons_WeaponID",
                table: "CharacterWeapons",
                column: "WeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterWitcherSigns_WitcherSignID",
                table: "CharacterWitcherSigns",
                column: "WitcherSignID");

            migrationBuilder.CreateIndex(
                name: "IX_CraftingDiagramComponents_CraftingComponentID",
                table: "CraftingDiagramComponents",
                column: "CraftingComponentID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_FollowingSkillID",
                table: "DefiningSkills",
                column: "FollowingSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_PreviousSkillID",
                table: "DefiningSkills",
                column: "PreviousSkillID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_ProfessionID",
                table: "DefiningSkills",
                column: "ProfessionID");

            migrationBuilder.CreateIndex(
                name: "IX_DefiningSkills_StatisticID",
                table: "DefiningSkills",
                column: "StatisticID");

            migrationBuilder.CreateIndex(
                name: "IX_EffectPackages_EffectID",
                table: "EffectPackages",
                column: "EffectID");

            migrationBuilder.CreateIndex(
                name: "IX_FormulaeComponents_SubstanceID",
                table: "FormulaeComponents",
                column: "SubstanceID");

            migrationBuilder.CreateIndex(
                name: "IX_RacialPerks_RaceID",
                table: "RacialPerks",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_SkillPackages_SkillID",
                table: "SkillPackages",
                column: "SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_StatisticID",
                table: "Skills",
                column: "StatisticID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AttackModifiers");

            migrationBuilder.DropTable(
                name: "CharacterAlchemicalItems");

            migrationBuilder.DropTable(
                name: "CharacterAmmunitions");

            migrationBuilder.DropTable(
                name: "CharacterArmorEffect");

            migrationBuilder.DropTable(
                name: "CharacterArmorEnhancements");

            migrationBuilder.DropTable(
                name: "CharacterCampaignNotes");

            migrationBuilder.DropTable(
                name: "CharacterDefiningSkills");

            migrationBuilder.DropTable(
                name: "CharacterEarlyLifeNotes");

            migrationBuilder.DropTable(
                name: "CharacterEffects");

            migrationBuilder.DropTable(
                name: "CharacterFormulaes");

            migrationBuilder.DropTable(
                name: "CharacterGeneralGears");

            migrationBuilder.DropTable(
                name: "CharacterHexs");

            migrationBuilder.DropTable(
                name: "CharacterLifeEvents");

            migrationBuilder.DropTable(
                name: "CharacterMountOutfits");

            migrationBuilder.DropTable(
                name: "CharacterNotes");

            migrationBuilder.DropTable(
                name: "CharacterPriestInvocations");

            migrationBuilder.DropTable(
                name: "CharacterRituals");

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
                name: "CharacterWeaponEffect");

            migrationBuilder.DropTable(
                name: "CharacterWitcherSigns");

            migrationBuilder.DropTable(
                name: "CommonCovers");

            migrationBuilder.DropTable(
                name: "CraftingDiagramComponents");

            migrationBuilder.DropTable(
                name: "DamageLocations");

            migrationBuilder.DropTable(
                name: "FormulaeComponents");

            migrationBuilder.DropTable(
                name: "LightLevelModifiers");

            migrationBuilder.DropTable(
                name: "RacialPerks");

            migrationBuilder.DropTable(
                name: "RammingSizeModifiers");

            migrationBuilder.DropTable(
                name: "RangeAndTargetDCs");

            migrationBuilder.DropTable(
                name: "SkillPackages");

            migrationBuilder.DropTable(
                name: "AlchemicalItems");

            migrationBuilder.DropTable(
                name: "Ammunitions");

            migrationBuilder.DropTable(
                name: "ArmorEnhancements");

            migrationBuilder.DropTable(
                name: "CharacterArmors");

            migrationBuilder.DropTable(
                name: "DefiningSkills");

            migrationBuilder.DropTable(
                name: "GeneralGears");

            migrationBuilder.DropTable(
                name: "Hexs");

            migrationBuilder.DropTable(
                name: "MountOutfits");

            migrationBuilder.DropTable(
                name: "CharacterMount_Vehicles");

            migrationBuilder.DropTable(
                name: "PriestInvocations");

            migrationBuilder.DropTable(
                name: "Rituals");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "ToolKits");

            migrationBuilder.DropTable(
                name: "CharacterWeapons");

            migrationBuilder.DropTable(
                name: "WitcherSigns");

            migrationBuilder.DropTable(
                name: "CraftingComponents");

            migrationBuilder.DropTable(
                name: "CraftingDiagrams");

            migrationBuilder.DropTable(
                name: "Formulaes");

            migrationBuilder.DropTable(
                name: "Substances");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Armors");

            migrationBuilder.DropTable(
                name: "EffectPackages");

            migrationBuilder.DropTable(
                name: "Mount_Vehicles");

            migrationBuilder.DropTable(
                name: "CharacterSheets");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Effects");

            migrationBuilder.DropTable(
                name: "Professions");

            migrationBuilder.DropTable(
                name: "Races");
        }
    }
}
