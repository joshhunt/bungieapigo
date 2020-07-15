using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class TrendingEntryDestinyItem{

		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingEntryDestinyItem);
        }

		public bool Equals(TrendingEntryDestinyItem input)
		{
			if (input == null) return false;

			return
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) ;
		}
	}
}

