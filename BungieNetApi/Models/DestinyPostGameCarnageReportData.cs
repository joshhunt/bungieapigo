using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyPostGameCarnageReportData{

		/// <summary>
		/// Date and time for the activity.
		/// </summary>
		[DataMember(Name="period", EmitDefaultValue=false)]
		public string Period { get; set; }

		/// <summary>
		/// If this activity has "phases", this is the phase at which the activity was started.
		/// </summary>
		[DataMember(Name="startingPhaseIndex", EmitDefaultValue=false)]
		public long StartingPhaseIndex { get; set; }

		/// <summary>
		/// Details about the activity.
		/// </summary>
		[DataMember(Name="activityDetails", EmitDefaultValue=false)]
		public DestinyHistoricalStatsActivity ActivityDetails { get; set; }

		/// <summary>
		/// Collection of players and their data for this activity.
		/// </summary>
		[DataMember(Name="entries", EmitDefaultValue=false)]
		public List<DestinyPostGameCarnageReportEntry> Entries { get; set; }

		/// <summary>
		/// Collection of stats for the player in this activity.
		/// </summary>
		[DataMember(Name="teams", EmitDefaultValue=false)]
		public List<DestinyPostGameCarnageReportTeamEntry> Teams { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPostGameCarnageReportData);
        }

		public bool Equals(DestinyPostGameCarnageReportData input)
		{
			if (input == null) return false;

			return
				(
                    Period == input.Period ||
                    (Period != null && Period.Equals(input.Period))
                ) &&
				(
                    StartingPhaseIndex == input.StartingPhaseIndex ||
                    (StartingPhaseIndex != null && StartingPhaseIndex.Equals(input.StartingPhaseIndex))
                ) &&
				(
                    ActivityDetails == input.ActivityDetails ||
                    (ActivityDetails != null && ActivityDetails.Equals(input.ActivityDetails))
                ) &&
				(
                    Entries == input.Entries ||
                    (Entries != null && Entries.Equals(input.Entries))
                ) &&
				(
                    Teams == input.Teams ||
                    (Teams != null && Teams.Equals(input.Teams))
                ) ;
		}
	}
}

