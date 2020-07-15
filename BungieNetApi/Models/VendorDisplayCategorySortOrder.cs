using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Display categories can have custom sort orders. These are the possible options.
	/// </summary>
	
	public enum VendorDisplayCategorySortOrder
	{
		/// <summary>
		/// Default = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Default = 0,

		/// <summary>
		/// SortByTier = 1
		/// </summary>
		[EnumMember(Value = "1")]
		SortByTier = 1,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}