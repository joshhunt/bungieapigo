using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// If defined, the item has at least one socket.
	[DataContract]
	public class DestinyItemSocketBlockDefinition{

		/// <summary>
		/// This was supposed to be a string that would give per-item details about sockets. In practice, it turns out that all this ever has is the localized word "details". ... that's lame, but perhaps it will become something cool in the future.
		/// </summary>
		[DataMember(Name="detail", EmitDefaultValue=false)]
		public string Detail { get; set; }

		/// <summary>
		/// Each non-intrinsic (or mutable) socket on an item is defined here. Check inside for more info.
		/// </summary>
		[DataMember(Name="socketEntries", EmitDefaultValue=false)]
		public List<DestinyItemSocketEntryDefinition> SocketEntries { get; set; }

		/// <summary>
		/// Each intrinsic (or immutable/permanent) socket on an item is defined here, along with the plug that is permanently affixed to the socket.
		/// </summary>
		[DataMember(Name="intrinsicSockets", EmitDefaultValue=false)]
		public List<DestinyItemIntrinsicSocketEntryDefinition> IntrinsicSockets { get; set; }

		/// <summary>
		/// A convenience property, that refers to the sockets in the "sockets" property, pre-grouped by category and ordered in the manner that they should be grouped in the UI. You could form this yourself with the existing data, but why would you want to? Enjoy life man.
		/// </summary>
		[DataMember(Name="socketCategories", EmitDefaultValue=false)]
		public List<DestinyItemSocketCategoryDefinition> SocketCategories { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketBlockDefinition);
        }

		public bool Equals(DestinyItemSocketBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Detail == input.Detail ||
                    (Detail != null && Detail.Equals(input.Detail))
                ) &&
				(
                    SocketEntries == input.SocketEntries ||
                    (SocketEntries != null && SocketEntries.Equals(input.SocketEntries))
                ) &&
				(
                    IntrinsicSockets == input.IntrinsicSockets ||
                    (IntrinsicSockets != null && IntrinsicSockets.Equals(input.IntrinsicSockets))
                ) &&
				(
                    SocketCategories == input.SocketCategories ||
                    (SocketCategories != null && SocketCategories.Equals(input.SocketCategories))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Detail.GetHashCode();
				hashCode = hashCode * 59 + this.SocketEntries.GetHashCode();
				hashCode = hashCode * 59 + this.IntrinsicSockets.GetHashCode();
				hashCode = hashCode * 59 + this.SocketCategories.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

