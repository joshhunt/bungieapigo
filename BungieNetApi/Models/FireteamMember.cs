using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class FireteamMember{

		[DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
		public FireteamUserInfoCard DestinyUserInfo { get; set; }

		/// <summary>
		/// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
		/// </summary>
		[DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
		public UserInfoCard BungieNetUserInfo { get; set; }

		[DataMember(Name="characterId", EmitDefaultValue=false)]
		public long CharacterId { get; set; }

		[DataMember(Name="dateJoined", EmitDefaultValue=false)]
		public string DateJoined { get; set; }

		[DataMember(Name="hasMicrophone", EmitDefaultValue=false)]
		public bool HasMicrophone { get; set; }

		[DataMember(Name="lastPlatformInviteAttemptDate", EmitDefaultValue=false)]
		public string LastPlatformInviteAttemptDate { get; set; }

		[DataMember(Name="lastPlatformInviteAttemptResult", EmitDefaultValue=false)]
		public FireteamPlatformInviteResult LastPlatformInviteAttemptResult { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as FireteamMember);
        }

		public bool Equals(FireteamMember input)
		{
			if (input == null) return false;

			return
				(
                    DestinyUserInfo == input.DestinyUserInfo ||
                    (DestinyUserInfo != null && DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) &&
				(
                    BungieNetUserInfo == input.BungieNetUserInfo ||
                    (BungieNetUserInfo != null && BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) &&
				(
                    CharacterId == input.CharacterId ||
                    (CharacterId != null && CharacterId.Equals(input.CharacterId))
                ) &&
				(
                    DateJoined == input.DateJoined ||
                    (DateJoined != null && DateJoined.Equals(input.DateJoined))
                ) &&
				(
                    HasMicrophone == input.HasMicrophone ||
                    (HasMicrophone != null && HasMicrophone.Equals(input.HasMicrophone))
                ) &&
				(
                    LastPlatformInviteAttemptDate == input.LastPlatformInviteAttemptDate ||
                    (LastPlatformInviteAttemptDate != null && LastPlatformInviteAttemptDate.Equals(input.LastPlatformInviteAttemptDate))
                ) &&
				(
                    LastPlatformInviteAttemptResult == input.LastPlatformInviteAttemptResult ||
                    (LastPlatformInviteAttemptResult != null && LastPlatformInviteAttemptResult.Equals(input.LastPlatformInviteAttemptResult))
                ) ;
		}
	}
}

