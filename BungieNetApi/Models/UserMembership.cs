using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Very basic info about a user as returned by the Account server.
	/// </summary>
	[DataContract]
	public class UserMembership{

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
            return this.Equals(input as UserMembership);
        }

		public bool Equals(UserMembership input)
		{
			if (input == null) return false;

			return
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

