using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Properties of a DestinyInventoryItemDefinition that store all of the information we were able to discern about how the item spawns, and where you can find the item.
	/// </summary>
	/// <summary>
	/// Items will have many of these sources, one per level at which it spawns, to try and give more granular data about where items spawn for specific level ranges.
	/// </summary>
	[DataContract]
	public class DestinyItemSourceDefinition{

		/// <summary>
		/// The level at which the item spawns. Essentially the Primary Key for this source data: there will be multiple of these source entries per item that has source data, grouped by the level at which the item spawns.
		/// </summary>
		[DataMember(Name="level", EmitDefaultValue=false)]
		public long Level { get; set; }

		/// <summary>
		/// The minimum Quality at which the item spawns for this level. Examine DestinyInventoryItemDefinition for more information about what Quality means. Just don't ask Phaedrus about it, he'll never stop talking and you'll have to write a book about it.
		/// </summary>
		[DataMember(Name="minQuality", EmitDefaultValue=false)]
		public long MinQuality { get; set; }

		/// <summary>
		/// The maximum quality at which the item spawns for this level.
		/// </summary>
		[DataMember(Name="maxQuality", EmitDefaultValue=false)]
		public long MaxQuality { get; set; }

		/// <summary>
		/// The minimum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
		/// </summary>
		[DataMember(Name="minLevelRequired", EmitDefaultValue=false)]
		public long MinLevelRequired { get; set; }

		/// <summary>
		/// The maximum Character Level required for equipping the item when the item spawns at the item level defined on this DestinyItemSourceDefinition, as far as we saw in our processing.
		/// </summary>
		[DataMember(Name="maxLevelRequired", EmitDefaultValue=false)]
		public long MaxLevelRequired { get; set; }

		/// <summary>
		/// The stats computed for this level/quality range.
		/// </summary>
		[DataMember(Name="computedStats", EmitDefaultValue=false)]
		public Map<String, DestinyInventoryItemStatDefinition> ComputedStats { get; set; }

		/// <summary>
		/// The DestinyRewardSourceDefinitions found that can spawn the item at this level.
		/// </summary>
		[DataMember(Name="sourceHashes", EmitDefaultValue=false)]
		public List<uint> SourceHashes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSourceDefinition);
        }

		public bool Equals(DestinyItemSourceDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Level == input.Level ||
                    (Level != null && Level.Equals(input.Level))
                ) &&
				(
                    MinQuality == input.MinQuality ||
                    (MinQuality != null && MinQuality.Equals(input.MinQuality))
                ) &&
				(
                    MaxQuality == input.MaxQuality ||
                    (MaxQuality != null && MaxQuality.Equals(input.MaxQuality))
                ) &&
				(
                    MinLevelRequired == input.MinLevelRequired ||
                    (MinLevelRequired != null && MinLevelRequired.Equals(input.MinLevelRequired))
                ) &&
				(
                    MaxLevelRequired == input.MaxLevelRequired ||
                    (MaxLevelRequired != null && MaxLevelRequired.Equals(input.MaxLevelRequired))
                ) &&
				(
                    ComputedStats == input.ComputedStats ||
                    (ComputedStats != null && ComputedStats.Equals(input.ComputedStats))
                ) &&
				(
                    SourceHashes == input.SourceHashes ||
                    (SourceHashes != null && SourceHashes.Equals(input.SourceHashes))
                ) ;
		}
	}
}

