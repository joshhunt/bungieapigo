using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// If the item can exist in an inventory - the overwhelming majority of them can and do - then this is the basic properties regarding the item's relationship with the inventory.
	/// </summary>
	[DataContract]
	public class DestinyItemInventoryBlockDefinition{

		/// <summary>
		/// If this string is populated, you can't have more than one stack with this label in a given inventory. Note that this is different from the equipping block's unique label, which is used for equipping uniqueness.
		/// </summary>
		[DataMember(Name="stackUniqueLabel", EmitDefaultValue=false)]
		public string StackUniqueLabel { get; set; }

		/// <summary>
		/// The maximum quantity of this item that can exist in a stack.
		/// </summary>
		[DataMember(Name="maxStackSize", EmitDefaultValue=false)]
		public long MaxStackSize { get; set; }

		/// <summary>
		/// The hash identifier for the DestinyInventoryBucketDefinition to which this item belongs. I should have named this "bucketHash", but too many things refer to it now. Sigh.
		/// </summary>
		[DataMember(Name="bucketTypeHash", EmitDefaultValue=false)]
		public uint BucketTypeHash { get; set; }

		/// <summary>
		/// If the item is picked up by the lost loot queue, this is the hash identifier for the DestinyInventoryBucketDefinition into which it will be placed. Again, I should have named this recoveryBucketHash instead.
		/// </summary>
		[DataMember(Name="recoveryBucketTypeHash", EmitDefaultValue=false)]
		public uint RecoveryBucketTypeHash { get; set; }

		/// <summary>
		/// The hash identifier for the Tier Type of the item, use to look up its DestinyItemTierTypeDefinition if you need to show localized data for the item's tier.
		/// </summary>
		[DataMember(Name="tierTypeHash", EmitDefaultValue=false)]
		public uint TierTypeHash { get; set; }

		/// <summary>
		/// If TRUE, this item is instanced. Otherwise, it is a generic item that merely has a quantity in a stack (like Glimmer).
		/// </summary>
		[DataMember(Name="isInstanceItem", EmitDefaultValue=false)]
		public bool IsInstanceItem { get; set; }

		/// <summary>
		/// The localized name of the tier type, which is a useful shortcut so you don't have to look up the definition every time. However, it's mostly a holdover from days before we had a DestinyItemTierTypeDefinition to refer to.
		/// </summary>
		[DataMember(Name="tierTypeName", EmitDefaultValue=false)]
		public string TierTypeName { get; set; }

		/// <summary>
		/// The enumeration matching the tier type of the item to known values, again for convenience sake.
		/// </summary>
		[DataMember(Name="tierType", EmitDefaultValue=false)]
		public TierType TierType { get; set; }

		/// <summary>
		/// The tooltip message to show, if any, when the item expires.
		/// </summary>
		[DataMember(Name="expirationTooltip", EmitDefaultValue=false)]
		public string ExpirationTooltip { get; set; }

		/// <summary>
		/// If the item expires while playing in an activity, we show a different message.
		/// </summary>
		[DataMember(Name="expiredInActivityMessage", EmitDefaultValue=false)]
		public string ExpiredInActivityMessage { get; set; }

		/// <summary>
		/// If the item expires in orbit, we show a... more different message. ("Consummate V's, consummate!")
		/// </summary>
		[DataMember(Name="expiredInOrbitMessage", EmitDefaultValue=false)]
		public string ExpiredInOrbitMessage { get; set; }

		[DataMember(Name="suppressExpirationWhenObjectivesComplete", EmitDefaultValue=false)]
		public bool SuppressExpirationWhenObjectivesComplete { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemInventoryBlockDefinition);
        }

		public bool Equals(DestinyItemInventoryBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    StackUniqueLabel == input.StackUniqueLabel ||
                    (StackUniqueLabel != null && StackUniqueLabel.Equals(input.StackUniqueLabel))
                ) &&
				(
                    MaxStackSize == input.MaxStackSize ||
                    (MaxStackSize != null && MaxStackSize.Equals(input.MaxStackSize))
                ) &&
				(
                    BucketTypeHash == input.BucketTypeHash ||
                    (BucketTypeHash != null && BucketTypeHash.Equals(input.BucketTypeHash))
                ) &&
				(
                    RecoveryBucketTypeHash == input.RecoveryBucketTypeHash ||
                    (RecoveryBucketTypeHash != null && RecoveryBucketTypeHash.Equals(input.RecoveryBucketTypeHash))
                ) &&
				(
                    TierTypeHash == input.TierTypeHash ||
                    (TierTypeHash != null && TierTypeHash.Equals(input.TierTypeHash))
                ) &&
				(
                    IsInstanceItem == input.IsInstanceItem ||
                    (IsInstanceItem != null && IsInstanceItem.Equals(input.IsInstanceItem))
                ) &&
				(
                    TierTypeName == input.TierTypeName ||
                    (TierTypeName != null && TierTypeName.Equals(input.TierTypeName))
                ) &&
				(
                    TierType == input.TierType ||
                    (TierType != null && TierType.Equals(input.TierType))
                ) &&
				(
                    ExpirationTooltip == input.ExpirationTooltip ||
                    (ExpirationTooltip != null && ExpirationTooltip.Equals(input.ExpirationTooltip))
                ) &&
				(
                    ExpiredInActivityMessage == input.ExpiredInActivityMessage ||
                    (ExpiredInActivityMessage != null && ExpiredInActivityMessage.Equals(input.ExpiredInActivityMessage))
                ) &&
				(
                    ExpiredInOrbitMessage == input.ExpiredInOrbitMessage ||
                    (ExpiredInOrbitMessage != null && ExpiredInOrbitMessage.Equals(input.ExpiredInOrbitMessage))
                ) &&
				(
                    SuppressExpirationWhenObjectivesComplete == input.SuppressExpirationWhenObjectivesComplete ||
                    (SuppressExpirationWhenObjectivesComplete != null && SuppressExpirationWhenObjectivesComplete.Equals(input.SuppressExpirationWhenObjectivesComplete))
                ) ;
		}
	}
}

