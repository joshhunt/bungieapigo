using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// This is a reference to, and summary data for, a specific item that you can get as a result of Using or Acquiring some other Item (For example, this could be summary information for an Emote that you can get by opening an an Eververse Box) See DestinyDerivedItemCategoryDefinition for more information.
	/// </summary>
	[DataContract]
	public class DestinyDerivedItemDefinition{

		/// <summary>
		/// The hash for the DestinyInventoryItemDefinition of this derived item, if there is one. Sometimes we are given this information as a manual override, in which case there won't be an actual DestinyInventoryItemDefinition for what we display, but you can still show the strings from this object itself.
		/// </summary>
		[DataMember(Name="itemHash", EmitDefaultValue=false)]
		public uint ItemHash { get; set; }

		/// <summary>
		/// The name of the derived item.
		/// </summary>
		[DataMember(Name="itemName", EmitDefaultValue=false)]
		public string ItemName { get; set; }

		/// <summary>
		/// Additional details about the derived item, in addition to the description.
		/// </summary>
		[DataMember(Name="itemDetail", EmitDefaultValue=false)]
		public string ItemDetail { get; set; }

		/// <summary>
		/// A brief description of the item.
		/// </summary>
		[DataMember(Name="itemDescription", EmitDefaultValue=false)]
		public string ItemDescription { get; set; }

		/// <summary>
		/// An icon for the item.
		/// </summary>
		[DataMember(Name="iconPath", EmitDefaultValue=false)]
		public string IconPath { get; set; }

		/// <summary>
		/// If the item was derived from a "Preview Vendor", this will be an index into the DestinyVendorDefinition's itemList property. Otherwise, -1.
		/// </summary>
		[DataMember(Name="vendorItemIndex", EmitDefaultValue=false)]
		public long VendorItemIndex { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyDerivedItemDefinition);
        }

		public bool Equals(DestinyDerivedItemDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
				(
                    ItemName == input.ItemName ||
                    (ItemName != null && ItemName.Equals(input.ItemName))
                ) &&
				(
                    ItemDetail == input.ItemDetail ||
                    (ItemDetail != null && ItemDetail.Equals(input.ItemDetail))
                ) &&
				(
                    ItemDescription == input.ItemDescription ||
                    (ItemDescription != null && ItemDescription.Equals(input.ItemDescription))
                ) &&
				(
                    IconPath == input.IconPath ||
                    (IconPath != null && IconPath.Equals(input.IconPath))
                ) &&
				(
                    VendorItemIndex == input.VendorItemIndex ||
                    (VendorItemIndex != null && VendorItemIndex.Equals(input.VendorItemIndex))
                ) ;
		}
	}
}

