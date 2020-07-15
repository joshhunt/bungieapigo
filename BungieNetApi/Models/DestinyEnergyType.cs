using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Represents an Energy Type for systems that require payment of energy of certain types, such as with Armor 2.0.
	/// </summary>
	
	public enum DestinyEnergyType
	{
		/// <summary>
		/// Any = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Any = 0,

		/// <summary>
		/// Arc = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Arc = 1,

		/// <summary>
		/// Thermal = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Thermal = 2,

		/// <summary>
		/// Void = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Void = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}