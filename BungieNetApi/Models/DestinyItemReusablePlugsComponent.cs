using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyItemReusablePlugsComponent{

		/// <summary>
		/// If the item supports reusable plugs, this is the list of plugs that are allowed to be used for the socket, and any relevant information about whether they are "enabled", whether they are allowed to be inserted, and any other information such as objectives.
		/// </summary>
		/// <summary>
		///  A Reusable Plug is a plug that you can always insert into this socket as long as its insertion rules are passed, regardless of whether or not you have the plug in your inventory. An example of it failing an insertion rule would be if it has an Objective that needs to be completed before it can be inserted, and that objective hasn't been completed yet.
		/// </summary>
		/// <summary>
		///  In practice, a socket will *either* have reusable plugs *or* it will allow for plugs in your inventory to be inserted. See DestinyInventoryItemDefinition.socket for more info.
		/// </summary>
		/// <summary>
		///  KEY = The INDEX into the item's list of sockets. VALUE = The set of plugs for that socket.
		/// </summary>
		/// <summary>
		///  If a socket doesn't have any reusable plugs defined at the item scope, there will be no entry for that socket.
		/// </summary>
		[DataMember(Name="plugs", EmitDefaultValue=false)]
		public Dictionary<string, List<DestinyItemPlugBase>> Plugs { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemReusablePlugsComponent);
        }

		public bool Equals(DestinyItemReusablePlugsComponent input)
		{
			if (input == null) return false;

			return
				(
                    Plugs == input.Plugs ||
                    (Plugs != null && Plugs.Equals(input.Plugs))
                ) ;
		}
	}
}

