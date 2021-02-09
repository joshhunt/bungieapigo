using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// Defines a canonical "Season" of Destiny: a range of a few months where the game highlights certain challenges, provides new loot, has new Clan-related rewards and celebrates various seasonal events.
    /// </summary>
    [DataContract]
    public class DestinySeasonDefinition
    {
        /// <summary>
        /// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        [DataMember(Name = "backgroundImagePath", EmitDefaultValue = false)]
        public string BackgroundImagePath { get; set; }

        [DataMember(Name = "seasonNumber", EmitDefaultValue = false)]
        public long SeasonNumber { get; set; }

        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public DateTime StartDate { get; set; }

        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public DateTime EndDate { get; set; }

        [DataMember(Name = "seasonPassHash", EmitDefaultValue = false)]
        public uint SeasonPassHash { get; set; }

        [DataMember(Name = "seasonPassProgressionHash", EmitDefaultValue = false)]
        public uint SeasonPassProgressionHash { get; set; }

        [DataMember(Name = "artifactItemHash", EmitDefaultValue = false)]
        public uint ArtifactItemHash { get; set; }

        [DataMember(Name = "sealPresentationNodeHash", EmitDefaultValue = false)]
        public uint SealPresentationNodeHash { get; set; }

        [DataMember(Name = "seasonalChallengesPresentationNodeHash", EmitDefaultValue = false)]
        public uint SeasonalChallengesPresentationNodeHash { get; set; }

        /// <summary>
        /// Optional - Defines the promotional text, images, and links to preview this season.
        /// </summary>
        [DataMember(Name = "preview", EmitDefaultValue = false)]
        public DestinySeasonPreviewDefinition Preview { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
        /// </summary>
        /// <summary>
        /// When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public long Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        [DataMember(Name = "redacted", EmitDefaultValue = false)]
        public bool Redacted { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinySeasonDefinition);
        }

        public bool Equals(DestinySeasonDefinition input)
        {
            if (input == null) return false;

            return
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    BackgroundImagePath == input.BackgroundImagePath ||
                    (BackgroundImagePath != null && BackgroundImagePath.Equals(input.BackgroundImagePath))
                ) &&
                (
                    SeasonNumber == input.SeasonNumber ||
                    (SeasonNumber.Equals(input.SeasonNumber))
                ) &&
                (
                    StartDate == input.StartDate ||
                    (StartDate != null && StartDate.Equals(input.StartDate))
                ) &&
                (
                    EndDate == input.EndDate ||
                    (EndDate != null && EndDate.Equals(input.EndDate))
                ) &&
                (
                    SeasonPassHash == input.SeasonPassHash ||
                    (SeasonPassHash.Equals(input.SeasonPassHash))
                ) &&
                (
                    SeasonPassProgressionHash == input.SeasonPassProgressionHash ||
                    (SeasonPassProgressionHash.Equals(input.SeasonPassProgressionHash))
                ) &&
                (
                    ArtifactItemHash == input.ArtifactItemHash ||
                    (ArtifactItemHash.Equals(input.ArtifactItemHash))
                ) &&
                (
                    SealPresentationNodeHash == input.SealPresentationNodeHash ||
                    (SealPresentationNodeHash.Equals(input.SealPresentationNodeHash))
                ) &&
                (
                    SeasonalChallengesPresentationNodeHash == input.SeasonalChallengesPresentationNodeHash ||
                    (SeasonalChallengesPresentationNodeHash.Equals(input.SeasonalChallengesPresentationNodeHash))
                ) &&
                (
                    Preview == input.Preview ||
                    (Preview != null && Preview.Equals(input.Preview))
                ) &&
                (
                    Hash == input.Hash ||
                    (Hash.Equals(input.Hash))
                ) &&
                (
                    Index == input.Index ||
                    (Index.Equals(input.Index))
                ) &&
                (
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
        }
    }
}

