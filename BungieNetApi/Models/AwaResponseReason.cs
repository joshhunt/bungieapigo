using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum AwaResponseReason
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Answered = 1
		/// User provided an answer
		/// </summary>
		[EnumMember(Value = "1")]
		Answered = 1,

		/// <summary>
		/// TimedOut = 2
		/// The HTTP request timed out, a new request may be made and an answer may still be provided.
		/// </summary>
		[EnumMember(Value = "2")]
		TimedOut = 2,

		/// <summary>
		/// Replaced = 3
		/// This request was replaced by another request.
		/// </summary>
		[EnumMember(Value = "3")]
		Replaced = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}