using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// The various known UI styles in which an item can be highlighted. It'll be up to you to determine what you want to show based on this highlighting, BNet doesn't have any assets that correspond to these states. And yeah, RiseOfIron and Comet have their own special highlight states. Don't ask me, I can't imagine they're still used.
	/// </summary>
	
	public enum ActivityGraphNodeHighlightType
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Normal = 1
		/// </summary>
		[EnumMember(Value = "1")]
		Normal = 1,

		/// <summary>
		/// Hyper = 2
		/// </summary>
		[EnumMember(Value = "2")]
		Hyper = 2,

		/// <summary>
		/// Comet = 3
		/// </summary>
		[EnumMember(Value = "3")]
		Comet = 3,

		/// <summary>
		/// RiseOfIron = 4
		/// </summary>
		[EnumMember(Value = "4")]
		RiseOfIron = 4,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}