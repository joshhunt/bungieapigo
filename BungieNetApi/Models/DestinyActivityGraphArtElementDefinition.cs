using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// These Art Elements are meant to represent one-off visual effects overlaid on the map. Currently, we do not have a pipeline to import the assets for these overlays, so this info exists as a placeholder for when such a pipeline exists (if it ever will)
    /// </summary>
    [DataContract]
    public class DestinyActivityGraphArtElementDefinition
    {
        /// <summary>
        /// The position on the map of the art element.
        /// </summary>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public DestinyPositionDefinition Position { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphArtElementDefinition);
        }

        public bool Equals(DestinyActivityGraphArtElementDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Position == input.Position ||
                    (Position != null && Position.Equals(input.Position))
                ) ;
        }
    }
}

