using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum BucketScope
    {
        /// <summary>
        /// Character = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Character = 0,

        /// <summary>
        /// Account = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Account = 1,

    }
}