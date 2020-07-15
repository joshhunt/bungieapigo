using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// DestinyManifest is the external-facing contract for just the properties needed by those calling the Destiny Platform.
	/// </summary>
	[DataContract]
	public class DestinyManifest{

		[DataMember(Name="version", EmitDefaultValue=false)]
		public string Version { get; set; }

		[DataMember(Name="mobileAssetContentPath", EmitDefaultValue=false)]
		public string MobileAssetContentPath { get; set; }

		[DataMember(Name="mobileGearAssetDataBases", EmitDefaultValue=false)]
		public List<GearAssetDataBaseDefinition> MobileGearAssetDataBases { get; set; }

		[DataMember(Name="mobileWorldContentPaths", EmitDefaultValue=false)]
		public Map<String, string> MobileWorldContentPaths { get; set; }

		/// <summary>
		/// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a path to the aggregated world definitions (warning: large file!)
		/// </summary>
		[DataMember(Name="jsonWorldContentPaths", EmitDefaultValue=false)]
		public Map<String, string> JsonWorldContentPaths { get; set; }

		/// <summary>
		/// This points to the generated JSON that contains all the Definitions. Each key is a locale. The value is a dictionary, where the key is a definition type by name, and the value is the path to the file for that definition. WARNING: This is unsafe and subject to change - do not depend on data in these files staying around long-term.
		/// </summary>
		[DataMember(Name="jsonWorldComponentContentPaths", EmitDefaultValue=false)]
		public Map<String, Map<String, string>> JsonWorldComponentContentPaths { get; set; }

		[DataMember(Name="mobileClanBannerDatabasePath", EmitDefaultValue=false)]
		public string MobileClanBannerDatabasePath { get; set; }

		[DataMember(Name="mobileGearCDN", EmitDefaultValue=false)]
		public Map<String, string> MobileGearCdn { get; set; }

		/// <summary>
		/// Information about the "Image Pyramid" for Destiny icons. Where possible, we create smaller versions of Destiny icons. These are found as subfolders under the location of the "original/full size" Destiny images, with the same file name and extension as the original image itself. (this lets us avoid sending largely redundant path info with every entity, at the expense of the smaller versions of the image being less discoverable)
		/// </summary>
		[DataMember(Name="iconImagePyramidInfo", EmitDefaultValue=false)]
		public List<ImagePyramidEntry> IconImagePyramidInfo { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyManifest);
        }

		public bool Equals(DestinyManifest input)
		{
			if (input == null) return false;

			return
				(
                    Version == input.Version ||
                    (Version != null && Version.Equals(input.Version))
                ) &&
				(
                    MobileAssetContentPath == input.MobileAssetContentPath ||
                    (MobileAssetContentPath != null && MobileAssetContentPath.Equals(input.MobileAssetContentPath))
                ) &&
				(
                    MobileGearAssetDataBases == input.MobileGearAssetDataBases ||
                    (MobileGearAssetDataBases != null && MobileGearAssetDataBases.Equals(input.MobileGearAssetDataBases))
                ) &&
				(
                    MobileWorldContentPaths == input.MobileWorldContentPaths ||
                    (MobileWorldContentPaths != null && MobileWorldContentPaths.Equals(input.MobileWorldContentPaths))
                ) &&
				(
                    JsonWorldContentPaths == input.JsonWorldContentPaths ||
                    (JsonWorldContentPaths != null && JsonWorldContentPaths.Equals(input.JsonWorldContentPaths))
                ) &&
				(
                    JsonWorldComponentContentPaths == input.JsonWorldComponentContentPaths ||
                    (JsonWorldComponentContentPaths != null && JsonWorldComponentContentPaths.Equals(input.JsonWorldComponentContentPaths))
                ) &&
				(
                    MobileClanBannerDatabasePath == input.MobileClanBannerDatabasePath ||
                    (MobileClanBannerDatabasePath != null && MobileClanBannerDatabasePath.Equals(input.MobileClanBannerDatabasePath))
                ) &&
				(
                    MobileGearCdn == input.MobileGearCdn ||
                    (MobileGearCdn != null && MobileGearCdn.Equals(input.MobileGearCdn))
                ) &&
				(
                    IconImagePyramidInfo == input.IconImagePyramidInfo ||
                    (IconImagePyramidInfo != null && IconImagePyramidInfo.Equals(input.IconImagePyramidInfo))
                ) ;
		}
	}
}

