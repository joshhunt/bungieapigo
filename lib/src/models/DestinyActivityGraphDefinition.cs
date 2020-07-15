using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Represents a Map View in the director: be them overview views, destination views, or other.
	/// They have nodes which map to activities, and other various visual elements that we (or others) may or may not be able to use.
	/// Activity graphs, most importantly, have nodes which can have activities in various states of playability.
	/// Unfortunately, activity graphs are combined at runtime with Game UI-only assets such as fragments of map images, various in-game special effects, decals etc... that we don&#39;t get in these definitions.
	/// If we end up having time, we may end up trying to manually populate those here: but the last time we tried that, before the lead-up to D1, it proved to be unmaintainable as the game&#39;s content changed. So don&#39;t bet the farm on us providing that content in this definition.
	[DataContract]
	public class DestinyActivityGraphDefinition{

		/// <summary>
		/// These represent the visual "nodes" on the map's view. These are the activities you can click on in the map.
		/// </summary>
		[DataMember(Name="nodes", EmitDefaultValue=false)]
		public List<DestinyActivityGraphNodeDefinition> Nodes { get; set; }

		/// <summary>
		/// Represents one-off/special UI elements that appear on the map.
		/// </summary>
		[DataMember(Name="artElements", EmitDefaultValue=false)]
		public List<DestinyActivityGraphArtElementDefinition> ArtElements { get; set; }

		/// <summary>
		/// Represents connections between graph nodes. However, it lacks context that we'd need to make good use of it.
		/// </summary>
		[DataMember(Name="connections", EmitDefaultValue=false)]
		public List<DestinyActivityGraphConnectionDefinition> Connections { get; set; }

		/// <summary>
		/// Objectives can display on maps, and this is supposedly metadata for that. I have not had the time to analyze the details of what is useful within however: we could be missing important data to make this work. Expect this property to be expanded on later if possible.
		/// </summary>
		[DataMember(Name="displayObjectives", EmitDefaultValue=false)]
		public List<DestinyActivityGraphDisplayObjectiveDefinition> DisplayObjectives { get; set; }

		/// <summary>
		/// Progressions can also display on maps, but similarly to displayObjectives we appear to lack some required information and context right now. We will have to look into it later and add more data if possible.
		/// </summary>
		[DataMember(Name="displayProgressions", EmitDefaultValue=false)]
		public List<DestinyActivityGraphDisplayProgressionDefinition> DisplayProgressions { get; set; }

		/// <summary>
		/// Represents links between this Activity Graph and other ones.
		/// </summary>
		[DataMember(Name="linkedGraphs", EmitDefaultValue=false)]
		public List<DestinyLinkedGraphDefinition> LinkedGraphs { get; set; }

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
            return this.Equals(input as DestinyActivityGraphDefinition);
        }

		public bool Equals(DestinyActivityGraphDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Nodes == input.Nodes ||
                    (Nodes != null && Nodes.Equals(input.Nodes))
                ) &&
				(
                    ArtElements == input.ArtElements ||
                    (ArtElements != null && ArtElements.Equals(input.ArtElements))
                ) &&
				(
                    Connections == input.Connections ||
                    (Connections != null && Connections.Equals(input.Connections))
                ) &&
				(
                    DisplayObjectives == input.DisplayObjectives ||
                    (DisplayObjectives != null && DisplayObjectives.Equals(input.DisplayObjectives))
                ) &&
				(
                    DisplayProgressions == input.DisplayProgressions ||
                    (DisplayProgressions != null && DisplayProgressions.Equals(input.DisplayProgressions))
                ) &&
				(
                    LinkedGraphs == input.LinkedGraphs ||
                    (LinkedGraphs != null && LinkedGraphs.Equals(input.LinkedGraphs))
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

