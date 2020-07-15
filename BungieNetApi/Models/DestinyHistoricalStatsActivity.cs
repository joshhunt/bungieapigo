using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Summary information about the activity that was played.
	/// </summary>
	[DataContract]
	public class DestinyHistoricalStatsActivity{

		/// <summary>
		/// The unique hash identifier of the DestinyActivityDefinition that was played. If I had this to do over, it'd be named activityHash. Too late now.
		/// </summary>
		[DataMember(Name="referenceId", EmitDefaultValue=false)]
		public uint ReferenceId { get; set; }

		/// <summary>
		/// The unique hash identifier of the DestinyActivityDefinition that was played.
		/// </summary>
		[DataMember(Name="directorActivityHash", EmitDefaultValue=false)]
		public uint DirectorActivityHash { get; set; }

		/// <summary>
		/// The unique identifier for this *specific* match that was played.
		/// </summary>
		/// <summary>
		/// This value can be used to get additional data about this activity such as who else was playing via the GetPostGameCarnageReport endpoint.
		/// </summary>
		[DataMember(Name="instanceId", EmitDefaultValue=false)]
		public long InstanceId { get; set; }

		/// <summary>
		/// Indicates the most specific game mode of the activity that we could find.
		/// </summary>
		[DataMember(Name="mode", EmitDefaultValue=false)]
		public DestinyActivityModeType Mode { get; set; }

		/// <summary>
		/// The list of all Activity Modes to which this activity applies, including aggregates. This will let you see, for example, whether the activity was both Clash and part of the Trials of the Nine event.
		/// </summary>
		[DataMember(Name="modes", EmitDefaultValue=false)]
		public List<DestinyActivityModeType> Modes { get; set; }

		/// <summary>
		/// Whether or not the match was a private match.
		/// </summary>
		[DataMember(Name="isPrivate", EmitDefaultValue=false)]
		public bool IsPrivate { get; set; }

		/// <summary>
		/// The Membership Type indicating the platform on which this match was played.
		/// </summary>
		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsActivity);
        }

		public bool Equals(DestinyHistoricalStatsActivity input)
		{
			if (input == null) return false;

			return
				(
                    ReferenceId == input.ReferenceId ||
                    (ReferenceId != null && ReferenceId.Equals(input.ReferenceId))
                ) &&
				(
                    DirectorActivityHash == input.DirectorActivityHash ||
                    (DirectorActivityHash != null && DirectorActivityHash.Equals(input.DirectorActivityHash))
                ) &&
				(
                    InstanceId == input.InstanceId ||
                    (InstanceId != null && InstanceId.Equals(input.InstanceId))
                ) &&
				(
                    Mode == input.Mode ||
                    (Mode != null && Mode.Equals(input.Mode))
                ) &&
				(
                    Modes == input.Modes ||
                    (Modes != null && Modes.Equals(input.Modes))
                ) &&
				(
                    IsPrivate == input.IsPrivate ||
                    (IsPrivate != null && IsPrivate.Equals(input.IsPrivate))
                ) &&
				(
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) ;
		}
	}
}

