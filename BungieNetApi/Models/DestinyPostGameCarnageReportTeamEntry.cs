using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyPostGameCarnageReportTeamEntry{

		/// <summary>
		/// Integer ID for the team.
		/// </summary>
		[DataMember(Name="teamId", EmitDefaultValue=false)]
		public long TeamId { get; set; }

		/// <summary>
		/// Team's standing relative to other teams.
		/// </summary>
		[DataMember(Name="standing", EmitDefaultValue=false)]
		public DestinyHistoricalStatsValue Standing { get; set; }

		/// <summary>
		/// Score earned by the team
		/// </summary>
		[DataMember(Name="score", EmitDefaultValue=false)]
		public DestinyHistoricalStatsValue Score { get; set; }

		/// <summary>
		/// Alpha or Bravo
		/// </summary>
		[DataMember(Name="teamName", EmitDefaultValue=false)]
		public string TeamName { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPostGameCarnageReportTeamEntry);
        }

		public bool Equals(DestinyPostGameCarnageReportTeamEntry input)
		{
			if (input == null) return false;

			return
				(
                    TeamId == input.TeamId ||
                    (TeamId != null && TeamId.Equals(input.TeamId))
                ) &&
				(
                    Standing == input.Standing ||
                    (Standing != null && Standing.Equals(input.Standing))
                ) &&
				(
                    Score == input.Score ||
                    (Score != null && Score.Equals(input.Score))
                ) &&
				(
                    TeamName == input.TeamName ||
                    (TeamName != null && TeamName.Equals(input.TeamName))
                ) ;
		}
	}
}

