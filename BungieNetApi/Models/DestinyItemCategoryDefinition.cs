using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// In an attempt to categorize items by type, usage, and other interesting properties, we created DestinyItemCategoryDefinition: information about types that is assembled using a set of heuristics that examine the properties of an item such as what inventory bucket it's in, its item type name, and whether it has or is missing certain blocks of data.
	/// </summary>
	/// <summary>
	/// This heuristic is imperfect, however. If you find an item miscategorized, let us know on the Bungie API forums!
	/// </summary>
	/// <summary>
	/// We then populate all of the categories that we think an item belongs to in its DestinyInventoryItemDefinition.itemCategoryHashes property. You can use that to provide your own custom item filtering, sorting, aggregating... go nuts on it! And let us know if you see more categories that you wish would be added!
	/// </summary>
	[DataContract]
	public class DestinyItemCategoryDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// If True, this category should be visible in UI. Sometimes we make categories that we don't think are interesting externally. It's up to you if you want to skip on showing them.
		/// </summary>
		[DataMember(Name="visible", EmitDefaultValue=false)]
		public bool Visible { get; set; }

		/// <summary>
		/// If True, this category has been deprecated: it may have no items left, or there may be only legacy items that remain in it which are no longer relevant to the game.
		/// </summary>
		[DataMember(Name="deprecated", EmitDefaultValue=false)]
		public bool Deprecated { get; set; }

		/// <summary>
		/// A shortened version of the title. The reason why we have this is because the Armory in German had titles that were too long to display in our UI, so these were localized abbreviated versions of those categories. The property still exists today, even though the Armory doesn't exist for D2... yet.
		/// </summary>
		[DataMember(Name="shortTitle", EmitDefaultValue=false)]
		public string ShortTitle { get; set; }

		/// <summary>
		/// The janky regular expression we used against the item type to try and discern whether the item belongs to this category.
		/// </summary>
		[DataMember(Name="itemTypeRegex", EmitDefaultValue=false)]
		public string ItemTypeRegex { get; set; }

		/// <summary>
		/// If the item in question has this category, it also should have this breaker type.
		/// </summary>
		[DataMember(Name="grantDestinyBreakerType", EmitDefaultValue=false)]
		public DestinyBreakerType GrantDestinyBreakerType { get; set; }

		/// <summary>
		/// If the item is a plug, this is the identifier we expect to find associated with it if it is in this category.
		/// </summary>
		[DataMember(Name="plugCategoryIdentifier", EmitDefaultValue=false)]
		public string PlugCategoryIdentifier { get; set; }

		/// <summary>
		/// If the item type matches this janky regex, it does *not* belong to this category.
		/// </summary>
		[DataMember(Name="itemTypeRegexNot", EmitDefaultValue=false)]
		public string ItemTypeRegexNot { get; set; }

		/// <summary>
		/// If the item belongs to this bucket, it does belong to this category.
		/// </summary>
		[DataMember(Name="originBucketIdentifier", EmitDefaultValue=false)]
		public string OriginBucketIdentifier { get; set; }

		/// <summary>
		/// If an item belongs to this category, it will also receive this item type. This is now how DestinyItemType is populated for items: it used to be an even jankier process, but that's a story that requires more alcohol.
		/// </summary>
		[DataMember(Name="grantDestinyItemType", EmitDefaultValue=false)]
		public DestinyItemType GrantDestinyItemType { get; set; }

		/// <summary>
		/// If an item belongs to this category, it will also receive this subtype enum value.
		/// </summary>
		/// <summary>
		/// I know what you're thinking - what if it belongs to multiple categories that provide sub-types?
		/// </summary>
		/// <summary>
		/// The last one processed wins, as is the case with all of these "grant" enums. Now you can see one reason why we moved away from these enums... but they're so convenient when they work, aren't they?
		/// </summary>
		[DataMember(Name="grantDestinySubType", EmitDefaultValue=false)]
		public DestinyItemSubType GrantDestinySubType { get; set; }

		/// <summary>
		/// If an item belongs to this category, it will also get this class restriction enum value.
		/// </summary>
		/// <summary>
		/// See the other "grant"-prefixed properties on this definition for my color commentary.
		/// </summary>
		[DataMember(Name="grantDestinyClass", EmitDefaultValue=false)]
		public DestinyClass GrantDestinyClass { get; set; }

		/// <summary>
		/// The traitId that can be found on items that belong to this category.
		/// </summary>
		[DataMember(Name="traitId", EmitDefaultValue=false)]
		public string TraitId { get; set; }

		/// <summary>
		/// If this category is a "parent" category of other categories, those children will have their hashes listed in rendering order here, and can be looked up using these hashes against DestinyItemCategoryDefinition.
		/// </summary>
		/// <summary>
		/// In this way, you can build up a visual hierarchy of item categories. That's what we did, and you can do it too. I believe in you. Yes, you, Carl.
		/// </summary>
		/// <summary>
		/// (I hope someone named Carl reads this someday)
		/// </summary>
		[DataMember(Name="groupedCategoryHashes", EmitDefaultValue=false)]
		public List<uint> GroupedCategoryHashes { get; set; }

		/// <summary>
		/// All item category hashes of "parent" categories: categories that contain this as a child through the hierarchy of groupedCategoryHashes. It's a bit redundant, but having this child-centric list speeds up some calculations.
		/// </summary>
		[DataMember(Name="parentCategoryHashes", EmitDefaultValue=false)]
		public List<uint> ParentCategoryHashes { get; set; }

		/// <summary>
		/// If true, this category is only used for grouping, and should not be evaluated with its own checks. Rather, the item only has this category if it has one of its child categories.
		/// </summary>
		[DataMember(Name="groupCategoryOnly", EmitDefaultValue=false)]
		public bool GroupCategoryOnly { get; set; }

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
            return this.Equals(input as DestinyItemCategoryDefinition);
        }

		public bool Equals(DestinyItemCategoryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    Visible == input.Visible ||
                    (Visible != null && Visible.Equals(input.Visible))
                ) &&
				(
                    Deprecated == input.Deprecated ||
                    (Deprecated != null && Deprecated.Equals(input.Deprecated))
                ) &&
				(
                    ShortTitle == input.ShortTitle ||
                    (ShortTitle != null && ShortTitle.Equals(input.ShortTitle))
                ) &&
				(
                    ItemTypeRegex == input.ItemTypeRegex ||
                    (ItemTypeRegex != null && ItemTypeRegex.Equals(input.ItemTypeRegex))
                ) &&
				(
                    GrantDestinyBreakerType == input.GrantDestinyBreakerType ||
                    (GrantDestinyBreakerType != null && GrantDestinyBreakerType.Equals(input.GrantDestinyBreakerType))
                ) &&
				(
                    PlugCategoryIdentifier == input.PlugCategoryIdentifier ||
                    (PlugCategoryIdentifier != null && PlugCategoryIdentifier.Equals(input.PlugCategoryIdentifier))
                ) &&
				(
                    ItemTypeRegexNot == input.ItemTypeRegexNot ||
                    (ItemTypeRegexNot != null && ItemTypeRegexNot.Equals(input.ItemTypeRegexNot))
                ) &&
				(
                    OriginBucketIdentifier == input.OriginBucketIdentifier ||
                    (OriginBucketIdentifier != null && OriginBucketIdentifier.Equals(input.OriginBucketIdentifier))
                ) &&
				(
                    GrantDestinyItemType == input.GrantDestinyItemType ||
                    (GrantDestinyItemType != null && GrantDestinyItemType.Equals(input.GrantDestinyItemType))
                ) &&
				(
                    GrantDestinySubType == input.GrantDestinySubType ||
                    (GrantDestinySubType != null && GrantDestinySubType.Equals(input.GrantDestinySubType))
                ) &&
				(
                    GrantDestinyClass == input.GrantDestinyClass ||
                    (GrantDestinyClass != null && GrantDestinyClass.Equals(input.GrantDestinyClass))
                ) &&
				(
                    TraitId == input.TraitId ||
                    (TraitId != null && TraitId.Equals(input.TraitId))
                ) &&
				(
                    GroupedCategoryHashes == input.GroupedCategoryHashes ||
                    (GroupedCategoryHashes != null && GroupedCategoryHashes.Equals(input.GroupedCategoryHashes))
                ) &&
				(
                    ParentCategoryHashes == input.ParentCategoryHashes ||
                    (ParentCategoryHashes != null && ParentCategoryHashes.Equals(input.ParentCategoryHashes))
                ) &&
				(
                    GroupCategoryOnly == input.GroupCategoryOnly ||
                    (GroupCategoryOnly != null && GroupCategoryOnly.Equals(input.GroupCategoryOnly))
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

