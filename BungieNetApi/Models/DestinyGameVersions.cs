using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// A flags enumeration/bitmask indicating the versions of the game that a given user has purchased.
    /// </summary>
    [Flags]
    public enum DestinyGameVersions
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Destiny2 = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Destiny2 = 1,

        /// <summary>
        /// DLC1 = 2
        /// </summary>
        [EnumMember(Value = "2")]
        DLC1 = 2,

        /// <summary>
        /// DLC2 = 4
        /// </summary>
        [EnumMember(Value = "4")]
        DLC2 = 4,

        /// <summary>
        /// Forsaken = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Forsaken = 8,

        /// <summary>
        /// YearTwoAnnualPass = 16
        /// </summary>
        [EnumMember(Value = "16")]
        YearTwoAnnualPass = 16,

        /// <summary>
        /// Shadowkeep = 32
        /// </summary>
        [EnumMember(Value = "32")]
        Shadowkeep = 32,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}