using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Represents this player's personal completion status for the Activity under a Milestone, if the activity has trackable completion and progress information. (most activities won't, or the concept won't apply. For instance, it makes sense to talk about a tier of a raid as being Completed or having progress, but it doesn't make sense to talk about a Crucible Playlist in those terms.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneActivityCompletionStatus{

		/// <summary>
		/// If the activity has been "completed", that information will be returned here.
		/// </summary>
		[DataMember(Name="completed", EmitDefaultValue=false)]
		public bool Completed { get; set; }

		/// <summary>
		/// If the Activity has discrete "phases" that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
		/// </summary>
		[DataMember(Name="phases", EmitDefaultValue=false)]
		public List<DestinyMilestoneActivityPhase> Phases { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneActivityCompletionStatus);
        }

		public bool Equals(DestinyMilestoneActivityCompletionStatus input)
		{
			if (input == null) return false;

			return
				(
                    Completed == input.Completed ||
                    (Completed != null && Completed.Equals(input.Completed))
                ) &&
				(
                    Phases == input.Phases ||
                    (Phases != null && Phases.Equals(input.Phases))
                ) ;
		}
	}
}

