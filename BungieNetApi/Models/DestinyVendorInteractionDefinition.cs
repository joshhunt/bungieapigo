using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// A Vendor Interaction is a dialog shown by the vendor other than sale items or transfer screens. The vendor is showing you something, and asking you to reply to it by choosing an option or reward.
	/// </summary>
	[DataContract]
	public class DestinyVendorInteractionDefinition{

		/// <summary>
		/// The position of this interaction in its parent array. Note that this is NOT content agnostic, and should not be used as such.
		/// </summary>
		[DataMember(Name="interactionIndex", EmitDefaultValue=false)]
		public long InteractionIndex { get; set; }

		/// <summary>
		/// The potential replies that the user can make to the interaction.
		/// </summary>
		[DataMember(Name="replies", EmitDefaultValue=false)]
		public List<DestinyVendorInteractionReplyDefinition> Replies { get; set; }

		/// <summary>
		/// If >= 0, this is the category of sale items to show along with this interaction dialog.
		/// </summary>
		[DataMember(Name="vendorCategoryIndex", EmitDefaultValue=false)]
		public long VendorCategoryIndex { get; set; }

		/// <summary>
		/// If this interaction dialog is about a quest, this is the questline related to the interaction. You can use this to show the quest overview, or even the character's status with the quest if you use it to find the character's current Quest Step by checking their inventory against this questlineItemHash's DestinyInventoryItemDefinition.setData.
		/// </summary>
		[DataMember(Name="questlineItemHash", EmitDefaultValue=false)]
		public uint QuestlineItemHash { get; set; }

		/// <summary>
		/// If this interaction is meant to show you sacks, this is the list of types of sacks to be shown. If empty, the interaction is not meant to show sacks.
		/// </summary>
		[DataMember(Name="sackInteractionList", EmitDefaultValue=false)]
		public List<DestinyVendorInteractionSackEntryDefinition> SackInteractionList { get; set; }

		/// <summary>
		/// A UI hint for the behavior of the interaction screen. This is useful to determine what type of interaction is occurring, such as a prompt to receive a rank up reward or a prompt to choose a reward for completing a quest. The hash isn't as useful as the Enum in retrospect, well what can you do. Try using interactionType instead.
		/// </summary>
		[DataMember(Name="uiInteractionType", EmitDefaultValue=false)]
		public uint UiInteractionType { get; set; }

		/// <summary>
		/// The enumerated version of the possible UI hints for vendor interactions, which is a little easier to grok than the hash found in uiInteractionType.
		/// </summary>
		[DataMember(Name="interactionType", EmitDefaultValue=false)]
		public VendorInteractionType InteractionType { get; set; }

		/// <summary>
		/// If this interaction is displaying rewards, this is the text to use for the header of the reward-displaying section of the interaction.
		/// </summary>
		[DataMember(Name="rewardBlockLabel", EmitDefaultValue=false)]
		public string RewardBlockLabel { get; set; }

		/// <summary>
		/// If the vendor's reward list is sourced from one of his categories, this is the index into the category array of items to show.
		/// </summary>
		[DataMember(Name="rewardVendorCategoryIndex", EmitDefaultValue=false)]
		public long RewardVendorCategoryIndex { get; set; }

		/// <summary>
		/// If the vendor interaction has flavor text, this is some of it.
		/// </summary>
		[DataMember(Name="flavorLineOne", EmitDefaultValue=false)]
		public string FlavorLineOne { get; set; }

		/// <summary>
		/// If the vendor interaction has flavor text, this is the rest of it.
		/// </summary>
		[DataMember(Name="flavorLineTwo", EmitDefaultValue=false)]
		public string FlavorLineTwo { get; set; }

		/// <summary>
		/// The header for the interaction dialog.
		/// </summary>
		[DataMember(Name="headerDisplayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition HeaderDisplayProperties { get; set; }

		/// <summary>
		/// The localized text telling the player what to do when they see this dialog.
		/// </summary>
		[DataMember(Name="instructions", EmitDefaultValue=false)]
		public string Instructions { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorInteractionDefinition);
        }

		public bool Equals(DestinyVendorInteractionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    InteractionIndex == input.InteractionIndex ||
                    (InteractionIndex != null && InteractionIndex.Equals(input.InteractionIndex))
                ) &&
				(
                    Replies == input.Replies ||
                    (Replies != null && Replies.Equals(input.Replies))
                ) &&
				(
                    VendorCategoryIndex == input.VendorCategoryIndex ||
                    (VendorCategoryIndex != null && VendorCategoryIndex.Equals(input.VendorCategoryIndex))
                ) &&
				(
                    QuestlineItemHash == input.QuestlineItemHash ||
                    (QuestlineItemHash != null && QuestlineItemHash.Equals(input.QuestlineItemHash))
                ) &&
				(
                    SackInteractionList == input.SackInteractionList ||
                    (SackInteractionList != null && SackInteractionList.Equals(input.SackInteractionList))
                ) &&
				(
                    UiInteractionType == input.UiInteractionType ||
                    (UiInteractionType != null && UiInteractionType.Equals(input.UiInteractionType))
                ) &&
				(
                    InteractionType == input.InteractionType ||
                    (InteractionType != null && InteractionType.Equals(input.InteractionType))
                ) &&
				(
                    RewardBlockLabel == input.RewardBlockLabel ||
                    (RewardBlockLabel != null && RewardBlockLabel.Equals(input.RewardBlockLabel))
                ) &&
				(
                    RewardVendorCategoryIndex == input.RewardVendorCategoryIndex ||
                    (RewardVendorCategoryIndex != null && RewardVendorCategoryIndex.Equals(input.RewardVendorCategoryIndex))
                ) &&
				(
                    FlavorLineOne == input.FlavorLineOne ||
                    (FlavorLineOne != null && FlavorLineOne.Equals(input.FlavorLineOne))
                ) &&
				(
                    FlavorLineTwo == input.FlavorLineTwo ||
                    (FlavorLineTwo != null && FlavorLineTwo.Equals(input.FlavorLineTwo))
                ) &&
				(
                    HeaderDisplayProperties == input.HeaderDisplayProperties ||
                    (HeaderDisplayProperties != null && HeaderDisplayProperties.Equals(input.HeaderDisplayProperties))
                ) &&
				(
                    Instructions == input.Instructions ||
                    (Instructions != null && Instructions.Equals(input.Instructions))
                ) ;
		}
	}
}

