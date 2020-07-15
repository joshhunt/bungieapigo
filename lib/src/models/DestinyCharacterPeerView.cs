using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// A minimal view of a character's equipped items, for the purpose of rendering a summary screen or showing the character in 3D.
	/// </summary>
	[DataContract]
	public class DestinyCharacterPeerView{

		[DataMember(Name="equipment", EmitDefaultValue=false)]
		public List<DestinyItemPeerView> Equipment { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterPeerView);
        }

		public bool Equals(DestinyCharacterPeerView input)
		{
			if (input == null) return false;

			return
				(
                    Equipment == input.Equipment ||
                    (Equipment != null && Equipment.Equals(input.Equipment))
                ) ;
		}
	}
}

