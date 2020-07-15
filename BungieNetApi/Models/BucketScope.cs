using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	
	public enum BucketScope
	{
		/// <summary>
		/// Character = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Character = 0,

		/// <summary>
		/// Account = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Account = 1,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}