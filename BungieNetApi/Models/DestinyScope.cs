using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// There's a lot of places where we need to know scope on more than just a profile or character level. For everything else, there's this more generic sense of scope.
	/// </summary>
	
	public enum DestinyScope
	{
		/// <summary>
		/// Profile = 0
		/// </summary>
		[EnumMember(Value = "0")]
		Profile = 0,

		/// <summary>
		/// Character = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Character = 1,

		///value not found fallback
		[EnumMember(Value = 999999999)]
		ProtectedInvalidEnumValue = 999999999
	}
}