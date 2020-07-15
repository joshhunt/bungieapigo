using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// This is a bit of an odd duck. Apparently, if talent nodes steps have this data, the game will go through on step activation and alter the first Socket it finds on the item that has a type matching the given socket type, inserting the indicated plug item.
	/// </summary>
	[DataContract]
	public class DestinyNodeSocketReplaceResponse{

		/// <summary>
		/// The hash identifier of the socket type to find amidst the item's sockets (the item to which this talent grid is attached). See DestinyInventoryItemDefinition.sockets.socketEntries to find the socket type of sockets on the item in question.
		/// </summary>
		[DataMember(Name="socketTypeHash", EmitDefaultValue=false)]
		public uint SocketTypeHash { get; set; }

		/// <summary>
		/// The hash identifier of the plug item that will be inserted into the socket found.
		/// </summary>
		[DataMember(Name="plugItemHash", EmitDefaultValue=false)]
		public uint PlugItemHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyNodeSocketReplaceResponse);
        }

		public bool Equals(DestinyNodeSocketReplaceResponse input)
		{
			if (input == null) return false;

			return
				(
                    SocketTypeHash == input.SocketTypeHash ||
                    (SocketTypeHash != null && SocketTypeHash.Equals(input.SocketTypeHash))
                ) &&
				(
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash != null && PlugItemHash.Equals(input.PlugItemHash))
                ) ;
		}
	}
}

