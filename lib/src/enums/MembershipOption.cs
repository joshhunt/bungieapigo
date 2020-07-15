using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum MembershipOption
	{
		/// <summary>
		/// Reviewed = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Reviewed = 0,

		/// <summary>
		/// Open = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Open = 1,

		/// <summary>
		/// Closed = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Closed = 2,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}