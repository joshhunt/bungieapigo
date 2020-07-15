using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Indicates the type of actions that can be performed
	/// </summary>
	
	public enum SocketTypeActionType
	{
		/// <summary>
		/// InsertPlug = 0
		/// </summary>
		[EnumMember(Value = "0")]
		InsertPlug = 0,

		/// <summary>
		/// InfuseItem = 1
		/// </summary>
		[EnumMember(Value = "1")]
		InfuseItem = 1,

		/// <summary>
		/// ReinitializeSocket = 2
		/// </summary>
		[EnumMember(Value = "2")]
		ReinitializeSocket = 2,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}