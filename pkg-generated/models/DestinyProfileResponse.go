package bungieAPI

// The response for GetDestinyProfile, with components for character and item-level data.
type DestinyProfileResponse struct {

	// Recent, refundable purchases you have made from vendors. When will you use it? Couldn't say...
	// COMPONENT TYPE: VendorReceipts
	VendorReceipts SingleComponentResponseOfDestinyVendorReceiptsComponent `json:"vendorReceipts"`

	// The profile-level inventory of the Destiny Profile.
	// COMPONENT TYPE: ProfileInventories
	ProfileInventory SingleComponentResponseOfDestinyInventoryComponent `json:"profileInventory"`

	// The profile-level currencies owned by the Destiny Profile.
	// COMPONENT TYPE: ProfileCurrencies
	ProfileCurrencies SingleComponentResponseOfDestinyInventoryComponent `json:"profileCurrencies"`

	// The basic information about the Destiny Profile (formerly "Account").
	// COMPONENT TYPE: Profiles
	Profile SingleComponentResponseOfDestinyProfileComponent `json:"profile"`

	// Silver quantities for any platform on which this Profile plays destiny.
	//  COMPONENT TYPE: PlatformSilver
	PlatformSilver SingleComponentResponseOfDestinyPlatformSilverComponent `json:"platformSilver"`

	// Items available from Kiosks that are available Profile-wide (i.e. across all characters)
	// This component returns information about what Kiosk items are available to you on a *Profile*
	// level. It is theoretically possible for Kiosks to have items gated by specific Character as
	// well. If you ever have those, you will find them on the characterKiosks property.
	// COMPONENT TYPE: Kiosks
	ProfileKiosks SingleComponentResponseOfDestinyKiosksComponent `json:"profileKiosks"`

	// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this
	// is the set of plugs and their states that are profile-scoped.
	// This comes back with ItemSockets, as it is needed for a complete picture of the sockets on
	// requested items.
	// COMPONENT TYPE: ItemSockets
	ProfilePlugSets SingleComponentResponseOfDestinyPlugSetsComponent `json:"profilePlugSets"`

	// When we have progression information - such as Checklists - that may apply profile-wide, it
	// will be returned here rather than in the per-character progression data.
	// COMPONENT TYPE: ProfileProgression
	ProfileProgression SingleComponentResponseOfDestinyProfileProgressionComponent `json:"profileProgression"`

	// COMPONENT TYPE: PresentationNodes
	ProfilePresentationNodes SingleComponentResponseOfDestinyPresentationNodesComponent `json:"profilePresentationNodes"`

	// COMPONENT TYPE: Records
	ProfileRecords SingleComponentResponseOfDestinyProfileRecordsComponent `json:"profileRecords"`

	// COMPONENT TYPE: Collectibles
	ProfileCollectibles SingleComponentResponseOfDestinyProfileCollectiblesComponent `json:"profileCollectibles"`

	// COMPONENT TYPE: Transitory
	ProfileTransitoryData SingleComponentResponseOfDestinyProfileTransitoryComponent `json:"profileTransitoryData"`

	// COMPONENT TYPE: Metrics
	Metrics SingleComponentResponseOfDestinyMetricsComponent `json:"metrics"`

	// COMPONENT TYPE: StringVariables
	ProfileStringVariables SingleComponentResponseOfDestinyStringVariablesComponent `json:"profileStringVariables"`

	// Basic information about each character, keyed by the CharacterId.
	// COMPONENT TYPE: Characters
	Characters DictionaryComponentResponseOfint64AndDestinyCharacterComponent `json:"characters"`

	// The character-level non-equipped inventory items, keyed by the Character's Id.
	// COMPONENT TYPE: CharacterInventories
	CharacterInventories DictionaryComponentResponseOfint64AndDestinyInventoryComponent `json:"characterInventories"`

	// Character-level progression data, keyed by the Character's Id.
	// COMPONENT TYPE: CharacterProgressions
	CharacterProgressions DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent `json:"characterProgressions"`

	// Character rendering data - a minimal set of info needed to render a character in 3D - keyed by the
	// Character's Id.
	// COMPONENT TYPE: CharacterRenderData
	CharacterRenderData DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent `json:"characterRenderData"`

	// Character activity data - the activities available to this character and its status, keyed by
	// the Character's Id.
	// COMPONENT TYPE: CharacterActivities
	CharacterActivities DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent `json:"characterActivities"`

	// The character's equipped items, keyed by the Character's Id.
	// COMPONENT TYPE: CharacterEquipment
	CharacterEquipment DictionaryComponentResponseOfint64AndDestinyInventoryComponent `json:"characterEquipment"`

	// Items available from Kiosks that are available to a specific character as opposed to the
	// account as a whole. It must be combined with data from the profileKiosks property to get a full
	// picture of the character's available items to check out of a kiosk.
	// This component returns information about what Kiosk items are available to you on a
	// *Character* level. Usually, kiosk items will be earned for the entire Profile (all
	// characters) at once. To find those, look in the profileKiosks property.
	// COMPONENT TYPE: Kiosks
	CharacterKiosks DictionaryComponentResponseOfint64AndDestinyKiosksComponent `json:"characterKiosks"`

	// When sockets refer to reusable Plug Sets (see DestinyPlugSetDefinition for more info), this
	// is the set of plugs and their states, per character, that are character-scoped.
	// This comes back with ItemSockets, as it is needed for a complete picture of the sockets on
	// requested items.
	// COMPONENT TYPE: ItemSockets
	CharacterPlugSets DictionaryComponentResponseOfint64AndDestinyPlugSetsComponent `json:"characterPlugSets"`

	// Do you ever get the feeling that a system was designed *too* flexibly? That it can be used in so
	// many different ways that you end up being unable to provide an easy to use abstraction for the
	// mess that's happening under the surface?
	// Let's talk about character-specific data that might be related to items without instances.
	// These two statements are totally unrelated, I promise.
	// At some point during D2, it was decided that items - such as Bounties - could be given to
	// characters and *not* have instance data, but that *could* display and even use relevant state
	// information on your account and character.
	// Up to now, any item that had meaningful dependencies on character or account state had to be
	// instanced, and thus "itemComponents" was all that you needed: it was keyed by item's instance
	// IDs and provided the stateful information you needed inside.
	// Unfortunately, we don't live in such a magical world anymore. This is information held on a
	// per-character basis about non-instanced items that the characters have in their inventory -
	// or that reference character-specific state information even if it's in Account-level
	// inventory - and the values related to that item's state in relation to the given character.
	// To give a concrete example, look at a Moments of Triumph bounty. They exist in a character's
	// inventory, and show/care about a character's progression toward completing the bounty. But
	// the bounty itself is a non-instanced item, like a mod or a currency. This returns that data for
	// the characters who have the bounty in their inventory.
	// I'm not crying, you're crying Okay we're both crying but it's going to be okay I promise Actually
	// I shouldn't promise that, I don't know if it's going to be okay
	CharacterUninstancedItemComponents map[int64]DestinyBaseItemComponentSetOfuint32 `json:"characterUninstancedItemComponents"`

	// COMPONENT TYPE: PresentationNodes
	CharacterPresentationNodes DictionaryComponentResponseOfint64AndDestinyPresentationNodesComponent `json:"characterPresentationNodes"`

	// COMPONENT TYPE: Records
	CharacterRecords DictionaryComponentResponseOfint64AndDestinyCharacterRecordsComponent `json:"characterRecords"`

	// COMPONENT TYPE: Collectibles
	CharacterCollectibles DictionaryComponentResponseOfint64AndDestinyCollectiblesComponent `json:"characterCollectibles"`

	// COMPONENT TYPE: StringVariables
	CharacterStringVariables DictionaryComponentResponseOfint64AndDestinyStringVariablesComponent `json:"characterStringVariables"`

	// Information about instanced items across all returned characters, keyed by the item's
	// instance ID.
	// COMPONENT TYPE: [See inside the DestinyItemComponentSet contract for component types.]
	ItemComponents DestinyItemComponentSetOfint64 `json:"itemComponents"`

	// A "lookup" convenience component that can be used to quickly check if the character has access
	// to items that can be used for purchasing.
	// COMPONENT TYPE: CurrencyLookups
	CharacterCurrencyLookups DictionaryComponentResponseOfint64AndDestinyCurrenciesComponent `json:"characterCurrencyLookups"`
}
