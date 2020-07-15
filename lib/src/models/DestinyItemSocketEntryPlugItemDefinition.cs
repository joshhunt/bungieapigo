using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The definition of a known, reusable plug that can be applied to a socket.
	[DataContract]
	public class DestinyItemSocketEntryPlugItemDefinition{

		/// <summary>
		/// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
		/// </summary>
		[DataMember(Name="plugItemHash", EmitDefaultValue=false)]
		public uint PlugItemHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketEntryPlugItemDefinition);
        }

		public bool Equals(DestinyItemSocketEntryPlugItemDefinition input)
		{
			if (input == null) return false;

			return
				(
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash != null && PlugItemHash.Equals(input.PlugItemHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.PlugItemHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

