using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class FireteamUserInfoCard{

		[DataMember(Name="FireteamDisplayName", EmitDefaultValue=false)]
		public string FireteamDisplayName { get; set; }

		[DataMember(Name="FireteamMembershipType", EmitDefaultValue=false)]
		public BungieMembershipType FireteamMembershipType { get; set; }

		[DataMember(Name="FireteamPlatformProfileUrl", EmitDefaultValue=false)]
		public string FireteamPlatformProfileUrl { get; set; }

		[DataMember(Name="FireteamPlatformUniqueIdentifier", EmitDefaultValue=false)]
		public string FireteamPlatformUniqueIdentifier { get; set; }

		/// <summary>
		/// A platform specific additional display name - ex: psn Real Name, bnet Unique Name, etc.
		/// </summary>
		[DataMember(Name="supplementalDisplayName", EmitDefaultValue=false)]
		public string SupplementalDisplayName { get; set; }

		/// <summary>
		/// URL the Icon if available.
		/// </summary>
		[DataMember(Name="iconPath", EmitDefaultValue=false)]
		public string IconPath { get; set; }

		/// <summary>
		/// If there is a cross save override in effect, this value will tell you the type that is overridding this one.
		/// </summary>
		[DataMember(Name="crossSaveOverride", EmitDefaultValue=false)]
		public BungieMembershipType CrossSaveOverride { get; set; }

		/// <summary>
		/// The list of Membership Types indicating the platforms on which this Membership can be used.
		/// </summary>
		/// <summary>
		///  Not in Cross Save = its original membership type. Cross Save Primary = Any membership types it is overridding, and its original membership type Cross Save Overridden = Empty list
		/// </summary>
		[DataMember(Name="applicableMembershipTypes", EmitDefaultValue=false)]
		public List<BungieMembershipType> ApplicableMembershipTypes { get; set; }

		/// <summary>
		/// If True, this is a public user membership.
		/// </summary>
		[DataMember(Name="isPublic", EmitDefaultValue=false)]
		public bool IsPublic { get; set; }

		/// <summary>
		/// Type of the membership. Not necessarily the native type.
		/// </summary>
		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }

		/// <summary>
		/// Membership ID as they user is known in the Accounts service
		/// </summary>
		[DataMember(Name="membershipId", EmitDefaultValue=false)]
		public long MembershipId { get; set; }

		/// <summary>
		/// Display Name the player has chosen for themselves. The display name is optional when the data type is used as input to a platform API.
		/// </summary>
		[DataMember(Name="displayName", EmitDefaultValue=false)]
		public string DisplayName { get; set; }


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
                    FireteamPlatformProfileUrl == input.FireteamPlatformProfileUrl ||
                    (FireteamPlatformProfileUrl != null && FireteamPlatformProfileUrl.Equals(input.FireteamPlatformProfileUrl))
                ) &&
				(
                    FireteamPlatformUniqueIdentifier == input.FireteamPlatformUniqueIdentifier ||
                    (FireteamPlatformUniqueIdentifier != null && FireteamPlatformUniqueIdentifier.Equals(input.FireteamPlatformUniqueIdentifier))
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.FireteamDisplayName.GetHashCode();
				hashCode = hashCode * 59 + this.FireteamMembershipType.GetHashCode();
				hashCode = hashCode * 59 + this.FireteamPlatformProfileUrl.GetHashCode();
				hashCode = hashCode * 59 + this.FireteamPlatformUniqueIdentifier.GetHashCode();
				hashCode = hashCode * 59 + this.SupplementalDisplayName.GetHashCode();
				hashCode = hashCode * 59 + this.IconPath.GetHashCode();
				hashCode = hashCode * 59 + this.CrossSaveOverride.GetHashCode();
				hashCode = hashCode * 59 + this.ApplicableMembershipTypes.GetHashCode();
				hashCode = hashCode * 59 + this.IsPublic.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
				hashCode = hashCode * 59 + this.MembershipId.GetHashCode();
				hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

