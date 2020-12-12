using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyItemSocketEntryPlugItemRandomizedDefinition
    {
        /// <summary>
        /// Indicates if the plug can be rolled on the current version of the item. For example, older versions of weapons may have plug rolls that are no longer possible on the current versions.
        /// </summary>
        [DataMember(Name = "currentlyCanRoll", EmitDefaultValue = false)]
        public bool CurrentlyCanRoll { get; set; }

        /// <summary>
        /// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
        /// </summary>
        [DataMember(Name = "plugItemHash", EmitDefaultValue = false)]
        public uint PlugItemHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemSocketEntryPlugItemRandomizedDefinition);
        }

        public bool Equals(DestinyItemSocketEntryPlugItemRandomizedDefinition input)
        {
            if (input == null) return false;

            return
                (
                    CurrentlyCanRoll == input.CurrentlyCanRoll ||
                    (CurrentlyCanRoll != null && CurrentlyCanRoll.Equals(input.CurrentlyCanRoll))
                ) &&
                (
                    PlugItemHash == input.PlugItemHash ||
                    (PlugItemHash.Equals(input.PlugItemHash))
                ) ;
        }
    }
}

