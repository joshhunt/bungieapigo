using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Determines how items are sorted in an inventory bucket.
    /// </summary>
    
    public enum DestinyItemSortType
    {
        /// <summary>
        /// ItemId = 0
        /// </summary>
        [EnumMember(Value = "0")]
        ItemId = 0,

        /// <summary>
        /// Timestamp = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Timestamp = 1,

        /// <summary>
        /// StackSize = 2
        /// </summary>
        [EnumMember(Value = "2")]
        StackSize = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}