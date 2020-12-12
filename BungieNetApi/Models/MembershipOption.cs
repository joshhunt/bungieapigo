using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum MembershipOption
    {
        /// <summary>
        /// Reviewed = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Reviewed = 0,

        /// <summary>
        /// Open = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Open = 1,

        /// <summary>
        /// Closed = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Closed = 2,

    }
}