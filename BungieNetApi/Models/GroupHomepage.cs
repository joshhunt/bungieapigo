using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum GroupHomepage
	{
		/// <summary>
		/// Wall = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Wall = 0,

		/// <summary>
		/// Forum = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Forum = 1,

		/// <summary>
		/// AllianceForum = 2
		/// </summary>
		[EnumMember(Value = "2")]
		AllianceForum = 2,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}