using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents the possible and known UI styles used by the game for rendering Socket Categories.
    /// </summary>
    
    public enum DestinySocketCategoryStyle
    {
        /// <summary>
        /// Unknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unknown = 0,

        /// <summary>
        /// Reusable = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Reusable = 1,

        /// <summary>
        /// Consumable = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Consumable = 2,

        /// <summary>
        /// Unlockable = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Unlockable = 3,

        /// <summary>
        /// Intrinsic = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Intrinsic = 4,

        /// <summary>
        /// EnergyMeter = 5
        /// </summary>
        [EnumMember(Value = "5")]
        EnergyMeter = 5,

        /// <summary>
        /// LargePerk = 6
        /// </summary>
        [EnumMember(Value = "6")]
        LargePerk = 6,

    }
}