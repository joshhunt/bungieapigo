using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The reasons why an item cannot be equipped, if any. Many flags can be set, or "None" if
    /// </summary>
    [Flags]
    public enum EquipFailureReason
    {
        /// <summary>
        /// None = 0
        /// The item is&#x2F;was able to be equipped.
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// ItemUnequippable = 1
        /// This is not the kind of item that can be equipped. Did you try equipping Glimmer or something?
        /// </summary>
        [EnumMember(Value = "1")]
        ItemUnequippable = 1,

        /// <summary>
        /// ItemUniqueEquipRestricted = 2
        /// This item is part of a &quot;unique set&quot;, and you can&#39;t have more than one item of that same set type equipped at once. For instance, if you already have an Exotic Weapon equipped, you can&#39;t equip a second one in another weapon slot.
        /// </summary>
        [EnumMember(Value = "2")]
        ItemUniqueEquipRestricted = 2,

        /// <summary>
        /// ItemFailedUnlockCheck = 4
        /// This item has state-based gating that prevents it from being equipped in certain circumstances. For instance, an item might be for Warlocks only and you&#39;re a Titan, or it might require you to have beaten some special quest that you haven&#39;t beaten yet. Use the additional failure data passed on the item itself to get more information about what the specific failure case was (See DestinyInventoryItemDefinition and DestinyItemInstanceComponent)
        /// </summary>
        [EnumMember(Value = "4")]
        ItemFailedUnlockCheck = 4,

        /// <summary>
        /// ItemFailedLevelCheck = 8
        /// This item requires you to have reached a specific character level in order to equip it, and you haven&#39;t reached that level yet.
        /// </summary>
        [EnumMember(Value = "8")]
        ItemFailedLevelCheck = 8,

        /// <summary>
        /// ItemNotOnCharacter = 16
        /// This item can&#39;t be equipped on the character requested, because it must be in that character&#39;s inventory first. Transfer the item to the character you want to equip it before you attempt to equip it.
        /// </summary>
        [EnumMember(Value = "16")]
        ItemNotOnCharacter = 16,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}