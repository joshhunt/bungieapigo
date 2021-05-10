using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyProgressionRewardItemQuantity
    {
        [DataMember(Name = "rewardedAtProgressionLevel", EmitDefaultValue = false)]
        public long RewardedAtProgressionLevel { get; set; }

        [DataMember(Name = "acquisitionBehavior", EmitDefaultValue = false)]
        public DestinyProgressionRewardItemAcquisitionBehavior AcquisitionBehavior { get; set; }

        [DataMember(Name = "uiDisplayStyle", EmitDefaultValue = false)]
        public string UiDisplayStyle { get; set; }

        [DataMember(Name = "claimUnlockDisplayStrings", EmitDefaultValue = false)]
        public List<string> ClaimUnlockDisplayStrings { get; set; }

        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.
        /// </summary>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public long Quantity { get; set; }

        /// <summary>
        /// Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress.
        /// </summary>
        [DataMember(Name = "hasConditionalVisibility", EmitDefaultValue = false)]
        public bool HasConditionalVisibility { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProgressionRewardItemQuantity);
        }

        public bool Equals(DestinyProgressionRewardItemQuantity input)
        {
            if (input == null) return false;

            return
                (
                    RewardedAtProgressionLevel == input.RewardedAtProgressionLevel ||
                    (RewardedAtProgressionLevel.Equals(input.RewardedAtProgressionLevel))
                ) &&
                (
                    AcquisitionBehavior == input.AcquisitionBehavior ||
                    (AcquisitionBehavior != null && AcquisitionBehavior.Equals(input.AcquisitionBehavior))
                ) &&
                (
                    UiDisplayStyle == input.UiDisplayStyle ||
                    (UiDisplayStyle != null && UiDisplayStyle.Equals(input.UiDisplayStyle))
                ) &&
                (
                    ClaimUnlockDisplayStrings == input.ClaimUnlockDisplayStrings ||
                    (ClaimUnlockDisplayStrings != null && ClaimUnlockDisplayStrings.SequenceEqual(input.ClaimUnlockDisplayStrings))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
                (
                    Quantity == input.Quantity ||
                    (Quantity.Equals(input.Quantity))
                ) &&
                (
                    HasConditionalVisibility == input.HasConditionalVisibility ||
                    (HasConditionalVisibility != null && HasConditionalVisibility.Equals(input.HasConditionalVisibility))
                ) ;
        }
    }
}

