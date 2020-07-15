using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// I know what you seek. You seek linked accounts. Found them, you have.
	/// </summary>
	/// <summary>
	/// This contract returns a minimal amount of data about Destiny Accounts that are linked through your Bungie.Net account. We will not return accounts in this response whose
	/// </summary>
	[DataContract]
	public class DestinyLinkedProfilesResponse{

		/// <summary>
		/// Any Destiny account for whom we could successfully pull characters will be returned here, as the Platform-level summary of user data. (no character data, no Destiny account data other than the Membership ID and Type so you can make further queries)
		/// </summary>
		[DataMember(Name="profiles", EmitDefaultValue=false)]
		public List<DestinyProfileUserInfoCard> Profiles { get; set; }

		/// <summary>
		/// If the requested membership had a linked Bungie.Net membership ID, this is the basic information about that BNet account.
		/// </summary>
		/// <summary>
		/// I know, Tetron; I know this is mixing UserServices concerns with DestinyServices concerns. But it's so damn convenient! https://www.youtube.com/watch?v=X5R-bB-gKVI
		/// </summary>
		[DataMember(Name="bnetMembership", EmitDefaultValue=false)]
		public UserInfoCard BnetMembership { get; set; }

		/// <summary>
		/// This is brief summary info for profiles that we believe have valid Destiny info, but who failed to return data for some other reason and thus we know that subsequent calls for their info will also fail.
		/// </summary>
		[DataMember(Name="profilesWithErrors", EmitDefaultValue=false)]
		public List<DestinyErrorProfile> ProfilesWithErrors { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyLinkedProfilesResponse);
        }

		public bool Equals(DestinyLinkedProfilesResponse input)
		{
			if (input == null) return false;

			return
				(
                    Profiles == input.Profiles ||
                    (Profiles != null && Profiles.Equals(input.Profiles))
                ) &&
				(
                    BnetMembership == input.BnetMembership ||
                    (BnetMembership != null && BnetMembership.Equals(input.BnetMembership))
                ) &&
				(
                    ProfilesWithErrors == input.ProfilesWithErrors ||
                    (ProfilesWithErrors != null && ProfilesWithErrors.Equals(input.ProfilesWithErrors))
                ) ;
		}
	}
}

