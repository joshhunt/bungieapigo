using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyHistoricalStatsValuePair{

		/// <summary>
		/// Raw value of the statistic
		/// </summary>
		[DataMember(Name="value", EmitDefaultValue=false)]
		public double Value { get; set; }

		/// <summary>
		/// Localized formated version of the value.
		/// </summary>
		[DataMember(Name="displayValue", EmitDefaultValue=false)]
		public string DisplayValue { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsValuePair);
        }

		public bool Equals(DestinyHistoricalStatsValuePair input)
		{
			if (input == null) return false;

			return
				(
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) &&
				(
                    DisplayValue == input.DisplayValue ||
                    (DisplayValue != null && DisplayValue.Equals(input.DisplayValue))
                ) ;
		}
	}
}

