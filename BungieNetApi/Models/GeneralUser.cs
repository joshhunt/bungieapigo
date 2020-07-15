using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class GeneralUser{

		[DataMember(Name="membershipId", EmitDefaultValue=false)]
		public long MembershipId { get; set; }

		[DataMember(Name="uniqueName", EmitDefaultValue=false)]
		public string UniqueName { get; set; }

		[DataMember(Name="normalizedName", EmitDefaultValue=false)]
		public string NormalizedName { get; set; }

		[DataMember(Name="displayName", EmitDefaultValue=false)]
		public string DisplayName { get; set; }

		[DataMember(Name="profilePicture", EmitDefaultValue=false)]
		public long ProfilePicture { get; set; }

		[DataMember(Name="profileTheme", EmitDefaultValue=false)]
		public long ProfileTheme { get; set; }

		[DataMember(Name="userTitle", EmitDefaultValue=false)]
		public long UserTitle { get; set; }

		[DataMember(Name="successMessageFlags", EmitDefaultValue=false)]
		public long SuccessMessageFlags { get; set; }

		[DataMember(Name="isDeleted", EmitDefaultValue=false)]
		public bool IsDeleted { get; set; }

		[DataMember(Name="about", EmitDefaultValue=false)]
		public string About { get; set; }

		[DataMember(Name="firstAccess", EmitDefaultValue=false)]
		public string FirstAccess { get; set; }

		[DataMember(Name="lastUpdate", EmitDefaultValue=false)]
		public string LastUpdate { get; set; }

		[DataMember(Name="legacyPortalUID", EmitDefaultValue=false)]
		public long LegacyPortalUid { get; set; }

		[DataMember(Name="context", EmitDefaultValue=false)]
		public UserToUserContext Context { get; set; }

		[DataMember(Name="psnDisplayName", EmitDefaultValue=false)]
		public string PsnDisplayName { get; set; }

		[DataMember(Name="xboxDisplayName", EmitDefaultValue=false)]
		public string XboxDisplayName { get; set; }

		[DataMember(Name="fbDisplayName", EmitDefaultValue=false)]
		public string FbDisplayName { get; set; }

		[DataMember(Name="showActivity", EmitDefaultValue=false)]
		public bool ShowActivity { get; set; }

		[DataMember(Name="locale", EmitDefaultValue=false)]
		public string Locale { get; set; }

		[DataMember(Name="localeInheritDefault", EmitDefaultValue=false)]
		public bool LocaleInheritDefault { get; set; }

		[DataMember(Name="lastBanReportId", EmitDefaultValue=false)]
		public long LastBanReportId { get; set; }

		[DataMember(Name="showGroupMessaging", EmitDefaultValue=false)]
		public bool ShowGroupMessaging { get; set; }

		[DataMember(Name="profilePicturePath", EmitDefaultValue=false)]
		public string ProfilePicturePath { get; set; }

		[DataMember(Name="profilePictureWidePath", EmitDefaultValue=false)]
		public string ProfilePictureWidePath { get; set; }

		[DataMember(Name="profileThemeName", EmitDefaultValue=false)]
		public string ProfileThemeName { get; set; }

		[DataMember(Name="userTitleDisplay", EmitDefaultValue=false)]
		public string UserTitleDisplay { get; set; }

		[DataMember(Name="statusText", EmitDefaultValue=false)]
		public string StatusText { get; set; }

		[DataMember(Name="statusDate", EmitDefaultValue=false)]
		public string StatusDate { get; set; }

		[DataMember(Name="profileBanExpire", EmitDefaultValue=false)]
		public string ProfileBanExpire { get; set; }

		[DataMember(Name="blizzardDisplayName", EmitDefaultValue=false)]
		public string BlizzardDisplayName { get; set; }

		[DataMember(Name="steamDisplayName", EmitDefaultValue=false)]
		public string SteamDisplayName { get; set; }

		[DataMember(Name="stadiaDisplayName", EmitDefaultValue=false)]
		public string StadiaDisplayName { get; set; }

		[DataMember(Name="twitchDisplayName", EmitDefaultValue=false)]
		public string TwitchDisplayName { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GeneralUser);
        }

		public bool Equals(GeneralUser input)
		{
			if (input == null) return false;

			return
				(
                    MembershipId == input.MembershipId ||
                    (MembershipId != null && MembershipId.Equals(input.MembershipId))
                ) &&
				(
                    UniqueName == input.UniqueName ||
                    (UniqueName != null && UniqueName.Equals(input.UniqueName))
                ) &&
				(
                    NormalizedName == input.NormalizedName ||
                    (NormalizedName != null && NormalizedName.Equals(input.NormalizedName))
                ) &&
				(
                    DisplayName == input.DisplayName ||
                    (DisplayName != null && DisplayName.Equals(input.DisplayName))
                ) &&
				(
                    ProfilePicture == input.ProfilePicture ||
                    (ProfilePicture != null && ProfilePicture.Equals(input.ProfilePicture))
                ) &&
				(
                    ProfileTheme == input.ProfileTheme ||
                    (ProfileTheme != null && ProfileTheme.Equals(input.ProfileTheme))
                ) &&
				(
                    UserTitle == input.UserTitle ||
                    (UserTitle != null && UserTitle.Equals(input.UserTitle))
                ) &&
				(
                    SuccessMessageFlags == input.SuccessMessageFlags ||
                    (SuccessMessageFlags != null && SuccessMessageFlags.Equals(input.SuccessMessageFlags))
                ) &&
				(
                    IsDeleted == input.IsDeleted ||
                    (IsDeleted != null && IsDeleted.Equals(input.IsDeleted))
                ) &&
				(
                    About == input.About ||
                    (About != null && About.Equals(input.About))
                ) &&
				(
                    FirstAccess == input.FirstAccess ||
                    (FirstAccess != null && FirstAccess.Equals(input.FirstAccess))
                ) &&
				(
                    LastUpdate == input.LastUpdate ||
                    (LastUpdate != null && LastUpdate.Equals(input.LastUpdate))
                ) &&
				(
                    LegacyPortalUid == input.LegacyPortalUid ||
                    (LegacyPortalUid != null && LegacyPortalUid.Equals(input.LegacyPortalUid))
                ) &&
				(
                    Context == input.Context ||
                    (Context != null && Context.Equals(input.Context))
                ) &&
				(
                    PsnDisplayName == input.PsnDisplayName ||
                    (PsnDisplayName != null && PsnDisplayName.Equals(input.PsnDisplayName))
                ) &&
				(
                    XboxDisplayName == input.XboxDisplayName ||
                    (XboxDisplayName != null && XboxDisplayName.Equals(input.XboxDisplayName))
                ) &&
				(
                    FbDisplayName == input.FbDisplayName ||
                    (FbDisplayName != null && FbDisplayName.Equals(input.FbDisplayName))
                ) &&
				(
                    ShowActivity == input.ShowActivity ||
                    (ShowActivity != null && ShowActivity.Equals(input.ShowActivity))
                ) &&
				(
                    Locale == input.Locale ||
                    (Locale != null && Locale.Equals(input.Locale))
                ) &&
				(
                    LocaleInheritDefault == input.LocaleInheritDefault ||
                    (LocaleInheritDefault != null && LocaleInheritDefault.Equals(input.LocaleInheritDefault))
                ) &&
				(
                    LastBanReportId == input.LastBanReportId ||
                    (LastBanReportId != null && LastBanReportId.Equals(input.LastBanReportId))
                ) &&
				(
                    ShowGroupMessaging == input.ShowGroupMessaging ||
                    (ShowGroupMessaging != null && ShowGroupMessaging.Equals(input.ShowGroupMessaging))
                ) &&
				(
                    ProfilePicturePath == input.ProfilePicturePath ||
                    (ProfilePicturePath != null && ProfilePicturePath.Equals(input.ProfilePicturePath))
                ) &&
				(
                    ProfilePictureWidePath == input.ProfilePictureWidePath ||
                    (ProfilePictureWidePath != null && ProfilePictureWidePath.Equals(input.ProfilePictureWidePath))
                ) &&
				(
                    ProfileThemeName == input.ProfileThemeName ||
                    (ProfileThemeName != null && ProfileThemeName.Equals(input.ProfileThemeName))
                ) &&
				(
                    UserTitleDisplay == input.UserTitleDisplay ||
                    (UserTitleDisplay != null && UserTitleDisplay.Equals(input.UserTitleDisplay))
                ) &&
				(
                    StatusText == input.StatusText ||
                    (StatusText != null && StatusText.Equals(input.StatusText))
                ) &&
				(
                    StatusDate == input.StatusDate ||
                    (StatusDate != null && StatusDate.Equals(input.StatusDate))
                ) &&
				(
                    ProfileBanExpire == input.ProfileBanExpire ||
                    (ProfileBanExpire != null && ProfileBanExpire.Equals(input.ProfileBanExpire))
                ) &&
				(
                    BlizzardDisplayName == input.BlizzardDisplayName ||
                    (BlizzardDisplayName != null && BlizzardDisplayName.Equals(input.BlizzardDisplayName))
                ) &&
				(
                    SteamDisplayName == input.SteamDisplayName ||
                    (SteamDisplayName != null && SteamDisplayName.Equals(input.SteamDisplayName))
                ) &&
				(
                    StadiaDisplayName == input.StadiaDisplayName ||
                    (StadiaDisplayName != null && StadiaDisplayName.Equals(input.StadiaDisplayName))
                ) &&
				(
                    TwitchDisplayName == input.TwitchDisplayName ||
                    (TwitchDisplayName != null && TwitchDisplayName.Equals(input.TwitchDisplayName))
                ) ;
		}
	}
}

