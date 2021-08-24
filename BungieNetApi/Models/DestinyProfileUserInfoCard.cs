using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyProfileUserInfoCard
    {
        [DataMember(Name = "dateLastPlayed", EmitDefaultValue = false)]
        public DateTime DateLastPlayed { get; set; }

        /// <summary>
        /// If this profile is being overridden/obscured by Cross Save, this will be set to true. We will still return the profile for display purposes where users need to know the info: it is up to any given area of the app/site to determine if this profile should still be shown.
        /// </summary>
        [DataMember(Name = "isOverridden", EmitDefaultValue = false)]
        public bool IsOverridden { get; set; }

        /// <summary>
        /// If true, this account is hooked up as the "Primary" cross save account for one or more platforms.
        /// </summary>
        [DataMember(Name = "isCrossSavePrimary", EmitDefaultValue = false)]
        public bool IsCrossSavePrimary { get; set; }

        /// <summary>
        /// This is the silver available on this Profile across any platforms on which they have purchased silver.
        /// </summary>
        /// <summary>
        ///  This is only available if you are requesting yourself.
        /// </summary>
        [DataMember(Name = "platformSilver", EmitDefaultValue = false)]
        public DestinyPlatformSilverComponent PlatformSilver { get; set; }

        /// <summary>
        /// If this profile is not in a cross save pairing, this will return the game versions that we believe this profile has access to.
        /// </summary>
        /// <summary>
        ///  For the time being, we will not return this information for any membership that is in a cross save pairing. The gist is that, once the pairing occurs, we do not currently have a consistent way to get that information for the profile's original Platform, and thus gameVersions would be too inconsistent (based on the last platform they happened to play on) for the info to be useful.
        /// </summary>
        /// <summary>
        ///  If we ever can get this data, this field will be deprecated and replaced with data on the DestinyLinkedProfileResponse itself, with game versions per linked Platform. But since we can't get that, we have this as a stop-gap measure for getting the data in the only situation that we currently need it.
        /// </summary>
        [DataMember(Name = "unpairedGameVersions", EmitDefaultValue = false)]
        public long UnpairedGameVersions { get; set; }

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
            return this.Equals(input as DestinyProfileUserInfoCard);
        }

        public bool Equals(DestinyProfileUserInfoCard input)
        {
            if (input == null) return false;

            return
                (
                    DateLastPlayed == input.DateLastPlayed ||
                    (DateLastPlayed != null && DateLastPlayed.Equals(input.DateLastPlayed))
                ) &&
                (
                    IsOverridden == input.IsOverridden ||
                    (IsOverridden != null && IsOverridden.Equals(input.IsOverridden))
                ) &&
                (
                    IsCrossSavePrimary == input.IsCrossSavePrimary ||
                    (IsCrossSavePrimary != null && IsCrossSavePrimary.Equals(input.IsCrossSavePrimary))
                ) &&
                (
                    PlatformSilver == input.PlatformSilver ||
                    (PlatformSilver != null && PlatformSilver.Equals(input.PlatformSilver))
                ) &&
                (
                    UnpairedGameVersions == input.UnpairedGameVersions ||
                    (UnpairedGameVersions.Equals(input.UnpairedGameVersions))
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

