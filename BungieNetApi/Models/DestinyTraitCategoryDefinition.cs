using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyTraitCategoryDefinition
    {
        [DataMember(Name = "traitCategoryId", EmitDefaultValue = false)]
        public string TraitCategoryId { get; set; }

        [DataMember(Name = "traitHashes", EmitDefaultValue = false)]
        public List<uint> TraitHashes { get; set; }

        [DataMember(Name = "traitIds", EmitDefaultValue = false)]
        public List<string> TraitIds { get; set; }

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
            return this.Equals(input as DestinyTraitCategoryDefinition);
        }

        public bool Equals(DestinyTraitCategoryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    TraitCategoryId == input.TraitCategoryId ||
                    (TraitCategoryId != null && TraitCategoryId.Equals(input.TraitCategoryId))
                ) &&
                (
                    TraitHashes == input.TraitHashes ||
                    (TraitHashes != null && TraitHashes.Equals(input.TraitHashes))
                ) &&
                (
                    TraitIds == input.TraitIds ||
                    (TraitIds != null && TraitIds.Equals(input.TraitIds))
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

