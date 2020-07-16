using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinySeasonPassDefinition
    {
        /// <summary>
        /// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// This is the progression definition related to the progression for the initial levels 1-100 that provide item rewards for the Season pass. Further experience after you reach the limit is provided in the "Prestige" progression referred to by prestigeProgressionHash.
        /// </summary>
        [DataMember(Name = "rewardProgressionHash", EmitDefaultValue = false)]
        public uint RewardProgressionHash { get; set; }

        /// <summary>
        /// I know what you're thinking, but I promise we're not going to duplicate and drown you. Instead, we're giving you sweet, sweet power bonuses.
        /// </summary>
        /// <summary>
        ///  Prestige progression is further progression that you can make on the Season pass after you gain max ranks, that will ultimately increase your power/light level over the theoretical limit.
        /// </summary>
        [DataMember(Name = "prestigeProgressionHash", EmitDefaultValue = false)]
        public uint PrestigeProgressionHash { get; set; }

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
            return this.Equals(input as DestinySeasonPassDefinition);
        }

        public bool Equals(DestinySeasonPassDefinition input)
        {
            if (input == null) return false;

            return
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    RewardProgressionHash == input.RewardProgressionHash ||
                    (RewardProgressionHash != null && RewardProgressionHash.Equals(input.RewardProgressionHash))
                ) &&
                (
                    PrestigeProgressionHash == input.PrestigeProgressionHash ||
                    (PrestigeProgressionHash != null && PrestigeProgressionHash.Equals(input.PrestigeProgressionHash))
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

