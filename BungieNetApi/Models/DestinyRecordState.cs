using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// A Flags enumeration/bitmask where each bit represents a possible state that a Record/Triumph can be in.
    /// </summary>
    [Flags]
    public enum DestinyRecordState
    {
        /// <summary>
        /// None = 0
        /// If there are no flags set, the record is in a state where it *could* be redeemed, but it has not been yet.
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// RecordRedeemed = 1
        /// If this is set, the completed record has been redeemed.
        /// </summary>
        [EnumMember(Value = "1")]
        RecordRedeemed = 1,

        /// <summary>
        /// RewardUnavailable = 2
        /// If this is set, there&#39;s a reward available from this Record but it&#39;s unavailable for redemption.
        /// </summary>
        [EnumMember(Value = "2")]
        RewardUnavailable = 2,

        /// <summary>
        /// ObjectiveNotCompleted = 4
        /// If this is set, the objective for this Record has not yet been completed.
        /// </summary>
        [EnumMember(Value = "4")]
        ObjectiveNotCompleted = 4,

        /// <summary>
        /// Obscured = 8
        /// If this is set, the game recommends that you replace the display text of this Record with DestinyRecordDefinition.stateInfo.obscuredString.
        /// </summary>
        [EnumMember(Value = "8")]
        Obscured = 8,

        /// <summary>
        /// Invisible = 16
        /// If this is set, the game recommends that you not show this record. Do what you will with this recommendation.
        /// </summary>
        [EnumMember(Value = "16")]
        Invisible = 16,

        /// <summary>
        /// EntitlementUnowned = 32
        /// If this is set, you can&#39;t complete this record because you lack some permission that&#39;s required to complete it.
        /// </summary>
        [EnumMember(Value = "32")]
        EntitlementUnowned = 32,

        /// <summary>
        /// CanEquipTitle = 64
        /// If this is set, the record has a title (check DestinyRecordDefinition for title info) and you can equip it.
        /// </summary>
        [EnumMember(Value = "64")]
        CanEquipTitle = 64,

    }
}