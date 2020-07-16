using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Basic identifying data about the bubble. Combine with DestinyDestinationBubbleSettingDefinition - see DestinyDestinationDefinition.bubbleSettings for more information.
    /// </summary>
    [DataContract]
    public class DestinyBubbleDefinition
    {
        /// <summary>
        /// The identifier for the bubble: only guaranteed to be unique within the Destination.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// The display properties of this bubble, so you don't have to look them up in a separate list anymore.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyBubbleDefinition);
        }

        public bool Equals(DestinyBubbleDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) ;
        }
    }
}

