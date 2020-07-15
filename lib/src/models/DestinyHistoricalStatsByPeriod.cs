using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyHistoricalStatsByPeriod{

		[DataMember(Name="allTime", EmitDefaultValue=false)]
		public Map<String, DestinyHistoricalStatsValue> AllTime { get; set; }

		[DataMember(Name="allTimeTier1", EmitDefaultValue=false)]
		public Map<String, DestinyHistoricalStatsValue> AllTimeTier1 { get; set; }

		[DataMember(Name="allTimeTier2", EmitDefaultValue=false)]
		public Map<String, DestinyHistoricalStatsValue> AllTimeTier2 { get; set; }

		[DataMember(Name="allTimeTier3", EmitDefaultValue=false)]
		public Map<String, DestinyHistoricalStatsValue> AllTimeTier3 { get; set; }

		[DataMember(Name="daily", EmitDefaultValue=false)]
		public List<DestinyHistoricalStatsPeriodGroup> Daily { get; set; }

		[DataMember(Name="monthly", EmitDefaultValue=false)]
		public List<DestinyHistoricalStatsPeriodGroup> Monthly { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsByPeriod);
        }

		public bool Equals(DestinyHistoricalStatsByPeriod input)
		{
			if (input == null) return false;

			return
				(
                    AllTime == input.AllTime ||
                    (AllTime != null && AllTime.Equals(input.AllTime))
                ) &&
				(
                    AllTimeTier1 == input.AllTimeTier1 ||
                    (AllTimeTier1 != null && AllTimeTier1.Equals(input.AllTimeTier1))
                ) &&
				(
                    AllTimeTier2 == input.AllTimeTier2 ||
                    (AllTimeTier2 != null && AllTimeTier2.Equals(input.AllTimeTier2))
                ) &&
				(
                    AllTimeTier3 == input.AllTimeTier3 ||
                    (AllTimeTier3 != null && AllTimeTier3.Equals(input.AllTimeTier3))
                ) &&
				(
                    Daily == input.Daily ||
                    (Daily != null && Daily.Equals(input.Daily))
                ) &&
				(
                    Monthly == input.Monthly ||
                    (Monthly != null && Monthly.Equals(input.Monthly))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.AllTime.GetHashCode();
				hashCode = hashCode * 59 + this.AllTimeTier1.GetHashCode();
				hashCode = hashCode * 59 + this.AllTimeTier2.GetHashCode();
				hashCode = hashCode * 59 + this.AllTimeTier3.GetHashCode();
				hashCode = hashCode * 59 + this.Daily.GetHashCode();
				hashCode = hashCode * 59 + this.Monthly.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

