using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum FireteamPlatformInviteResult
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Success = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Success = 1,

		/// <summary>
		/// AlreadyInFireteam = 2
		/// </summary>
		[EnumMember(Value = "2")]
		AlreadyInFireteam = 2,

		/// <summary>
		/// Throttled = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Throttled = 3,

		/// <summary>
		/// ServiceError = 4
		/// </summary>
		[EnumMember(Value = "4")]
		ServiceError = 4,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}