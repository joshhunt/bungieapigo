using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum GroupType
	{
		/// <summary>
		/// General = 0
		/// </summary>
		[EnumMember(Value = "0")]
		General = 0,

		/// <summary>
		/// Clan = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Clan = 1,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}