using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyVendorDisplayPropertiesDefinition{

		/// <summary>
		/// I regret calling this a "large icon". It's more like a medium-sized image with a picture of the vendor's mug on it, trying their best to look cool. Not what one would call an icon.
		/// </summary>
		[DataMember(Name="largeIcon", EmitDefaultValue=false)]
		public string LargeIcon { get; set; }

		[DataMember(Name="subtitle", EmitDefaultValue=false)]
		public string Subtitle { get; set; }

		/// <summary>
		/// If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game's content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use.
		/// </summary>
		[DataMember(Name="originalIcon", EmitDefaultValue=false)]
		public string OriginalIcon { get; set; }

		/// <summary>
		/// Vendors, in addition to expected display property data, may also show some "common requirements" as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor.
		/// </summary>
		[DataMember(Name="requirementsDisplay", EmitDefaultValue=false)]
		public List<DestinyVendorRequirementDisplayEntryDefinition> RequirementsDisplay { get; set; }

		/// <summary>
		/// This is the icon used in parts of the game UI such as the vendor's waypoint.
		/// </summary>
		[DataMember(Name="smallTransparentIcon", EmitDefaultValue=false)]
		public string SmallTransparentIcon { get; set; }

		/// <summary>
		/// This is the icon used in the map overview, when the vendor is located on the map.
		/// </summary>
		[DataMember(Name="mapIcon", EmitDefaultValue=false)]
		public string MapIcon { get; set; }

		/// <summary>
		/// This is apparently the "Watermark". I am not certain offhand where this is actually used in the Game UI, but some people may find it useful.
		/// </summary>
		[DataMember(Name="largeTransparentIcon", EmitDefaultValue=false)]
		public string LargeTransparentIcon { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		/// <summary>
		/// Note that "icon" is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition's icon was a big picture of a book.
		/// </summary>
		/// <summary>
		/// But usually, it will be a small square image that you can use as... well, an icon.
		/// </summary>
		/// <summary>
		/// They are currently represented as 96px x 96px images.
		/// </summary>
		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }

		[DataMember(Name="iconSequences", EmitDefaultValue=false)]
		public List<DestinyIconSequenceDefinition> IconSequences { get; set; }

		/// <summary>
		/// If this item has a high-res icon (at least for now, many things won't), then the path to that icon will be here.
		/// </summary>
		[DataMember(Name="highResIcon", EmitDefaultValue=false)]
		public string HighResIcon { get; set; }

		[DataMember(Name="hasIcon", EmitDefaultValue=false)]
		public bool HasIcon { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorDisplayPropertiesDefinition);
        }

		public bool Equals(DestinyVendorDisplayPropertiesDefinition input)
		{
			if (input == null) return false;

			return
				(
                    LargeIcon == input.LargeIcon ||
                    (LargeIcon != null && LargeIcon.Equals(input.LargeIcon))
                ) &&
				(
                    Subtitle == input.Subtitle ||
                    (Subtitle != null && Subtitle.Equals(input.Subtitle))
                ) &&
				(
                    OriginalIcon == input.OriginalIcon ||
                    (OriginalIcon != null && OriginalIcon.Equals(input.OriginalIcon))
                ) &&
				(
                    RequirementsDisplay == input.RequirementsDisplay ||
                    (RequirementsDisplay != null && RequirementsDisplay.Equals(input.RequirementsDisplay))
                ) &&
				(
                    SmallTransparentIcon == input.SmallTransparentIcon ||
                    (SmallTransparentIcon != null && SmallTransparentIcon.Equals(input.SmallTransparentIcon))
                ) &&
				(
                    MapIcon == input.MapIcon ||
                    (MapIcon != null && MapIcon.Equals(input.MapIcon))
                ) &&
				(
                    LargeTransparentIcon == input.LargeTransparentIcon ||
                    (LargeTransparentIcon != null && LargeTransparentIcon.Equals(input.LargeTransparentIcon))
                ) &&
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) &&
				(
                    IconSequences == input.IconSequences ||
                    (IconSequences != null && IconSequences.Equals(input.IconSequences))
                ) &&
				(
                    HighResIcon == input.HighResIcon ||
                    (HighResIcon != null && HighResIcon.Equals(input.HighResIcon))
                ) &&
				(
                    HasIcon == input.HasIcon ||
                    (HasIcon != null && HasIcon.Equals(input.HasIcon))
                ) ;
		}
	}
}

