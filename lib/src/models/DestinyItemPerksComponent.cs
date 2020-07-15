using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Instanced items can have perks: benefits that the item bestows.
	/// These are related to DestinySandboxPerkDefinition, and sometimes - but not always - have human readable info. When they do, they are the icons and text that you see in an item&#39;s tooltip.
	/// Talent Grids, Sockets, and the item itself can apply Perks, which are then summarized here for your convenience.
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

