using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class Destiny2CoreSettings
    {
        [DataMember(Name = "collectionRootNode", EmitDefaultValue = false)]
        public uint CollectionRootNode { get; set; }

        [DataMember(Name = "badgesRootNode", EmitDefaultValue = false)]
        public uint BadgesRootNode { get; set; }

        [DataMember(Name = "recordsRootNode", EmitDefaultValue = false)]
        public uint RecordsRootNode { get; set; }

        [DataMember(Name = "medalsRootNode", EmitDefaultValue = false)]
        public uint MedalsRootNode { get; set; }

        [DataMember(Name = "metricsRootNode", EmitDefaultValue = false)]
        public uint MetricsRootNode { get; set; }

        [DataMember(Name = "activeTriumphsRootNodeHash", EmitDefaultValue = false)]
        public uint ActiveTriumphsRootNodeHash { get; set; }

        [DataMember(Name = "activeSealsRootNodeHash", EmitDefaultValue = false)]
        public uint ActiveSealsRootNodeHash { get; set; }

        [DataMember(Name = "legacyTriumphsRootNodeHash", EmitDefaultValue = false)]
        public uint LegacyTriumphsRootNodeHash { get; set; }

        [DataMember(Name = "legacySealsRootNodeHash", EmitDefaultValue = false)]
        public uint LegacySealsRootNodeHash { get; set; }

        [DataMember(Name = "medalsRootNodeHash", EmitDefaultValue = false)]
        public uint MedalsRootNodeHash { get; set; }

        [DataMember(Name = "exoticCatalystsRootNodeHash", EmitDefaultValue = false)]
        public uint ExoticCatalystsRootNodeHash { get; set; }

        [DataMember(Name = "loreRootNodeHash", EmitDefaultValue = false)]
        public uint LoreRootNodeHash { get; set; }

        [DataMember(Name = "currentRankProgressionHashes", EmitDefaultValue = false)]
        public List<uint> CurrentRankProgressionHashes { get; set; }

        [DataMember(Name = "undiscoveredCollectibleImage", EmitDefaultValue = false)]
        public string UndiscoveredCollectibleImage { get; set; }

        [DataMember(Name = "ammoTypeHeavyIcon", EmitDefaultValue = false)]
        public string AmmoTypeHeavyIcon { get; set; }

        [DataMember(Name = "ammoTypeSpecialIcon", EmitDefaultValue = false)]
        public string AmmoTypeSpecialIcon { get; set; }

        [DataMember(Name = "ammoTypePrimaryIcon", EmitDefaultValue = false)]
        public string AmmoTypePrimaryIcon { get; set; }

        [DataMember(Name = "currentSeasonalArtifactHash", EmitDefaultValue = false)]
        public uint CurrentSeasonalArtifactHash { get; set; }

        [DataMember(Name = "currentSeasonHash", EmitDefaultValue = false)]
        public uint CurrentSeasonHash { get; set; }

        [DataMember(Name = "futureSeasonHashes", EmitDefaultValue = false)]
        public List<uint> FutureSeasonHashes { get; set; }

        [DataMember(Name = "pastSeasonHashes", EmitDefaultValue = false)]
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
                    (CollectionRootNode.Equals(input.CollectionRootNode))
                ) &&
                (
                    BadgesRootNode == input.BadgesRootNode ||
                    (BadgesRootNode.Equals(input.BadgesRootNode))
                ) &&
                (
                    RecordsRootNode == input.RecordsRootNode ||
                    (RecordsRootNode.Equals(input.RecordsRootNode))
                ) &&
                (
                    MedalsRootNode == input.MedalsRootNode ||
                    (MedalsRootNode.Equals(input.MedalsRootNode))
                ) &&
                (
                    MetricsRootNode == input.MetricsRootNode ||
                    (MetricsRootNode.Equals(input.MetricsRootNode))
                ) &&
                (
                    ActiveTriumphsRootNodeHash == input.ActiveTriumphsRootNodeHash ||
                    (ActiveTriumphsRootNodeHash.Equals(input.ActiveTriumphsRootNodeHash))
                ) &&
                (
                    ActiveSealsRootNodeHash == input.ActiveSealsRootNodeHash ||
                    (ActiveSealsRootNodeHash.Equals(input.ActiveSealsRootNodeHash))
                ) &&
                (
                    LegacyTriumphsRootNodeHash == input.LegacyTriumphsRootNodeHash ||
                    (LegacyTriumphsRootNodeHash.Equals(input.LegacyTriumphsRootNodeHash))
                ) &&
                (
                    LegacySealsRootNodeHash == input.LegacySealsRootNodeHash ||
                    (LegacySealsRootNodeHash.Equals(input.LegacySealsRootNodeHash))
                ) &&
                (
                    MedalsRootNodeHash == input.MedalsRootNodeHash ||
                    (MedalsRootNodeHash.Equals(input.MedalsRootNodeHash))
                ) &&
                (
                    ExoticCatalystsRootNodeHash == input.ExoticCatalystsRootNodeHash ||
                    (ExoticCatalystsRootNodeHash.Equals(input.ExoticCatalystsRootNodeHash))
                ) &&
                (
                    LoreRootNodeHash == input.LoreRootNodeHash ||
                    (LoreRootNodeHash.Equals(input.LoreRootNodeHash))
                ) &&
                (
                    CurrentRankProgressionHashes == input.CurrentRankProgressionHashes ||
                    (CurrentRankProgressionHashes != null && CurrentRankProgressionHashes.SequenceEqual(input.CurrentRankProgressionHashes))
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
                    (CurrentSeasonalArtifactHash.Equals(input.CurrentSeasonalArtifactHash))
                ) &&
                (
                    CurrentSeasonHash == input.CurrentSeasonHash ||
                    (CurrentSeasonHash.Equals(input.CurrentSeasonHash))
                ) &&
                (
                    FutureSeasonHashes == input.FutureSeasonHashes ||
                    (FutureSeasonHashes != null && FutureSeasonHashes.SequenceEqual(input.FutureSeasonHashes))
                ) &&
                (
                    PastSeasonHashes == input.PastSeasonHashes ||
                    (PastSeasonHashes != null && PastSeasonHashes.SequenceEqual(input.PastSeasonHashes))
                ) ;
        }
    }
}

