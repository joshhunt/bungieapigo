using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	[Flags]
	public enum ForumTopicsCategoryFiltersEnum
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Links = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Links = 1,

		/// <summary>
		/// Questions = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Questions = 2,

		/// <summary>
		/// AnsweredQuestions = 4
		/// </summary>
		[EnumMember(Value = "4")]
		AnsweredQuestions = 4,

		/// <summary>
		/// Media = 8
		/// </summary>
		[EnumMember(Value = "8")]
		Media = 8,

		/// <summary>
		/// TextOnly = 16
		/// </summary>
		[EnumMember(Value = "16")]
		TextOnly = 16,

		/// <summary>
		/// Announcement = 32
		/// </summary>
		[EnumMember(Value = "32")]
		Announcement = 32,

		/// <summary>
		/// BungieOfficial = 64
		/// </summary>
		[EnumMember(Value = "64")]
		BungieOfficial = 64,

		/// <summary>
		/// Polls = 128
		/// </summary>
		[EnumMember(Value = "128")]
		Polls = 128,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}