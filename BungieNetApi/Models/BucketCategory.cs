using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum BucketCategory
    {
        /// <summary>
        /// Invisible = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Invisible = 0,

        /// <summary>
        /// Item = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Item = 1,

        /// <summary>
        /// Currency = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Currency = 2,

        /// <summary>
        /// Equippable = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Equippable = 3,

        /// <summary>
        /// Ignored = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Ignored = 4,

    }
}