using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// As of Destiny 2, nodes can exist as part of "Exclusive Groups". These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause "opposing" nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.
    /// </summary>
    [DataContract]
    public class DestinyTalentExclusiveGroup
    {
        /// <summary>
        /// The identifier for this exclusive group. Only guaranteed unique within the talent grid, not globally.
        /// </summary>
        [DataMember(Name = "groupHash", EmitDefaultValue = false)]
        public uint GroupHash { get; set; }

        /// <summary>
        /// If this group has an associated piece of lore to show next to it, this will be the identifier for that DestinyLoreDefinition.
        /// </summary>
        [DataMember(Name = "loreHash", EmitDefaultValue = false)]
        public uint LoreHash { get; set; }

        /// <summary>
        /// A quick reference of the talent nodes that are part of this group, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
        /// </summary>
        [DataMember(Name = "nodeHashes", EmitDefaultValue = false)]
        public List<uint> NodeHashes { get; set; }

        /// <summary>
        /// A quick reference of Groups whose nodes will be deactivated if any node in this group is activated.
        /// </summary>
        [DataMember(Name = "opposingGroupHashes", EmitDefaultValue = false)]
        public List<uint> OpposingGroupHashes { get; set; }

        /// <summary>
        /// A quick reference of Nodes that will be deactivated if any node in this group is activated, by their Talent Node hashes. (See DestinyTalentNodeDefinition.nodeHash)
        /// </summary>
        [DataMember(Name = "opposingNodeHashes", EmitDefaultValue = false)]
        public List<uint> OpposingNodeHashes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyTalentExclusiveGroup);
        }

        public bool Equals(DestinyTalentExclusiveGroup input)
        {
            if (input == null) return false;

            return
                (
                    GroupHash == input.GroupHash ||
                    (GroupHash != null && GroupHash.Equals(input.GroupHash))
                ) &&
                (
                    LoreHash == input.LoreHash ||
                    (LoreHash != null && LoreHash.Equals(input.LoreHash))
                ) &&
                (
                    NodeHashes == input.NodeHashes ||
                    (NodeHashes != null && NodeHashes.Equals(input.NodeHashes))
                ) &&
                (
                    OpposingGroupHashes == input.OpposingGroupHashes ||
                    (OpposingGroupHashes != null && OpposingGroupHashes.Equals(input.OpposingGroupHashes))
                ) &&
                (
                    OpposingNodeHashes == input.OpposingNodeHashes ||
                    (OpposingNodeHashes != null && OpposingNodeHashes.Equals(input.OpposingNodeHashes))
                ) ;
        }
    }
}

