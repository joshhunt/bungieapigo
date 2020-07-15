using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class GroupUserInfoCard
    {
        /// <summary>
        /// This will be the display name the clan server last saw the user as. If the account is an active cross save override, this will be the display name to use. Otherwise, this will match the displayName property.
        /// </summary>
        [DataMember(Name = "LastSeenDisplayName", EmitDefaultValue = false)]
        public string LastSeenDisplayName { get; set; }

        /// <summary>
        /// The platform of the LastSeenDisplayName
        /// </summary>
        [DataMember(Name = "LastSeenDisplayNameType", EmitDefaultValue = false)]
        public BungieMembershipType LastSeenDisplayNameType { get; set; }

        /// <summary>
        /// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
        /// </summary>
        [DataMember(Name = "supplementalDisplayName", EmitDefaultValue = false)]
        public string SupplementalDisplayName { get; set; }

        /// <summary>
        /// URL the Icon if available.
        /// </summary>
        [DataMember(Name = "iconPath", EmitDefaultValue = false)]
        public string IconPath { get; set; }

        /// <summary>
        /// If there is a cross save override in effect, this value will tell you the type that is overridding this one.
        /// </summary>
        [DataMember(Name = "crossSaveOverride", EmitDefaultValue = false)]
        public BungieMembershipType CrossSaveOverride { get; set; }

        /// <summary>
        /// The list of Membership Types indicating the platforms on which this Membership can be used.
        /// </summary>
        /// <summary>
        ///  Not in Cross Save = its original membership type. Cross Save Primary = Any membership types it is overridding, and its original membership type Cross Save Overridden = Empty list
        /// </summary>
        [DataMember(Name = "applicableMembershipTypes", EmitDefaultValue = false)]
        public List<BungieMembershipType> ApplicableMembershipTypes { get; set; }

        /// <summary>
        /// If True, this is a public user membership.
        /// </summary>
        [DataMember(Name = "isPublic", EmitDefaultValue = false)]
        public bool IsPublic { get; set; }

        /// <summary>
        /// Type of the membership. Not necessarily the native type.
        /// </summary>
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public BungieMembershipType MembershipType { get; set; }

        /// <summary>
        /// Membership ID as they user is known in the Accounts service
        /// </summary>
        [DataMember(Name = "membershipId", EmitDefaultValue = false)]
        public long MembershipId { get; set; }

        /// <summary>
        /// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
        /// </summary>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupUserInfoCard);
        }

        public bool Equals(GroupUserInfoCard input)
        {
            if (input == null) return false;

            return
                (
                    LastSeenDisplayName == input.LastSeenDisplayName ||
                    (LastSeenDisplayName != null && LastSeenDisplayName.Equals(input.LastSeenDisplayName))
                ) &&
                (
                    LastSeenDisplayNameType == input.LastSeenDisplayNameType ||
                    (LastSeenDisplayNameType != null && LastSeenDisplayNameType.Equals(input.LastSeenDisplayNameType))
                ) &&
                (
                    SupplementalDisplayName == input.SupplementalDisplayName ||
                    (SupplementalDisplayName != null && SupplementalDisplayName.Equals(input.SupplementalDisplayName))
                ) &&
                (
                    IconPath == input.IconPath ||
                    (IconPath != null && IconPath.Equals(input.IconPath))
                ) &&
                (
                    CrossSaveOverride == input.CrossSaveOverride ||
                    (CrossSaveOverride != null && CrossSaveOverride.Equals(input.CrossSaveOverride))
                ) &&
                (
                    ApplicableMembershipTypes == input.ApplicableMembershipTypes ||
                    (ApplicableMembershipTypes != null && ApplicableMembershipTypes.Equals(input.ApplicableMembershipTypes))
                ) &&
                (
                    IsPublic == input.IsPublic ||
                    (IsPublic != null && IsPublic.Equals(input.IsPublic))
                ) &&
                (
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) &&
                (
                    MembershipId == input.MembershipId ||
                    (MembershipId != null && MembershipId.Equals(input.MembershipId))
                ) &&
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null && DisplayName.Equals(input.DisplayName))
                ) ;
        }
    }
}

