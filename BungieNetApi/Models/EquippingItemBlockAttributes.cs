using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Models
{
	[Flags]
	public enum EquippingItemBlockAttributes
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// EquipOnAcquire = 1
		/// </summary>
		[EnumMember(Value = "1")]
		EquipOnAcquire = 1,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}