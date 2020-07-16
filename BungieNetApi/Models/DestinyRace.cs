using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum DestinyRace
    {
        /// <summary>
        /// Human = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Human = 0,

        /// <summary>
        /// Awoken = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Awoken = 1,

        /// <summary>
        /// Exo = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Exo = 2,

        /// <summary>
        /// Unknown = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Unknown = 3,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}