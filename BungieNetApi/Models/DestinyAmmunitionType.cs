using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum DestinyAmmunitionType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Primary = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Primary = 1,

        /// <summary>
        /// Special = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Special = 2,

        /// <summary>
        /// Heavy = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Heavy = 3,

        /// <summary>
        /// Unknown = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Unknown = 4,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}