using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// This represents an item being sold by the vendor.
    /// </summary>
    [DataContract]
    public class DestinyVendorItemDefinition
    {
        /// <summary>
        /// The index into the DestinyVendorDefinition.saleList. This is what we use to refer to items being sold throughout live and definition data.
        /// </summary>
        [DataMember(Name = "vendorItemIndex", EmitDefaultValue = false)]
        public long VendorItemIndex { get; set; }

        /// <summary>
        /// The hash identifier of the item being sold (DestinyInventoryItemDefinition).
        /// </summary>
        /// <summary>
        /// Note that a vendor can sell the same item in multiple ways, so don't assume that itemHash is a unique identifier for this entity.
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        /// <summary>
        /// The amount you will recieve of the item described in itemHash if you make the purchase.
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public long Quantity { get; set; }

        /// <summary>
        /// An list of indexes into the DestinyVendorDefinition.failureStrings array, indicating the possible failure strings that can be relevant for this item.
        /// </summary>
        [DataMember(Name = "failureIndexes", EmitDefaultValue = false)]
        public List<long> FailureIndexes { get; set; }

        /// <summary>
        /// This is a pre-compiled aggregation of item value and priceOverrideList, so that we have one place to check for what the purchaser must pay for the item. Use this instead of trying to piece together the price separately.
        /// </summary>
        /// <summary>
        /// The somewhat crappy part about this is that, now that item quantity overrides have dynamic modifiers, this will not necessarily be statically true. If you were using this instead of live data, switch to using live data.
        /// </summary>
        [DataMember(Name = "currencies", EmitDefaultValue = false)]
        public List<DestinyVendorItemQuantity> Currencies { get; set; }

        /// <summary>
        /// If this item can be refunded, this is the policy for what will be refundd, how, and in what time period.
        /// </summary>
        [DataMember(Name = "refundPolicy", EmitDefaultValue = false)]
        public DestinyVendorItemRefundPolicy RefundPolicy { get; set; }

        /// <summary>
        /// The amount of time before refundability of the newly purchased item will expire.
        /// </summary>
        [DataMember(Name = "refundTimeLimit", EmitDefaultValue = false)]
        public long RefundTimeLimit { get; set; }

        /// <summary>
        /// The Default level at which the item will spawn. Almost always driven by an adjusto these days. Ideally should be singular. It's a long story how this ended up as a list, but there is always either going to be 0:1 of these entities.
        /// </summary>
        [DataMember(Name = "creationLevels", EmitDefaultValue = false)]
        public List<DestinyItemCreationEntryLevelDefinition> CreationLevels { get; set; }

        /// <summary>
        /// This is an index specifically into the display category, as opposed to the server-side Categories (which do not need to match or pair with each other in any way: server side categories are really just structures for common validation. Display Category will let us more easily categorize items visually)
        /// </summary>
        [DataMember(Name = "displayCategoryIndex", EmitDefaultValue = false)]
        public long DisplayCategoryIndex { get; set; }

        /// <summary>
        /// The index into the DestinyVendorDefinition.categories array, so you can find the category associated with this item.
        /// </summary>
        [DataMember(Name = "categoryIndex", EmitDefaultValue = false)]
        public long CategoryIndex { get; set; }

        /// <summary>
        /// Same as above, but for the original category indexes.
        /// </summary>
        [DataMember(Name = "originalCategoryIndex", EmitDefaultValue = false)]
        public long OriginalCategoryIndex { get; set; }

        /// <summary>
        /// The minimum character level at which this item is available for sale.
        /// </summary>
        [DataMember(Name = "minimumLevel", EmitDefaultValue = false)]
        public long MinimumLevel { get; set; }

        /// <summary>
        /// The maximum character level at which this item is available for sale.
        /// </summary>
        [DataMember(Name = "maximumLevel", EmitDefaultValue = false)]
        public long MaximumLevel { get; set; }

        /// <summary>
        /// The action to be performed when purchasing the item, if it's not just "buy".
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public DestinyVendorSaleItemActionBlockDefinition Action { get; set; }

        /// <summary>
        /// The string identifier for the category selling this item.
        /// </summary>
        [DataMember(Name = "displayCategory", EmitDefaultValue = false)]
        public string DisplayCategory { get; set; }

        /// <summary>
        /// The inventory bucket into which this item will be placed upon purchase.
        /// </summary>
        [DataMember(Name = "inventoryBucketHash", EmitDefaultValue = false)]
        public uint InventoryBucketHash { get; set; }

        /// <summary>
        /// The most restrictive scope that determines whether the item is available in the Vendor's inventory. See DestinyGatingScope's documentation for more information.
        /// </summary>
        /// <summary>
        /// This can be determined by Unlock gating, or by whether or not the item has purchase level requirements (minimumLevel and maximumLevel properties).
        /// </summary>
        [DataMember(Name = "visibilityScope", EmitDefaultValue = false)]
        public DestinyGatingScope VisibilityScope { get; set; }

        /// <summary>
        /// Similar to visibilityScope, it represents the most restrictive scope that determines whether the item can be purchased. It will at least be as restrictive as visibilityScope, but could be more restrictive if the item has additional purchase requirements beyond whether it is merely visible or not.
        /// </summary>
        /// <summary>
        /// See DestinyGatingScope's documentation for more information.
        /// </summary>
        [DataMember(Name = "purchasableScope", EmitDefaultValue = false)]
        public DestinyGatingScope PurchasableScope { get; set; }

        /// <summary>
        /// If this item can only be purchased by a given platform, this indicates the platform to which it is restricted.
        /// </summary>
        [DataMember(Name = "exclusivity", EmitDefaultValue = false)]
        public BungieMembershipType Exclusivity { get; set; }

        /// <summary>
        /// If this sale can only be performed as the result of an offer check, this is true.
        /// </summary>
        [DataMember(Name = "isOffer", EmitDefaultValue = false)]
        public bool IsOffer { get; set; }

        /// <summary>
        /// If this sale can only be performed as the result of receiving a CRM offer, this is true.
        /// </summary>
        [DataMember(Name = "isCrm", EmitDefaultValue = false)]
        public bool IsCrm { get; set; }

        /// <summary>
        /// *if* the category this item is in supports non-default sorting, this value should represent the sorting value to use, pre-processed and ready to go.
        /// </summary>
        [DataMember(Name = "sortValue", EmitDefaultValue = false)]
        public long SortValue { get; set; }

        /// <summary>
        /// If this item can expire, this is the tooltip message to show with its expiration info.
        /// </summary>
        [DataMember(Name = "expirationTooltip", EmitDefaultValue = false)]
        public string ExpirationTooltip { get; set; }

        /// <summary>
        /// If this is populated, the purchase of this item should redirect to purchasing these other items instead.
        /// </summary>
        [DataMember(Name = "redirectToSaleIndexes", EmitDefaultValue = false)]
        public List<long> RedirectToSaleIndexes { get; set; }

        [DataMember(Name = "socketOverrides", EmitDefaultValue = false)]
        public List<DestinyVendorItemSocketOverride> SocketOverrides { get; set; }

        /// <summary>
        /// If true, this item is some sort of dummy sale item that cannot actually be purchased. It may be a display only item, or some fluff left by a content designer for testing purposes, or something that got disabled because it was a terrible idea. You get the picture. We won't know *why* it can't be purchased, only that it can't be. Sorry.
        /// </summary>
        /// <summary>
        /// This is also only whether it's unpurchasable as a static property according to game content. There are other reasons why an item may or may not be purchasable at runtime, so even if this isn't set to True you should trust the runtime value for this sale item over the static definition if this is unset.
        /// </summary>
        [DataMember(Name = "unpurchasable", EmitDefaultValue = false)]
        public bool Unpurchasable { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorItemDefinition);
        }

        public bool Equals(DestinyVendorItemDefinition input)
        {
            if (input == null) return false;

            return
                (
                    VendorItemIndex == input.VendorItemIndex ||
                    (VendorItemIndex != null && VendorItemIndex.Equals(input.VendorItemIndex))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    Quantity == input.Quantity ||
                    (Quantity != null && Quantity.Equals(input.Quantity))
                ) &&
                (
                    FailureIndexes == input.FailureIndexes ||
                    (FailureIndexes != null && FailureIndexes.Equals(input.FailureIndexes))
                ) &&
                (
                    Currencies == input.Currencies ||
                    (Currencies != null && Currencies.Equals(input.Currencies))
                ) &&
                (
                    RefundPolicy == input.RefundPolicy ||
                    (RefundPolicy != null && RefundPolicy.Equals(input.RefundPolicy))
                ) &&
                (
                    RefundTimeLimit == input.RefundTimeLimit ||
                    (RefundTimeLimit != null && RefundTimeLimit.Equals(input.RefundTimeLimit))
                ) &&
                (
                    CreationLevels == input.CreationLevels ||
                    (CreationLevels != null && CreationLevels.Equals(input.CreationLevels))
                ) &&
                (
                    DisplayCategoryIndex == input.DisplayCategoryIndex ||
                    (DisplayCategoryIndex != null && DisplayCategoryIndex.Equals(input.DisplayCategoryIndex))
                ) &&
                (
                    CategoryIndex == input.CategoryIndex ||
                    (CategoryIndex != null && CategoryIndex.Equals(input.CategoryIndex))
                ) &&
                (
                    OriginalCategoryIndex == input.OriginalCategoryIndex ||
                    (OriginalCategoryIndex != null && OriginalCategoryIndex.Equals(input.OriginalCategoryIndex))
                ) &&
                (
                    MinimumLevel == input.MinimumLevel ||
                    (MinimumLevel != null && MinimumLevel.Equals(input.MinimumLevel))
                ) &&
                (
                    MaximumLevel == input.MaximumLevel ||
                    (MaximumLevel != null && MaximumLevel.Equals(input.MaximumLevel))
                ) &&
                (
                    Action == input.Action ||
                    (Action != null && Action.Equals(input.Action))
                ) &&
                (
                    DisplayCategory == input.DisplayCategory ||
                    (DisplayCategory != null && DisplayCategory.Equals(input.DisplayCategory))
                ) &&
                (
                    InventoryBucketHash == input.InventoryBucketHash ||
                    (InventoryBucketHash != null && InventoryBucketHash.Equals(input.InventoryBucketHash))
                ) &&
                (
                    VisibilityScope == input.VisibilityScope ||
                    (VisibilityScope != null && VisibilityScope.Equals(input.VisibilityScope))
                ) &&
                (
                    PurchasableScope == input.PurchasableScope ||
                    (PurchasableScope != null && PurchasableScope.Equals(input.PurchasableScope))
                ) &&
                (
                    Exclusivity == input.Exclusivity ||
                    (Exclusivity != null && Exclusivity.Equals(input.Exclusivity))
                ) &&
                (
                    IsOffer == input.IsOffer ||
                    (IsOffer != null && IsOffer.Equals(input.IsOffer))
                ) &&
                (
                    IsCrm == input.IsCrm ||
                    (IsCrm != null && IsCrm.Equals(input.IsCrm))
                ) &&
                (
                    SortValue == input.SortValue ||
                    (SortValue != null && SortValue.Equals(input.SortValue))
                ) &&
                (
                    ExpirationTooltip == input.ExpirationTooltip ||
                    (ExpirationTooltip != null && ExpirationTooltip.Equals(input.ExpirationTooltip))
                ) &&
                (
                    RedirectToSaleIndexes == input.RedirectToSaleIndexes ||
                    (RedirectToSaleIndexes != null && RedirectToSaleIndexes.Equals(input.RedirectToSaleIndexes))
                ) &&
                (
                    SocketOverrides == input.SocketOverrides ||
                    (SocketOverrides != null && SocketOverrides.Equals(input.SocketOverrides))
                ) &&
                (
                    Unpurchasable == input.Unpurchasable ||
                    (Unpurchasable != null && Unpurchasable.Equals(input.Unpurchasable))
                ) ;
        }
    }
}

