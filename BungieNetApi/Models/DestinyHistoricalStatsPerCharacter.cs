using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyHistoricalStatsPerCharacter
    {
        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public bool Deleted { get; set; }

        [DataMember(Name = "results", EmitDefaultValue = false)]
        public Dictionary<string, DestinyHistoricalStatsByPeriod> Results { get; set; }

        [DataMember(Name = "merged", EmitDefaultValue = false)]
        public DestinyHistoricalStatsByPeriod Merged { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsPerCharacter);
        }

        public bool Equals(DestinyHistoricalStatsPerCharacter input)
        {
            if (input == null) return false;

            return
                (
                    CharacterId == input.CharacterId ||
                    (CharacterId.Equals(input.CharacterId))
                ) &&
                (
                    Deleted == input.Deleted ||
                    (Deleted != null && Deleted.Equals(input.Deleted))
                ) &&
                (
                    Results == input.Results ||
                    (Results != null && Results.SequenceEqual(input.Results))
                ) &&
                (
                    Merged == input.Merged ||
                    (Merged != null && Merged.Equals(input.Merged))
                ) ;
        }
    }
}

