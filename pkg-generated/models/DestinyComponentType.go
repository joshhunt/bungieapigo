package bungieAPI

// Represents the possible components that can be returned from Destiny "Get" calls such as
// GetProfile, GetCharacter, GetVendor etc...
// When making one of these requests, you will pass one or more of these components as a comma
// separated list in the "?components=" querystring parameter. For instance, if you want
// baseline Profile data, Character Data, and character progressions, you would pass
// "?components=Profiles,Characters,CharacterProgressions" You may use either the
// numerical or string values.
type DestinyComponentType int

const (
	DestinyComponentTypeNone = 0

	// Profiles is the most basic component, only relevant when calling GetProfile. This returns
	// basic information about the profile, which is almost nothing: a list of characterIds, some
	// information about the last time you logged in, and that most sobering statistic: how long
	// you've played.
	DestinyComponentTypeProfiles = 100

	// Only applicable for GetProfile, this will return information about receipts for refundable
	// vendor items.
	DestinyComponentTypeVendorReceipts = 101

	// Asking for this will get you the profile-level inventories, such as your Vault buckets (yeah,
	// the Vault is really inventory buckets located on your Profile)
	DestinyComponentTypeProfileInventories = 102

	// This will get you a summary of items on your Profile that we consider to be "currencies", such as
	// Glimmer. I mean, if there's Glimmer in Destiny 2. I didn't say there was Glimmer.
	DestinyComponentTypeProfileCurrencies = 103

	// This will get you any progression-related information that exists on a Profile-wide level,
	// across all characters.
	DestinyComponentTypeProfileProgression = 104

	// This will get you information about the silver that this profile has on every platform on which
	// it plays.
	//  You may only request this component for the logged in user's Profile, and will not recieve it if
	// you request it for another Profile.
	DestinyComponentTypePlatformSilver = 105

	// This will get you summary info about each of the characters in the profile.
	DestinyComponentTypeCharacters = 200

	// This will get you information about any non-equipped items on the character or character(s) in
	// question, if you're allowed to see it. You have to either be authenticated as that user, or that
	// user must allow anonymous viewing of their non-equipped items in Bungie.Net settings to
	// actually get results.
	DestinyComponentTypeCharacterInventories = 201

	// This will get you information about the progression (faction, experience, etc... "levels")
	// relevant to each character, if you are the currently authenticated user or the user has elected
	// to allow anonymous viewing of its progression info.
	DestinyComponentTypeCharacterProgressions = 202

	// This will get you just enough information to be able to render the character in 3D if you have
	// written a 3D rendering library for Destiny Characters, or "borrowed" ours. It's okay, I won't
	// tell anyone if you're using it. I'm no snitch. (actually, we don't care if you use it - go to town)
	DestinyComponentTypeCharacterRenderData = 203

	// This will return info about activities that a user can see and gating on it, if you are the
	// currently authenticated user or the user has elected to allow anonymous viewing of its
	// progression info. Note that the data returned by this can be unfortunately problematic and
	// relatively unreliable in some cases. We'll eventually work on making it more consistently
	// reliable.
	DestinyComponentTypeCharacterActivities = 204

	// This will return info about the equipped items on the character(s). Everyone can see this.
	DestinyComponentTypeCharacterEquipment = 205

	// This will return basic info about instanced items - whether they can be equipped, their tracked
	// status, and some info commonly needed in many places (current damage type, primary stat value,
	// etc)
	DestinyComponentTypeItemInstances = 300

	// Items can have Objectives (DestinyObjectiveDefinition) bound to them. If they do, this will
	// return info for items that have such bound objectives.
	DestinyComponentTypeItemObjectives = 301

	// Items can have perks (DestinyPerkDefinition). If they do, this will return info for what perks
	// are active on items.
	DestinyComponentTypeItemPerks = 302

	// If you just want to render the weapon, this is just enough info to do that rendering.
	DestinyComponentTypeItemRenderData = 303

	// Items can have stats, like rate of fire. Asking for this component will return requested item's
	// stats if they have stats.
	DestinyComponentTypeItemStats = 304

	// Items can have sockets, where plugs can be inserted. Asking for this component will return all
	// info relevant to the sockets on items that have them.
	DestinyComponentTypeItemSockets = 305

	// Items can have talent grids, though that matters a lot less frequently than it used to. Asking
	// for this component will return all relevant info about activated Nodes and Steps on this talent
	// grid, like the good ol' days.
	DestinyComponentTypeItemTalentGrids = 306

	// Items that *aren't* instanced still have important information you need to know: how much of it
	// you have, the itemHash so you can look up their DestinyInventoryItemDefinition, whether
	// they're locked, etc... Both instanced and non-instanced items will have these properties.
	// You will get this automatically with Inventory components - you only need to pass this when
	// calling GetItem on a specific item.
	DestinyComponentTypeItemCommonData = 307

	// Items that are "Plugs" can be inserted into sockets. This returns statuses about those plugs
	// and why they can/can't be inserted. I hear you giggling, there's nothing funny about inserting
	// plugs. Get your head out of the gutter and pay attention!
	DestinyComponentTypeItemPlugStates = 308

	// Sometimes, plugs have objectives on them. This data can get really large, so we split it into its
	// own component. Please, don't grab it unless you need it.
	DestinyComponentTypeItemPlugObjectives = 309

	// Sometimes, designers create thousands of reusable plugs and suddenly your response sizes are
	// almost 3MB, and something has to give.
	//  Reusable Plugs were split off as their own component, away from ItemSockets, as a result of the
	// Plug changes in Shadowkeep that made plug data infeasibly large for the most common use cases.
	//  Request this component if and only if you need to know what plugs *could* be inserted into a
	// socket, and need to know it before "drilling" into the details of an item in your application
	// (for instance, if you're doing some sort of interesting sorting or aggregation based on
	// available plugs.
	//  When you get this, you will also need to combine it with "Plug Sets" data if you want a full picture
	// of all of the available plugs: this component will only return plugs that have state data that is
	// per-item. See Plug Sets for available plugs that have Character, Profile, or no
	// state-specific restrictions.
	DestinyComponentTypeItemReusablePlugs = 310

	// When obtaining vendor information, this will return summary information about the Vendor or
	// Vendors being returned.
	DestinyComponentTypeVendors = 400

	// When obtaining vendor information, this will return information about the categories of
	// items provided by the Vendor.
	DestinyComponentTypeVendorCategories = 401

	// When obtaining vendor information, this will return the information about items being sold by
	// the Vendor.
	DestinyComponentTypeVendorSales = 402

	// Asking for this component will return you the account's Kiosk statuses: that is, what items
	// have been filled out/acquired. But only if you are the currently authenticated user or the user
	// has elected to allow anonymous viewing of its progression info.
	DestinyComponentTypeKiosks = 500

	// A "shortcut" component that will give you all of the item hashes/quantities of items that the
	// requested character can use to determine if an action (purchasing, socket insertion) has the
	// required currency. (recall that all currencies are just items, and that some vendor purchases
	// require items that you might not traditionally consider to be a "currency", like plugs/mods!)
	DestinyComponentTypeCurrencyLookups = 600

	// Returns summary status information about all "Presentation Nodes". See
	// DestinyPresentationNodeDefinition for more details, but the gist is that these are entities
	// used by the game UI to bucket Collectibles and Records into a hierarchy of categories. You may
	// ask for and use this data if you want to perform similar bucketing in your own UI: or you can skip it
	// and roll your own.
	DestinyComponentTypePresentationNodes = 700

	// Returns summary status information about all "Collectibles". These are records of what items
	// you've discovered while playing Destiny, and some other basic information. For detailed
	// information, you will have to call a separate endpoint devoted to the purpose.
	DestinyComponentTypeCollectibles = 800

	// Returns summary status information about all "Records" (also known in the game as "Triumphs".
	// I know, it's confusing because there's also "Moments of Triumph" that will themselves be
	// represented as "Triumphs.")
	DestinyComponentTypeRecords = 900

	// Returns information that Bungie considers to be "Transitory": data that may change too
	// frequently or come from a non-authoritative source such that we don't consider the data to be
	// fully trustworthy, but that might prove useful for some limited use cases. We can provide no
	// guarantee of timeliness nor consistency for this data: buyer beware with the Transitory
	// component.
	DestinyComponentTypeTransitory = 1000

	// Returns summary status information about all "Metrics" (also known in the game as "Stat
	// Trackers").
	DestinyComponentTypeMetrics = 1100

	// Returns a mapping of localized string variable hashes to values, on a per-account or
	// per-character basis.
	DestinyComponentTypeStringVariables = 1200
)
