using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// This defines information that can only come from a talent grid on an item. Items mostly have negligible talent grid data these days, but instanced items still retain grids as a source for some of this common information.
    /// </summary>
    /// <summary>
    /// Builds/Subclasses are the only items left that still have talent grids with meaningful Nodes.
    /// </summary>
    [DataContract]
    public class DestinyItemTalentGridBlockDefinition
    {
        /// <summary>
        /// The hash identifier of the DestinyTalentGridDefinition attached to this item.
        /// </summary>
        [DataMember(Name = "talentGridHash", EmitDefaultValue = false)]
        public uint TalentGridHash { get; set; }

        /// <summary>
        /// This is meant to be a subtitle for looking at the talent grid. In practice, somewhat frustratingly, this always merely says the localized word for "Details". Great. Maybe it'll have more if talent grids ever get used for more than builds and subclasses again.
        /// </summary>
        [DataMember(Name = "itemDetailString", EmitDefaultValue = false)]
        public string ItemDetailString { get; set; }

        /// <summary>
        /// A shortcut string identifier for the "build" in question, if this talent grid has an associated build. Doesn't map to anything we can expose at the moment.
        /// </summary>
        [DataMember(Name = "buildName", EmitDefaultValue = false)]
        public string BuildName { get; set; }

        /// <summary>
        /// If the talent grid implies a damage type, this is the enum value for that damage type.
        /// </summary>
        [DataMember(Name = "hudDamageType", EmitDefaultValue = false)]
        public DamageType HudDamageType { get; set; }

        /// <summary>
        /// If the talent grid has a special icon that's shown in the game UI (like builds, funny that), this is the identifier for that icon. Sadly, we don't actually get that icon right now. I'll be looking to replace this with a path to the actual icon itself.
        /// </summary>
        [DataMember(Name = "hudIcon", EmitDefaultValue = false)]
        public string HudIcon { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemTalentGridBlockDefinition);
        }

        public bool Equals(DestinyItemTalentGridBlockDefinition input)
        {
            if (input == null) return false;

            return
                (
                    TalentGridHash == input.TalentGridHash ||
                    (TalentGridHash != null && TalentGridHash.Equals(input.TalentGridHash))
                ) &&
                (
                    ItemDetailString == input.ItemDetailString ||
                    (ItemDetailString != null && ItemDetailString.Equals(input.ItemDetailString))
                ) &&
                (
                    BuildName == input.BuildName ||
                    (BuildName != null && BuildName.Equals(input.BuildName))
                ) &&
                (
                    HudDamageType == input.HudDamageType ||
                    (HudDamageType != null && HudDamageType.Equals(input.HudDamageType))
                ) &&
                (
                    HudIcon == input.HudIcon ||
                    (HudIcon != null && HudIcon.Equals(input.HudIcon))
                ) ;
        }
    }
}

