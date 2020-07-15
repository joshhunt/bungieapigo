using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// If you look in the DestinyInventoryItemDefinition's "sockets" property, you'll see that there are two types of sockets: intrinsic, and "socketEntry."
	/// </summary>
	/// <summary>
	/// Unfortunately, because Intrinsic sockets are a whole separate array, it is no longer sufficient to know the index into that array to know which socket we're talking about. You have to know whether it's in the default "socketEntries" or if it's in the "intrinsic" list.
	/// </summary>
	
	public enum DestinySocketArrayType
	{
		/// <summary>
		/// Default = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Default = 0,

		/// <summary>
		/// Intrinsic = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Intrinsic = 1,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}