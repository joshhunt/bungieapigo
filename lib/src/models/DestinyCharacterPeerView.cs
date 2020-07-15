using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// A minimal view of a character&#39;s equipped items, for the purpose of rendering a summary screen or showing the character in 3D.
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

