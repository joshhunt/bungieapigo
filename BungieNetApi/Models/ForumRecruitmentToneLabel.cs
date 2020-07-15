using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum ForumRecruitmentToneLabel
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// FamilyFriendly = 1
		/// </summary>
		[EnumMember(Value = "1")]
		FamilyFriendly = 1,

		/// <summary>
		/// Rowdy = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Rowdy = 2,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}