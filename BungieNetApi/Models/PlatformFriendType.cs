using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum PlatformFriendType
    {
        /// <summary>
        /// Unknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unknown = 0,

        /// <summary>
        /// Xbox = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Xbox = 1,

        /// <summary>
        /// PSN = 2
        /// </summary>
        [EnumMember(Value = "2")]
        PSN = 2,

        /// <summary>
        /// Steam = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Steam = 3,

    }
}