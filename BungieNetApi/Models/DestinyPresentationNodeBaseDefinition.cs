using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// This is the base class for all presentation system children. Presentation Nodes, Records, Collectibles, and Metrics.
	/// </summary>
	[DataContract]
	public class DestinyPresentationNodeBaseDefinition{

		[DataMember(Name="presentationNodeType", EmitDefaultValue=false)]
		public DestinyPresentationNodeType PresentationNodeType { get; set; }

		[DataMember(Name="traitIds", EmitDefaultValue=false)]
		public List<string> TraitIds { get; set; }

		[DataMember(Name="traitHashes", EmitDefaultValue=false)]
		public List<uint> TraitHashes { get; set; }

		/// <summary>
		/// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
		/// </summary>
		[DataMember(Name="parentNodeHashes", EmitDefaultValue=false)]
		public List<uint> ParentNodeHashes { get; set; }

		/// <summary>
		/// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
		/// </summary>
		/// <summary>
		/// When entities refer to each other in Destiny content, it is this hash that they are referring to.
		/// </summary>
		[DataMember(Name="hash", EmitDefaultValue=false)]
		public uint Hash { get; set; }

		/// <summary>
		/// The index of the entity as it was found in the investment tables.
		/// </summary>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public long Index { get; set; }

		/// <summary>
		/// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
		/// </summary>
		[DataMember(Name="redacted", EmitDefaultValue=false)]
		public bool Redacted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeBaseDefinition);
        }

		public bool Equals(DestinyPresentationNodeBaseDefinition input)
		{
			if (input == null) return false;

			return
				(
                    PresentationNodeType == input.PresentationNodeType ||
                    (PresentationNodeType != null && PresentationNodeType.Equals(input.PresentationNodeType))
                ) &&
				(
                    TraitIds == input.TraitIds ||
                    (TraitIds != null && TraitIds.Equals(input.TraitIds))
                ) &&
				(
                    TraitHashes == input.TraitHashes ||
                    (TraitHashes != null && TraitHashes.Equals(input.TraitHashes))
                ) &&
				(
                    ParentNodeHashes == input.ParentNodeHashes ||
                    (ParentNodeHashes != null && ParentNodeHashes.Equals(input.ParentNodeHashes))
                ) &&
				(
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
				(
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
				(
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
		}
	}
}

