using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents the different kinds of acquisition behavior for progression reward items.
    /// </summary>
    
    public enum DestinyProgressionRewardItemAcquisitionBehavior
    {
        /// <summary>
        /// Instant = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Instant = 0,

        /// <summary>
        /// PlayerClaimRequired = 1
        /// </summary>
        [EnumMember(Value = "1")]
        PlayerClaimRequired = 1,

    }
}