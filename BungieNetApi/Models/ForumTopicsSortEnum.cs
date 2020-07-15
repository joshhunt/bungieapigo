using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum ForumTopicsSortEnum
	{
		/// <summary>
		/// Default = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Default = 0,

		/// <summary>
		/// LastReplied = 1
		/// </summary>
		[EnumMember(Value = "1")]
		LastReplied = 1,

		/// <summary>
		/// MostReplied = 2
		/// </summary>
		[EnumMember(Value = "2")]
		MostReplied = 2,

		/// <summary>
		/// Popularity = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Popularity = 3,

		/// <summary>
		/// Controversiality = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Controversiality = 4,

		/// <summary>
		/// Liked = 5
		/// </summary>
		[EnumMember(Value = "5")]
		Liked = 5,

		/// <summary>
		/// HighestRated = 6
		/// </summary>
		[EnumMember(Value = "6")]
		HighestRated = 6,

		/// <summary>
		/// MostUpvoted = 7
		/// </summary>
		[EnumMember(Value = "7")]
		MostUpvoted = 7,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}