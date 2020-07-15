using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyItemSocketEntryPlugItemRandomizedDefinition{

		/// <summary>
		/// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
		/// </summary>
		[DataMember(Name="plugItemHash", EmitDefaultValue=false)]
		public uint PlugItemHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketEntryPlugItemRandomizedDefinition);
        }

		public bool Equals(DestinyItemSocketEntryPlugItemRandomizedDefinition input)
		{
			if (input == null) return false;

			return
				(
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash != null && PlugItemHash.Equals(input.PlugItemHash))
                ) ;
		}
	}
}

