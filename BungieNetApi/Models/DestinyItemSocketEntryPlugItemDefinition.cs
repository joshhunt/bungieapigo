using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// The definition of a known, reusable plug that can be applied to a socket.
    /// </summary>
    [DataContract]
    public class DestinyItemSocketEntryPlugItemDefinition
    {
        /// <summary>
        /// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
        /// </summary>
        [DataMember(Name = "plugItemHash", EmitDefaultValue = false)]
        public uint PlugItemHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketEntryPlugItemDefinition);
        }

        public bool Equals(DestinyItemSocketEntryPlugItemDefinition input)
        {
            if (input == null) return false;

            return
                (
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash != null && PlugItemHash.Equals(input.PlugItemHash))
                ) ;
        }
    }
}

