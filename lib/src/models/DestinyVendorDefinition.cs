using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// These are the definitions for Vendors.
	/// In Destiny, a Vendor can be a lot of things - some things that you wouldn&#39;t expect, and some things that you don&#39;t even see directly in the game. Vendors are the Dolly Levi of the Destiny universe.
	/// - Traditional Vendors as you see in game: people who you come up to and who give you quests, rewards, or who you can buy things from.
	/// - Kiosks&#x2F;Collections, which are really just Vendors that don&#39;t charge currency (or charge some pittance of a currency) and whose gating for purchases revolves more around your character&#39;s state.
	/// - Previews for rewards or the contents of sacks. These are implemented as Vendors, where you can&#39;t actually purchase from them but the items that they have for sale and the categories of sale items reflect the rewards or contents of the sack. This is so that the game could reuse the existing Vendor display UI for rewards and save a bunch of wheel reinvention.
	/// - Item Transfer capabilities, like the Vault and Postmaster. Vendors can have &quot;acceptedItem&quot; buckets that determine the source and destination buckets for transfers. When you interact with such a vendor, these buckets are what gets shown in the UI instead of any items that the Vendor would have for sale. Yep, the Vault is a vendor.
	/// It is pretty much guaranteed that they&#39;ll be used for even more features in the future. They have come to be seen more as generic categorized containers for items than &quot;vendors&quot; in a traditional sense, for better or worse.
	/// Where possible and time allows, we&#39;ll attempt to split those out into their own more digestible derived &quot;Definitions&quot;: but often time does not allow that, as you can see from the above ways that vendors are used which we never split off from Vendor Definitions externally.
	/// Since Vendors are so many things to so many parts of the game, the definition is understandably complex. You will want to combine this data with live Vendor information from the API when it is available.
	[DataContract]
	public class DestinyVendorDefinition{

		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyVendorDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// If the vendor has a custom localized string describing the "buy" action, that is returned here.
		/// </summary>
		[DataMember(Name="buyString", EmitDefaultValue=false)]
		public string BuyString { get; set; }

		/// <summary>
		/// Ditto for selling. Not that you can sell items to a vendor anymore. Will it come back? Who knows. The string's still there.
		/// </summary>
		[DataMember(Name="sellString", EmitDefaultValue=false)]
		public string SellString { get; set; }

		/// <summary>
		/// If the vendor has an item that should be displayed as the "featured" item, this is the hash identifier for that DestinyVendorItemDefinition.
		/// </summary>
		/// <summary>
		/// Apparently this is usually a related currency, like a reputation token. But it need not be restricted to that.
		/// </summary>
		[DataMember(Name="displayItemHash", EmitDefaultValue=false)]
		public uint DisplayItemHash { get; set; }

		/// <summary>
		/// If this is true, you aren't allowed to buy whatever the vendor is selling.
		/// </summary>
		[DataMember(Name="inhibitBuying", EmitDefaultValue=false)]
		public bool InhibitBuying { get; set; }

		/// <summary>
		/// If this is true, you're not allowed to sell whatever the vendor is buying.
		/// </summary>
		[DataMember(Name="inhibitSelling", EmitDefaultValue=false)]
		public bool InhibitSelling { get; set; }

		/// <summary>
		/// If the Vendor has a faction, this hash will be valid and point to a DestinyFactionDefinition.
		/// </summary>
		/// <summary>
		/// The game UI and BNet often mine the faction definition for additional elements and details to place on the screen, such as the faction's Progression status (aka "Reputation").
		/// </summary>
		[DataMember(Name="factionHash", EmitDefaultValue=false)]
		public uint FactionHash { get; set; }

		/// <summary>
		/// A number used for calculating the frequency of a vendor's inventory resetting/refreshing.
		/// </summary>
		/// <summary>
		/// Don't worry about calculating this - we do it on the server side and send you the next refresh date with the live data.
		/// </summary>
		[DataMember(Name="resetIntervalMinutes", EmitDefaultValue=false)]
		public long ResetIntervalMinutes { get; set; }

		/// <summary>
		/// Again, used for reset/refreshing of inventory. Don't worry too much about it. Unless you want to.
		/// </summary>
		[DataMember(Name="resetOffsetMinutes", EmitDefaultValue=false)]
		public long ResetOffsetMinutes { get; set; }

		/// <summary>
		/// If an item can't be purchased from the vendor, there may be many "custom"/game state specific reasons why not.
		/// </summary>
		/// <summary>
		/// This is a list of localized strings with messages for those custom failures. The live BNet data will return a failureIndexes property for items that can't be purchased: using those values to index into this array, you can show the user the appropriate failure message for the item that can't be bought.
		/// </summary>
		[DataMember(Name="failureStrings", EmitDefaultValue=false)]
		public List<string> FailureStrings { get; set; }

		/// <summary>
		/// If we were able to predict the dates when this Vendor will be visible/available, this will be the list of those date ranges. Sadly, we're not able to predict this very frequently, so this will often be useless data.
		/// </summary>
		[DataMember(Name="unlockRanges", EmitDefaultValue=false)]
		public List<DateRange> UnlockRanges { get; set; }

		/// <summary>
		/// The internal identifier for the Vendor. A holdover from the old days of Vendors, but we don't have time to refactor it away.
		/// </summary>
		[DataMember(Name="vendorIdentifier", EmitDefaultValue=false)]
		public string VendorIdentifier { get; set; }

		/// <summary>
		/// A portrait of the Vendor's smiling mug. Or frothing tentacles.
		/// </summary>
		[DataMember(Name="vendorPortrait", EmitDefaultValue=false)]
		public string VendorPortrait { get; set; }

		/// <summary>
		/// If the vendor has a custom banner image, that can be found here.
		/// </summary>
		[DataMember(Name="vendorBanner", EmitDefaultValue=false)]
		public string VendorBanner { get; set; }

		/// <summary>
		/// If a vendor is not enabled, we won't even save the vendor's definition, and we won't return any items or info about them. It's as if they don't exist.
		/// </summary>
		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool Enabled { get; set; }

		/// <summary>
		/// If a vendor is not visible, we still have and will give vendor definition info, but we won't use them for things like Advisors or UI.
		/// </summary>
		[DataMember(Name="visible", EmitDefaultValue=false)]
		public bool Visible { get; set; }

		/// <summary>
		/// The identifier of the VendorCategoryDefinition for this vendor's subcategory.
		/// </summary>
		[DataMember(Name="vendorSubcategoryIdentifier", EmitDefaultValue=false)]
		public string VendorSubcategoryIdentifier { get; set; }

		/// <summary>
		/// If TRUE, consolidate categories that only differ by trivial properties (such as having minor differences in name)
		/// </summary>
		[DataMember(Name="consolidateCategories", EmitDefaultValue=false)]
		public bool ConsolidateCategories { get; set; }

		/// <summary>
		/// Describes "actions" that can be performed on a vendor. Currently, none of these exist. But theoretically a Vendor could let you interact with it by performing actions. We'll see what these end up looking like if they ever get used.
		/// </summary>
		[DataMember(Name="actions", EmitDefaultValue=false)]
		public List<DestinyVendorActionDefinition> Actions { get; set; }

		/// <summary>
		/// These are the headers for sections of items that the vendor is selling. When you see items organized by category in the header, it is these categories that it is showing.
		/// </summary>
		/// <summary>
		/// Well, technically not *exactly* these. On BNet, it doesn't make sense to have categories be "paged" as we do in Destiny, so we run some heuristics to attempt to aggregate pages of categories together. 
		/// </summary>
		/// <summary>
		/// These are the categories post-concatenation, if the vendor had concatenation applied. If you want the pre-aggregated category data, use originalCategories.
		/// </summary>
		[DataMember(Name="categories", EmitDefaultValue=false)]
		public List<DestinyVendorCategoryEntryDefinition> Categories { get; set; }

		/// <summary>
		/// See the categories property for a description of categories and why originalCategories exists.
		/// </summary>
		[DataMember(Name="originalCategories", EmitDefaultValue=false)]
		public List<DestinyVendorCategoryEntryDefinition> OriginalCategories { get; set; }

		/// <summary>
		/// Display Categories are different from "categories" in that these are specifically for visual grouping and display of categories in Vendor UI. 
		/// </summary>
		/// <summary>
		/// The "categories" structure is for validation of the contained items, and can be categorized entirely separately from "Display Categories", there need be and often will be no meaningful relationship between the two.
		/// </summary>
		[DataMember(Name="displayCategories", EmitDefaultValue=false)]
		public List<DestinyDisplayCategoryDefinition> DisplayCategories { get; set; }

		/// <summary>
		/// In addition to selling items, vendors can have "interactions": UI where you "talk" with the vendor and they offer you a reward, some item, or merely acknowledge via dialog that you did something cool.
		/// </summary>
		[DataMember(Name="interactions", EmitDefaultValue=false)]
		public List<DestinyVendorInteractionDefinition> Interactions { get; set; }

		/// <summary>
		/// If the vendor shows you items from your own inventory - such as the Vault vendor does - this data describes the UI around showing those inventory buckets and which ones get shown.
		/// </summary>
		[DataMember(Name="inventoryFlyouts", EmitDefaultValue=false)]
		public List<DestinyVendorInventoryFlyoutDefinition> InventoryFlyouts { get; set; }

		/// <summary>
		/// If the vendor sells items (or merely has a list of items to show like the "Sack" vendors do), this is the list of those items that the vendor can sell. From this list, only a subset will be available from the vendor at any given time, selected randomly and reset on the vendor's refresh interval.
		/// </summary>
		/// <summary>
		/// Note that a vendor can sell the same item multiple ways: for instance, nothing stops a vendor from selling you some specific weapon but using two different currencies, or the same weapon at multiple "item levels".
		/// </summary>
		[DataMember(Name="itemList", EmitDefaultValue=false)]
		public List<DestinyVendorItemDefinition> ItemList { get; set; }

		/// <summary>
		/// BNet doesn't use this data yet, but it appears to be an optional list of flavor text about services that the Vendor can provide.
		/// </summary>
		[DataMember(Name="services", EmitDefaultValue=false)]
		public List<DestinyVendorServiceDefinition> Services { get; set; }

		/// <summary>
		/// If the Vendor is actually a vehicle for the transferring of items (like the Vault and Postmaster vendors), this defines the list of source->destination buckets for transferring.
		/// </summary>
		[DataMember(Name="acceptedItems", EmitDefaultValue=false)]
		public List<DestinyVendorAcceptedItemDefinition> AcceptedItems { get; set; }

		/// <summary>
		/// As many of you know, Vendor data has historically been pretty brutal on the BNet servers. In an effort to reduce this workload, only Vendors with this flag set will be returned on Vendor requests. This allows us to filter out Vendors that don't dynamic data that's particularly useful: things like "Preview/Sack" vendors, for example, that you can usually suss out the details for using just the definitions themselves.
		/// </summary>
		[DataMember(Name="returnWithVendorRequest", EmitDefaultValue=false)]
		public bool ReturnWithVendorRequest { get; set; }

		/// <summary>
		/// A vendor can be at different places in the world depending on the game/character/account state. This is the list of possible locations for the vendor, along with conditions we use to determine which one is currently active.
		/// </summary>
		[DataMember(Name="locations", EmitDefaultValue=false)]
		public List<DestinyVendorLocationDefinition> Locations { get; set; }

		/// <summary>
		/// A vendor can be a part of 0 or 1 "groups" at a time: a group being a collection of Vendors related by either location or function/purpose. It's used for our our Companion Vendor UI. Only one of these can be active for a Vendor at a time.
		/// </summary>
		[DataMember(Name="groups", EmitDefaultValue=false)]
		public List<DestinyVendorGroupReference> Groups { get; set; }

		/// <summary>
		/// Some items don't make sense to return in the API, for example because they represent an action to be performed rather than an item being sold. I'd rather we not do this, but at least in the short term this is a workable workaround.
		/// </summary>
		[DataMember(Name="ignoreSaleItemHashes", EmitDefaultValue=false)]
		public List<uint> IgnoreSaleItemHashes { get; set; }

		/// <summary>
		/// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
		/// </summary>
		/// <summary>
		/// When entities refer to each other in Destiny content, it is this hash that they are referring to.
		/// </summary>
		[DataMember(Name="hash", EmitDefaultValue=false)]
		public uint Hash { get; set; }

		/// <summary>
		/// The index of the entity as it was found in the investment tables.
		/// </summary>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public long Index { get; set; }

		/// <summary>
		/// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
		/// </summary>
		[DataMember(Name="redacted", EmitDefaultValue=false)]
		public bool Redacted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorDefinition);
        }

		public bool Equals(DestinyVendorDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    BuyString == input.BuyString ||
                    (BuyString != null && BuyString.Equals(input.BuyString))
                ) &&
				(
                    SellString == input.SellString ||
                    (SellString != null && SellString.Equals(input.SellString))
                ) &&
				(
                    DisplayItemHash == input.DisplayItemHash ||
                    (DisplayItemHash != null && DisplayItemHash.Equals(input.DisplayItemHash))
                ) &&
				(
                    InhibitBuying == input.InhibitBuying ||
                    (InhibitBuying != null && InhibitBuying.Equals(input.InhibitBuying))
                ) &&
				(
                    InhibitSelling == input.InhibitSelling ||
                    (InhibitSelling != null && InhibitSelling.Equals(input.InhibitSelling))
                ) &&
				(
                    FactionHash == input.FactionHash ||
                    (FactionHash != null && FactionHash.Equals(input.FactionHash))
                ) &&
				(
                    ResetIntervalMinutes == input.ResetIntervalMinutes ||
                    (ResetIntervalMinutes != null && ResetIntervalMinutes.Equals(input.ResetIntervalMinutes))
                ) &&
				(
                    ResetOffsetMinutes == input.ResetOffsetMinutes ||
                    (ResetOffsetMinutes != null && ResetOffsetMinutes.Equals(input.ResetOffsetMinutes))
                ) &&
				(
                    FailureStrings == input.FailureStrings ||
                    (FailureStrings != null && FailureStrings.Equals(input.FailureStrings))
                ) &&
				(
                    UnlockRanges == input.UnlockRanges ||
                    (UnlockRanges != null && UnlockRanges.Equals(input.UnlockRanges))
                ) &&
				(
                    VendorIdentifier == input.VendorIdentifier ||
                    (VendorIdentifier != null && VendorIdentifier.Equals(input.VendorIdentifier))
                ) &&
				(
                    VendorPortrait == input.VendorPortrait ||
                    (VendorPortrait != null && VendorPortrait.Equals(input.VendorPortrait))
                ) &&
				(
                    VendorBanner == input.VendorBanner ||
                    (VendorBanner != null && VendorBanner.Equals(input.VendorBanner))
                ) &&
				(
                    Enabled == input.Enabled ||
                    (Enabled != null && Enabled.Equals(input.Enabled))
                ) &&
				(
                    Visible == input.Visible ||
                    (Visible != null && Visible.Equals(input.Visible))
                ) &&
				(
                    VendorSubcategoryIdentifier == input.VendorSubcategoryIdentifier ||
                    (VendorSubcategoryIdentifier != null && VendorSubcategoryIdentifier.Equals(input.VendorSubcategoryIdentifier))
                ) &&
				(
                    ConsolidateCategories == input.ConsolidateCategories ||
                    (ConsolidateCategories != null && ConsolidateCategories.Equals(input.ConsolidateCategories))
                ) &&
				(
                    Actions == input.Actions ||
                    (Actions != null && Actions.Equals(input.Actions))
                ) &&
				(
                    Categories == input.Categories ||
                    (Categories != null && Categories.Equals(input.Categories))
                ) &&
				(
                    OriginalCategories == input.OriginalCategories ||
                    (OriginalCategories != null && OriginalCategories.Equals(input.OriginalCategories))
                ) &&
				(
                    DisplayCategories == input.DisplayCategories ||
                    (DisplayCategories != null && DisplayCategories.Equals(input.DisplayCategories))
                ) &&
				(
                    Interactions == input.Interactions ||
                    (Interactions != null && Interactions.Equals(input.Interactions))
                ) &&
				(
                    InventoryFlyouts == input.InventoryFlyouts ||
                    (InventoryFlyouts != null && InventoryFlyouts.Equals(input.InventoryFlyouts))
                ) &&
				(
                    ItemList == input.ItemList ||
                    (ItemList != null && ItemList.Equals(input.ItemList))
                ) &&
				(
                    Services == input.Services ||
                    (Services != null && Services.Equals(input.Services))
                ) &&
				(
                    AcceptedItems == input.AcceptedItems ||
                    (AcceptedItems != null && AcceptedItems.Equals(input.AcceptedItems))
                ) &&
				(
                    ReturnWithVendorRequest == input.ReturnWithVendorRequest ||
                    (ReturnWithVendorRequest != null && ReturnWithVendorRequest.Equals(input.ReturnWithVendorRequest))
                ) &&
				(
                    Locations == input.Locations ||
                    (Locations != null && Locations.Equals(input.Locations))
                ) &&
				(
                    Groups == input.Groups ||
                    (Groups != null && Groups.Equals(input.Groups))
                ) &&
				(
                    IgnoreSaleItemHashes == input.IgnoreSaleItemHashes ||
                    (IgnoreSaleItemHashes != null && IgnoreSaleItemHashes.Equals(input.IgnoreSaleItemHashes))
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

