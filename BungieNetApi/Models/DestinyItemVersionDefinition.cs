using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The version definition currently just holds a reference to the power cap.
    /// </summary>
    [DataContract]
    public class DestinyItemVersionDefinition
    {
        /// <summary>
        /// A reference to the power cap for this item version.
        /// </summary>
        [DataMember(Name = "powerCapHash", EmitDefaultValue = false)]
        public uint PowerCapHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemVersionDefinition);
        }

        public bool Equals(DestinyItemVersionDefinition input)
        {
            if (input == null) return false;

            return
                (
                    PowerCapHash == input.PowerCapHash ||
                    (PowerCapHash != null && PowerCapHash.Equals(input.PowerCapHash))
                ) ;
        }
    }
}

