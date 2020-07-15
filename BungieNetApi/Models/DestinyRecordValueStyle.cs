using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum DestinyRecordValueStyle
	{
		/// <summary>
		/// Integer = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Integer = 0,

		/// <summary>
		/// Percentage = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Percentage = 1,

		/// <summary>
		/// Milliseconds = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Milliseconds = 2,

		/// <summary>
		/// Boolean = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Boolean = 3,

		/// <summary>
		/// Decimal = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Decimal = 4,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}