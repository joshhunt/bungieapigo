using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Characters can not only have Inventory buckets (containers of items that are generally matched by their type or functionality), they can also have Equipment Slots.
	/// </summary>
	/// <summary>
	/// The Equipment Slot is an indicator that the related bucket can have instanced items equipped on the character. For instance, the Primary Weapon bucket has an Equipment Slot that determines whether you can equip primary weapons, and holds the association between its slot and the inventory bucket from which it can have items equipped.
	/// </summary>
	/// <summary>
	/// An Equipment Slot must have a related Inventory Bucket, but not all inventory buckets must have Equipment Slots.
	/// </summary>
	[DataContract]
	public class DestinyEquipmentSlotDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// These technically point to "Equipment Category Definitions". But don't get excited. There's nothing of significant value in those definitions, so I didn't bother to expose them. You can use the hash here to group equipment slots by common functionality, which serves the same purpose as if we had the Equipment Category definitions exposed.
		/// </summary>
		[DataMember(Name="equipmentCategoryHash", EmitDefaultValue=false)]
		public uint EquipmentCategoryHash { get; set; }

		/// <summary>
		/// The inventory bucket that owns this equipment slot.
		/// </summary>
		[DataMember(Name="bucketTypeHash", EmitDefaultValue=false)]
		public uint BucketTypeHash { get; set; }

		/// <summary>
		/// If True, equipped items should have their custom art dyes applied when rendering the item. Otherwise, custom art dyes on an item should be ignored if the item is equipped in this slot.
		/// </summary>
		[DataMember(Name="applyCustomArtDyes", EmitDefaultValue=false)]
		public bool ApplyCustomArtDyes { get; set; }

		/// <summary>
		/// The Art Dye Channels that apply to this equipment slot.
		/// </summary>
		[DataMember(Name="artDyeChannels", EmitDefaultValue=false)]
		public List<DestinyArtDyeReference> ArtDyeChannels { get; set; }

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
            return this.Equals(input as DestinyEquipmentSlotDefinition);
        }

		public bool Equals(DestinyEquipmentSlotDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    EquipmentCategoryHash == input.EquipmentCategoryHash ||
                    (EquipmentCategoryHash != null && EquipmentCategoryHash.Equals(input.EquipmentCategoryHash))
                ) &&
				(
                    BucketTypeHash == input.BucketTypeHash ||
                    (BucketTypeHash != null && BucketTypeHash.Equals(input.BucketTypeHash))
                ) &&
				(
                    ApplyCustomArtDyes == input.ApplyCustomArtDyes ||
                    (ApplyCustomArtDyes != null && ApplyCustomArtDyes.Equals(input.ApplyCustomArtDyes))
                ) &&
				(
                    ArtDyeChannels == input.ArtDyeChannels ||
                    (ArtDyeChannels != null && ArtDyeChannels.Equals(input.ArtDyeChannels))
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

