using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// When a Graph needs to show active Progressions, this defines those objectives as well as an identifier.
    /// </summary>
    [DataContract]
    public class DestinyActivityGraphDisplayProgressionDefinition
    {
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public uint Id { get; set; }

        [DataMember(Name = "progressionHash", EmitDefaultValue = false)]
        public uint ProgressionHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphDisplayProgressionDefinition);
        }

        public bool Equals(DestinyActivityGraphDisplayProgressionDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Id == input.Id ||
                    (Id != null && Id.Equals(input.Id))
                ) &&
                (
                    ProgressionHash == input.ProgressionHash ||
                    (ProgressionHash != null && ProgressionHash.Equals(input.ProgressionHash))
                ) ;
        }
    }
}

