using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyHistoricalWeaponStats
    {
        /// <summary>
        /// The hash ID of the item definition that describes the weapon.
        /// </summary>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        public uint ReferenceId { get; set; }

        /// <summary>
        /// Collection of stats for the period.
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalWeaponStats);
        }

        public bool Equals(DestinyHistoricalWeaponStats input)
        {
            if (input == null) return false;

            return
                (
                    ReferenceId == input.ReferenceId ||
                    (ReferenceId != null && ReferenceId.Equals(input.ReferenceId))
                ) &&
                (
                    Values == input.Values ||
                    (Values != null && Values.Equals(input.Values))
                ) ;
        }
    }
}

