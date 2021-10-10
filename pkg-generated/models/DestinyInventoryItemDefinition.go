package bungieAPI

// So much of what you see in Destiny is actually an Item used in a new and creative way. This is the definition for Items in Destiny, which started off as just entities that could exist in your Inventory but ended up being the backing data for so much more: quests, reward previews, slots, and subclasses.
// In practice, you will want to associate this data with "live" item data from a Bungie.Net Platform call: these definitions describe the item in generic, non-instanced terms: but an actual instance of an item can vary widely from these generic definitions.
type DestinyInventoryItemDefinition struct {

	// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
	DisplayProperties DestinyDisplayPropertiesDefinition `json:"displayProperties"`

	// Tooltips that only come up conditionally for the item. Check the live data DestinyItemComponent.tooltipNotificationIndexes property for which of these should be shown at runtime.
	TooltipNotifications []DestinyItemTooltipNotification `json:"tooltipNotifications"`

	// If this item has a collectible related to it, this is the hash identifier of that collectible entry.
	CollectibleHash int `json:"collectibleHash"`

	// If available, this is the original 'active' release watermark overlay for the icon. If the item has different versions, this can be overridden by the 'display version watermark icon' from the 'quality' block. Alternatively, if there is no watermark for the version, and the item version has a power cap below the current season power cap, this can be overridden by the iconWatermarkShelved property.
	IconWatermark string `json:"iconWatermark"`

	// If available, this is the 'shelved' release watermark overlay for the icon. If the item version has a power cap below the current season power cap, it can be treated as 'shelved', and should be shown with this 'shelved' watermark overlay.
	IconWatermarkShelved string `json:"iconWatermarkShelved"`

	// A secondary icon associated with the item. Currently this is used in very context specific applications, such as Emblem Nameplates.
	SecondaryIcon string `json:"secondaryIcon"`

	// Pulled from the secondary icon, this is the "secondary background" of the secondary icon. Confusing? Sure, that's why I call it "overlay" here: because as far as it's been used thus far, it has been for an optional overlay image. We'll see if that holds up, but at least for now it explains what this image is a bit better.
	SecondaryOverlay string `json:"secondaryOverlay"`

	// Pulled from the Secondary Icon, this is the "special" background for the item. For Emblems, this is the background image used on the Details view: but it need not be limited to that for other types of items.
	SecondarySpecial string `json:"secondarySpecial"`

	// Sometimes, an item will have a background color. Most notably this occurs with Emblems, who use the Background Color for small character nameplates such as the "friends" view you see in-game. There are almost certainly other items that have background color as well, though I have not bothered to investigate what items have it nor what purposes they serve: use it as you will.
	BackgroundColor DestinyColor `json:"backgroundColor"`

	// If we were able to acquire an in-game screenshot for the item, the path to that screenshot will be returned here. Note that not all items have screenshots: particularly not any non-equippable items.
	Screenshot string `json:"screenshot"`

	// The localized title/name of the item's type. This can be whatever the designers want, and has no guarantee of consistency between items.
	ItemTypeDisplayName string `json:"itemTypeDisplayName"`
	FlavorText          string `json:"flavorText"`

	// A string identifier that the game's UI uses to determine how the item should be rendered in inventory screens and the like. This could really be anything - at the moment, we don't have the time to really breakdown and maintain all the possible strings this could be, partly because new ones could be added ad hoc. But if you want to use it to dictate your own UI, or look for items with a certain display style, go for it!
	UiItemDisplayStyle string `json:"uiItemDisplayStyle"`

	// It became a common enough pattern in our UI to show Item Type and Tier combined into a single localized string that I'm just going to go ahead and start pre-creating these for items.
	ItemTypeAndTierDisplayName string `json:"itemTypeAndTierDisplayName"`

	// In theory, it is a localized string telling you about how you can find the item. I really wish this was more consistent. Many times, it has nothing. Sometimes, it's instead a more narrative-forward description of the item. Which is cool, and I wish all properties had that data, but it should really be its own property.
	DisplaySource string `json:"displaySource"`

	// An identifier that the game UI uses to determine what type of tooltip to show for the item. These have no corresponding definitions that BNet can link to: so it'll be up to you to interpret and display your UI differently according to these styles (or ignore it).
	TooltipStyle string `json:"tooltipStyle"`

	// If the item can be "used", this block will be non-null, and will have data related to the action performed when using the item. (Guess what? 99% of the time, this action is "dismantle". Shocker)
	Action DestinyItemActionBlockDefinition `json:"action"`

	// If this item can exist in an inventory, this block will be non-null. In practice, every item that currently exists has one of these blocks. But note that it is not necessarily guaranteed.
	Inventory DestinyItemInventoryBlockDefinition `json:"inventory"`

	// If this item is a quest, this block will be non-null. In practice, I wish I had called this the Quest block, but at the time it wasn't clear to me whether it would end up being used for purposes other than quests. It will contain data about the steps in the quest, and mechanics we can use for displaying and tracking the quest.
	SetData DestinyItemSetBlockDefinition `json:"setData"`

	// If this item can have stats (such as a weapon, armor, or vehicle), this block will be non-null and populated with the stats found on the item.
	Stats DestinyItemStatBlockDefinition `json:"stats"`

	// If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the "art channel". When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they're being used for and how they are wired up, but for now here's the raw data.
	EmblemObjectiveHash int `json:"emblemObjectiveHash"`

	// If this item can be equipped, this block will be non-null and will be populated with the conditions under which it can be equipped.
	EquippingBlock DestinyEquippingBlockDefinition `json:"equippingBlock"`

	// If this item can be rendered, this block will be non-null and will be populated with rendering information.
	TranslationBlock DestinyItemTranslationBlockDefinition `json:"translationBlock"`

	// If this item can be Used or Acquired to gain other items (for instance, how Eververse Boxes can be consumed to get items from the box), this block will be non-null and will give summary information for the items that can be acquired.
	Preview DestinyItemPreviewBlockDefinition `json:"preview"`

	// If this item can have a level or stats, this block will be non-null and will be populated with default quality (item level, "quality", and infusion) data. See the block for more details, there's often less upfront information in D2 so you'll want to be aware of how you use quality and item level on the definition level now.
	Quality DestinyItemQualityBlockDefinition `json:"quality"`

	// The conceptual "Value" of an item, if any was defined. See the DestinyItemValueBlockDefinition for more details.
	Value DestinyItemValueBlockDefinition `json:"value"`

	// If this item has a known source, this block will be non-null and populated with source information. Unfortunately, at this time we are not generating sources: that is some aggressively manual work which we didn't have time for, and I'm hoping to get back to at some point in the future.
	SourceData DestinyItemSourceBlockDefinition `json:"sourceData"`

	// If this item has Objectives (extra tasks that can be accomplished related to the item... most frequently when the item is a Quest Step and the Objectives need to be completed to move on to the next Quest Step), this block will be non-null and the objectives defined herein.
	Objectives DestinyItemObjectiveBlockDefinition `json:"objectives"`

	// If this item has available metrics to be shown, this block will be non-null have the appropriate hashes defined.
	Metrics DestinyItemMetricBlockDefinition `json:"metrics"`

	// If this item *is* a Plug, this will be non-null and the info defined herein. See DestinyItemPlugDefinition for more information.
	Plug DestinyItemPlugDefinition `json:"plug"`

	// If this item has related items in a "Gear Set", this will be non-null and the relationships defined herein.
	Gearset DestinyItemGearsetBlockDefinition `json:"gearset"`

	// If this item is a "reward sack" that can be opened to provide other items, this will be non-null and the properties of the sack contained herein.
	Sack DestinyItemSackBlockDefinition `json:"sack"`

	// If this item has any Sockets, this will be non-null and the individual sockets on the item will be defined herein.
	Sockets DestinyItemSocketBlockDefinition `json:"sockets"`

	// Summary data about the item.
	Summary DestinyItemSummaryBlockDefinition `json:"summary"`

	// If the item has a Talent Grid, this will be non-null and the properties of the grid defined herein. Note that, while many items still have talent grids, the only ones with meaningful Nodes still on them will be Subclass/"Build" items.
	TalentGrid DestinyItemTalentGridBlockDefinition `json:"talentGrid"`

	// If the item has stats, this block will be defined. It has the "raw" investment stats for the item. These investment stats don't take into account the ways that the items can spawn, nor do they take into account any Stat Group transformations. I have retained them for debugging purposes, but I do not know how useful people will find them.
	InvestmentStats []DestinyItemInvestmentStatDefinition `json:"investmentStats"`

	// If the item has any *intrinsic* Perks (Perks that it will provide regardless of Sockets, Talent Grid, and other transitory state), they will be defined here.
	Perks []DestinyItemPerkEntryDefinition `json:"perks"`

	// If the item has any related Lore (DestinyLoreDefinition), this will be the hash identifier you can use to look up the lore definition.
	LoreHash int `json:"loreHash"`

	// There are times when the game will show you a "summary/vague" version of an item - such as a description of its type represented as a DestinyInventoryItemDefinition - rather than display the item itself.
	// This happens sometimes when summarizing possible rewards in a tooltip. This is the item displayed instead, if it exists.
	SummaryItemHash int `json:"summaryItemHash"`

	// If any animations were extracted from game content for this item, these will be the definitions of those animations.
	Animations []DestinyAnimationReference `json:"animations"`

	// BNet may forbid the execution of actions on this item via the API. If that is occurring, allowActions will be set to false.
	AllowActions bool `json:"allowActions"`

	// If we added any help or informational URLs about this item, these will be those links.
	Links []HyperlinkReference `json:"links"`

	// The boolean will indicate to us (and you!) whether something *could* happen when you transfer this item from the Postmaster that might be considered a "destructive" action.
	// It is not feasible currently to tell you (or ourelves!) in a consistent way whether this *will* actually cause a destructive action, so we are playing it safe: if it has the potential to do so, we will not allow it to be transferred from the Postmaster by default. You will need to check for this flag before transferring an item from the Postmaster, or else you'll end up receiving an error.
	DoesPostmasterPullHaveSideEffects bool `json:"doesPostmasterPullHaveSideEffects"`

	// The intrinsic transferability of an item.
	// I hate that this boolean is negative - but there's a reason.
	// Just because an item is intrinsically transferrable doesn't mean that it can be transferred, and we don't want to imply that this is the only source of that transferability.
	NonTransferrable bool `json:"nonTransferrable"`

	// BNet attempts to make a more formal definition of item "Categories", as defined by DestinyItemCategoryDefinition. This is a list of all Categories that we were able to algorithmically determine that this item is a member of. (for instance, that it's a "Weapon", that it's an "Auto Rifle", etc...)
	// The algorithm for these is, unfortunately, volatile. If you believe you see a miscategorized item, please let us know on the Bungie API forums.
	ItemCategoryHashes []int `json:"itemCategoryHashes"`

	// In Destiny 1, we identified some items as having particular categories that we'd like to know about for various internal logic purposes. These are defined in SpecialItemType, and while these days the itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
	SpecialItemType SpecialItemType `json:"specialItemType"`

	// A value indicating the "base" the of the item. This enum is a useful but dramatic oversimplification of what it means for an item to have a "Type". Still, it's handy in many situations.
	// itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
	ItemType DestinyItemType `json:"itemType"`

	// A value indicating the "sub-type" of the item. For instance, where an item might have an itemType value "Weapon", this will be something more specific like "Auto Rifle".
	// itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
	ItemSubType DestinyItemSubType `json:"itemSubType"`

	// We run a similarly weak-sauce algorithm to try and determine whether an item is restricted to a specific class. If we find it to be restricted in such a way, we set this classType property to match the class' enumeration value so that users can easily identify class restricted items.
	// If you see a mis-classed item, please inform the developers in the Bungie API forum.
	ClassType DestinyClass `json:"classType"`

	// Some weapons and plugs can have a "Breaker Type": a special ability that works sort of like damage type vulnerabilities. This is (almost?) always set on items by plugs.
	BreakerType DestinyBreakerType `json:"breakerType"`

	// Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what's cleanest for your code.
	BreakerTypeHash int `json:"breakerTypeHash"`

	// If true, then you will be allowed to equip the item if you pass its other requirements.
	// This being false means that you cannot equip the item under any circumstances.
	Equippable bool `json:"equippable"`

	// Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.
	DamageTypeHashes []int `json:"damageTypeHashes"`

	// This is the list of all damage types that we know ahead of time the item can take on. Unfortunately, this does not preclude the possibility of something funky happening to give the item a damage type that cannot be predicted beforehand: for example, if some designer decides to create arbitrary non-reusable plugs that cause damage type to change.
	// This damage type prediction will only use the following to determine potential damage types:
	// - Intrinsic perks
	// - Talent Node perks
	// - Known, reusable plugs for sockets
	DamageTypes []DamageType `json:"damageTypes"`

	// If the item has a damage type that could be considered to be default, it will be populated here.
	// For various upsetting reasons, it's surprisingly cumbersome to figure this out. I hope you're happy.
	DefaultDamageType DamageType `json:"defaultDamageType"`

	// Similar to defaultDamageType, but represented as the hash identifier for a DestinyDamageTypeDefinition.
	// I will likely regret leaving in the enumeration versions of these properties, but for now they're very convenient.
	DefaultDamageTypeHash int `json:"defaultDamageTypeHash"`

	// If this item is related directly to a Season of Destiny, this is the hash identifier for that season.
	SeasonHash int `json:"seasonHash"`

	// If true, this is a dummy vendor-wrapped item template. Items purchased from Eververse will be "wrapped" by one of these items so that we can safely provide refund capabilities before the item is "unwrapped".
	IsWrapper bool `json:"isWrapper"`

	// Traits are metadata tags applied to this item. For example: armor slot, weapon type, foundry, faction, etc. These IDs come from the game and don't map to any content, but should still be useful.
	TraitIds []string `json:"traitIds"`

	// These are the corresponding trait definition hashes for the entries in traitIds.
	TraitHashes []int `json:"traitHashes"`

	// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
	// When entities refer to each other in Destiny content, it is this hash that they are referring to.
	Hash int `json:"hash"`

	// The index of the entity as it was found in the investment tables.
	Index int `json:"index"`

	// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
	Redacted bool `json:"redacted"`
}
