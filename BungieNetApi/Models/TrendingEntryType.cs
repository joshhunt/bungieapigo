using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// The known entity types that you can have returned from Trending.
	/// </summary>
	
	public enum TrendingEntryType
	{
		/// <summary>
		/// News = 0
		/// </summary>
		[EnumMember(Value = "0")]
		News = 0,

		/// <summary>
		/// DestinyItem = 1
		/// </summary>
		[EnumMember(Value = "1")]
		DestinyItem = 1,

		/// <summary>
		/// DestinyActivity = 2
		/// </summary>
		[EnumMember(Value = "2")]
		DestinyActivity = 2,

		/// <summary>
		/// DestinyRitual = 3
		/// </summary>
		[EnumMember(Value = "3")]
		DestinyRitual = 3,

		/// <summary>
		/// SupportArticle = 4
		/// </summary>
		[EnumMember(Value = "4")]
		SupportArticle = 4,

		/// <summary>
		/// Creation = 5
		/// </summary>
		[EnumMember(Value = "5")]
		Creation = 5,

		/// <summary>
		/// Stream = 6
		/// </summary>
		[EnumMember(Value = "6")]
		Stream = 6,

		/// <summary>
		/// Update = 7
		/// </summary>
		[EnumMember(Value = "7")]
		Update = 7,

		/// <summary>
		/// Link = 8
		/// </summary>
		[EnumMember(Value = "8")]
		Link = 8,

		/// <summary>
		/// ForumTag = 9
		/// </summary>
		[EnumMember(Value = "9")]
		ForumTag = 9,

		/// <summary>
		/// Container = 10
		/// </summary>
		[EnumMember(Value = "10")]
		Container = 10,

		/// <summary>
		/// Release = 11
		/// </summary>
		[EnumMember(Value = "11")]
		Release = 11,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}