using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyProgressionRewardItemQuantity{

		[DataMember(Name="rewardedAtProgressionLevel", EmitDefaultValue=false)]
		public long RewardedAtProgressionLevel { get; set; }

		[DataMember(Name="acquisitionBehavior", EmitDefaultValue=false)]
		public DestinyProgressionRewardItemAcquisitionBehavior AcquisitionBehavior { get; set; }

		[DataMember(Name="uiDisplayStyle", EmitDefaultValue=false)]
		public string UiDisplayStyle { get; set; }

		[DataMember(Name="claimUnlockDisplayStrings", EmitDefaultValue=false)]
		public List<string> ClaimUnlockDisplayStrings { get; set; }

		/// <summary>
		/// The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.
		/// </summary>
		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }

		/// <summary>
		/// If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.
		/// </summary>
		[DataMember(Name="itemInstanceId", EmitDefaultValue=false)]
		public long ItemInstanceId { get; set; }

		/// <summary>
		/// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
		/// </summary>
		[DataMember(Name="quantity", EmitDefaultValue=false)]
		public long Quantity { get; set; }


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
                    (RewardedAtProgressionLevel != null && RewardedAtProgressionLevel.Equals(input.RewardedAtProgressionLevel))
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
                    (ClaimUnlockDisplayStrings != null && ClaimUnlockDisplayStrings.Equals(input.ClaimUnlockDisplayStrings))
                ) &&
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
				(
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId != null && ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
				(
                    Quantity == input.Quantity ||
                    (Quantity != null && Quantity.Equals(input.Quantity))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.RewardedAtProgressionLevel.GetHashCode();
				hashCode = hashCode * 59 + this.AcquisitionBehavior.GetHashCode();
				hashCode = hashCode * 59 + this.UiDisplayStyle.GetHashCode();
				hashCode = hashCode * 59 + this.ClaimUnlockDisplayStrings.GetHashCode();
				hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
				hashCode = hashCode * 59 + this.ItemInstanceId.GetHashCode();
				hashCode = hashCode * 59 + this.Quantity.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

