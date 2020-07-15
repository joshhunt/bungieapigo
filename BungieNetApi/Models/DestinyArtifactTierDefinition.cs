using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyArtifactTierDefinition{

		/// <summary>
		/// An identifier, unique within the Artifact, for this specific tier.
		/// </summary>
		[DataMember(Name="tierHash", EmitDefaultValue=false)]
		public uint TierHash { get; set; }

		/// <summary>
		/// The human readable title of this tier, if any.
		/// </summary>
		[DataMember(Name="displayTitle", EmitDefaultValue=false)]
		public string DisplayTitle { get; set; }

		/// <summary>
		/// A string representing the localized minimum requirement text for this Tier, if any.
		/// </summary>
		[DataMember(Name="progressRequirementMessage", EmitDefaultValue=false)]
		public string ProgressRequirementMessage { get; set; }

		/// <summary>
		/// The items that can be earned within this tier.
		/// </summary>
		[DataMember(Name="items", EmitDefaultValue=false)]
		public List<DestinyArtifactTierItemDefinition> Items { get; set; }

		/// <summary>
		/// The minimum number of "unlock points" that you must have used before you can unlock items from this tier.
		/// </summary>
		[DataMember(Name="minimumUnlockPointsUsedRequirement", EmitDefaultValue=false)]
		public long MinimumUnlockPointsUsedRequirement { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyArtifactTierDefinition);
        }

		public bool Equals(DestinyArtifactTierDefinition input)
		{
			if (input == null) return false;

			return
				(
                    TierHash == input.TierHash ||
                    (TierHash != null && TierHash.Equals(input.TierHash))
                ) &&
				(
                    DisplayTitle == input.DisplayTitle ||
                    (DisplayTitle != null && DisplayTitle.Equals(input.DisplayTitle))
                ) &&
				(
                    ProgressRequirementMessage == input.ProgressRequirementMessage ||
                    (ProgressRequirementMessage != null && ProgressRequirementMessage.Equals(input.ProgressRequirementMessage))
                ) &&
				(
                    Items == input.Items ||
                    (Items != null && Items.Equals(input.Items))
                ) &&
				(
                    MinimumUnlockPointsUsedRequirement == input.MinimumUnlockPointsUsedRequirement ||
                    (MinimumUnlockPointsUsedRequirement != null && MinimumUnlockPointsUsedRequirement.Equals(input.MinimumUnlockPointsUsedRequirement))
                ) ;
		}
	}
}

