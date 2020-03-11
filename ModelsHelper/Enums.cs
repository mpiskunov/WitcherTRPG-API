using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WitcherTRPGWebApplication.ModelsHelper
{
    public enum StatisticCategory
    {
        INT = 1,
        REF = 2,
        DEX = 3,
        BODY = 4,
        SPEED = 5,
        EMP = 6,
        CRA = 7,
        WILL = 8,
        LUCK = 9
    }

    public enum SkillCategory
    {
        Awareness = 1,
        Business = 2,
        Deduction = 3,
        Education = 4,
        Language = 5,
        MonsterLore = 6,
        SocialEtiquette = 7,
        StreetWise = 8,
        Tactics = 9,
        Teaching = 10,
        WildernessSurvival = 11,
        Brawling = 12,
        DodgeEscape = 13,
        Melee = 14,
        Riding = 15,
        Sailing = 16,
        SmallBlades = 1,
        StaffSpear = 1,
        Swordsmanship = 1,
        Archery = 20,
        Athletics = 21,
        Crossbow = 22,
        SleightOfHand = 23,
        Stealth = 24,
        Physique = 25,
        Endurance = 26,
        Charisma = 27,
        Deceit = 28,
        FineArts = 29,
        Gambling = 30,
        GroomingAndStyle = 31,
        HumanPerception = 32,
        Leadership = 33,
        Persuasion = 34,
        Performance = 35,
        Seduction = 36,
        Alchemy = 37,
        Crafting = 38,
        Disguise = 39,
        FirstAid = 40,
        Forgery = 41,
        PickLock = 42,
        TrapCrafting = 43,
        Courage = 44,
        HexWeaving = 45,
        Intimidation = 46,
        SpellCasting = 47,
        ResisMagic = 48,
        ResistCoercion = 49,
        RitualCrafting = 50
    }
    public enum EffectCategory
    {
        Weapon = 1,
        Armor = 2,
        Alchemical = 3,
        Ammunition = 4,
        ArmorEnhancement = 5,
        MountOrVehicle = 6,
        ToolKit = 7,
        Other
    }
    public enum WeaponClassification
    {
        Sword = 1,
        SmallBlade = 2,
        Axe = 3,
        Bludgeon = 4,
        PoleArm = 5,
        Stave = 6,
        ThrownWeapon = 7,
        Bow = 8,
        CrossBow = 9
    }
    public enum ArmorClassification
    {
        Head = 1,
        Torso = 2,
        LegArmor = 3,
        Shield = 4,
        LeftArm = 5,
        RightArm = 6,
        LeftLeg = 7,
        RightLeg = 8,
        ArmArmor = 9
    }
    public enum WeightClassification
    {
        Light = 1,
        Medium = 2,
        Heavy = 3
    }

    public enum MountOutfitClassification
    {
        Saddle = 1,
        Blinder = 2,
        SaddleBag = 3,
        Barding = 4
    }

    public enum GeneralGearClassification
    {
        GeneralGear = 1,
        Container = 2,
        FoodAndDrink = 3,
        Clothing = 4,
        Service = 5,
        Lodging = 6,
        WitcherGear = 7
    }

    public enum SpellDifficultyClassification
    {
        NoviceSpell = 1,
        JourneymanSpell = 2,
        MasterSpell = 3,
        ArchPriest = 4
    }
    public enum SpellTypeClassification
    {
        Earth = 1,
        Air = 2,
        Fire = 3,
        Water = 4,
        MixedElement = 5,
        DruidInvocation = 6,
        PreacherInvocation = 7,
        ArchPriestInvocation = 8
    }
    public enum WitcherSignClassification
    {
        Basic = 1,
        Alternate = 2
    }

    public enum SkillLevel
    {
        Novice = 1,
        Journeyman = 2,
        Master = 3,
        Grandmaster = 4
    }

    public enum AlchemySkillLevel
    {
        Novice = 1,
        Journeyman = 2,
        Master = 3,
        WitcherPotion = 4,
        BladeOil = 5,
        WitcherDecoction = 6
    }

    public enum MutagenType
    {
        Red = 1,
        Green = 2,
        Blue = 3
    }

    /// <summary>
    /// Used to distinguish different Diagram types when Crafting.
    /// </summary>
    public enum CraftingDiagramCategory
    {
        Ingredient = 1,
        Weapon = 2,
        Armor = 3,
        Ammunition = 4,
        ElderfolkWeapon = 5,
        ElderfolkArmor = 6,
        ElderfolkAmmunition = 7,
        ArmorEnhancement = 8,
        WitcherGear = 9
    }

    /// <summary>
    /// Used to distinguish different Component Types when Crafting.
    /// </summary>
    public enum CraftingComponentType
    {
        CraftingMaterial = 1,
        HideOrAnimalPart = 2,
        AlchemicalTreatment = 3,
        IngotOrMineral = 4
    }

    public enum AlchemyCategory
    {
        Vitriol = 1,
        Rebis = 2,
        Aether = 3,
        Quebirth = 4,
        Hydragenum = 5,
        Vermilion = 6,
        Sol = 7,
        Caelum = 8,
        Fulgur = 9
    }

    public enum CriticalLevelCategory
    { 
        Simple = 1,
        Complex = 2,
        Difficult = 3,
        Deadly = 4
    }

    public enum ProfessionCategory
    {
        Bard =1,
        Crafstman = 2,
        Criminal = 3,
        Doctor = 4,
        Mage = 5,
        ManAtArms = 6,
        Merchant = 7,
        Priest = 8,
        Witcher = 9,
        Noble = 10
    }

    public enum DefiningSkillTableType
    {
        Description = 1,
        Table = 2
    }

    public enum MonsterType
    {
        Humanoid = 1,
        Necrophage = 2,
        Specter = 3,
        Beast = 4,
        CursedOne = 5,
        Hybrid = 6,
        Insectoid = 7,
        Elementa = 8,
        Relict = 9,
        Ogroid = 10,
        Draconoid = 11,
        Vampire = 12,
        Other = 13
    }

    public enum RaceType
    {
        Witcher = 1,
        Elven = 2,
        Dwarvern = 3,
        Human = 4,
        Halfling = 5
    }

}
