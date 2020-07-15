using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupV2{

		[DataMember(Name="groupId", EmitDefaultValue=false)]
		public long GroupId { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="groupType", EmitDefaultValue=false)]
		public GroupType GroupType { get; set; }

		[DataMember(Name="membershipIdCreated", EmitDefaultValue=false)]
		public long MembershipIdCreated { get; set; }

		[DataMember(Name="creationDate", EmitDefaultValue=false)]
		public string CreationDate { get; set; }

		[DataMember(Name="modificationDate", EmitDefaultValue=false)]
		public string ModificationDate { get; set; }

		[DataMember(Name="about", EmitDefaultValue=false)]
		public string About { get; set; }

		[DataMember(Name="tags", EmitDefaultValue=false)]
		public List<string> Tags { get; set; }

		[DataMember(Name="memberCount", EmitDefaultValue=false)]
		public long MemberCount { get; set; }

		[DataMember(Name="isPublic", EmitDefaultValue=false)]
		public bool IsPublic { get; set; }

		[DataMember(Name="isPublicTopicAdminOnly", EmitDefaultValue=false)]
		public bool IsPublicTopicAdminOnly { get; set; }

		[DataMember(Name="motto", EmitDefaultValue=false)]
		public string Motto { get; set; }

		[DataMember(Name="allowChat", EmitDefaultValue=false)]
		public bool AllowChat { get; set; }

		[DataMember(Name="isDefaultPostPublic", EmitDefaultValue=false)]
		public bool IsDefaultPostPublic { get; set; }

		[DataMember(Name="chatSecurity", EmitDefaultValue=false)]
		public ChatSecuritySetting ChatSecurity { get; set; }

		[DataMember(Name="locale", EmitDefaultValue=false)]
		public string Locale { get; set; }

		[DataMember(Name="avatarImageIndex", EmitDefaultValue=false)]
		public long AvatarImageIndex { get; set; }

		[DataMember(Name="homepage", EmitDefaultValue=false)]
		public GroupHomepage Homepage { get; set; }

		[DataMember(Name="membershipOption", EmitDefaultValue=false)]
		public MembershipOption MembershipOption { get; set; }

		[DataMember(Name="defaultPublicity", EmitDefaultValue=false)]
		public GroupPostPublicity DefaultPublicity { get; set; }

		[DataMember(Name="theme", EmitDefaultValue=false)]
		public string Theme { get; set; }

		[DataMember(Name="bannerPath", EmitDefaultValue=false)]
		public string BannerPath { get; set; }

		[DataMember(Name="avatarPath", EmitDefaultValue=false)]
		public string AvatarPath { get; set; }

		[DataMember(Name="conversationId", EmitDefaultValue=false)]
		public long ConversationId { get; set; }

		[DataMember(Name="enableInvitationMessagingForAdmins", EmitDefaultValue=false)]
		public bool EnableInvitationMessagingForAdmins { get; set; }

		[DataMember(Name="banExpireDate", EmitDefaultValue=false)]
		public string BanExpireDate { get; set; }

		[DataMember(Name="features", EmitDefaultValue=false)]
		public GroupFeatures Features { get; set; }

		/// <summary>
		/// The same as GroupV2ClanInfo, but includes any investment data.
		/// </summary>
		[DataMember(Name="clanInfo", EmitDefaultValue=false)]
		public GroupV2ClanInfoAndInvestment ClanInfo { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupV2);
        }

		public bool Equals(GroupV2 input)
		{
			if (input == null) return false;

			return
				(
                    GroupId == input.GroupId ||
                    (GroupId != null && GroupId.Equals(input.GroupId))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    GroupType == input.GroupType ||
                    (GroupType != null && GroupType.Equals(input.GroupType))
                ) &&
				(
                    MembershipIdCreated == input.MembershipIdCreated ||
                    (MembershipIdCreated != null && MembershipIdCreated.Equals(input.MembershipIdCreated))
                ) &&
				(
                    CreationDate == input.CreationDate ||
                    (CreationDate != null && CreationDate.Equals(input.CreationDate))
                ) &&
				(
                    ModificationDate == input.ModificationDate ||
                    (ModificationDate != null && ModificationDate.Equals(input.ModificationDate))
                ) &&
				(
                    About == input.About ||
                    (About != null && About.Equals(input.About))
                ) &&
				(
                    Tags == input.Tags ||
                    (Tags != null && Tags.Equals(input.Tags))
                ) &&
				(
                    MemberCount == input.MemberCount ||
                    (MemberCount != null && MemberCount.Equals(input.MemberCount))
                ) &&
				(
                    IsPublic == input.IsPublic ||
                    (IsPublic != null && IsPublic.Equals(input.IsPublic))
                ) &&
				(
                    IsPublicTopicAdminOnly == input.IsPublicTopicAdminOnly ||
                    (IsPublicTopicAdminOnly != null && IsPublicTopicAdminOnly.Equals(input.IsPublicTopicAdminOnly))
                ) &&
				(
                    Motto == input.Motto ||
                    (Motto != null && Motto.Equals(input.Motto))
                ) &&
				(
                    AllowChat == input.AllowChat ||
                    (AllowChat != null && AllowChat.Equals(input.AllowChat))
                ) &&
				(
                    IsDefaultPostPublic == input.IsDefaultPostPublic ||
                    (IsDefaultPostPublic != null && IsDefaultPostPublic.Equals(input.IsDefaultPostPublic))
                ) &&
				(
                    ChatSecurity == input.ChatSecurity ||
                    (ChatSecurity != null && ChatSecurity.Equals(input.ChatSecurity))
                ) &&
				(
                    Locale == input.Locale ||
                    (Locale != null && Locale.Equals(input.Locale))
                ) &&
				(
                    AvatarImageIndex == input.AvatarImageIndex ||
                    (AvatarImageIndex != null && AvatarImageIndex.Equals(input.AvatarImageIndex))
                ) &&
				(
                    Homepage == input.Homepage ||
                    (Homepage != null && Homepage.Equals(input.Homepage))
                ) &&
				(
                    MembershipOption == input.MembershipOption ||
                    (MembershipOption != null && MembershipOption.Equals(input.MembershipOption))
                ) &&
				(
                    DefaultPublicity == input.DefaultPublicity ||
                    (DefaultPublicity != null && DefaultPublicity.Equals(input.DefaultPublicity))
                ) &&
				(
                    Theme == input.Theme ||
                    (Theme != null && Theme.Equals(input.Theme))
                ) &&
				(
                    BannerPath == input.BannerPath ||
                    (BannerPath != null && BannerPath.Equals(input.BannerPath))
                ) &&
				(
                    AvatarPath == input.AvatarPath ||
                    (AvatarPath != null && AvatarPath.Equals(input.AvatarPath))
                ) &&
				(
                    ConversationId == input.ConversationId ||
                    (ConversationId != null && ConversationId.Equals(input.ConversationId))
                ) &&
				(
                    EnableInvitationMessagingForAdmins == input.EnableInvitationMessagingForAdmins ||
                    (EnableInvitationMessagingForAdmins != null && EnableInvitationMessagingForAdmins.Equals(input.EnableInvitationMessagingForAdmins))
                ) &&
				(
                    BanExpireDate == input.BanExpireDate ||
                    (BanExpireDate != null && BanExpireDate.Equals(input.BanExpireDate))
                ) &&
				(
                    Features == input.Features ||
                    (Features != null && Features.Equals(input.Features))
                ) &&
				(
                    ClanInfo == input.ClanInfo ||
                    (ClanInfo != null && ClanInfo.Equals(input.ClanInfo))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.GroupId.GetHashCode();
				hashCode = hashCode * 59 + this.Name.GetHashCode();
				hashCode = hashCode * 59 + this.GroupType.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipIdCreated.GetHashCode();
				hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
				hashCode = hashCode * 59 + this.ModificationDate.GetHashCode();
				hashCode = hashCode * 59 + this.About.GetHashCode();
				hashCode = hashCode * 59 + this.Tags.GetHashCode();
				hashCode = hashCode * 59 + this.MemberCount.GetHashCode();
				hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
				hashCode = hashCode * 59 + this.IsPublicTopicAdminOnly.GetHashCode();
				hashCode = hashCode * 59 + this.Motto.GetHashCode();
				hashCode = hashCode * 59 + this.AllowChat.GetHashCode();
				hashCode = hashCode * 59 + this.IsDefaultPostPublic.GetHashCode();
				hashCode = hashCode * 59 + this.ChatSecurity.GetHashCode();
				hashCode = hashCode * 59 + this.Locale.GetHashCode();
				hashCode = hashCode * 59 + this.AvatarImageIndex.GetHashCode();
				hashCode = hashCode * 59 + this.Homepage.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipOption.GetHashCode();
				hashCode = hashCode * 59 + this.DefaultPublicity.GetHashCode();
				hashCode = hashCode * 59 + this.Theme.GetHashCode();
				hashCode = hashCode * 59 + this.BannerPath.GetHashCode();
				hashCode = hashCode * 59 + this.AvatarPath.GetHashCode();
				hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
				hashCode = hashCode * 59 + this.EnableInvitationMessagingForAdmins.GetHashCode();
				hashCode = hashCode * 59 + this.BanExpireDate.GetHashCode();
				hashCode = hashCode * 59 + this.Features.GetHashCode();
				hashCode = hashCode * 59 + this.ClanInfo.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

