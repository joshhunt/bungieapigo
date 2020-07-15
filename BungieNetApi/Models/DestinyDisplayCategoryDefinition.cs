using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Display Categories are different from "categories" in that these are specifically for visual grouping and display of categories in Vendor UI. The "categories" structure is for validation of the contained items, and can be categorized entirely separately from "Display Categories", there need be and often will be no meaningful relationship between the two.
	/// </summary>
	[DataContract]
	public class DestinyDisplayCategoryDefinition{

		[DataMember(Name="index", EmitDefaultValue=false)]
		public long Index { get; set; }

		/// <summary>
		/// A string identifier for the display category.
		/// </summary>
		[DataMember(Name="identifier", EmitDefaultValue=false)]
		public string Identifier { get; set; }

		[DataMember(Name="displayCategoryHash", EmitDefaultValue=false)]
		public uint DisplayCategoryHash { get; set; }

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// If true, this category should be displayed in the "Banner" section of the vendor's UI.
		/// </summary>
		[DataMember(Name="displayInBanner", EmitDefaultValue=false)]
		public bool DisplayInBanner { get; set; }

		/// <summary>
		/// If it exists, this is the hash identifier of a DestinyProgressionDefinition that represents the progression to show on this display category.
		/// </summary>
		/// <summary>
		/// Specific categories can now have thier own distinct progression, apparently. So that's cool.
		/// </summary>
		[DataMember(Name="progressionHash", EmitDefaultValue=false)]
		public uint ProgressionHash { get; set; }

		/// <summary>
		/// If this category sorts items in a nonstandard way, this will be the way we sort.
		/// </summary>
		[DataMember(Name="sortOrder", EmitDefaultValue=false)]
		public VendorDisplayCategorySortOrder SortOrder { get; set; }

		/// <summary>
		/// An indicator of how the category will be displayed in the UI. It's up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
		/// </summary>
		[DataMember(Name="displayStyleHash", EmitDefaultValue=false)]
		public uint DisplayStyleHash { get; set; }

		/// <summary>
		/// An indicator of how the category will be displayed in the UI. It's up to you to do something cool or interesting in response to this, or just to treat it as a normal category.
		/// </summary>
		[DataMember(Name="displayStyleIdentifier", EmitDefaultValue=false)]
		public string DisplayStyleIdentifier { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyDisplayCategoryDefinition);
        }

		public bool Equals(DestinyDisplayCategoryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
				(
                    Identifier == input.Identifier ||
                    (Identifier != null && Identifier.Equals(input.Identifier))
                ) &&
				(
                    DisplayCategoryHash == input.DisplayCategoryHash ||
                    (DisplayCategoryHash != null && DisplayCategoryHash.Equals(input.DisplayCategoryHash))
                ) &&
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    DisplayInBanner == input.DisplayInBanner ||
                    (DisplayInBanner != null && DisplayInBanner.Equals(input.DisplayInBanner))
                ) &&
				(
                    ProgressionHash == input.ProgressionHash ||
                    (ProgressionHash != null && ProgressionHash.Equals(input.ProgressionHash))
                ) &&
				(
                    SortOrder == input.SortOrder ||
                    (SortOrder != null && SortOrder.Equals(input.SortOrder))
                ) &&
				(
                    DisplayStyleHash == input.DisplayStyleHash ||
                    (DisplayStyleHash != null && DisplayStyleHash.Equals(input.DisplayStyleHash))
                ) &&
				(
                    DisplayStyleIdentifier == input.DisplayStyleIdentifier ||
                    (DisplayStyleIdentifier != null && DisplayStyleIdentifier.Equals(input.DisplayStyleIdentifier))
                ) ;
		}
	}
}

