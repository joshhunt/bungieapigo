using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyHistoricalStatsWithMerged{

		[DataMember(Name="results", EmitDefaultValue=false)]
		public Map<String, DestinyHistoricalStatsByPeriod> Results { get; set; }

		[DataMember(Name="merged", EmitDefaultValue=false)]
		public DestinyHistoricalStatsByPeriod Merged { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsWithMerged);
        }

		public bool Equals(DestinyHistoricalStatsWithMerged input)
		{
			if (input == null) return false;

			return
				(
                    Results == input.Results ||
                    (Results != null && Results.Equals(input.Results))
                ) &&
				(
                    Merged == input.Merged ||
                    (Merged != null && Merged.Equals(input.Merged))
                ) ;
		}
	}
}

