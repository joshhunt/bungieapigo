using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class Destiny2CoreSettings{

		[DataMember(Name="collectionRootNode", EmitDefaultValue=false)]
		public uint CollectionRootNode { get; set; }

		[DataMember(Name="badgesRootNode", EmitDefaultValue=false)]
		public uint BadgesRootNode { get; set; }

		[DataMember(Name="recordsRootNode", EmitDefaultValue=false)]
		public uint RecordsRootNode { get; set; }

		[DataMember(Name="medalsRootNode", EmitDefaultValue=false)]
		public uint MedalsRootNode { get; set; }

		[DataMember(Name="metricsRootNode", EmitDefaultValue=false)]
		public uint MetricsRootNode { get; set; }

		[DataMember(Name="currentRankProgressionHashes", EmitDefaultValue=false)]
		public List<uint> CurrentRankProgressionHashes { get; set; }

		[DataMember(Name="undiscoveredCollectibleImage", EmitDefaultValue=false)]
		public string UndiscoveredCollectibleImage { get; set; }

		[DataMember(Name="ammoTypeHeavyIcon", EmitDefaultValue=false)]
		public string AmmoTypeHeavyIcon { get; set; }

		[DataMember(Name="ammoTypeSpecialIcon", EmitDefaultValue=false)]
		public string AmmoTypeSpecialIcon { get; set; }

		[DataMember(Name="ammoTypePrimaryIcon", EmitDefaultValue=false)]
		public string AmmoTypePrimaryIcon { get; set; }

		[DataMember(Name="currentSeasonalArtifactHash", EmitDefaultValue=false)]
		public uint CurrentSeasonalArtifactHash { get; set; }

		[DataMember(Name="currentSeasonHash", EmitDefaultValue=false)]
		public uint CurrentSeasonHash { get; set; }

		[DataMember(Name="futureSeasonHashes", EmitDefaultValue=false)]
		public List<uint> FutureSeasonHashes { get; set; }

		[DataMember(Name="pastSeasonHashes", EmitDefaultValue=false)]
		public List<uint> PastSeasonHashes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as Destiny2CoreSettings);
        }

		public bool Equals(Destiny2CoreSettings input)
		{
			if (input == null) return false;

			return
				(
                    CollectionRootNode == input.CollectionRootNode ||
                    (CollectionRootNode != null && CollectionRootNode.Equals(input.CollectionRootNode))
                ) &&
				(
                    BadgesRootNode == input.BadgesRootNode ||
                    (BadgesRootNode != null && BadgesRootNode.Equals(input.BadgesRootNode))
                ) &&
				(
                    RecordsRootNode == input.RecordsRootNode ||
                    (RecordsRootNode != null && RecordsRootNode.Equals(input.RecordsRootNode))
                ) &&
				(
                    MedalsRootNode == input.MedalsRootNode ||
                    (MedalsRootNode != null && MedalsRootNode.Equals(input.MedalsRootNode))
                ) &&
				(
                    MetricsRootNode == input.MetricsRootNode ||
                    (MetricsRootNode != null && MetricsRootNode.Equals(input.MetricsRootNode))
                ) &&
				(
                    CurrentRankProgressionHashes == input.CurrentRankProgressionHashes ||
                    (CurrentRankProgressionHashes != null && CurrentRankProgressionHashes.Equals(input.CurrentRankProgressionHashes))
                ) &&
				(
                    UndiscoveredCollectibleImage == input.UndiscoveredCollectibleImage ||
                    (UndiscoveredCollectibleImage != null && UndiscoveredCollectibleImage.Equals(input.UndiscoveredCollectibleImage))
                ) &&
				(
                    AmmoTypeHeavyIcon == input.AmmoTypeHeavyIcon ||
                    (AmmoTypeHeavyIcon != null && AmmoTypeHeavyIcon.Equals(input.AmmoTypeHeavyIcon))
                ) &&
				(
                    AmmoTypeSpecialIcon == input.AmmoTypeSpecialIcon ||
                    (AmmoTypeSpecialIcon != null && AmmoTypeSpecialIcon.Equals(input.AmmoTypeSpecialIcon))
                ) &&
				(
                    AmmoTypePrimaryIcon == input.AmmoTypePrimaryIcon ||
                    (AmmoTypePrimaryIcon != null && AmmoTypePrimaryIcon.Equals(input.AmmoTypePrimaryIcon))
                ) &&
				(
                    CurrentSeasonalArtifactHash == input.CurrentSeasonalArtifactHash ||
                    (CurrentSeasonalArtifactHash != null && CurrentSeasonalArtifactHash.Equals(input.CurrentSeasonalArtifactHash))
                ) &&
				(
                    CurrentSeasonHash == input.CurrentSeasonHash ||
                    (CurrentSeasonHash != null && CurrentSeasonHash.Equals(input.CurrentSeasonHash))
                ) &&
				(
                    FutureSeasonHashes == input.FutureSeasonHashes ||
                    (FutureSeasonHashes != null && FutureSeasonHashes.Equals(input.FutureSeasonHashes))
                ) &&
				(
                    PastSeasonHashes == input.PastSeasonHashes ||
                    (PastSeasonHashes != null && PastSeasonHashes.Equals(input.PastSeasonHashes))
                ) ;
		}
	}
}

