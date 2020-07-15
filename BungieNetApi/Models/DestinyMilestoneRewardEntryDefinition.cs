using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// The definition of a specific reward, which may be contained in a category of rewards and that has optional information about how it is obtained.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneRewardEntryDefinition{

		/// <summary>
		/// The identifier for this reward entry. Runtime data will refer to reward entries by this hash. Only guaranteed unique within the specific Milestone.
		/// </summary>
		[DataMember(Name="rewardEntryHash", EmitDefaultValue=false)]
		public uint RewardEntryHash { get; set; }

		/// <summary>
		/// The string identifier, if you care about it. Only guaranteed unique within the specific Milestone.
		/// </summary>
		[DataMember(Name="rewardEntryIdentifier", EmitDefaultValue=false)]
		public string RewardEntryIdentifier { get; set; }

		/// <summary>
		/// The items you will get as rewards, and how much of it you'll get.
		/// </summary>
		[DataMember(Name="items", EmitDefaultValue=false)]
		public List<DestinyItemQuantity> Items { get; set; }

		/// <summary>
		/// If this reward is redeemed at a Vendor, this is the hash of the Vendor to go to in order to redeem the reward. Use this hash to look up the DestinyVendorDefinition.
		/// </summary>
		[DataMember(Name="vendorHash", EmitDefaultValue=false)]
		public uint VendorHash { get; set; }

		/// <summary>
		/// For us to bother returning this info, we should be able to return some kind of information about why these rewards are grouped together. This is ideally that information. Look at how confident I am that this will always remain true.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// If you want to follow BNet's ordering of these rewards, use this number within a given category to order the rewards. Yeah, I know. I feel dirty too.
		/// </summary>
		[DataMember(Name="order", EmitDefaultValue=false)]
		public long Order { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneRewardEntryDefinition);
        }

		public bool Equals(DestinyMilestoneRewardEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    RewardEntryHash == input.RewardEntryHash ||
                    (RewardEntryHash != null && RewardEntryHash.Equals(input.RewardEntryHash))
                ) &&
				(
                    RewardEntryIdentifier == input.RewardEntryIdentifier ||
                    (RewardEntryIdentifier != null && RewardEntryIdentifier.Equals(input.RewardEntryIdentifier))
                ) &&
				(
                    Items == input.Items ||
                    (Items != null && Items.Equals(input.Items))
                ) &&
				(
                    VendorHash == input.VendorHash ||
                    (VendorHash != null && VendorHash.Equals(input.VendorHash))
                ) &&
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    Order == input.Order ||
                    (Order != null && Order.Equals(input.Order))
                ) ;
		}
	}
}

