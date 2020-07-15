using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Represents a season and the number of resets you had in that season.
	///  We do not necessarily - even for progressions with resets - track it over all seasons. So be careful and check the season numbers being returned.
	[DataContract]
	public class DestinyProgressionResetEntry{

		[DataMember(Name="season", EmitDefaultValue=false)]
		public long Season { get; set; }

		[DataMember(Name="resets", EmitDefaultValue=false)]
		public long Resets { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProgressionResetEntry);
        }

		public bool Equals(DestinyProgressionResetEntry input)
		{
			if (input == null) return false;

			return
				(
                    Season == input.Season ||
                    (Season != null && Season.Equals(input.Season))
                ) &&
				(
                    Resets == input.Resets ||
                    (Resets != null && Resets.Equals(input.Resets))
                ) ;
		}
	}
}

