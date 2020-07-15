using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum PeriodType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Daily = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Daily = 1,

        /// <summary>
        /// AllTime = 2
        /// </summary>
        [EnumMember(Value = "2")]
        AllTime = 2,

        /// <summary>
        /// Activity = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Activity = 3,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}