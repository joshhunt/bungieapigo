using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupSortBy
    {
        /// <summary>
        /// Name = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Name = 0,

        /// <summary>
        /// Date = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Date = 1,

        /// <summary>
        /// Popularity = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Popularity = 2,

        /// <summary>
        /// Id = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Id = 3,

    }
}