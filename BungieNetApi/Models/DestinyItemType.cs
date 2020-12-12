using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// An enumeration that indicates the high-level "type" of the item, attempting to iron out the context specific differences for specific instances of an entity. For instance, though a weapon may be of various weapon "Types", in DestinyItemType they are all classified as "Weapon". This allows for better filtering on a higher level of abstraction for the concept of types.
    /// </summary>
    /// <summary>
    ///  This enum is provided for historical compatibility with Destiny 1, but an ideal alternative is to use DestinyItemCategoryDefinitions and the DestinyItemDefinition.itemCategories property instead. Item Categories allow for arbitrary hierarchies of specificity, and for items to belong to multiple categories across multiple hierarchies simultaneously. For this enum, we pick a single type as a "best guess" fit.
    /// </summary>
    /// <summary>
    ///  NOTE: This is not all of the item types available, and some of these are holdovers from Destiny 1 that may or may not still exist.
    /// </summary>
    /// <summary>
    ///  I keep updating these because they're so damn convenient. I guess I shouldn't fight it.
    /// </summary>
    
    public enum DestinyItemType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Currency = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Currency = 1,

        /// <summary>
        /// Armor = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Armor = 2,

        /// <summary>
        /// Weapon = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Weapon = 3,

        /// <summary>
        /// Message = 7
        /// </summary>
        [EnumMember(Value = "7")]
        Message = 7,

        /// <summary>
        /// Engram = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Engram = 8,

        /// <summary>
        /// Consumable = 9
        /// </summary>
        [EnumMember(Value = "9")]
        Consumable = 9,

        /// <summary>
        /// ExchangeMaterial = 10
        /// </summary>
        [EnumMember(Value = "10")]
        ExchangeMaterial = 10,

        /// <summary>
        /// MissionReward = 11
        /// </summary>
        [EnumMember(Value = "11")]
        MissionReward = 11,

        /// <summary>
        /// QuestStep = 12
        /// </summary>
        [EnumMember(Value = "12")]
        QuestStep = 12,

        /// <summary>
        /// QuestStepComplete = 13
        /// </summary>
        [EnumMember(Value = "13")]
        QuestStepComplete = 13,

        /// <summary>
        /// Emblem = 14
        /// </summary>
        [EnumMember(Value = "14")]
        Emblem = 14,

        /// <summary>
        /// Quest = 15
        /// </summary>
        [EnumMember(Value = "15")]
        Quest = 15,

        /// <summary>
        /// Subclass = 16
        /// </summary>
        [EnumMember(Value = "16")]
        Subclass = 16,

        /// <summary>
        /// ClanBanner = 17
        /// </summary>
        [EnumMember(Value = "17")]
        ClanBanner = 17,

        /// <summary>
        /// Aura = 18
        /// </summary>
        [EnumMember(Value = "18")]
        Aura = 18,

        /// <summary>
        /// Mod = 19
        /// </summary>
        [EnumMember(Value = "19")]
        Mod = 19,

        /// <summary>
        /// Dummy = 20
        /// </summary>
        [EnumMember(Value = "20")]
        Dummy = 20,

        /// <summary>
        /// Ship = 21
        /// </summary>
        [EnumMember(Value = "21")]
        Ship = 21,

        /// <summary>
        /// Vehicle = 22
        /// </summary>
        [EnumMember(Value = "22")]
        Vehicle = 22,

        /// <summary>
        /// Emote = 23
        /// </summary>
        [EnumMember(Value = "23")]
        Emote = 23,

        /// <summary>
        /// Ghost = 24
        /// </summary>
        [EnumMember(Value = "24")]
        Ghost = 24,

        /// <summary>
        /// Package = 25
        /// </summary>
        [EnumMember(Value = "25")]
        Package = 25,

        /// <summary>
        /// Bounty = 26
        /// </summary>
        [EnumMember(Value = "26")]
        Bounty = 26,

        /// <summary>
        /// Wrapper = 27
        /// </summary>
        [EnumMember(Value = "27")]
        Wrapper = 27,

        /// <summary>
        /// SeasonalArtifact = 28
        /// </summary>
        [EnumMember(Value = "28")]
        SeasonalArtifact = 28,

        /// <summary>
        /// Finisher = 29
        /// </summary>
        [EnumMember(Value = "29")]
        Finisher = 29,

    }
}