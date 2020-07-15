using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Represents custom data that we know about an individual variant of an activity.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneActivityVariant{

		/// <summary>
		/// The hash for the specific variant of the activity related to this milestone. You can pull more detailed static info from the DestinyActivityDefinition, such as difficulty level.
		/// </summary>
		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }

		/// <summary>
		/// An OPTIONAL component: if it makes sense to talk about this activity variant in terms of whether or not it has been completed or what progress you have made in it, this will be returned. Otherwise, this will be NULL.
		/// </summary>
		[DataMember(Name="completionStatus", EmitDefaultValue=false)]
		public DestinyMilestoneActivityCompletionStatus CompletionStatus { get; set; }

		/// <summary>
		/// The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.
		/// </summary>
		[DataMember(Name="activityModeHash", EmitDefaultValue=false)]
		public uint ActivityModeHash { get; set; }

		/// <summary>
		/// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
		/// </summary>
		[DataMember(Name="activityModeType", EmitDefaultValue=false)]
		public long ActivityModeType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneActivityVariant);
        }

		public bool Equals(DestinyMilestoneActivityVariant input)
		{
			if (input == null) return false;

			return
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
				(
                    CompletionStatus == input.CompletionStatus ||
                    (CompletionStatus != null && CompletionStatus.Equals(input.CompletionStatus))
                ) &&
				(
                    ActivityModeHash == input.ActivityModeHash ||
                    (ActivityModeHash != null && ActivityModeHash.Equals(input.ActivityModeHash))
                ) &&
				(
                    ActivityModeType == input.ActivityModeType ||
                    (ActivityModeType != null && ActivityModeType.Equals(input.ActivityModeType))
                ) ;
		}
	}
}

