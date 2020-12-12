using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// The list of indexes into the Talent Grid's "nodes" property for nodes in this exclusive set. (See DestinyTalentNodeDefinition.nodeIndex)
    /// </summary>
    [DataContract]
    public class DestinyTalentNodeExclusiveSetDefinition
    {
        /// <summary>
        /// The list of node indexes for the exclusive set. Historically, these were indexes. I would have liked to replace this with nodeHashes for consistency, but it's way too late for that. (9:09 PM, he's right!)
        /// </summary>
        [DataMember(Name = "nodeIndexes", EmitDefaultValue = false)]
        public List<long> NodeIndexes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyTalentNodeExclusiveSetDefinition);
        }

        public bool Equals(DestinyTalentNodeExclusiveSetDefinition input)
        {
            if (input == null) return false;

            return
                (
                    NodeIndexes == input.NodeIndexes ||
                    (NodeIndexes != null && NodeIndexes.SequenceEqual(input.NodeIndexes))
                ) ;
        }
    }
}

