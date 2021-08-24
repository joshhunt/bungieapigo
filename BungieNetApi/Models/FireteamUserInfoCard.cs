using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class FireteamUserInfoCard
    {
        [DataMember(Name = "FireteamDisplayName", EmitDefaultValue = false)]
        public string FireteamDisplayName { get; set; }

        [DataMember(Name = "FireteamMembershipType", EmitDefaultValue = false)]
        public BungieMembershipType FireteamMembershipType { get; set; }

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

        /// <summary>
        /// The bungie global display name, if set.
        /// </summary>
        [DataMember(Name = "bungieGlobalDisplayName", EmitDefaultValue = false)]
        public string BungieGlobalDisplayName { get; set; }

        /// <summary>
        /// The bungie global display name code, if set.
        /// </summary>
        [DataMember(Name = "bungieGlobalDisplayNameCode", EmitDefaultValue = false)]
        public long BungieGlobalDisplayNameCode { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as FireteamUserInfoCard);
        }

        public bool Equals(FireteamUserInfoCard input)
        {
            if (input == null) return false;

            return
                (
                    FireteamDisplayName == input.FireteamDisplayName ||
                    (FireteamDisplayName != null && FireteamDisplayName.Equals(input.FireteamDisplayName))
                ) &&
                (
                    FireteamMembershipType == input.FireteamMembershipType ||
                    (FireteamMembershipType != null && FireteamMembershipType.Equals(input.FireteamMembershipType))
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
                    (ApplicableMembershipTypes != null && ApplicableMembershipTypes.SequenceEqual(input.ApplicableMembershipTypes))
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
                    (MembershipId.Equals(input.MembershipId))
                ) &&
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null && DisplayName.Equals(input.DisplayName))
                ) &&
                (
                    BungieGlobalDisplayName == input.BungieGlobalDisplayName ||
                    (BungieGlobalDisplayName != null && BungieGlobalDisplayName.Equals(input.BungieGlobalDisplayName))
                ) &&
                (
                    BungieGlobalDisplayNameCode == input.BungieGlobalDisplayNameCode ||
                    (BungieGlobalDisplayNameCode.Equals(input.BungieGlobalDisplayNameCode))
                ) ;
        }
    }
}

