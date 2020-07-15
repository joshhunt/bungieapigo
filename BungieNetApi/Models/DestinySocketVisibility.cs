using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum DestinySocketVisibility
	{
		/// <summary>
		/// Visible = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Visible = 0,

		/// <summary>
		/// Hidden = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Hidden = 1,

		/// <summary>
		/// HiddenWhenEmpty = 2
		/// </summary>
		[EnumMember(Value = "2")]
		HiddenWhenEmpty = 2,

		/// <summary>
		/// HiddenIfNoPlugsAvailable = 3
		/// </summary>
		[EnumMember(Value = "3")]
		HiddenIfNoPlugsAvailable = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}