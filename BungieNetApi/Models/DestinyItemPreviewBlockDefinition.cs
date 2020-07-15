using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Items like Sacks or Boxes can have items that it shows in-game when you view details that represent the items you can obtain if you use or acquire the item.
	/// </summary>
	/// <summary>
	/// This defines those categories, and gives some insights into that data's source.
	/// </summary>
	[DataContract]
	public class DestinyItemPreviewBlockDefinition{

		/// <summary>
		/// A string that the game UI uses as a hint for which detail screen to show for the item. You, too, can leverage this for your own custom screen detail views. Note, however, that these are arbitrarily defined by designers: there's no guarantees of a fixed, known number of these - so fall back to something reasonable if you don't recognize it.
		/// </summary>
		[DataMember(Name="screenStyle", EmitDefaultValue=false)]
		public string ScreenStyle { get; set; }

		/// <summary>
		/// If the preview data is derived from a fake "Preview" Vendor, this will be the hash identifier for the DestinyVendorDefinition of that fake vendor.
		/// </summary>
		[DataMember(Name="previewVendorHash", EmitDefaultValue=false)]
		public uint PreviewVendorHash { get; set; }

		/// <summary>
		/// If this item should show you Artifact information when you preview it, this is the hash identifier of the DestinyArtifactDefinition for the artifact whose data should be shown.
		/// </summary>
		[DataMember(Name="artifactHash", EmitDefaultValue=false)]
		public uint ArtifactHash { get; set; }

		/// <summary>
		/// If the preview has an associated action (like "Open"), this will be the localized string for that action.
		/// </summary>
		[DataMember(Name="previewActionString", EmitDefaultValue=false)]
		public string PreviewActionString { get; set; }

		/// <summary>
		/// This is a list of the items being previewed, categorized in the same way as they are in the preview UI.
		/// </summary>
		[DataMember(Name="derivedItemCategories", EmitDefaultValue=false)]
		public List<DestinyDerivedItemCategoryDefinition> DerivedItemCategories { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemPreviewBlockDefinition);
        }

		public bool Equals(DestinyItemPreviewBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ScreenStyle == input.ScreenStyle ||
                    (ScreenStyle != null && ScreenStyle.Equals(input.ScreenStyle))
                ) &&
				(
                    PreviewVendorHash == input.PreviewVendorHash ||
                    (PreviewVendorHash != null && PreviewVendorHash.Equals(input.PreviewVendorHash))
                ) &&
				(
                    ArtifactHash == input.ArtifactHash ||
                    (ArtifactHash != null && ArtifactHash.Equals(input.ArtifactHash))
                ) &&
				(
                    PreviewActionString == input.PreviewActionString ||
                    (PreviewActionString != null && PreviewActionString.Equals(input.PreviewActionString))
                ) &&
				(
                    DerivedItemCategories == input.DerivedItemCategories ||
                    (DerivedItemCategories != null && DerivedItemCategories.Equals(input.DerivedItemCategories))
                ) ;
		}
	}
}

