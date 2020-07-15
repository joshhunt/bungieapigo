using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// At last, stats have categories. Use this for whatever purpose you might wish.
	/// </summary>
	
	public enum DestinyStatCategory
	{
		/// <summary>
		/// Gameplay = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Gameplay = 0,

		/// <summary>
		/// Weapon = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Weapon = 1,

		/// <summary>
		/// Defense = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Defense = 2,

		/// <summary>
		/// Primary = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Primary = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}