using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum TierType
    {
        /// <summary>
        /// Unknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unknown = 0,

        /// <summary>
        /// Currency = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Currency = 1,

        /// <summary>
        /// Basic = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Basic = 2,

        /// <summary>
        /// Common = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Common = 3,

        /// <summary>
        /// Rare = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Rare = 4,

        /// <summary>
        /// Superior = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Superior = 5,

        /// <summary>
        /// Exotic = 6
        /// </summary>
        [EnumMember(Value = "6")]
        Exotic = 6,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}