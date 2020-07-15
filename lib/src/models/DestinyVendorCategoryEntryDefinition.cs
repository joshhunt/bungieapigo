using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// This is the definition for a single Vendor Category, into which Sale Items are grouped.
	/// </summary>
	[DataContract]
	public class DestinyVendorCategoryEntryDefinition{

		/// <summary>
		/// The index of the category in the original category definitions for the vendor.
		/// </summary>
		[DataMember(Name="categoryIndex", EmitDefaultValue=false)]
		public long CategoryIndex { get; set; }

		/// <summary>
		/// Used in sorting items in vendors... but there's a lot more to it. Just go with the order provided in the itemIndexes property on the DestinyVendorCategoryComponent instead, it should be more reliable than trying to recalculate it yourself.
		/// </summary>
		[DataMember(Name="sortValue", EmitDefaultValue=false)]
		public long SortValue { get; set; }

		/// <summary>
		/// The hashed identifier for the category.
		/// </summary>
		[DataMember(Name="categoryHash", EmitDefaultValue=false)]
		public uint CategoryHash { get; set; }

		/// <summary>
		/// The amount of items that will be available when this category is shown.
		/// </summary>
		[DataMember(Name="quantityAvailable", EmitDefaultValue=false)]
		public long QuantityAvailable { get; set; }

		/// <summary>
		/// If items aren't up for sale in this category, should we still show them (greyed out)?
		/// </summary>
		[DataMember(Name="showUnavailableItems", EmitDefaultValue=false)]
		public bool ShowUnavailableItems { get; set; }

		/// <summary>
		/// If you don't have the currency required to buy items from this category, should the items be hidden?
		/// </summary>
		[DataMember(Name="hideIfNoCurrency", EmitDefaultValue=false)]
		public bool HideIfNoCurrency { get; set; }

		/// <summary>
		/// True if this category doesn't allow purchases.
		/// </summary>
		[DataMember(Name="hideFromRegularPurchase", EmitDefaultValue=false)]
		public bool HideFromRegularPurchase { get; set; }

		/// <summary>
		/// The localized string for making purchases from this category, if it is different from the vendor's string for purchasing.
		/// </summary>
		[DataMember(Name="buyStringOverride", EmitDefaultValue=false)]
		public string BuyStringOverride { get; set; }

		/// <summary>
		/// If the category is disabled, this is the localized description to show.
		/// </summary>
		[DataMember(Name="disabledDescription", EmitDefaultValue=false)]
		public string DisabledDescription { get; set; }

		/// <summary>
		/// The localized title of the category.
		/// </summary>
		[DataMember(Name="displayTitle", EmitDefaultValue=false)]
		public string DisplayTitle { get; set; }

		/// <summary>
		/// If this category has an overlay prompt that should appear, this contains the details of that prompt.
		/// </summary>
		[DataMember(Name="overlay", EmitDefaultValue=false)]
		public DestinyVendorCategoryOverlayDefinition Overlay { get; set; }

		/// <summary>
		/// A shortcut for the vendor item indexes sold under this category. Saves us from some expensive reorganization at runtime.
		/// </summary>
		[DataMember(Name="vendorItemIndexes", EmitDefaultValue=false)]
		public List<long> VendorItemIndexes { get; set; }

		/// <summary>
		/// Sometimes a category isn't actually used to sell items, but rather to preview them. This implies different UI (and manual placement of the category in the UI) in the game, and special treatment.
		/// </summary>
		[DataMember(Name="isPreview", EmitDefaultValue=false)]
		public bool IsPreview { get; set; }

		/// <summary>
		/// If true, this category only displays items: you can't purchase anything in them.
		/// </summary>
		[DataMember(Name="isDisplayOnly", EmitDefaultValue=false)]
		public bool IsDisplayOnly { get; set; }

		[DataMember(Name="resetIntervalMinutesOverride", EmitDefaultValue=false)]
		public long ResetIntervalMinutesOverride { get; set; }

		[DataMember(Name="resetOffsetMinutesOverride", EmitDefaultValue=false)]
		public long ResetOffsetMinutesOverride { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorCategoryEntryDefinition);
        }

		public bool Equals(DestinyVendorCategoryEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    CategoryIndex == input.CategoryIndex ||
                    (CategoryIndex != null && CategoryIndex.Equals(input.CategoryIndex))
                ) &&
				(
                    SortValue == input.SortValue ||
                    (SortValue != null && SortValue.Equals(input.SortValue))
                ) &&
				(
                    CategoryHash == input.CategoryHash ||
                    (CategoryHash != null && CategoryHash.Equals(input.CategoryHash))
                ) &&
				(
                    QuantityAvailable == input.QuantityAvailable ||
                    (QuantityAvailable != null && QuantityAvailable.Equals(input.QuantityAvailable))
                ) &&
				(
                    ShowUnavailableItems == input.ShowUnavailableItems ||
                    (ShowUnavailableItems != null && ShowUnavailableItems.Equals(input.ShowUnavailableItems))
                ) &&
				(
                    HideIfNoCurrency == input.HideIfNoCurrency ||
                    (HideIfNoCurrency != null && HideIfNoCurrency.Equals(input.HideIfNoCurrency))
                ) &&
				(
                    HideFromRegularPurchase == input.HideFromRegularPurchase ||
                    (HideFromRegularPurchase != null && HideFromRegularPurchase.Equals(input.HideFromRegularPurchase))
                ) &&
				(
                    BuyStringOverride == input.BuyStringOverride ||
                    (BuyStringOverride != null && BuyStringOverride.Equals(input.BuyStringOverride))
                ) &&
				(
                    DisabledDescription == input.DisabledDescription ||
                    (DisabledDescription != null && DisabledDescription.Equals(input.DisabledDescription))
                ) &&
				(
                    DisplayTitle == input.DisplayTitle ||
                    (DisplayTitle != null && DisplayTitle.Equals(input.DisplayTitle))
                ) &&
				(
                    Overlay == input.Overlay ||
                    (Overlay != null && Overlay.Equals(input.Overlay))
                ) &&
				(
                    VendorItemIndexes == input.VendorItemIndexes ||
                    (VendorItemIndexes != null && VendorItemIndexes.Equals(input.VendorItemIndexes))
                ) &&
				(
                    IsPreview == input.IsPreview ||
                    (IsPreview != null && IsPreview.Equals(input.IsPreview))
                ) &&
				(
                    IsDisplayOnly == input.IsDisplayOnly ||
                    (IsDisplayOnly != null && IsDisplayOnly.Equals(input.IsDisplayOnly))
                ) &&
				(
                    ResetIntervalMinutesOverride == input.ResetIntervalMinutesOverride ||
                    (ResetIntervalMinutesOverride != null && ResetIntervalMinutesOverride.Equals(input.ResetIntervalMinutesOverride))
                ) &&
				(
                    ResetOffsetMinutesOverride == input.ResetOffsetMinutesOverride ||
                    (ResetOffsetMinutesOverride != null && ResetOffsetMinutesOverride.Equals(input.ResetOffsetMinutesOverride))
                ) ;
		}
	}
}

