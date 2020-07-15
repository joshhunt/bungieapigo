using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum ForumPostSortEnum
	{
		/// <summary>
		/// Default = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Default = 0,

		/// <summary>
		/// OldestFirst = 1
		/// </summary>
		[EnumMember(Value = "1")]
		OldestFirst = 1,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}