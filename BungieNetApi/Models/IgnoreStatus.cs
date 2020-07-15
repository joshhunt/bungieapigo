using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Model
{
	[Flags]
	public enum IgnoreStatus
	{
		/// <summary>
		/// NotIgnored = 0
		/// </summary>
		[EnumMember(Value = "0")]
		NotIgnored = 0,

		/// <summary>
		/// IgnoredUser = 1
		/// </summary>
		[EnumMember(Value = "1")]
		IgnoredUser = 1,

		/// <summary>
		/// IgnoredGroup = 2
		/// </summary>
		[EnumMember(Value = "2")]
		IgnoredGroup = 2,

		/// <summary>
		/// IgnoredByGroup = 4
		/// </summary>
		[EnumMember(Value = "4")]
		IgnoredByGroup = 4,

		/// <summary>
		/// IgnoredPost = 8
		/// </summary>
		[EnumMember(Value = "8")]
		IgnoredPost = 8,

		/// <summary>
		/// IgnoredTag = 16
		/// </summary>
		[EnumMember(Value = "16")]
		IgnoredTag = 16,

		/// <summary>
		/// IgnoredGlobal = 32
		/// </summary>
		[EnumMember(Value = "32")]
		IgnoredGlobal = 32,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}