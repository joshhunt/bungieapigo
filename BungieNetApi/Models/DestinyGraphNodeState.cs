using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Represents a potential state of an Activity Graph node.
	/// </summary>
	
	public enum DestinyGraphNodeState
	{
		/// <summary>
		/// Hidden = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Hidden = 0,

		/// <summary>
		/// Visible = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Visible = 1,

		/// <summary>
		/// Teaser = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Teaser = 2,

		/// <summary>
		/// Incomplete = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Incomplete = 3,

		/// <summary>
		/// Completed = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Completed = 4,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}