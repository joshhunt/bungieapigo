using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// If a Destiny Profile can't be returned, but we're pretty certain it's a valid Destiny account, this will contain as much info as we can get about the profile for your use.
	/// </summary>
	/// <summary>
	/// Assume that the most you'll get is the Error Code, the Membership Type and the Membership ID.
	/// </summary>
	[DataContract]
	public class DestinyErrorProfile{

		/// <summary>
		/// The error that we encountered. You should be able to look up localized text to show to the user for these failures.
		/// </summary>
		[DataMember(Name="errorCode", EmitDefaultValue=false)]
		public PlatformErrorCodes ErrorCode { get; set; }

		/// <summary>
		/// Basic info about the account that failed. Don't expect anything other than membership ID, Membership Type, and displayName to be populated.
		/// </summary>
		[DataMember(Name="infoCard", EmitDefaultValue=false)]
		public UserInfoCard InfoCard { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyErrorProfile);
        }

		public bool Equals(DestinyErrorProfile input)
		{
			if (input == null) return false;

			return
				(
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null && ErrorCode.Equals(input.ErrorCode))
                ) &&
				(
                    InfoCard == input.InfoCard ||
                    (InfoCard != null && InfoCard.Equals(input.InfoCard))
                ) ;
		}
	}
}

