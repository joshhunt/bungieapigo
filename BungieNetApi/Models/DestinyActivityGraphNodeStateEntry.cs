using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents a single state that a graph node might end up in. Depending on what's going on in the game, graph nodes could be shown in different ways or even excluded from view entirely.
    /// </summary>
    [DataContract]
    public class DestinyActivityGraphNodeStateEntry
    {
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DestinyGraphNodeState State { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphNodeStateEntry);
        }

        public bool Equals(DestinyActivityGraphNodeStateEntry input)
        {
            if (input == null) return false;

            return
                (
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) ;
        }
    }
}

