using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum FireteamDateRange
    {
        /// <summary>
        /// All = 0
        /// </summary>
        [EnumMember(Value = "0")]
        All = 0,

        /// <summary>
        /// Now = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Now = 1,

        /// <summary>
        /// TwentyFourHours = 2
        /// </summary>
        [EnumMember(Value = "2")]
        TwentyFourHours = 2,

        /// <summary>
        /// FortyEightHours = 3
        /// </summary>
        [EnumMember(Value = "3")]
        FortyEightHours = 3,

        /// <summary>
        /// ThisWeek = 4
        /// </summary>
        [EnumMember(Value = "4")]
        ThisWeek = 4,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}