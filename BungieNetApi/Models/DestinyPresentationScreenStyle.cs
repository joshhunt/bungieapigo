using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// A hint for what screen should be shown when this presentation node is clicked into. How you use this is your UI is up to you.
	/// </summary>
	
	public enum DestinyPresentationScreenStyle
	{
		/// <summary>
		/// Default = 0
		/// Use the &quot;default&quot; view for the presentation nodes.
		/// </summary>
		[EnumMember(Value = "0")]
		Default = 0,

		/// <summary>
		/// CategorySets = 1
		/// Show sub-items as &quot;category sets&quot;. In-game, you&#39;d see these as a vertical list of child presentation nodes - armor sets for example - and the icons of items within those sets displayed horizontally.
		/// </summary>
		[EnumMember(Value = "1")]
		CategorySets = 1,

		/// <summary>
		/// Badge = 2
		/// Show sub-items as Badges. (I know, I know. We don&#39;t need no stinkin&#39; badges har har har)
		/// </summary>
		[EnumMember(Value = "2")]
		Badge = 2,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}