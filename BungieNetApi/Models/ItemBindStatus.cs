using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum ItemBindStatus
    {
        /// <summary>
        /// NotBound = 0
        /// </summary>
        [EnumMember(Value = "0")]
        NotBound = 0,

        /// <summary>
        /// BoundToCharacter = 1
        /// </summary>
        [EnumMember(Value = "1")]
        BoundToCharacter = 1,

        /// <summary>
        /// BoundToAccount = 2
        /// </summary>
        [EnumMember(Value = "2")]
        BoundToAccount = 2,

        /// <summary>
        /// BoundToGuild = 3
        /// </summary>
        [EnumMember(Value = "3")]
        BoundToGuild = 3,

    }
}