using System.Runtime.Serialization;

namespace BungieNetApi.Model {
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

