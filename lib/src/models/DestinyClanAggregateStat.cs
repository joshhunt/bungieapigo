using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyClanAggregateStat{

		/// <summary>
		/// The id of the mode of stats (allPvp, allPvE, etc)
		/// </summary>
		[DataMember(Name="mode", EmitDefaultValue=false)]
		public DestinyActivityModeType Mode { get; set; }

		/// <summary>
		/// The id of the stat
		/// </summary>
		[DataMember(Name="statId", EmitDefaultValue=false)]
		public string StatId { get; set; }

		/// <summary>
		/// Value of the stat for this player
		/// </summary>
		[DataMember(Name="value", EmitDefaultValue=false)]
		public DestinyHistoricalStatsValue Value { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyClanAggregateStat);
        }

		public bool Equals(DestinyClanAggregateStat input)
		{
			if (input == null) return false;

			return
				(
                    Mode == input.Mode ||
                    (Mode != null && Mode.Equals(input.Mode))
                ) &&
				(
                    StatId == input.StatId ||
                    (StatId != null && StatId.Equals(input.StatId))
                ) &&
				(
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Mode.GetHashCode();
				hashCode = hashCode * 59 + this.StatId.GetHashCode();
				hashCode = hashCode * 59 + this.Value.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

