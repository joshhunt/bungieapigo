using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyLeaderboard{

		[DataMember(Name="statId", EmitDefaultValue=false)]
		public string StatId { get; set; }

		[DataMember(Name="entries", EmitDefaultValue=false)]
		public List<DestinyLeaderboardEntry> Entries { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyLeaderboard);
        }

		public bool Equals(DestinyLeaderboard input)
		{
			if (input == null) return false;

			return
				(
                    StatId == input.StatId ||
                    (StatId != null && StatId.Equals(input.StatId))
                ) &&
				(
                    Entries == input.Entries ||
                    (Entries != null && Entries.Equals(input.Entries))
                ) ;
		}
	}
}

