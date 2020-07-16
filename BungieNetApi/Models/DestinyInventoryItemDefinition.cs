using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// So much of what you see in Destiny is actually an Item used in a new and creative way. This is the definition for Items in Destiny, which started off as just entities that could exist in your Inventory but ended up being the backing data for so much more: quests, reward previews, slots, and subclasses.
    /// </summary>
    /// <summary>
    /// In practice, you will want to associate this data with "live" item data from a Bungie.Net Platform call: these definitions describe the item in generic, non-instanced terms: but an actual instance of an item can vary widely from these generic definitions.
    /// </summary>
    [DataContract]
    public class DestinyInventoryItemDefinition
    {
        /// <summary>
        /// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Tooltips that only come up conditionally for the item. Check the live data DestinyItemComponent.tooltipNotificationIndexes property for which of these should be shown at runtime.
        /// </summary>
        [DataMember(Name = "tooltipNotifications", EmitDefaultValue = false)]
        public List<DestinyItemTooltipNotification> TooltipNotifications { get; set; }

        /// <summary>
        /// If this item has a collectible related to it, this is the hash identifier of that collectible entry.
        /// </summary>
        [DataMember(Name = "collectibleHash", EmitDefaultValue = false)]
        public uint CollectibleHash { get; set; }

        /// <summary>
        /// A secondary icon associated with the item. Currently this is used in very context specific applications, such as Emblem Nameplates.
        /// </summary>
        [DataMember(Name = "secondaryIcon", EmitDefaultValue = false)]
        public string SecondaryIcon { get; set; }

        /// <summary>
        /// Pulled from the secondary icon, this is the "secondary background" of the secondary icon. Confusing? Sure, that's why I call it "overlay" here: because as far as it's been used thus far, it has been for an optional overlay image. We'll see if that holds up, but at least for now it explains what this image is a bit better.
        /// </summary>
        [DataMember(Name = "secondaryOverlay", EmitDefaultValue = false)]
        public string SecondaryOverlay { get; set; }

        /// <summary>
        /// Pulled from the Secondary Icon, this is the "special" background for the item. For Emblems, this is the background image used on the Details view: but it need not be limited to that for other types of items.
        /// </summary>
        [DataMember(Name = "secondarySpecial", EmitDefaultValue = false)]
        public string SecondarySpecial { get; set; }

        /// <summary>
        /// Sometimes, an item will have a background color. Most notably this occurs with Emblems, who use the Background Color for small character nameplates such as the "friends" view you see in-game. There are almost certainly other items that have background color as well, though I have not bothered to investigate what items have it nor what purposes they serve: use it as you will.
        /// </summary>
        [DataMember(Name = "backgroundColor", EmitDefaultValue = false)]
        public DestinyColor BackgroundColor { get; set; }

        /// <summary>
        /// If we were able to acquire an in-game screenshot for the item, the path to that screenshot will be returned here. Note that not all items have screenshots: particularly not any non-equippable items.
        /// </summary>
        [DataMember(Name = "screenshot", EmitDefaultValue = false)]
        public string Screenshot { get; set; }

        /// <summary>
        /// The localized title/name of the item's type. This can be whatever the designers want, and has no guarantee of consistency between items.
        /// </summary>
        [DataMember(Name = "itemTypeDisplayName", EmitDefaultValue = false)]
        public string ItemTypeDisplayName { get; set; }

        /// <summary>
        /// A string identifier that the game's UI uses to determine how the item should be rendered in inventory screens and the like. This could really be anything - at the moment, we don't have the time to really breakdown and maintain all the possible strings this could be, partly because new ones could be added ad hoc. But if you want to use it to dictate your own UI, or look for items with a certain display style, go for it!
        /// </summary>
        [DataMember(Name = "uiItemDisplayStyle", EmitDefaultValue = false)]
        public string UiItemDisplayStyle { get; set; }

        /// <summary>
        /// It became a common enough pattern in our UI to show Item Type and Tier combined into a single localized string that I'm just going to go ahead and start pre-creating these for items.
        /// </summary>
        [DataMember(Name = "itemTypeAndTierDisplayName", EmitDefaultValue = false)]
        public string ItemTypeAndTierDisplayName { get; set; }

        /// <summary>
        /// In theory, it is a localized string telling you about how you can find the item. I really wish this was more consistent. Many times, it has nothing. Sometimes, it's instead a more narrative-forward description of the item. Which is cool, and I wish all properties had that data, but it should really be its own property.
        /// </summary>
        [DataMember(Name = "displaySource", EmitDefaultValue = false)]
        public string DisplaySource { get; set; }

        /// <summary>
        /// An identifier that the game UI uses to determine what type of tooltip to show for the item. These have no corresponding definitions that BNet can link to: so it'll be up to you to interpret and display your UI differently according to these styles (or ignore it).
        /// </summary>
        [DataMember(Name = "tooltipStyle", EmitDefaultValue = false)]
        public string TooltipStyle { get; set; }

        /// <summary>
        /// If the item can be "used", this block will be non-null, and will have data related to the action performed when using the item. (Guess what? 99% of the time, this action is "dismantle". Shocker)
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public DestinyItemActionBlockDefinition Action { get; set; }

        /// <summary>
        /// If this item can exist in an inventory, this block will be non-null. In practice, every item that currently exists has one of these blocks. But note that it is not necessarily guaranteed.
        /// </summary>
        [DataMember(Name = "inventory", EmitDefaultValue = false)]
        public DestinyItemInventoryBlockDefinition Inventory { get; set; }

        /// <summary>
        /// If this item is a quest, this block will be non-null. In practice, I wish I had called this the Quest block, but at the time it wasn't clear to me whether it would end up being used for purposes other than quests. It will contain data about the steps in the quest, and mechanics we can use for displaying and tracking the quest.
        /// </summary>
        [DataMember(Name = "setData", EmitDefaultValue = false)]
        public DestinyItemSetBlockDefinition SetData { get; set; }

        /// <summary>
        /// If this item can have stats (such as a weapon, armor, or vehicle), this block will be non-null and populated with the stats found on the item.
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public DestinyItemStatBlockDefinition Stats { get; set; }

        /// <summary>
        /// If the item is an emblem that has a special Objective attached to it - for instance, if the emblem tracks PVP Kills, or what-have-you. This is a bit different from, for example, the Vanguard Kill Tracker mod, which pipes data into the "art channel". When I get some time, I would like to standardize these so you can get at the values they expose without having to care about what they're being used for and how they are wired up, but for now here's the raw data.
        /// </summary>
        [DataMember(Name = "emblemObjectiveHash", EmitDefaultValue = false)]
        public uint EmblemObjectiveHash { get; set; }

        /// <summary>
        /// If this item can be equipped, this block will be non-null and will be populated with the conditions under which it can be equipped.
        /// </summary>
        [DataMember(Name = "equippingBlock", EmitDefaultValue = false)]
        public DestinyEquippingBlockDefinition EquippingBlock { get; set; }

        /// <summary>
        /// If this item can be rendered, this block will be non-null and will be populated with rendering information.
        /// </summary>
        [DataMember(Name = "translationBlock", EmitDefaultValue = false)]
        public DestinyItemTranslationBlockDefinition TranslationBlock { get; set; }

        /// <summary>
        /// If this item can be Used or Acquired to gain other items (for instance, how Eververse Boxes can be consumed to get items from the box), this block will be non-null and will give summary information for the items that can be acquired.
        /// </summary>
        [DataMember(Name = "preview", EmitDefaultValue = false)]
        public DestinyItemPreviewBlockDefinition Preview { get; set; }

        /// <summary>
        /// If this item can have a level or stats, this block will be non-null and will be populated with default quality (item level, "quality", and infusion) data. See the block for more details, there's often less upfront information in D2 so you'll want to be aware of how you use quality and item level on the definition level now.
        /// </summary>
        [DataMember(Name = "quality", EmitDefaultValue = false)]
        public DestinyItemQualityBlockDefinition Quality { get; set; }

        /// <summary>
        /// The conceptual "Value" of an item, if any was defined. See the DestinyItemValueBlockDefinition for more details.
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public DestinyItemValueBlockDefinition Value { get; set; }

        /// <summary>
        /// If this item has a known source, this block will be non-null and populated with source information. Unfortunately, at this time we are not generating sources: that is some aggressively manual work which we didn't have time for, and I'm hoping to get back to at some point in the future.
        /// </summary>
        [DataMember(Name = "sourceData", EmitDefaultValue = false)]
        public DestinyItemSourceBlockDefinition SourceData { get; set; }

        /// <summary>
        /// If this item has Objectives (extra tasks that can be accomplished related to the item... most frequently when the item is a Quest Step and the Objectives need to be completed to move on to the next Quest Step), this block will be non-null and the objectives defined herein.
        /// </summary>
        [DataMember(Name = "objectives", EmitDefaultValue = false)]
        public DestinyItemObjectiveBlockDefinition Objectives { get; set; }

        /// <summary>
        /// If this item has available metrics to be shown, this block will be non-null have the appropriate hashes defined.
        /// </summary>
        [DataMember(Name = "metrics", EmitDefaultValue = false)]
        public DestinyItemMetricBlockDefinition Metrics { get; set; }

        /// <summary>
        /// If this item *is* a Plug, this will be non-null and the info defined herein. See DestinyItemPlugDefinition for more information.
        /// </summary>
        [DataMember(Name = "plug", EmitDefaultValue = false)]
        public DestinyItemPlugDefinition Plug { get; set; }

        /// <summary>
        /// If this item has related items in a "Gear Set", this will be non-null and the relationships defined herein.
        /// </summary>
        [DataMember(Name = "gearset", EmitDefaultValue = false)]
        public DestinyItemGearsetBlockDefinition Gearset { get; set; }

        /// <summary>
        /// If this item is a "reward sack" that can be opened to provide other items, this will be non-null and the properties of the sack contained herein.
        /// </summary>
        [DataMember(Name = "sack", EmitDefaultValue = false)]
        public DestinyItemSackBlockDefinition Sack { get; set; }

        /// <summary>
        /// If this item has any Sockets, this will be non-null and the individual sockets on the item will be defined herein.
        /// </summary>
        [DataMember(Name = "sockets", EmitDefaultValue = false)]
        public DestinyItemSocketBlockDefinition Sockets { get; set; }

        /// <summary>
        /// Summary data about the item.
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public DestinyItemSummaryBlockDefinition Summary { get; set; }

        /// <summary>
        /// If the item has a Talent Grid, this will be non-null and the properties of the grid defined herein. Note that, while many items still have talent grids, the only ones with meaningful Nodes still on them will be Subclass/"Build" items.
        /// </summary>
        [DataMember(Name = "talentGrid", EmitDefaultValue = false)]
        public DestinyItemTalentGridBlockDefinition TalentGrid { get; set; }

        /// <summary>
        /// If the item has stats, this block will be defined. It has the "raw" investment stats for the item. These investment stats don't take into account the ways that the items can spawn, nor do they take into account any Stat Group transformations. I have retained them for debugging purposes, but I do not know how useful people will find them.
        /// </summary>
        [DataMember(Name = "investmentStats", EmitDefaultValue = false)]
        public List<DestinyItemInvestmentStatDefinition> InvestmentStats { get; set; }

        /// <summary>
        /// If the item has any *intrinsic* Perks (Perks that it will provide regardless of Sockets, Talent Grid, and other transitory state), they will be defined here.
        /// </summary>
        [DataMember(Name = "perks", EmitDefaultValue = false)]
        public List<DestinyItemPerkEntryDefinition> Perks { get; set; }

        /// <summary>
        /// If the item has any related Lore (DestinyLoreDefinition), this will be the hash identifier you can use to look up the lore definition.
        /// </summary>
        [DataMember(Name = "loreHash", EmitDefaultValue = false)]
        public uint LoreHash { get; set; }

        /// <summary>
        /// There are times when the game will show you a "summary/vague" version of an item - such as a description of its type represented as a DestinyInventoryItemDefinition - rather than display the item itself.
        /// </summary>
        /// <summary>
        /// This happens sometimes when summarizing possible rewards in a tooltip. This is the item displayed instead, if it exists.
        /// </summary>
        [DataMember(Name = "summaryItemHash", EmitDefaultValue = false)]
        public uint SummaryItemHash { get; set; }

        /// <summary>
        /// If any animations were extracted from game content for this item, these will be the definitions of those animations.
        /// </summary>
        [DataMember(Name = "animations", EmitDefaultValue = false)]
        public List<DestinyAnimationReference> Animations { get; set; }

        /// <summary>
        /// BNet may forbid the execution of actions on this item via the API. If that is occurring, allowActions will be set to false.
        /// </summary>
        [DataMember(Name = "allowActions", EmitDefaultValue = false)]
        public bool AllowActions { get; set; }

        /// <summary>
        /// If we added any help or informational URLs about this item, these will be those links.
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public List<HyperlinkReference> Links { get; set; }

        /// <summary>
        /// The boolean will indicate to us (and you!) whether something *could* happen when you transfer this item from the Postmaster that might be considered a "destructive" action.
        /// </summary>
        /// <summary>
        /// It is not feasible currently to tell you (or ourelves!) in a consistent way whether this *will* actually cause a destructive action, so we are playing it safe: if it has the potential to do so, we will not allow it to be transferred from the Postmaster by default. You will need to check for this flag before transferring an item from the Postmaster, or else you'll end up receiving an error.
        /// </summary>
        [DataMember(Name = "doesPostmasterPullHaveSideEffects", EmitDefaultValue = false)]
        public bool DoesPostmasterPullHaveSideEffects { get; set; }

        /// <summary>
        /// The intrinsic transferability of an item.
        /// </summary>
        /// <summary>
        /// I hate that this boolean is negative - but there's a reason.
        /// </summary>
        /// <summary>
        /// Just because an item is intrinsically transferrable doesn't mean that it can be transferred, and we don't want to imply that this is the only source of that transferability.
        /// </summary>
        [DataMember(Name = "nonTransferrable", EmitDefaultValue = false)]
        public bool NonTransferrable { get; set; }

        /// <summary>
        /// BNet attempts to make a more formal definition of item "Categories", as defined by DestinyItemCategoryDefinition. This is a list of all Categories that we were able to algorithmically determine that this item is a member of. (for instance, that it's a "Weapon", that it's an "Auto Rifle", etc...)
        /// </summary>
        /// <summary>
        /// The algorithm for these is, unfortunately, volatile. If you believe you see a miscategorized item, please let us know on the Bungie API forums.
        /// </summary>
        [DataMember(Name = "itemCategoryHashes", EmitDefaultValue = false)]
        public List<uint> ItemCategoryHashes { get; set; }

        /// <summary>
        /// In Destiny 1, we identified some items as having particular categories that we'd like to know about for various internal logic purposes. These are defined in SpecialItemType, and while these days the itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
        /// </summary>
        [DataMember(Name = "specialItemType", EmitDefaultValue = false)]
        public SpecialItemType SpecialItemType { get; set; }

        /// <summary>
        /// A value indicating the "base" the of the item. This enum is a useful but dramatic oversimplification of what it means for an item to have a "Type". Still, it's handy in many situations.
        /// </summary>
        /// <summary>
        /// itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
        /// </summary>
        [DataMember(Name = "itemType", EmitDefaultValue = false)]
        public DestinyItemType ItemType { get; set; }

        /// <summary>
        /// A value indicating the "sub-type" of the item. For instance, where an item might have an itemType value "Weapon", this will be something more specific like "Auto Rifle".
        /// </summary>
        /// <summary>
        /// itemCategoryHashes are the preferred way of identifying types, we have retained this enum for its convenience.
        /// </summary>
        [DataMember(Name = "itemSubType", EmitDefaultValue = false)]
        public DestinyItemSubType ItemSubType { get; set; }

        /// <summary>
        /// We run a similarly weak-sauce algorithm to try and determine whether an item is restricted to a specific class. If we find it to be restricted in such a way, we set this classType property to match the class' enumeration value so that users can easily identify class restricted items.
        /// </summary>
        /// <summary>
        /// If you see a mis-classed item, please inform the developers in the Bungie API forum.
        /// </summary>
        [DataMember(Name = "classType", EmitDefaultValue = false)]
        public DestinyClass ClassType { get; set; }

        /// <summary>
        /// Some weapons and plugs can have a "Breaker Type": a special ability that works sort of like damage type vulnerabilities. This is (almost?) always set on items by plugs.
        /// </summary>
        [DataMember(Name = "breakerType", EmitDefaultValue = false)]
        public DestinyBreakerType BreakerType { get; set; }

        /// <summary>
        /// Since we also have a breaker type definition, this is the hash for that breaker type for your convenience. Whether you use the enum or hash and look up the definition depends on what's cleanest for your code.
        /// </summary>
        [DataMember(Name = "breakerTypeHash", EmitDefaultValue = false)]
        public uint BreakerTypeHash { get; set; }

        /// <summary>
        /// If true, then you will be allowed to equip the item if you pass its other requirements.
        /// </summary>
        /// <summary>
        /// This being false means that you cannot equip the item under any circumstances.
        /// </summary>
        [DataMember(Name = "equippable", EmitDefaultValue = false)]
        public bool Equippable { get; set; }

        /// <summary>
        /// Theoretically, an item can have many possible damage types. In *practice*, this is not true, but just in case weapons start being made that have multiple (for instance, an item where a socket has reusable plugs for every possible damage type that you can choose from freely), this field will return all of the possible damage types that are available to the weapon by default.
        /// </summary>
        [DataMember(Name = "damageTypeHashes", EmitDefaultValue = false)]
        public List<uint> DamageTypeHashes { get; set; }

        /// <summary>
        /// This is the list of all damage types that we know ahead of time the item can take on. Unfortunately, this does not preclude the possibility of something funky happening to give the item a damage type that cannot be predicted beforehand: for example, if some designer decides to create arbitrary non-reusable plugs that cause damage type to change.
        /// </summary>
        /// <summary>
        /// This damage type prediction will only use the following to determine potential damage types:
        /// </summary>
        /// <summary>
        /// - Intrinsic perks
        /// </summary>
        /// <summary>
        /// - Talent Node perks
        /// </summary>
        /// <summary>
        /// - Known, reusable plugs for sockets
        /// </summary>
        [DataMember(Name = "damageTypes", EmitDefaultValue = false)]
        public List<DamageType> DamageTypes { get; set; }

        /// <summary>
        /// If the item has a damage type that could be considered to be default, it will be populated here.
        /// </summary>
        /// <summary>
        /// For various upsetting reasons, it's surprisingly cumbersome to figure this out. I hope you're happy.
        /// </summary>
        [DataMember(Name = "defaultDamageType", EmitDefaultValue = false)]
        public DamageType DefaultDamageType { get; set; }

        /// <summary>
        /// Similar to defaultDamageType, but represented as the hash identifier for a DestinyDamageTypeDefinition.
        /// </summary>
        /// <summary>
        /// I will likely regret leaving in the enumeration versions of these properties, but for now they're very convenient.
        /// </summary>
        [DataMember(Name = "defaultDamageTypeHash", EmitDefaultValue = false)]
        public uint DefaultDamageTypeHash { get; set; }

        /// <summary>
        /// If this item is related directly to a Season of Destiny, this is the hash identifier for that season.
        /// </summary>
        [DataMember(Name = "seasonHash", EmitDefaultValue = false)]
        public uint SeasonHash { get; set; }

        /// <summary>
        /// If true, this is a dummy vendor-wrapped item template. Items purchased from Eververse will be "wrapped" by one of these items so that we can safely provide refund capabilities before the item is "unwrapped".
        /// </summary>
        [DataMember(Name = "isWrapper", EmitDefaultValue = false)]
        public bool IsWrapper { get; set; }

        /// <summary>
        /// Traits are metadata tags applied to this item. For example: armor slot, weapon type, foundry, faction, etc. These IDs come from the game and don't map to any content, but should still be useful.
        /// </summary>
        [DataMember(Name = "traitIds", EmitDefaultValue = false)]
        public List<string> TraitIds { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
        /// </summary>
        /// <summary>
        /// When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public long Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        [DataMember(Name = "redacted", EmitDefaultValue = false)]
        public bool Redacted { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyInventoryItemDefinition);
        }

        public bool Equals(DestinyInventoryItemDefinition input)
        {
            if (input == null) return false;

            return
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    TooltipNotifications == input.TooltipNotifications ||
                    (TooltipNotifications != null && TooltipNotifications.Equals(input.TooltipNotifications))
                ) &&
                (
                    CollectibleHash == input.CollectibleHash ||
                    (CollectibleHash != null && CollectibleHash.Equals(input.CollectibleHash))
                ) &&
                (
                    SecondaryIcon == input.SecondaryIcon ||
                    (SecondaryIcon != null && SecondaryIcon.Equals(input.SecondaryIcon))
                ) &&
                (
                    SecondaryOverlay == input.SecondaryOverlay ||
                    (SecondaryOverlay != null && SecondaryOverlay.Equals(input.SecondaryOverlay))
                ) &&
                (
                    SecondarySpecial == input.SecondarySpecial ||
                    (SecondarySpecial != null && SecondarySpecial.Equals(input.SecondarySpecial))
                ) &&
                (
                    BackgroundColor == input.BackgroundColor ||
                    (BackgroundColor != null && BackgroundColor.Equals(input.BackgroundColor))
                ) &&
                (
                    Screenshot == input.Screenshot ||
                    (Screenshot != null && Screenshot.Equals(input.Screenshot))
                ) &&
                (
                    ItemTypeDisplayName == input.ItemTypeDisplayName ||
                    (ItemTypeDisplayName != null && ItemTypeDisplayName.Equals(input.ItemTypeDisplayName))
                ) &&
                (
                    UiItemDisplayStyle == input.UiItemDisplayStyle ||
                    (UiItemDisplayStyle != null && UiItemDisplayStyle.Equals(input.UiItemDisplayStyle))
                ) &&
                (
                    ItemTypeAndTierDisplayName == input.ItemTypeAndTierDisplayName ||
                    (ItemTypeAndTierDisplayName != null && ItemTypeAndTierDisplayName.Equals(input.ItemTypeAndTierDisplayName))
                ) &&
                (
                    DisplaySource == input.DisplaySource ||
                    (DisplaySource != null && DisplaySource.Equals(input.DisplaySource))
                ) &&
                (
                    TooltipStyle == input.TooltipStyle ||
                    (TooltipStyle != null && TooltipStyle.Equals(input.TooltipStyle))
                ) &&
                (
                    Action == input.Action ||
                    (Action != null && Action.Equals(input.Action))
                ) &&
                (
                    Inventory == input.Inventory ||
                    (Inventory != null && Inventory.Equals(input.Inventory))
                ) &&
                (
                    SetData == input.SetData ||
                    (SetData != null && SetData.Equals(input.SetData))
                ) &&
                (
                    Stats == input.Stats ||
                    (Stats != null && Stats.Equals(input.Stats))
                ) &&
                (
                    EmblemObjectiveHash == input.EmblemObjectiveHash ||
                    (EmblemObjectiveHash != null && EmblemObjectiveHash.Equals(input.EmblemObjectiveHash))
                ) &&
                (
                    EquippingBlock == input.EquippingBlock ||
                    (EquippingBlock != null && EquippingBlock.Equals(input.EquippingBlock))
                ) &&
                (
                    TranslationBlock == input.TranslationBlock ||
                    (TranslationBlock != null && TranslationBlock.Equals(input.TranslationBlock))
                ) &&
                (
                    Preview == input.Preview ||
                    (Preview != null && Preview.Equals(input.Preview))
                ) &&
                (
                    Quality == input.Quality ||
                    (Quality != null && Quality.Equals(input.Quality))
                ) &&
                (
                    Value == input.Value ||
                    (Value != null && Value.Equals(input.Value))
                ) &&
                (
                    SourceData == input.SourceData ||
                    (SourceData != null && SourceData.Equals(input.SourceData))
                ) &&
                (
                    Objectives == input.Objectives ||
                    (Objectives != null && Objectives.Equals(input.Objectives))
                ) &&
                (
                    Metrics == input.Metrics ||
                    (Metrics != null && Metrics.Equals(input.Metrics))
                ) &&
                (
                    Plug == input.Plug ||
                    (Plug != null && Plug.Equals(input.Plug))
                ) &&
                (
                    Gearset == input.Gearset ||
                    (Gearset != null && Gearset.Equals(input.Gearset))
                ) &&
                (
                    Sack == input.Sack ||
                    (Sack != null && Sack.Equals(input.Sack))
                ) &&
                (
                    Sockets == input.Sockets ||
                    (Sockets != null && Sockets.Equals(input.Sockets))
                ) &&
                (
                    Summary == input.Summary ||
                    (Summary != null && Summary.Equals(input.Summary))
                ) &&
                (
                    TalentGrid == input.TalentGrid ||
                    (TalentGrid != null && TalentGrid.Equals(input.TalentGrid))
                ) &&
                (
                    InvestmentStats == input.InvestmentStats ||
                    (InvestmentStats != null && InvestmentStats.Equals(input.InvestmentStats))
                ) &&
                (
                    Perks == input.Perks ||
                    (Perks != null && Perks.Equals(input.Perks))
                ) &&
                (
                    LoreHash == input.LoreHash ||
                    (LoreHash != null && LoreHash.Equals(input.LoreHash))
                ) &&
                (
                    SummaryItemHash == input.SummaryItemHash ||
                    (SummaryItemHash != null && SummaryItemHash.Equals(input.SummaryItemHash))
                ) &&
                (
                    Animations == input.Animations ||
                    (Animations != null && Animations.Equals(input.Animations))
                ) &&
                (
                    AllowActions == input.AllowActions ||
                    (AllowActions != null && AllowActions.Equals(input.AllowActions))
                ) &&
                (
                    Links == input.Links ||
                    (Links != null && Links.Equals(input.Links))
                ) &&
                (
                    DoesPostmasterPullHaveSideEffects == input.DoesPostmasterPullHaveSideEffects ||
                    (DoesPostmasterPullHaveSideEffects != null && DoesPostmasterPullHaveSideEffects.Equals(input.DoesPostmasterPullHaveSideEffects))
                ) &&
                (
                    NonTransferrable == input.NonTransferrable ||
                    (NonTransferrable != null && NonTransferrable.Equals(input.NonTransferrable))
                ) &&
                (
                    ItemCategoryHashes == input.ItemCategoryHashes ||
                    (ItemCategoryHashes != null && ItemCategoryHashes.Equals(input.ItemCategoryHashes))
                ) &&
                (
                    SpecialItemType == input.SpecialItemType ||
                    (SpecialItemType != null && SpecialItemType.Equals(input.SpecialItemType))
                ) &&
                (
                    ItemType == input.ItemType ||
                    (ItemType != null && ItemType.Equals(input.ItemType))
                ) &&
                (
                    ItemSubType == input.ItemSubType ||
                    (ItemSubType != null && ItemSubType.Equals(input.ItemSubType))
                ) &&
                (
                    ClassType == input.ClassType ||
                    (ClassType != null && ClassType.Equals(input.ClassType))
                ) &&
                (
                    BreakerType == input.BreakerType ||
                    (BreakerType != null && BreakerType.Equals(input.BreakerType))
                ) &&
                (
                    BreakerTypeHash == input.BreakerTypeHash ||
                    (BreakerTypeHash != null && BreakerTypeHash.Equals(input.BreakerTypeHash))
                ) &&
                (
                    Equippable == input.Equippable ||
                    (Equippable != null && Equippable.Equals(input.Equippable))
                ) &&
                (
                    DamageTypeHashes == input.DamageTypeHashes ||
                    (DamageTypeHashes != null && DamageTypeHashes.Equals(input.DamageTypeHashes))
                ) &&
                (
                    DamageTypes == input.DamageTypes ||
                    (DamageTypes != null && DamageTypes.Equals(input.DamageTypes))
                ) &&
                (
                    DefaultDamageType == input.DefaultDamageType ||
                    (DefaultDamageType != null && DefaultDamageType.Equals(input.DefaultDamageType))
                ) &&
                (
                    DefaultDamageTypeHash == input.DefaultDamageTypeHash ||
                    (DefaultDamageTypeHash != null && DefaultDamageTypeHash.Equals(input.DefaultDamageTypeHash))
                ) &&
                (
                    SeasonHash == input.SeasonHash ||
                    (SeasonHash != null && SeasonHash.Equals(input.SeasonHash))
                ) &&
                (
                    IsWrapper == input.IsWrapper ||
                    (IsWrapper != null && IsWrapper.Equals(input.IsWrapper))
                ) &&
                (
                    TraitIds == input.TraitIds ||
                    (TraitIds != null && TraitIds.Equals(input.TraitIds))
                ) &&
                (
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
                (
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
                (
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
        }
    }
}

