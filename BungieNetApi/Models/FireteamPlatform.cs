using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum FireteamPlatform
    {
        /// <summary>
        /// Unknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unknown = 0,

        /// <summary>
        /// Playstation4 = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Playstation4 = 1,

        /// <summary>
        /// XboxOne = 2
        /// </summary>
        [EnumMember(Value = "2")]
        XboxOne = 2,

        /// <summary>
        /// Blizzard = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Blizzard = 3,

        /// <summary>
        /// Steam = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Steam = 4,

        /// <summary>
        /// Stadia = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Stadia = 5,

    }
}