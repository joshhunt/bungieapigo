using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum AwaUserSelection
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Rejected = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Rejected = 1,

        /// <summary>
        /// Approved = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Approved = 2,

    }
}