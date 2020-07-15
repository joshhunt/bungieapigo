using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class GroupEditAction{

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="about", EmitDefaultValue=false)]
		public string About { get; set; }

		[DataMember(Name="motto", EmitDefaultValue=false)]
		public string Motto { get; set; }

		[DataMember(Name="theme", EmitDefaultValue=false)]
		public string Theme { get; set; }

		[DataMember(Name="avatarImageIndex", EmitDefaultValue=false)]
		public long AvatarImageIndex { get; set; }

		[DataMember(Name="tags", EmitDefaultValue=false)]
		public string Tags { get; set; }

		[DataMember(Name="isPublic", EmitDefaultValue=false)]
		public bool IsPublic { get; set; }

		[DataMember(Name="membershipOption", EmitDefaultValue=false)]
		public long MembershipOption { get; set; }

		[DataMember(Name="isPublicTopicAdminOnly", EmitDefaultValue=false)]
		public bool IsPublicTopicAdminOnly { get; set; }

		[DataMember(Name="allowChat", EmitDefaultValue=false)]
		public bool AllowChat { get; set; }

		[DataMember(Name="chatSecurity", EmitDefaultValue=false)]
		public long ChatSecurity { get; set; }

		[DataMember(Name="callsign", EmitDefaultValue=false)]
		public string Callsign { get; set; }

		[DataMember(Name="locale", EmitDefaultValue=false)]
		public string Locale { get; set; }

		[DataMember(Name="homepage", EmitDefaultValue=false)]
		public long Homepage { get; set; }

		[DataMember(Name="enableInvitationMessagingForAdmins", EmitDefaultValue=false)]
		public bool EnableInvitationMessagingForAdmins { get; set; }

		[DataMember(Name="defaultPublicity", EmitDefaultValue=false)]
		public long DefaultPublicity { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupEditAction);
        }

		public bool Equals(GroupEditAction input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    About == input.About ||
                    (About != null && About.Equals(input.About))
                ) &&
				(
                    Motto == input.Motto ||
                    (Motto != null && Motto.Equals(input.Motto))
                ) &&
				(
                    Theme == input.Theme ||
                    (Theme != null && Theme.Equals(input.Theme))
                ) &&
				(
                    AvatarImageIndex == input.AvatarImageIndex ||
                    (AvatarImageIndex != null && AvatarImageIndex.Equals(input.AvatarImageIndex))
                ) &&
				(
                    Tags == input.Tags ||
                    (Tags != null && Tags.Equals(input.Tags))
                ) &&
				(
                    IsPublic == input.IsPublic ||
                    (IsPublic != null && IsPublic.Equals(input.IsPublic))
                ) &&
				(
                    MembershipOption == input.MembershipOption ||
                    (MembershipOption != null && MembershipOption.Equals(input.MembershipOption))
                ) &&
				(
                    IsPublicTopicAdminOnly == input.IsPublicTopicAdminOnly ||
                    (IsPublicTopicAdminOnly != null && IsPublicTopicAdminOnly.Equals(input.IsPublicTopicAdminOnly))
                ) &&
				(
                    AllowChat == input.AllowChat ||
                    (AllowChat != null && AllowChat.Equals(input.AllowChat))
                ) &&
				(
                    ChatSecurity == input.ChatSecurity ||
                    (ChatSecurity != null && ChatSecurity.Equals(input.ChatSecurity))
                ) &&
				(
                    Callsign == input.Callsign ||
                    (Callsign != null && Callsign.Equals(input.Callsign))
                ) &&
				(
                    Locale == input.Locale ||
                    (Locale != null && Locale.Equals(input.Locale))
                ) &&
				(
                    Homepage == input.Homepage ||
                    (Homepage != null && Homepage.Equals(input.Homepage))
                ) &&
				(
                    EnableInvitationMessagingForAdmins == input.EnableInvitationMessagingForAdmins ||
                    (EnableInvitationMessagingForAdmins != null && EnableInvitationMessagingForAdmins.Equals(input.EnableInvitationMessagingForAdmins))
                ) &&
				(
                    DefaultPublicity == input.DefaultPublicity ||
                    (DefaultPublicity != null && DefaultPublicity.Equals(input.DefaultPublicity))
                ) ;
		}
	}
}

