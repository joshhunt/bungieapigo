using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Well, we're here in Destiny 2, and Talent Grids are unfortunately still around.
	/// </summary>
	/// <summary>
	/// The good news is that they're pretty much only being used for certain base information on items and for Builds/Subclasses. The bad news is that they still suck. If you really want this information, grab this component.
	/// </summary>
	/// <summary>
	/// An important note is that talent grids are defined as such:
	/// </summary>
	/// <summary>
	/// A Grid has 1:M Nodes, which has 1:M Steps.
	/// </summary>
	/// <summary>
	/// Any given node can only have a single step active at one time, which represents the actual visual contents and effects of the Node (for instance, if you see a "Super Cool Bonus" node, the actual icon and text for the node is coming from the current Step of that node).
	/// </summary>
	/// <summary>
	/// Nodes can be grouped into exclusivity sets *and* as of D2, exclusivity groups (which are collections of exclusivity sets that affect each other).
	/// </summary>
	/// <summary>
	/// See DestinyTalentGridDefinition for more information. Brace yourself, the water's cold out there in the deep end.
	/// </summary>
	[DataContract]
	public class DestinyItemTalentGridComponent{

		/// <summary>
		/// Most items don't have useful talent grids anymore, but Builds in particular still do.
		/// </summary>
		/// <summary>
		/// You can use this hash to lookup the DestinyTalentGridDefinition attached to this item, which will be crucial for understanding the node values on the item.
		/// </summary>
		[DataMember(Name="talentGridHash", EmitDefaultValue=false)]
		public uint TalentGridHash { get; set; }

		/// <summary>
		/// Detailed information about the individual nodes in the talent grid.
		/// </summary>
		/// <summary>
		/// A node represents a single visual "pip" in the talent grid or Build detail view, though each node may have multiple "steps" which indicate the actual bonuses and visual representation of that node.
		/// </summary>
		[DataMember(Name="nodes", EmitDefaultValue=false)]
		public List<DestinyTalentNode> Nodes { get; set; }

		/// <summary>
		/// Indicates whether the talent grid on this item is completed, and thus whether it should have a gold border around it.
		/// </summary>
		/// <summary>
		/// Only will be true if the item actually *has* a talent grid, and only then if it is completed (i.e. every exclusive set has an activated node, and every non-exclusive set node has been activated)
		/// </summary>
		[DataMember(Name="isGridComplete", EmitDefaultValue=false)]
		public bool IsGridComplete { get; set; }

		/// <summary>
		/// If the item has a progression, it will be detailed here. A progression means that the item can gain experience. Thresholds of experience are what determines whether and when a talent node can be activated.
		/// </summary>
		[DataMember(Name="gridProgression", EmitDefaultValue=false)]
		public DestinyProgression GridProgression { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemTalentGridComponent);
        }

		public bool Equals(DestinyItemTalentGridComponent input)
		{
			if (input == null) return false;

			return
				(
                    TalentGridHash == input.TalentGridHash ||
                    (TalentGridHash != null && TalentGridHash.Equals(input.TalentGridHash))
                ) &&
				(
                    Nodes == input.Nodes ||
                    (Nodes != null && Nodes.Equals(input.Nodes))
                ) &&
				(
                    IsGridComplete == input.IsGridComplete ||
                    (IsGridComplete != null && IsGridComplete.Equals(input.IsGridComplete))
                ) &&
				(
                    GridProgression == input.GridProgression ||
                    (GridProgression != null && GridProgression.Equals(input.GridProgression))
                ) ;
		}
	}
}

