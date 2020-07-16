using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// This Enumeration further classifies items by more specific categorizations than DestinyItemType. The "Sub-Type" is where we classify and categorize items one step further in specificity: "Auto Rifle" instead of just "Weapon" for example, or "Vanguard Bounty" instead of merely "Bounty".
    /// </summary>
    /// <summary>
    /// These sub-types are provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a "best guess" fit.
    /// </summary>
    /// <summary>
    /// NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    
    public enum DestinyItemSubType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Crucible = 1
        /// DEPRECATED. Items can be both &quot;Crucible&quot; and something else interesting.
        /// </summary>
        [EnumMember(Value = "1")]
        Crucible = 1,

        /// <summary>
        /// Vanguard = 2
        /// DEPRECATED. An item can both be &quot;Vanguard&quot; and something else.
        /// </summary>
        [EnumMember(Value = "2")]
        Vanguard = 2,

        /// <summary>
        /// Exotic = 5
        /// DEPRECATED. An item can both be Exotic and something else.
        /// </summary>
        [EnumMember(Value = "5")]
        Exotic = 5,

        /// <summary>
        /// AutoRifle = 6
        /// </summary>
        [EnumMember(Value = "6")]
        AutoRifle = 6,

        /// <summary>
        /// Shotgun = 7
        /// </summary>
        [EnumMember(Value = "7")]
        Shotgun = 7,

        /// <summary>
        /// Machinegun = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Machinegun = 8,

        /// <summary>
        /// HandCannon = 9
        /// </summary>
        [EnumMember(Value = "9")]
        HandCannon = 9,

        /// <summary>
        /// RocketLauncher = 10
        /// </summary>
        [EnumMember(Value = "10")]
        RocketLauncher = 10,

        /// <summary>
        /// FusionRifle = 11
        /// </summary>
        [EnumMember(Value = "11")]
        FusionRifle = 11,

        /// <summary>
        /// SniperRifle = 12
        /// </summary>
        [EnumMember(Value = "12")]
        SniperRifle = 12,

        /// <summary>
        /// PulseRifle = 13
        /// </summary>
        [EnumMember(Value = "13")]
        PulseRifle = 13,

        /// <summary>
        /// ScoutRifle = 14
        /// </summary>
        [EnumMember(Value = "14")]
        ScoutRifle = 14,

        /// <summary>
        /// Crm = 16
        /// DEPRECATED. An item can both be CRM and something else.
        /// </summary>
        [EnumMember(Value = "16")]
        Crm = 16,

        /// <summary>
        /// Sidearm = 17
        /// </summary>
        [EnumMember(Value = "17")]
        Sidearm = 17,

        /// <summary>
        /// Sword = 18
        /// </summary>
        [EnumMember(Value = "18")]
        Sword = 18,

        /// <summary>
        /// Mask = 19
        /// </summary>
        [EnumMember(Value = "19")]
        Mask = 19,

        /// <summary>
        /// Shader = 20
        /// </summary>
        [EnumMember(Value = "20")]
        Shader = 20,

        /// <summary>
        /// Ornament = 21
        /// </summary>
        [EnumMember(Value = "21")]
        Ornament = 21,

        /// <summary>
        /// FusionRifleLine = 22
        /// </summary>
        [EnumMember(Value = "22")]
        FusionRifleLine = 22,

        /// <summary>
        /// GrenadeLauncher = 23
        /// </summary>
        [EnumMember(Value = "23")]
        GrenadeLauncher = 23,

        /// <summary>
        /// SubmachineGun = 24
        /// </summary>
        [EnumMember(Value = "24")]
        SubmachineGun = 24,

        /// <summary>
        /// TraceRifle = 25
        /// </summary>
        [EnumMember(Value = "25")]
        TraceRifle = 25,

        /// <summary>
        /// HelmetArmor = 26
        /// </summary>
        [EnumMember(Value = "26")]
        HelmetArmor = 26,

        /// <summary>
        /// GauntletsArmor = 27
        /// </summary>
        [EnumMember(Value = "27")]
        GauntletsArmor = 27,

        /// <summary>
        /// ChestArmor = 28
        /// </summary>
        [EnumMember(Value = "28")]
        ChestArmor = 28,

        /// <summary>
        /// LegArmor = 29
        /// </summary>
        [EnumMember(Value = "29")]
        LegArmor = 29,

        /// <summary>
        /// ClassArmor = 30
        /// </summary>
        [EnumMember(Value = "30")]
        ClassArmor = 30,

        /// <summary>
        /// Bow = 31
        /// </summary>
        [EnumMember(Value = "31")]
        Bow = 31,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}