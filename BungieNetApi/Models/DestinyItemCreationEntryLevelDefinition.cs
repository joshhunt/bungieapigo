using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// An overly complicated wrapper for the item level at which the item should spawn.
    /// </summary>
    [DataContract]
    public class DestinyItemCreationEntryLevelDefinition
    {
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public long Level { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemCreationEntryLevelDefinition);
        }

        public bool Equals(DestinyItemCreationEntryLevelDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Level == input.Level ||
                    (Level.Equals(input.Level))
                ) ;
        }
    }
}

