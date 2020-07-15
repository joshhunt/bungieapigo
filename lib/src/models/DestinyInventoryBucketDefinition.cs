using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// An Inventory (be it Character or Profile level) is comprised of many Buckets. An example of a bucket is &quot;Primary Weapons&quot;, where all of the primary weapons on a character are gathered together into a single visual element in the UI: a subset of the inventory that has a limited number of slots, and in this case also has an associated Equipment Slot for equipping an item in the bucket.
	/// Item definitions declare what their &quot;default&quot; bucket is (DestinyInventoryItemDefinition.inventory.bucketTypeHash), and Item instances will tell you which bucket they are currently residing in (DestinyItemComponent.bucketHash). You can use this information along with the DestinyInventoryBucketDefinition to show these items grouped by bucket.
	/// You cannot transfer an item to a bucket that is not its Default without going through a Vendor&#39;s &quot;accepted items&quot; (DestinyVendorDefinition.acceptedItems). This is how transfer functionality like the Vault is implemented, as a feature of a Vendor. See the vendor&#39;s acceptedItems property for more details.
	[DataContract]
	public class DestinyInventoryBucketDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// Where the bucket is found. 0 = Character, 1 = Account
		/// </summary>
		[DataMember(Name="scope", EmitDefaultValue=false)]
		public BucketScope Scope { get; set; }

		/// <summary>
		/// An enum value for what items can be found in the bucket. See the BucketCategory enum for more details.
		/// </summary>
		[DataMember(Name="category", EmitDefaultValue=false)]
		public BucketCategory Category { get; set; }

		/// <summary>
		/// Use this property to provide a quick-and-dirty recommended ordering for buckets in the UI. Most UIs will likely want to forsake this for something more custom and manual.
		/// </summary>
		[DataMember(Name="bucketOrder", EmitDefaultValue=false)]
		public long BucketOrder { get; set; }

		/// <summary>
		/// The maximum # of item "slots" in a bucket. A slot is a given combination of item + quantity.
		/// </summary>
		/// <summary>
		/// For instance, a Weapon will always take up a single slot, and always have a quantity of 1. But a material could take up only a single slot with hundreds of quantity.
		/// </summary>
		[DataMember(Name="itemCount", EmitDefaultValue=false)]
		public long ItemCount { get; set; }

		/// <summary>
		/// Sometimes, inventory buckets represent conceptual "locations" in the game that might not be expected. This value indicates the conceptual location of the bucket, regardless of where it is actually contained on the character/account. 
		/// </summary>
		/// <summary>
		/// See ItemLocation for details. 
		/// </summary>
		/// <summary>
		/// Note that location includes the Vault and the Postmaster (both of whom being just inventory buckets with additional actions that can be performed on them through a Vendor)
		/// </summary>
		[DataMember(Name="location", EmitDefaultValue=false)]
		public ItemLocation Location { get; set; }

		/// <summary>
		/// If TRUE, there is at least one Vendor that can transfer items to/from this bucket. See the DestinyVendorDefinition's acceptedItems property for more information on how transferring works.
		/// </summary>
		[DataMember(Name="hasTransferDestination", EmitDefaultValue=false)]
		public bool HasTransferDestination { get; set; }

		/// <summary>
		/// If True, this bucket is enabled. Disabled buckets may include buckets that were included for test purposes, or that were going to be used but then were abandoned but never removed from content *cough*.
		/// </summary>
		[DataMember(Name="enabled", EmitDefaultValue=false)]
		public bool Enabled { get; set; }

		/// <summary>
		/// if a FIFO bucket fills up, it will delete the oldest item from said bucket when a new item tries to be added to it. If this is FALSE, the bucket will not allow new items to be placed in it until room is made by the user manually deleting items from it. You can see an example of this with the Postmaster's bucket.
		/// </summary>
		[DataMember(Name="fifo", EmitDefaultValue=false)]
		public bool Fifo { get; set; }

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
            return this.Equals(input as DestinyInventoryBucketDefinition);
        }

		public bool Equals(DestinyInventoryBucketDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) &&
				(
                    Category == input.Category ||
                    (Category != null && Category.Equals(input.Category))
                ) &&
				(
                    BucketOrder == input.BucketOrder ||
                    (BucketOrder != null && BucketOrder.Equals(input.BucketOrder))
                ) &&
				(
                    ItemCount == input.ItemCount ||
                    (ItemCount != null && ItemCount.Equals(input.ItemCount))
                ) &&
				(
                    Location == input.Location ||
                    (Location != null && Location.Equals(input.Location))
                ) &&
				(
                    HasTransferDestination == input.HasTransferDestination ||
                    (HasTransferDestination != null && HasTransferDestination.Equals(input.HasTransferDestination))
                ) &&
				(
                    Enabled == input.Enabled ||
                    (Enabled != null && Enabled.Equals(input.Enabled))
                ) &&
				(
                    Fifo == input.Fifo ||
                    (Fifo != null && Fifo.Equals(input.Fifo))
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
				hashCode = hashCode * 59 + this.Scope.GetHashCode();
				hashCode = hashCode * 59 + this.Category.GetHashCode();
				hashCode = hashCode * 59 + this.BucketOrder.GetHashCode();
				hashCode = hashCode * 59 + this.ItemCount.GetHashCode();
				hashCode = hashCode * 59 + this.Location.GetHashCode();
				hashCode = hashCode * 59 + this.HasTransferDestination.GetHashCode();
				hashCode = hashCode * 59 + this.Enabled.GetHashCode();
				hashCode = hashCode * 59 + this.Fifo.GetHashCode();
				hashCode = hashCode * 59 + this.Hash.GetHashCode();
				hashCode = hashCode * 59 + this.Index.GetHashCode();
				hashCode = hashCode * 59 + this.Redacted.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

