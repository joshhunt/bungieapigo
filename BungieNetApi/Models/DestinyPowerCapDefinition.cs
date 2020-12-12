using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Defines a 'power cap' (limit) for gear items, based on the rarity tier and season of release.
    /// </summary>
    [DataContract]
    public class DestinyPowerCapDefinition
    {
        /// <summary>
        /// The raw value for a power cap.
        /// </summary>
        [DataMember(Name = "powerCap", EmitDefaultValue = false)]
        public long PowerCap { get; set; }

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
            return this.Equals(input as DestinyPowerCapDefinition);
        }

        public bool Equals(DestinyPowerCapDefinition input)
        {
            if (input == null) return false;

            return
                (
                    PowerCap == input.PowerCap ||
                    (PowerCap.Equals(input.PowerCap))
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

