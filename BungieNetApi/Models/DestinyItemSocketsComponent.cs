using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Instanced items can have sockets, which are slots on the item where plugs can be inserted.
	/// </summary>
	/// <summary>
	/// Sockets are a bit complex: be sure to examine the documentation on the DestinyInventoryItemDefinition's "socket" block and elsewhere on these objects for more details.
	/// </summary>
	[DataContract]
	public class DestinyItemSocketsComponent{

		/// <summary>
		/// The list of all sockets on the item, and their status information.
		/// </summary>
		[DataMember(Name="sockets", EmitDefaultValue=false)]
		public List<DestinyItemSocketState> Sockets { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketsComponent);
        }

		public bool Equals(DestinyItemSocketsComponent input)
		{
			if (input == null) return false;

			return
				(
                    Sockets == input.Sockets ||
                    (Sockets != null && Sockets.Equals(input.Sockets))
                ) ;
		}
	}
}

