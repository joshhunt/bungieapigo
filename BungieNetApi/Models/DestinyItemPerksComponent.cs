using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Instanced items can have perks: benefits that the item bestows.
	/// </summary>
	/// <summary>
	/// These are related to DestinySandboxPerkDefinition, and sometimes - but not always - have human readable info. When they do, they are the icons and text that you see in an item's tooltip.
	/// </summary>
	/// <summary>
	/// Talent Grids, Sockets, and the item itself can apply Perks, which are then summarized here for your convenience.
	/// </summary>
	[DataContract]
	public class DestinyItemPerksComponent{

		/// <summary>
		/// The list of perks to display in an item tooltip - and whether or not they have been activated.
		/// </summary>
		[DataMember(Name="perks", EmitDefaultValue=false)]
		public List<DestinyPerkReference> Perks { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemPerksComponent);
        }

		public bool Equals(DestinyItemPerksComponent input)
		{
			if (input == null) return false;

			return
				(
                    Perks == input.Perks ||
                    (Perks != null && Perks.Equals(input.Perks))
                ) ;
		}
	}
}

