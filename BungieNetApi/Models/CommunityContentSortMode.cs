using System.Runtime.Serialization;

namespace GhostSharper.Models
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

    }
}