using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum CommunityContentSortMode
    {
        /// <summary>
        /// Trending = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Trending = 0,

        /// <summary>
        /// Latest = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Latest = 1,

        /// <summary>
        /// HighestRated = 2
        /// </summary>
        [EnumMember(Value = "2")]
        HighestRated = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}