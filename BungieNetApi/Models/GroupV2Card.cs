using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// A small infocard of group information, usually used for when a list of groups are returned
    /// </summary>
    [DataContract]
    public class GroupV2Card
    {
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public long GroupId { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "groupType", EmitDefaultValue = false)]
        public GroupType GroupType { get; set; }

        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public string CreationDate { get; set; }

        [DataMember(Name = "about", EmitDefaultValue = false)]
        public string About { get; set; }

        [DataMember(Name = "motto", EmitDefaultValue = false)]
        public string Motto { get; set; }

        [DataMember(Name = "memberCount", EmitDefaultValue = false)]
        public long MemberCount { get; set; }

        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        [DataMember(Name = "membershipOption", EmitDefaultValue = false)]
        public MembershipOption MembershipOption { get; set; }

        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public Capabilities Capabilities { get; set; }

        /// <summary>
        /// This contract contains clan-specific group information. It does not include any investment data.
        /// </summary>
        [DataMember(Name = "clanInfo", EmitDefaultValue = false)]
        public GroupV2ClanInfo ClanInfo { get; set; }

        [DataMember(Name = "avatarPath", EmitDefaultValue = false)]
        public string AvatarPath { get; set; }

        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public string Theme { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupV2Card);
        }

        public bool Equals(GroupV2Card input)
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
                    CreationDate == input.CreationDate ||
                    (CreationDate != null && CreationDate.Equals(input.CreationDate))
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
                    MemberCount == input.MemberCount ||
                    (MemberCount != null && MemberCount.Equals(input.MemberCount))
                ) &&
                (
                    Locale == input.Locale ||
                    (Locale != null && Locale.Equals(input.Locale))
                ) &&
                (
                    MembershipOption == input.MembershipOption ||
                    (MembershipOption != null && MembershipOption.Equals(input.MembershipOption))
                ) &&
                (
                    Capabilities == input.Capabilities ||
                    (Capabilities != null && Capabilities.Equals(input.Capabilities))
                ) &&
                (
                    ClanInfo == input.ClanInfo ||
                    (ClanInfo != null && ClanInfo.Equals(input.ClanInfo))
                ) &&
                (
                    AvatarPath == input.AvatarPath ||
                    (AvatarPath != null && AvatarPath.Equals(input.AvatarPath))
                ) &&
                (
                    Theme == input.Theme ||
                    (Theme != null && Theme.Equals(input.Theme))
                ) ;
        }
    }
}

