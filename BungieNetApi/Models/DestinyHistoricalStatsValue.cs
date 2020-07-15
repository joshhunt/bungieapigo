using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyHistoricalStatsValue{

		/// <summary>
		/// Unique ID for this stat
		/// </summary>
		[DataMember(Name="statId", EmitDefaultValue=false)]
		public string StatId { get; set; }

		/// <summary>
		/// Basic stat value.
		/// </summary>
		[DataMember(Name="basic", EmitDefaultValue=false)]
		public DestinyHistoricalStatsValuePair Basic { get; set; }

		/// <summary>
		/// Per game average for the statistic, if applicable
		/// </summary>
		[DataMember(Name="pga", EmitDefaultValue=false)]
		public DestinyHistoricalStatsValuePair Pga { get; set; }

		/// <summary>
		/// Weighted value of the stat if a weight greater than 1 has been assigned.
		/// </summary>
		[DataMember(Name="weighted", EmitDefaultValue=false)]
		public DestinyHistoricalStatsValuePair Weighted { get; set; }

		/// <summary>
		/// When a stat represents the best, most, longest, fastest or some other personal best, the actual activity ID where that personal best was established is available on this property.
		/// </summary>
		[DataMember(Name="activityId", EmitDefaultValue=false)]
		public long ActivityId { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsValue);
        }

		public bool Equals(DestinyHistoricalStatsValue input)
		{
			if (input == null) return false;

			return
				(
                    StatId == input.StatId ||
                    (StatId != null && StatId.Equals(input.StatId))
                ) &&
				(
                    Basic == input.Basic ||
                    (Basic != null && Basic.Equals(input.Basic))
                ) &&
				(
                    Pga == input.Pga ||
                    (Pga != null && Pga.Equals(input.Pga))
                ) &&
				(
                    Weighted == input.Weighted ||
                    (Weighted != null && Weighted.Equals(input.Weighted))
                ) &&
				(
                    ActivityId == input.ActivityId ||
                    (ActivityId != null && ActivityId.Equals(input.ActivityId))
                ) ;
		}
	}
}

