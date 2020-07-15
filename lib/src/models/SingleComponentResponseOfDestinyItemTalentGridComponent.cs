using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class SingleComponentResponseOfDestinyItemTalentGridComponent{

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
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DestinyItemTalentGridComponent Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyItemTalentGridComponent);
        }

		public bool Equals(SingleComponentResponseOfDestinyItemTalentGridComponent input)
		{
			if (input == null) return false;

			return
				(
                    Data == input.Data ||
                    (Data != null && Data.Equals(input.Data))
                ) &&
				(
                    Privacy == input.Privacy ||
                    (Privacy != null && Privacy.Equals(input.Privacy))
                ) &&
				(
                    Disabled == input.Disabled ||
                    (Disabled != null && Disabled.Equals(input.Disabled))
                ) ;
		}
	}
}

