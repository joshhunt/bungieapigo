using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinySocketTypeScalarMaterialRequirementEntry{

		[DataMember(Name="currencyItemHash", EmitDefaultValue=false)]
		public uint CurrencyItemHash { get; set; }

		[DataMember(Name="scalarValue", EmitDefaultValue=false)]
		public long ScalarValue { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinySocketTypeScalarMaterialRequirementEntry);
        }

		public bool Equals(DestinySocketTypeScalarMaterialRequirementEntry input)
		{
			if (input == null) return false;

			return
				(
                    CurrencyItemHash == input.CurrencyItemHash ||
                    (CurrencyItemHash != null && CurrencyItemHash.Equals(input.CurrencyItemHash))
                ) &&
				(
                    ScalarValue == input.ScalarValue ||
                    (ScalarValue != null && ScalarValue.Equals(input.ScalarValue))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.CurrencyItemHash.GetHashCode();
				hashCode = hashCode * 59 + this.ScalarValue.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

