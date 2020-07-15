using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Milestones can have associated activities which provide additional information about the context, challenges, modifiers, state etc... related to this Milestone. 
	/// </summary>
	/// <summary>
	/// Information we need to be able to return that data is defined here, along with Tier data to establish a relationship between a conceptual Activity and its difficulty levels and variants.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneActivityDefinition{

		/// <summary>
		/// The "Conceptual" activity hash. Basically, we picked the lowest level activity and are treating it as the canonical definition of the activity for rendering purposes.
		/// </summary>
		/// <summary>
		/// If you care about the specific difficulty modes and variations, use the activities under "Variants".
		/// </summary>
		[DataMember(Name="conceptualActivityHash", EmitDefaultValue=false)]
		public uint ConceptualActivityHash { get; set; }

		/// <summary>
		/// A milestone-referenced activity can have many variants, such as Tiers or alternative modes of play.
		/// </summary>
		/// <summary>
		/// Even if there is only a single variant, the details for these are represented within as a variant definition.
		/// </summary>
		/// <summary>
		/// It is assumed that, if this DestinyMilestoneActivityDefinition is active, then all variants should be active.
		/// </summary>
		/// <summary>
		/// If a Milestone could ever split the variants' active status conditionally, they should all have their own DestinyMilestoneActivityDefinition instead! The potential duplication will be worth it for the obviousness of processing and use.
		/// </summary>
		[DataMember(Name="variants", EmitDefaultValue=false)]
		public Dictionary<string, DestinyMilestoneActivityVariantDefinition> Variants { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneActivityDefinition);
        }

		public bool Equals(DestinyMilestoneActivityDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ConceptualActivityHash == input.ConceptualActivityHash ||
                    (ConceptualActivityHash != null && ConceptualActivityHash.Equals(input.ConceptualActivityHash))
                ) &&
				(
                    Variants == input.Variants ||
                    (Variants != null && Variants.Equals(input.Variants))
                ) ;
		}
	}
}

