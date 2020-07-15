using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyLeaderboardEntry{

		/// <summary>
		/// Where this player ranks on the leaderboard. A value of 1 is the top rank.
		/// </summary>
		[DataMember(Name="rank", EmitDefaultValue=false)]
		public long Rank { get; set; }

		/// <summary>
		/// Identity details of the player
		/// </summary>
		[DataMember(Name="player", EmitDefaultValue=false)]
		public DestinyPlayer Player { get; set; }

		/// <summary>
		/// ID of the player's best character for the reported stat.
		/// </summary>
		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		/// <summary>
		/// Value of the stat for this player
		/// </summary>
		[DataMember(Name="value", EmitDefaultValue=false)]
		public DestinyHistoricalStatsValue Value { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyLeaderboardEntry);
        }

		public bool Equals(DestinyLeaderboardEntry input)
		{
			if (input == null) return false;

			return
				(
                    Rank == input.Rank ||
                    (Rank != null && Rank.Equals(input.Rank))
                ) &&
				(
                    Player == input.Player ||
                    (Player != null && Player.Equals(input.Player))
                ) &&
				(
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
				(
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) ;
		}
	}
}

