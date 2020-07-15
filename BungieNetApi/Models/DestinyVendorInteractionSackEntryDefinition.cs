using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Compare this sackType to the sack identifier in the DestinyInventoryItemDefinition.vendorSackType property of items. If they match, show this sack with this interaction.
    /// </summary>
    [DataContract]
    public class DestinyVendorInteractionSackEntryDefinition
    {
        [DataMember(Name = "sackType", EmitDefaultValue = false)]
        public uint SackType { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorInteractionSackEntryDefinition);
        }

        public bool Equals(DestinyVendorInteractionSackEntryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    SackType == input.SackType ||
                    (SackType != null && SackType.Equals(input.SackType))
                ) ;
        }
    }
}

