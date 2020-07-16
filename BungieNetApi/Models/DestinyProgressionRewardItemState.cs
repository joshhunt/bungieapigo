using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents the different states a progression reward item can be in.
    /// </summary>
    [Flags]
    public enum DestinyProgressionRewardItemState
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Invisible = 1
        /// If this is set, the reward should be hidden.
        /// </summary>
        [EnumMember(Value = "1")]
        Invisible = 1,

        /// <summary>
        /// Earned = 2
        /// If this is set, the reward has been earned.
        /// </summary>
        [EnumMember(Value = "2")]
        Earned = 2,

        /// <summary>
        /// Claimed = 4
        /// If this is set, the reward has been claimed.
        /// </summary>
        [EnumMember(Value = "4")]
        Claimed = 4,

        /// <summary>
        /// ClaimAllowed = 8
        /// If this is set, the reward is allowed to be claimed by this Character. An item can be earned but still can&#39;t be claimed in certain circumstances, like if it&#39;s only allowed for certain subclasses. It also might not be able to be claimed if you already claimed it!
        /// </summary>
        [EnumMember(Value = "8")]
        ClaimAllowed = 8,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}