using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Very basic info about a user as returned by the Account server, but including CrossSave information. Do NOT use as a request contract.
	/// </summary>
	[DataContract]
	public class CrossSaveUserMembership{

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
            return this.Equals(input as CrossSaveUserMembership);
        }

		public bool Equals(CrossSaveUserMembership input)
		{
			if (input == null) return false;

			return
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

