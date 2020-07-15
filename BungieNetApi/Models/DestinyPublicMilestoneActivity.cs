using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// A milestone may have one or more conceptual Activities associated with it, and each of those conceptual activities could have a variety of variants, modes, tiers, what-have-you. Our attempts to determine what qualifies as a conceptual activity are, unfortunately, janky. So if you see missing modes or modes that don't seem appropriate to you, let us know and I'll buy you a beer if we ever meet up in person.
    /// </summary>
    [DataContract]
    public class DestinyPublicMilestoneActivity
    {
        /// <summary>
        /// The hash identifier of the activity that's been chosen to be considered the canonical "conceptual" activity definition. This may have many variants, defined herein.
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        /// <summary>
        /// The activity may have 0-to-many modifiers: if it does, this will contain the hashes to the DestinyActivityModifierDefinition that defines the modifier being applied.
        /// </summary>
        [DataMember(Name = "modifierHashes", EmitDefaultValue = false)]
        public List<uint> ModifierHashes { get; set; }

        /// <summary>
        /// Every relevant variation of this conceptual activity, including the conceptual activity itself, have variants defined here.
        /// </summary>
        [DataMember(Name = "variants", EmitDefaultValue = false)]
        public List<DestinyPublicMilestoneActivityVariant> Variants { get; set; }

        /// <summary>
        /// The hash identifier of the most specific Activity Mode under which this activity is played. This is useful for situations where the activity in question is - for instance - a PVP map, but it's not clear what mode the PVP map is being played under. If it's a playlist, this will be less specific: but hopefully useful in some way.
        /// </summary>
        [DataMember(Name = "activityModeHash", EmitDefaultValue = false)]
        public uint ActivityModeHash { get; set; }

        /// <summary>
        /// The enumeration equivalent of the most specific Activity Mode under which this activity is played.
        /// </summary>
        [DataMember(Name = "activityModeType", EmitDefaultValue = false)]
        public long ActivityModeType { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicMilestoneActivity);
        }

        public bool Equals(DestinyPublicMilestoneActivity input)
        {
            if (input == null) return false;

            return
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    ModifierHashes == input.ModifierHashes ||
                    (ModifierHashes != null && ModifierHashes.Equals(input.ModifierHashes))
                ) &&
                (
                    Variants == input.Variants ||
                    (Variants != null && Variants.Equals(input.Variants))
                ) &&
                (
                    ActivityModeHash == input.ActivityModeHash ||
                    (ActivityModeHash != null && ActivityModeHash.Equals(input.ActivityModeHash))
                ) &&
                (
                    ActivityModeType == input.ActivityModeType ||
                    (ActivityModeType != null && ActivityModeType.Equals(input.ActivityModeType))
                ) ;
        }
    }
}

