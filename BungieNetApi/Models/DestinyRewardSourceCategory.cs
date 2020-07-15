using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// BNet's custom categorization of reward sources. We took a look at the existing ways that items could be spawned, and tried to make high-level categorizations of them. This needs to be re-evaluated for Destiny 2.
	/// </summary>
	
	public enum DestinyRewardSourceCategory
	{
		/// <summary>
		/// None = 0
		/// The source doesn&#39;t fit well into any of the other types.
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Activity = 1
		/// The source is directly related to the rewards gained by playing an activity or set of activities. This currently includes Quests and other action in-game.
		/// </summary>
		[EnumMember(Value = "1")]
		Activity = 1,

		/// <summary>
		/// Vendor = 2
		/// This source is directly related to items that Vendors sell.
		/// </summary>
		[EnumMember(Value = "2")]
		Vendor = 2,

		/// <summary>
		/// Aggregate = 3
		/// This source is a custom aggregation of items that can be earned in many ways, but that share some other property in common that is useful to share. For instance, in Destiny 1 we would make &quot;Reward Sources&quot; for every game expansion: that way, you could search reward sources to see what items became available with any given Expansion.
		/// </summary>
		[EnumMember(Value = "3")]
		Aggregate = 3,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}