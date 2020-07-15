using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// A set of flags for reason(s) why the component populated in the way that it did. Inspect the individual flags for the reasons.
	/// </summary>
	
	public enum ComponentPrivacySetting
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Public = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Public = 1,

		/// <summary>
		/// Private = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Private = 2,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}