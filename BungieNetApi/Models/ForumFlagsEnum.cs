using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	[Flags]
	public enum ForumFlagsEnum
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// BungieStaffPost = 1
		/// </summary>
		[EnumMember(Value = "1")]
		BungieStaffPost = 1,

		/// <summary>
		/// ForumNinjaPost = 2
		/// </summary>
		[EnumMember(Value = "2")]
		ForumNinjaPost = 2,

		/// <summary>
		/// ForumMentorPost = 4
		/// </summary>
		[EnumMember(Value = "4")]
		ForumMentorPost = 4,

		/// <summary>
		/// TopicBungieStaffPosted = 8
		/// </summary>
		[EnumMember(Value = "8")]
		TopicBungieStaffPosted = 8,

		/// <summary>
		/// TopicBungieVolunteerPosted = 16
		/// </summary>
		[EnumMember(Value = "16")]
		TopicBungieVolunteerPosted = 16,

		/// <summary>
		/// QuestionAnsweredByBungie = 32
		/// </summary>
		[EnumMember(Value = "32")]
		QuestionAnsweredByBungie = 32,

		/// <summary>
		/// QuestionAnsweredByNinja = 64
		/// </summary>
		[EnumMember(Value = "64")]
		QuestionAnsweredByNinja = 64,

		/// <summary>
		/// CommunityContent = 128
		/// </summary>
		[EnumMember(Value = "128")]
		CommunityContent = 128,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}