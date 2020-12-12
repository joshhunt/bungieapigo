using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represent a set of material requirements: Items that either need to be owned or need to be consumed in order to perform an action.
    /// </summary>
    /// <summary>
    /// A variety of other entities refer to these as gatekeepers and payments for actions that can be performed in game.
    /// </summary>
    [DataContract]
    public class DestinyMaterialRequirementSetDefinition
    {
        /// <summary>
        /// The list of all materials that are required.
        /// </summary>
        [DataMember(Name = "materials", EmitDefaultValue = false)]
        public List<DestinyMaterialRequirement> Materials { get; set; }

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
            return this.Equals(input as DestinyMaterialRequirementSetDefinition);
        }

        public bool Equals(DestinyMaterialRequirementSetDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Materials == input.Materials ||
                    (Materials != null && Materials.SequenceEqual(input.Materials))
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

