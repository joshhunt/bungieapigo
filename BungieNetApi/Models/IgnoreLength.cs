using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum IgnoreLength
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Week = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Week = 1,

		/// <summary>
		/// TwoWeeks = 2
		/// </summary>
		[EnumMember(Value = "2")]
		TwoWeeks = 2,

		/// <summary>
		/// ThreeWeeks = 3
		/// </summary>
		[EnumMember(Value = "3")]
		ThreeWeeks = 3,

		/// <summary>
		/// Month = 4
		/// </summary>
		[EnumMember(Value = "4")]
		Month = 4,

		/// <summary>
		/// ThreeMonths = 5
		/// </summary>
		[EnumMember(Value = "5")]
		ThreeMonths = 5,

		/// <summary>
		/// SixMonths = 6
		/// </summary>
		[EnumMember(Value = "6")]
		SixMonths = 6,

		/// <summary>
		/// Year = 7
		/// </summary>
		[EnumMember(Value = "7")]
		Year = 7,

		/// <summary>
		/// Forever = 8
		/// </summary>
		[EnumMember(Value = "8")]
		Forever = 8,

		/// <summary>
		/// ThreeMinutes = 9
		/// </summary>
		[EnumMember(Value = "9")]
		ThreeMinutes = 9,

		/// <summary>
		/// Hour = 10
		/// </summary>
		[EnumMember(Value = "10")]
		Hour = 10,

		/// <summary>
		/// ThirtyDays = 11
		/// </summary>
		[EnumMember(Value = "11")]
		ThirtyDays = 11,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}