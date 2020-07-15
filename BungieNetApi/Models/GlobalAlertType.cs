using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	
	public enum GlobalAlertType
	{
		/// <summary>
		/// GlobalAlert = 0
		/// </summary>
		[EnumMember(Value = "0")]
		GlobalAlert = 0,

		/// <summary>
		/// StreamingAlert = 1
		/// </summary>
		[EnumMember(Value = "1")]
		StreamingAlert = 1,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}