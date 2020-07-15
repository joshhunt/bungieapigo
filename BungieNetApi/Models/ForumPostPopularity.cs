using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum ForumPostPopularity
    {
        /// <summary>
        /// Empty = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Empty = 0,

        /// <summary>
        /// Default = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Default = 1,

        /// <summary>
        /// Discussed = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Discussed = 2,

        /// <summary>
        /// CoolStory = 3
        /// </summary>
        [EnumMember(Value = "3")]
        CoolStory = 3,

        /// <summary>
        /// HeatingUp = 4
        /// </summary>
        [EnumMember(Value = "4")]
        HeatingUp = 4,

        /// <summary>
        /// Hot = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Hot = 5,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}