using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class AwaAuthorizationResult{

		/// <summary>
		/// Indication of how the user responded to the request. If the value is "Approved" the actionToken will contain the token that can be presented when performing the advanced write action.
		/// </summary>
		[DataMember(Name="userSelection", EmitDefaultValue=false)]
		public AwaUserSelection UserSelection { get; set; }

		[DataMember(Name="responseReason", EmitDefaultValue=false)]
		public AwaResponseReason ResponseReason { get; set; }

		/// <summary>
		/// Message to the app developer to help understand the response.
		/// </summary>
		[DataMember(Name="developerNote", EmitDefaultValue=false)]
		public string DeveloperNote { get; set; }

		/// <summary>
		/// Credential used to prove the user authorized an advanced write action.
		/// </summary>
		[DataMember(Name="actionToken", EmitDefaultValue=false)]
		public string ActionToken { get; set; }

		/// <summary>
		/// This token may be used to perform the requested action this number of times, at a maximum. If this value is 0, then there is no limit.
		/// </summary>
		[DataMember(Name="maximumNumberOfUses", EmitDefaultValue=false)]
		public long MaximumNumberOfUses { get; set; }

		/// <summary>
		/// Time, UTC, when token expires.
		/// </summary>
		[DataMember(Name="validUntil", EmitDefaultValue=false)]
		public string ValidUntil { get; set; }

		/// <summary>
		/// Advanced Write Action Type from the permission request.
		/// </summary>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public AwaType Type { get; set; }

		/// <summary>
		/// MembershipType from the permission request.
		/// </summary>
		[DataMember(Name="membershipType", EmitDefaultValue=false)]
		public BungieMembershipType MembershipType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as AwaAuthorizationResult);
        }

		public bool Equals(AwaAuthorizationResult input)
		{
			if (input == null) return false;

			return
				(
                    UserSelection == input.UserSelection ||
                    (UserSelection != null && UserSelection.Equals(input.UserSelection))
                ) &&
				(
                    ResponseReason == input.ResponseReason ||
                    (ResponseReason != null && ResponseReason.Equals(input.ResponseReason))
                ) &&
				(
                    DeveloperNote == input.DeveloperNote ||
                    (DeveloperNote != null && DeveloperNote.Equals(input.DeveloperNote))
                ) &&
				(
                    ActionToken == input.ActionToken ||
                    (ActionToken != null && ActionToken.Equals(input.ActionToken))
                ) &&
				(
                    MaximumNumberOfUses == input.MaximumNumberOfUses ||
                    (MaximumNumberOfUses != null && MaximumNumberOfUses.Equals(input.MaximumNumberOfUses))
                ) &&
				(
                    ValidUntil == input.ValidUntil ||
                    (ValidUntil != null && ValidUntil.Equals(input.ValidUntil))
                ) &&
				(
                    Type == input.Type ||
                    (Type != null && Type.Equals(input.Type))
                ) &&
				(
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) ;
		}
	}
}

