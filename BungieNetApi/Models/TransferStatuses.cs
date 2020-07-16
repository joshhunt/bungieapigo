using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// Whether you can transfer an item, and why not if you can't.
    /// </summary>
    [Flags]
    public enum TransferStatuses
    {
        /// <summary>
        /// CanTransfer = 0
        /// The item can be transferred.
        /// </summary>
        [EnumMember(Value = "0")]
        CanTransfer = 0,

        /// <summary>
        /// ItemIsEquipped = 1
        /// You can&#39;t transfer the item because it is equipped on a character.
        /// </summary>
        [EnumMember(Value = "1")]
        ItemIsEquipped = 1,

        /// <summary>
        /// NotTransferrable = 2
        /// The item is defined as not transferrable in its DestinyInventoryItemDefinition.nonTransferrable property.
        /// </summary>
        [EnumMember(Value = "2")]
        NotTransferrable = 2,

        /// <summary>
        /// NoRoomInDestination = 4
        /// You could transfer the item, but the place you&#39;re trying to put it has run out of room! Check your remaining Vault and&#x2F;or character space.
        /// </summary>
        [EnumMember(Value = "4")]
        NoRoomInDestination = 4,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}