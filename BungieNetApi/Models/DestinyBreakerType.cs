using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// A plug can optionally have a "Breaker Type": a special ability that can affect units in unique ways. Activating this plug can grant one of these types.
	/// </summary>
	
	public enum DestinyBreakerType
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// ShieldPiercing = 1
		/// </summary>
		[EnumMember(Value = "1")]
		ShieldPiercing = 1,

		/// <summary>
		/// Disruption = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Disruption = 2,

		/// <summary>
		/// Stagger = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Stagger = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}