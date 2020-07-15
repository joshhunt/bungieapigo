using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// An intrinsic perk on an item, and the requirements for it to be activated.
    /// </summary>
    [DataContract]
    public class DestinyItemPerkEntryDefinition
    {
        /// <summary>
        /// If this perk is not active, this is the string to show for why it's not providing its benefits.
        /// </summary>
        [DataMember(Name = "requirementDisplayString", EmitDefaultValue = false)]
        public string RequirementDisplayString { get; set; }

        /// <summary>
        /// A hash identifier for the DestinySandboxPerkDefinition being provided on the item.
        /// </summary>
        [DataMember(Name = "perkHash", EmitDefaultValue = false)]
        public uint PerkHash { get; set; }

        /// <summary>
        /// Indicates whether this perk should be shown, or if it should be shown disabled.
        /// </summary>
        [DataMember(Name = "perkVisibility", EmitDefaultValue = false)]
        public ItemPerkVisibility PerkVisibility { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemPerkEntryDefinition);
        }

        public bool Equals(DestinyItemPerkEntryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    RequirementDisplayString == input.RequirementDisplayString ||
                    (RequirementDisplayString != null && RequirementDisplayString.Equals(input.RequirementDisplayString))
                ) &&
                (
                    PerkHash == input.PerkHash ||
                    (PerkHash != null && PerkHash.Equals(input.PerkHash))
                ) &&
                (
                    PerkVisibility == input.PerkVisibility ||
                    (PerkVisibility != null && PerkVisibility.Equals(input.PerkVisibility))
                ) ;
        }
    }
}

