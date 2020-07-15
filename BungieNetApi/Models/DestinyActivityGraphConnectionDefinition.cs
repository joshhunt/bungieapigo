using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Nodes on a graph can be visually connected: this appears to be the information about which nodes to link. It appears to lack more detailed information, such as the path for that linking.
    /// </summary>
    [DataContract]
    public class DestinyActivityGraphConnectionDefinition
    {
        [DataMember(Name = "sourceNodeHash", EmitDefaultValue = false)]
        public uint SourceNodeHash { get; set; }

        [DataMember(Name = "destNodeHash", EmitDefaultValue = false)]
        public uint DestNodeHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphConnectionDefinition);
        }

        public bool Equals(DestinyActivityGraphConnectionDefinition input)
        {
            if (input == null) return false;

            return
                (
                    SourceNodeHash == input.SourceNodeHash ||
                    (SourceNodeHash != null && SourceNodeHash.Equals(input.SourceNodeHash))
                ) &&
                (
                    DestNodeHash == input.DestNodeHash ||
                    (DestNodeHash != null && DestNodeHash.Equals(input.DestNodeHash))
                ) ;
        }
    }
}

