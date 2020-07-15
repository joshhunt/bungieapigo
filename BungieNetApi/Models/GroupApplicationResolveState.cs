using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum GroupApplicationResolveState
	{
		/// <summary>
		/// Unresolved = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Unresolved = 0,

		/// <summary>
		/// Accepted = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Accepted = 1,

		/// <summary>
		/// Denied = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Denied = 2,

		/// <summary>
		/// Rescinded = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Rescinded = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}