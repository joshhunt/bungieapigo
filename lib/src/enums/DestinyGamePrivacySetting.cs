using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// A player can choose to restrict requests to join their Fireteam to specific states. These are the possible states a user can choose.
	/// </summary>
	
	public enum DestinyGamePrivacySetting
	{
		/// <summary>
		/// Open = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Open = 0,

		/// <summary>
		/// ClanAndFriendsOnly = 1
		/// </summary>
		[EnumMember(Value = "1")]
		ClanAndFriendsOnly = 1,

		/// <summary>
		/// FriendsOnly = 2
		/// </summary>
		[EnumMember(Value = "2")]
		FriendsOnly = 2,

		/// <summary>
		/// InvitationOnly = 3
		/// </summary>
		[EnumMember(Value = "3")]
		InvitationOnly = 3,

		/// <summary>
		/// Closed = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Closed = 4,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}