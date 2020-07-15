using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum ApplicationStatus
	{
		/// <summary>
		/// None = 0
		/// No value assigned
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Private = 1
		/// Application exists and works but will not appear in any public catalog. New applications start in this state, test applications will remain in this state.
		/// </summary>
		[EnumMember(Value = "1")]
		Private = 1,

		/// <summary>
		/// Public = 2
		/// Active applications that can appear in an catalog.
		/// </summary>
		[EnumMember(Value = "2")]
		Public = 2,

		/// <summary>
		/// Disabled = 3
		/// Application disabled by the owner. All authorizations will be treated as terminated while in this state. Owner can move back to private or public state.
		/// </summary>
		[EnumMember(Value = "3")]
		Disabled = 3,

		/// <summary>
		/// Blocked = 4
		/// Application has been blocked by Bungie. It cannot be transitioned out of this state by the owner. Authorizations are terminated when an application is in this state.
		/// </summary>
		[EnumMember(Value = "4")]
		Blocked = 4,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}