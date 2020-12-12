using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// An enumeration representing the potential difficulty levels of an activity. Their names are... more qualitative than quantitative.
    /// </summary>
    
    public enum DestinyActivityDifficultyTier
    {
        /// <summary>
        /// Trivial = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Trivial = 0,

        /// <summary>
        /// Easy = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Easy = 1,

        /// <summary>
        /// Normal = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Normal = 2,

        /// <summary>
        /// Challenging = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Challenging = 3,

        /// <summary>
        /// Hard = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Hard = 4,

        /// <summary>
        /// Brave = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Brave = 5,

        /// <summary>
        /// AlmostImpossible = 6
        /// </summary>
        [EnumMember(Value = "6")]
        AlmostImpossible = 6,

        /// <summary>
        /// Impossible = 7
        /// </summary>
        [EnumMember(Value = "7")]
        Impossible = 7,

    }
}