using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// An item&#39;s &quot;Quality&quot; determines its calculated stats. The Level at which the item spawns is combined with its &quot;qualityLevel&quot; along with some additional calculations to determine the value of those stats.
	/// In Destiny 2, most items don&#39;t have default item levels and quality, making this property less useful: these apparently are almost always determined by the complex mechanisms of the Reward system rather than statically. They are still provided here in case they are still useful for people. This also contains some information about Infusion.
	[DataContract]
	public class DestinyItemQualityBlockDefinition{

		/// <summary>
		/// The "base" defined level of an item. This is a list because, in theory, each Expansion could define its own base level for an item.
		/// </summary>
		/// <summary>
		/// In practice, not only was that never done in Destiny 1, but now this isn't even populated at all. When it's not populated, the level at which it spawns has to be inferred by Reward information, of which BNet receives an imperfect view and will only be reliable on instanced data as a result.
		/// </summary>
		[DataMember(Name="itemLevels", EmitDefaultValue=false)]
		public List<long> ItemLevels { get; set; }

		/// <summary>
		/// qualityLevel is used in combination with the item's level to calculate stats like Attack and Defense. It plays a role in that calculation, but not nearly as large as itemLevel does.
		/// </summary>
		[DataMember(Name="qualityLevel", EmitDefaultValue=false)]
		public long QualityLevel { get; set; }

		/// <summary>
		/// The string identifier for this item's "infusability", if any. 
		/// </summary>
		/// <summary>
		/// Items that match the same infusionCategoryName are allowed to infuse with each other.
		/// </summary>
		/// <summary>
		/// DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
		/// </summary>
		[DataMember(Name="infusionCategoryName", EmitDefaultValue=false)]
		public string InfusionCategoryName { get; set; }

		/// <summary>
		/// The hash identifier for the infusion. It does not map to a Definition entity.
		/// </summary>
		/// <summary>
		/// DEPRECATED: Items can now have multiple infusion categories. Please use infusionCategoryHashes instead.
		/// </summary>
		[DataMember(Name="infusionCategoryHash", EmitDefaultValue=false)]
		public uint InfusionCategoryHash { get; set; }

		/// <summary>
		/// If any one of these hashes matches any value in another item's infusionCategoryHashes, the two can infuse with each other.
		/// </summary>
		[DataMember(Name="infusionCategoryHashes", EmitDefaultValue=false)]
		public List<uint> InfusionCategoryHashes { get; set; }

		/// <summary>
		/// An item can refer to pre-set level requirements. They are defined in DestinyProgressionLevelRequirementDefinition, and you can use this hash to find the appropriate definition.
		/// </summary>
		[DataMember(Name="progressionLevelRequirementHash", EmitDefaultValue=false)]
		public uint ProgressionLevelRequirementHash { get; set; }

		/// <summary>
		/// The latest version available for this item.
		/// </summary>
		[DataMember(Name="currentVersion", EmitDefaultValue=false)]
		public uint CurrentVersion { get; set; }

		/// <summary>
		/// The list of versions available for this item.
		/// </summary>
		[DataMember(Name="versions", EmitDefaultValue=false)]
		public List<DestinyItemVersionDefinition> Versions { get; set; }

		/// <summary>
		/// Icon overlays to denote the item version and power cap status.
		/// </summary>
		[DataMember(Name="displayVersionWatermarkIcons", EmitDefaultValue=false)]
		public List<string> DisplayVersionWatermarkIcons { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemQualityBlockDefinition);
        }

		public bool Equals(DestinyItemQualityBlockDefinition input)
		{
			if (input == null) return false;

			return
				(
                    ItemLevels == input.ItemLevels ||
                    (ItemLevels != null && ItemLevels.Equals(input.ItemLevels))
                ) &&
				(
                    QualityLevel == input.QualityLevel ||
                    (QualityLevel != null && QualityLevel.Equals(input.QualityLevel))
                ) &&
				(
                    InfusionCategoryName == input.InfusionCategoryName ||
                    (InfusionCategoryName != null && InfusionCategoryName.Equals(input.InfusionCategoryName))
                ) &&
				(
                    InfusionCategoryHash == input.InfusionCategoryHash ||
                    (InfusionCategoryHash != null && InfusionCategoryHash.Equals(input.InfusionCategoryHash))
                ) &&
				(
                    InfusionCategoryHashes == input.InfusionCategoryHashes ||
                    (InfusionCategoryHashes != null && InfusionCategoryHashes.Equals(input.InfusionCategoryHashes))
                ) &&
				(
                    ProgressionLevelRequirementHash == input.ProgressionLevelRequirementHash ||
                    (ProgressionLevelRequirementHash != null && ProgressionLevelRequirementHash.Equals(input.ProgressionLevelRequirementHash))
                ) &&
				(
                    CurrentVersion == input.CurrentVersion ||
                    (CurrentVersion != null && CurrentVersion.Equals(input.CurrentVersion))
                ) &&
				(
                    Versions == input.Versions ||
                    (Versions != null && Versions.Equals(input.Versions))
                ) &&
				(
                    DisplayVersionWatermarkIcons == input.DisplayVersionWatermarkIcons ||
                    (DisplayVersionWatermarkIcons != null && DisplayVersionWatermarkIcons.Equals(input.DisplayVersionWatermarkIcons))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemLevels.GetHashCode();
				hashCode = hashCode * 59 + this.QualityLevel.GetHashCode();
				hashCode = hashCode * 59 + this.InfusionCategoryName.GetHashCode();
				hashCode = hashCode * 59 + this.InfusionCategoryHash.GetHashCode();
				hashCode = hashCode * 59 + this.InfusionCategoryHashes.GetHashCode();
				hashCode = hashCode * 59 + this.ProgressionLevelRequirementHash.GetHashCode();
				hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
				hashCode = hashCode * 59 + this.Versions.GetHashCode();
				hashCode = hashCode * 59 + this.DisplayVersionWatermarkIcons.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

