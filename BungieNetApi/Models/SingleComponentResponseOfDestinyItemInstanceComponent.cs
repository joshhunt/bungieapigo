using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class SingleComponentResponseOfDestinyItemInstanceComponent
    {
        /// <summary>
        /// If an item is "instanced", this will contain information about the item's instance that doesn't fit easily into other components. One might say this is the "essential" instance data for the item.
        /// </summary>
        /// <summary>
        /// Items are instanced if they require information or state that can vary. For instance, weapons are Instanced: they are given a unique identifier, uniquely generated stats, and can have their properties altered. Non-instanced items have none of these things: for instance, Glimmer has no unique properties aside from how much of it you own.
        /// </summary>
        /// <summary>
        /// You can tell from an item's definition whether it will be instanced or not by looking at the DestinyInventoryItemDefinition's definition.inventory.isInstanceItem property.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DestinyItemInstanceComponent Data { get; set; }

        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public ComponentPrivacySetting Privacy { get; set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
        public bool Disabled { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyItemInstanceComponent);
        }

        public bool Equals(SingleComponentResponseOfDestinyItemInstanceComponent input)
        {
            if (input == null) return false;

            return
                (
                    Data == input.Data ||
                    (Data != null && Data.Equals(input.Data))
                ) &&
                (
                    Privacy == input.Privacy ||
                    (Privacy != null && Privacy.Equals(input.Privacy))
                ) &&
                (
                    Disabled == input.Disabled ||
                    (Disabled != null && Disabled.Equals(input.Disabled))
                ) ;
        }
    }
}

