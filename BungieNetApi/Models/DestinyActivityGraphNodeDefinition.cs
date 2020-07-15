using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// This is the position and other data related to nodes in the activity graph that you can click to launch activities. An Activity Graph node will only have one active Activity at a time, which will determine the activity to be launched (and, unless overrideDisplay information is provided, will also determine the tooltip and other UI related to the node)
	/// </summary>
	[DataContract]
	public class DestinyActivityGraphNodeDefinition{

		/// <summary>
		/// An identifier for the Activity Graph Node, only guaranteed to be unique within its parent Activity Graph.
		/// </summary>
		[DataMember(Name="nodeId", EmitDefaultValue=false)]
		public uint NodeId { get; set; }

		/// <summary>
		/// The node *may* have display properties that override the active Activity's display properties.
		/// </summary>
		[DataMember(Name="overrideDisplay", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition OverrideDisplay { get; set; }

		/// <summary>
		/// The position on the map for this node.
		/// </summary>
		[DataMember(Name="position", EmitDefaultValue=false)]
		public DestinyPositionDefinition Position { get; set; }

		/// <summary>
		/// The node may have various visual accents placed on it, or styles applied. These are the list of possible styles that the Node can have. The game iterates through each, looking for the first one that passes a check of the required game/character/account state in order to show that style, and then renders the node in that style.
		/// </summary>
		[DataMember(Name="featuringStates", EmitDefaultValue=false)]
		public List<DestinyActivityGraphNodeFeaturingStateDefinition> FeaturingStates { get; set; }

		/// <summary>
		/// The node may have various possible activities that could be active for it, however only one may be active at a time. See the DestinyActivityGraphNodeActivityDefinition for details.
		/// </summary>
		[DataMember(Name="activities", EmitDefaultValue=false)]
		public List<DestinyActivityGraphNodeActivityDefinition> Activities { get; set; }

		/// <summary>
		/// Represents possible states that the graph node can be in. These are combined with some checking that happens in the game client and server to determine which state is actually active at any given time.
		/// </summary>
		[DataMember(Name="states", EmitDefaultValue=false)]
		public List<DestinyActivityGraphNodeStateEntry> States { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphNodeDefinition);
        }

		public bool Equals(DestinyActivityGraphNodeDefinition input)
		{
			if (input == null) return false;

			return
				(
                    NodeId == input.NodeId ||
                    (NodeId != null && NodeId.Equals(input.NodeId))
                ) &&
				(
                    OverrideDisplay == input.OverrideDisplay ||
                    (OverrideDisplay != null && OverrideDisplay.Equals(input.OverrideDisplay))
                ) &&
				(
                    Position == input.Position ||
                    (Position != null && Position.Equals(input.Position))
                ) &&
				(
                    FeaturingStates == input.FeaturingStates ||
                    (FeaturingStates != null && FeaturingStates.Equals(input.FeaturingStates))
                ) &&
				(
                    Activities == input.Activities ||
                    (Activities != null && Activities.Equals(input.Activities))
                ) &&
				(
                    States == input.States ||
                    (States != null && States.Equals(input.States))
                ) ;
		}
	}
}

