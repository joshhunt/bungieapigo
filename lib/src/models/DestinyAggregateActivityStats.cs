using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyAggregateActivityStats{

		/// <summary>
		/// Hash ID that can be looked up in the DestinyActivityTable.
		/// </summary>
		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }

		/// <summary>
		/// Collection of stats for the player in this activity.
		/// </summary>
		[DataMember(Name="values", EmitDefaultValue=false)]
		public Map<String, DestinyHistoricalStatsValue> Values { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyAggregateActivityStats);
        }

		public bool Equals(DestinyAggregateActivityStats input)
		{
			if (input == null) return false;

			return
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
				(
                    Values == input.Values ||
                    (Values != null && Values.Equals(input.Values))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ActivityHash.GetHashCode();
				hashCode = hashCode * 59 + this.Values.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

