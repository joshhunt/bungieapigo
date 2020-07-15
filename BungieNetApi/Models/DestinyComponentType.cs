using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Represents the possible components that can be returned from Destiny "Get" calls such as GetProfile, GetCharacter, GetVendor etc...
	/// </summary>
	/// <summary>
	/// When making one of these requests, you will pass one or more of these components as a comma separated list in the "?components=" querystring parameter. For instance, if you want baseline Profile data, Character Data, and character progressions, you would pass "?components=Profiles,Characters,CharacterProgressions" You may use either the numerical or string values.
	/// </summary>
	
	public enum DestinyComponentType
	{
		/// <summary>
		/// None = 0
		/// </summary>
		[EnumMember(Value = "0")]
		None = 0,

		/// <summary>
		/// Profiles = 100
		/// Profiles is the most basic component, only relevant when calling GetProfile. This returns basic information about the profile, which is almost nothing: a list of characterIds, some information about the last time you logged in, and that most sobering statistic: how long you&#39;ve played.
		/// </summary>
		[EnumMember(Value = "100")]
		Profiles = 100,

		/// <summary>
		/// VendorReceipts = 101
		/// Only applicable for GetProfile, this will return information about receipts for refundable vendor items.
		/// </summary>
		[EnumMember(Value = "101")]
		VendorReceipts = 101,

		/// <summary>
		/// ProfileInventories = 102
		/// Asking for this will get you the profile-level inventories, such as your Vault buckets (yeah, the Vault is really inventory buckets located on your Profile)
		/// </summary>
		[EnumMember(Value = "102")]
		ProfileInventories = 102,

		/// <summary>
		/// ProfileCurrencies = 103
		/// This will get you a summary of items on your Profile that we consider to be &quot;currencies&quot;, such as Glimmer. I mean, if there&#39;s Glimmer in Destiny 2. I didn&#39;t say there was Glimmer.
		/// </summary>
		[EnumMember(Value = "103")]
		ProfileCurrencies = 103,

		/// <summary>
		/// ProfileProgression = 104
		/// This will get you any progression-related information that exists on a Profile-wide level, across all characters.
		/// </summary>
		[EnumMember(Value = "104")]
		ProfileProgression = 104,

		/// <summary>
		/// PlatformSilver = 105
		/// This will get you information about the silver that this profile has on every platform on which it plays.
		///  You may only request this component for the logged in user&#39;s Profile, and will not recieve it if you request it for another Profile.
		/// </summary>
		[EnumMember(Value = "105")]
		PlatformSilver = 105,

		/// <summary>
		/// Characters = 200
		/// This will get you summary info about each of the characters in the profile.
		/// </summary>
		[EnumMember(Value = "200")]
		Characters = 200,

		/// <summary>
		/// CharacterInventories = 201
		/// This will get you information about any non-equipped items on the character or character(s) in question, if you&#39;re allowed to see it. You have to either be authenticated as that user, or that user must allow anonymous viewing of their non-equipped items in Bungie.Net settings to actually get results.
		/// </summary>
		[EnumMember(Value = "201")]
		CharacterInventories = 201,

		/// <summary>
		/// CharacterProgressions = 202
		/// This will get you information about the progression (faction, experience, etc... &quot;levels&quot;) relevant to each character, if you are the currently authenticated user or the user has elected to allow anonymous viewing of its progression info.
		/// </summary>
		[EnumMember(Value = "202")]
		CharacterProgressions = 202,

		/// <summary>
		/// CharacterRenderData = 203
		/// This will get you just enough information to be able to render the character in 3D if you have written a 3D rendering library for Destiny Characters, or &quot;borrowed&quot; ours. It&#39;s okay, I won&#39;t tell anyone if you&#39;re using it. I&#39;m no snitch. (actually, we don&#39;t care if you use it - go to town)
		/// </summary>
		[EnumMember(Value = "203")]
		CharacterRenderData = 203,

		/// <summary>
		/// CharacterActivities = 204
		/// This will return info about activities that a user can see and gating on it, if you are the currently authenticated user or the user has elected to allow anonymous viewing of its progression info. Note that the data returned by this can be unfortunately problematic and relatively unreliable in some cases. We&#39;ll eventually work on making it more consistently reliable.
		/// </summary>
		[EnumMember(Value = "204")]
		CharacterActivities = 204,

		/// <summary>
		/// CharacterEquipment = 205
		/// This will return info about the equipped items on the character(s). Everyone can see this.
		/// </summary>
		[EnumMember(Value = "205")]
		CharacterEquipment = 205,

		/// <summary>
		/// ItemInstances = 300
		/// This will return basic info about instanced items - whether they can be equipped, their tracked status, and some info commonly needed in many places (current damage type, primary stat value, etc)
		/// </summary>
		[EnumMember(Value = "300")]
		ItemInstances = 300,

		/// <summary>
		/// ItemObjectives = 301
		/// Items can have Objectives (DestinyObjectiveDefinition) bound to them. If they do, this will return info for items that have such bound objectives.
		/// </summary>
		[EnumMember(Value = "301")]
		ItemObjectives = 301,

		/// <summary>
		/// ItemPerks = 302
		/// Items can have perks (DestinyPerkDefinition). If they do, this will return info for what perks are active on items.
		/// </summary>
		[EnumMember(Value = "302")]
		ItemPerks = 302,

		/// <summary>
		/// ItemRenderData = 303
		/// If you just want to render the weapon, this is just enough info to do that rendering.
		/// </summary>
		[EnumMember(Value = "303")]
		ItemRenderData = 303,

		/// <summary>
		/// ItemStats = 304
		/// Items can have stats, like rate of fire. Asking for this component will return requested item&#39;s stats if they have stats.
		/// </summary>
		[EnumMember(Value = "304")]
		ItemStats = 304,

		/// <summary>
		/// ItemSockets = 305
		/// Items can have sockets, where plugs can be inserted. Asking for this component will return all info relevant to the sockets on items that have them.
		/// </summary>
		[EnumMember(Value = "305")]
		ItemSockets = 305,

		/// <summary>
		/// ItemTalentGrids = 306
		/// Items can have talent grids, though that matters a lot less frequently than it used to. Asking for this component will return all relevant info about activated Nodes and Steps on this talent grid, like the good ol&#39; days.
		/// </summary>
		[EnumMember(Value = "306")]
		ItemTalentGrids = 306,

		/// <summary>
		/// ItemCommonData = 307
		/// Items that *aren&#39;t* instanced still have important information you need to know: how much of it you have, the itemHash so you can look up their DestinyInventoryItemDefinition, whether they&#39;re locked, etc... Both instanced and non-instanced items will have these properties. You will get this automatically with Inventory components - you only need to pass this when calling GetItem on a specific item.
		/// </summary>
		[EnumMember(Value = "307")]
		ItemCommonData = 307,

		/// <summary>
		/// ItemPlugStates = 308
		/// Items that are &quot;Plugs&quot; can be inserted into sockets. This returns statuses about those plugs and why they can&#x2F;can&#39;t be inserted. I hear you giggling, there&#39;s nothing funny about inserting plugs. Get your head out of the gutter and pay attention!
		/// </summary>
		[EnumMember(Value = "308")]
		ItemPlugStates = 308,

		/// <summary>
		/// ItemPlugObjectives = 309
		/// Sometimes, plugs have objectives on them. This data can get really large, so we split it into its own component. Please, don&#39;t grab it unless you need it.
		/// </summary>
		[EnumMember(Value = "309")]
		ItemPlugObjectives = 309,

		/// <summary>
		/// ItemReusablePlugs = 310
		/// Sometimes, designers create thousands of reusable plugs and suddenly your response sizes are almost 3MB, and something has to give.
		///  Reusable Plugs were split off as their own component, away from ItemSockets, as a result of the Plug changes in Shadowkeep that made plug data infeasibly large for the most common use cases.
		///  Request this component if and only if you need to know what plugs *could* be inserted into a socket, and need to know it before &quot;drilling&quot; into the details of an item in your application (for instance, if you&#39;re doing some sort of interesting sorting or aggregation based on available plugs.
		///  When you get this, you will also need to combine it with &quot;Plug Sets&quot; data if you want a full picture of all of the available plugs: this component will only return plugs that have state data that is per-item. See Plug Sets for available plugs that have Character, Profile, or no state-specific restrictions.
		/// </summary>
		[EnumMember(Value = "310")]
		ItemReusablePlugs = 310,

		/// <summary>
		/// Vendors = 400
		/// When obtaining vendor information, this will return summary information about the Vendor or Vendors being returned.
		/// </summary>
		[EnumMember(Value = "400")]
		Vendors = 400,

		/// <summary>
		/// VendorCategories = 401
		/// When obtaining vendor information, this will return information about the categories of items provided by the Vendor.
		/// </summary>
		[EnumMember(Value = "401")]
		VendorCategories = 401,

		/// <summary>
		/// VendorSales = 402
		/// When obtaining vendor information, this will return the information about items being sold by the Vendor.
		/// </summary>
		[EnumMember(Value = "402")]
		VendorSales = 402,

		/// <summary>
		/// Kiosks = 500
		/// Asking for this component will return you the account&#39;s Kiosk statuses: that is, what items have been filled out&#x2F;acquired. But only if you are the currently authenticated user or the user has elected to allow anonymous viewing of its progression info.
		/// </summary>
		[EnumMember(Value = "500")]
		Kiosks = 500,

		/// <summary>
		/// CurrencyLookups = 600
		/// A &quot;shortcut&quot; component that will give you all of the item hashes&#x2F;quantities of items that the requested character can use to determine if an action (purchasing, socket insertion) has the required currency. (recall that all currencies are just items, and that some vendor purchases require items that you might not traditionally consider to be a &quot;currency&quot;, like plugs&#x2F;mods!)
		/// </summary>
		[EnumMember(Value = "600")]
		CurrencyLookups = 600,

		/// <summary>
		/// PresentationNodes = 700
		/// Returns summary status information about all &quot;Presentation Nodes&quot;. See DestinyPresentationNodeDefinition for more details, but the gist is that these are entities used by the game UI to bucket Collectibles and Records into a hierarchy of categories. You may ask for and use this data if you want to perform similar bucketing in your own UI: or you can skip it and roll your own.
		/// </summary>
		[EnumMember(Value = "700")]
		PresentationNodes = 700,

		/// <summary>
		/// Collectibles = 800
		/// Returns summary status information about all &quot;Collectibles&quot;. These are records of what items you&#39;ve discovered while playing Destiny, and some other basic information. For detailed information, you will have to call a separate endpoint devoted to the purpose.
		/// </summary>
		[EnumMember(Value = "800")]
		Collectibles = 800,

		/// <summary>
		/// Records = 900
		/// Returns summary status information about all &quot;Records&quot; (also known in the game as &quot;Triumphs&quot;. I know, it&#39;s confusing because there&#39;s also &quot;Moments of Triumph&quot; that will themselves be represented as &quot;Triumphs.&quot;)
		/// </summary>
		[EnumMember(Value = "900")]
		Records = 900,

		/// <summary>
		/// Transitory = 1000
		/// Returns information that Bungie considers to be &quot;Transitory&quot;: data that may change too frequently or come from a non-authoritative source such that we don&#39;t consider the data to be fully trustworthy, but that might prove useful for some limited use cases. We can provide no guarantee of timeliness nor consistency for this data: buyer beware with the Transitory component.
		/// </summary>
		[EnumMember(Value = "1000")]
		Transitory = 1000,

		/// <summary>
		/// Metrics = 1100
		/// Returns summary status information about all &quot;Metrics&quot; (also known in the game as &quot;Stat Trackers&quot;).
		/// </summary>
		[EnumMember(Value = "1100")]
		Metrics = 1100,

		///value not found fallback
		[EnumMember(Value = "999999999")]
		ProtectedInvalidEnumValue = 999999999
	}
}