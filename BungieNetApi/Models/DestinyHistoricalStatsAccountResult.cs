using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyHistoricalStatsAccountResult
    {
        [DataMember(Name = "mergedDeletedCharacters", EmitDefaultValue = false)]
        public DestinyHistoricalStatsWithMerged MergedDeletedCharacters { get; set; }

        [DataMember(Name = "mergedAllCharacters", EmitDefaultValue = false)]
        public DestinyHistoricalStatsWithMerged MergedAllCharacters { get; set; }

        [DataMember(Name = "characters", EmitDefaultValue = false)]
        public List<DestinyHistoricalStatsPerCharacter> Characters { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsAccountResult);
        }

        public bool Equals(DestinyHistoricalStatsAccountResult input)
        {
            if (input == null) return false;

            return
                (
                    MergedDeletedCharacters == input.MergedDeletedCharacters ||
                    (MergedDeletedCharacters != null && MergedDeletedCharacters.Equals(input.MergedDeletedCharacters))
                ) &&
                (
                    MergedAllCharacters == input.MergedAllCharacters ||
                    (MergedAllCharacters != null && MergedAllCharacters.Equals(input.MergedAllCharacters))
                ) &&
                (
                    Characters == input.Characters ||
                    (Characters != null && Characters.SequenceEqual(input.Characters))
                ) ;
        }
    }
}

