using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyPostGameCarnageReportExtendedData
    {
        /// <summary>
        /// List of weapons and their perspective values.
        /// </summary>
        [DataMember(Name = "weapons", EmitDefaultValue = false)]
        public List<DestinyHistoricalWeaponStats> Weapons { get; set; }

        /// <summary>
        /// Collection of stats for the player in this activity.
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsValue> Values { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPostGameCarnageReportExtendedData);
        }

        public bool Equals(DestinyPostGameCarnageReportExtendedData input)
        {
            if (input == null) return false;

            return
                (
                    Weapons == input.Weapons ||
                    (Weapons != null && Weapons.SequenceEqual(input.Weapons))
                ) &&
                (
                    Values == input.Values ||
                    (Values != null && Values.SequenceEqual(input.Values))
                ) ;
        }
    }
}

