using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Not terribly useful, some basic cooldown interaction info.
	[DataContract]
	public class DestinyVendorSaleItemActionBlockDefinition{

		[DataMember(Name="executeSeconds", EmitDefaultValue=false)]
		public double ExecuteSeconds { get; set; }

		[DataMember(Name="isPositive", EmitDefaultValue=false)]
		public bool IsPositive { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorSaleItemActionBlockDefinition);
        }

		public bool Equals(DestinyVendorSaleItemActionBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ExecuteSeconds == input.ExecuteSeconds ||
                    (ExecuteSeconds != null && ExecuteSeconds.Equals(input.ExecuteSeconds))
                ) &&
				(
                    IsPositive == input.IsPositive ||
                    (IsPositive != null && IsPositive.Equals(input.IsPositive))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ExecuteSeconds.GetHashCode();
				hashCode = hashCode * 59 + this.IsPositive.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

