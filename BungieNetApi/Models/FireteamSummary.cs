using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class FireteamSummary{

		[DataMember(Name="fireteamId", EmitDefaultValue=false)]
		public long FireteamId { get; set; }

		[DataMember(Name="groupId", EmitDefaultValue=false)]
		public long GroupId { get; set; }

		[DataMember(Name="platform", EmitDefaultValue=false)]
		public FireteamPlatform Platform { get; set; }

		[DataMember(Name="activityType", EmitDefaultValue=false)]
		public long ActivityType { get; set; }

		[DataMember(Name="isImmediate", EmitDefaultValue=false)]
		public bool IsImmediate { get; set; }

		[DataMember(Name="scheduledTime", EmitDefaultValue=false)]
		public string ScheduledTime { get; set; }

		[DataMember(Name="ownerMembershipId", EmitDefaultValue=false)]
		public long OwnerMembershipId { get; set; }

		[DataMember(Name="playerSlotCount", EmitDefaultValue=false)]
		public long PlayerSlotCount { get; set; }

		[DataMember(Name="alternateSlotCount", EmitDefaultValue=false)]
		public long AlternateSlotCount { get; set; }

		[DataMember(Name="availablePlayerSlotCount", EmitDefaultValue=false)]
		public long AvailablePlayerSlotCount { get; set; }

		[DataMember(Name="availableAlternateSlotCount", EmitDefaultValue=false)]
		public long AvailableAlternateSlotCount { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="dateCreated", EmitDefaultValue=false)]
		public string DateCreated { get; set; }

		[DataMember(Name="dateModified", EmitDefaultValue=false)]
		public string DateModified { get; set; }

		[DataMember(Name="isPublic", EmitDefaultValue=false)]
		public bool IsPublic { get; set; }

		[DataMember(Name="locale", EmitDefaultValue=false)]
		public string Locale { get; set; }

		[DataMember(Name="isValid", EmitDefaultValue=false)]
		public bool IsValid { get; set; }

		[DataMember(Name="datePlayerModified", EmitDefaultValue=false)]
		public string DatePlayerModified { get; set; }

		[DataMember(Name="titleBeforeModeration", EmitDefaultValue=false)]
		public string TitleBeforeModeration { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as FireteamSummary);
        }

		public bool Equals(FireteamSummary input)
		{
			if (input == null) return false;

			return
				(
                    FireteamId == input.FireteamId ||
                    (FireteamId != null && FireteamId.Equals(input.FireteamId))
                ) &&
				(
                    GroupId == input.GroupId ||
                    (GroupId != null && GroupId.Equals(input.GroupId))
                ) &&
				(
                    Platform == input.Platform ||
                    (Platform != null && Platform.Equals(input.Platform))
                ) &&
				(
                    ActivityType == input.ActivityType ||
                    (ActivityType != null && ActivityType.Equals(input.ActivityType))
                ) &&
				(
                    IsImmediate == input.IsImmediate ||
                    (IsImmediate != null && IsImmediate.Equals(input.IsImmediate))
                ) &&
				(
                    ScheduledTime == input.ScheduledTime ||
                    (ScheduledTime != null && ScheduledTime.Equals(input.ScheduledTime))
                ) &&
				(
                    OwnerMembershipId == input.OwnerMembershipId ||
                    (OwnerMembershipId != null && OwnerMembershipId.Equals(input.OwnerMembershipId))
                ) &&
				(
                    PlayerSlotCount == input.PlayerSlotCount ||
                    (PlayerSlotCount != null && PlayerSlotCount.Equals(input.PlayerSlotCount))
                ) &&
				(
                    AlternateSlotCount == input.AlternateSlotCount ||
                    (AlternateSlotCount != null && AlternateSlotCount.Equals(input.AlternateSlotCount))
                ) &&
				(
                    AvailablePlayerSlotCount == input.AvailablePlayerSlotCount ||
                    (AvailablePlayerSlotCount != null && AvailablePlayerSlotCount.Equals(input.AvailablePlayerSlotCount))
                ) &&
				(
                    AvailableAlternateSlotCount == input.AvailableAlternateSlotCount ||
                    (AvailableAlternateSlotCount != null && AvailableAlternateSlotCount.Equals(input.AvailableAlternateSlotCount))
                ) &&
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    DateCreated == input.DateCreated ||
                    (DateCreated != null && DateCreated.Equals(input.DateCreated))
                ) &&
				(
                    DateModified == input.DateModified ||
                    (DateModified != null && DateModified.Equals(input.DateModified))
                ) &&
				(
                    IsPublic == input.IsPublic ||
                    (IsPublic != null && IsPublic.Equals(input.IsPublic))
                ) &&
				(
                    Locale == input.Locale ||
                    (Locale != null && Locale.Equals(input.Locale))
                ) &&
				(
                    IsValid == input.IsValid ||
                    (IsValid != null && IsValid.Equals(input.IsValid))
                ) &&
				(
                    DatePlayerModified == input.DatePlayerModified ||
                    (DatePlayerModified != null && DatePlayerModified.Equals(input.DatePlayerModified))
                ) &&
				(
                    TitleBeforeModeration == input.TitleBeforeModeration ||
                    (TitleBeforeModeration != null && TitleBeforeModeration.Equals(input.TitleBeforeModeration))
                ) ;
		}
	}
}

