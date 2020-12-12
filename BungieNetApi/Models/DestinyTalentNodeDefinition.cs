using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Talent Grids on items have Nodes. These nodes have positions in the talent grid's UI, and contain "Steps" (DestinyTalentNodeStepDefinition), one of whom will be the "Current" step.
    /// </summary>
    /// <summary>
    /// The Current Step determines the visual properties of the node, as well as what the node grants when it is activated.
    /// </summary>
    /// <summary>
    /// See DestinyTalentGridDefinition for a more complete overview of how Talent Grids work, and how they are used in Destiny 2 (and how they were used in Destiny 1).
    /// </summary>
    [DataContract]
    public class DestinyTalentNodeDefinition
    {
        /// <summary>
        /// The index into the DestinyTalentGridDefinition's "nodes" property where this node is located. Used to uniquely identify the node within the Talent Grid. Note that this is content version dependent: make sure you have the latest version of content before trying to use these properties.
        /// </summary>
        [DataMember(Name = "nodeIndex", EmitDefaultValue = false)]
        public long NodeIndex { get; set; }

        /// <summary>
        /// The hash identifier for the node, which unfortunately is also content version dependent but can be (and ideally, should be) used instead of the nodeIndex to uniquely identify the node.
        /// </summary>
        /// <summary>
        /// The two exist side-by-side for backcompat reasons due to the Great Talent Node Restructuring of Destiny 1, and I ran out of time to remove one of them and standardize on the other. Sorry!
        /// </summary>
        [DataMember(Name = "nodeHash", EmitDefaultValue = false)]
        public uint NodeHash { get; set; }

        /// <summary>
        /// The visual "row" where the node should be shown in the UI. If negative, then the node is hidden.
        /// </summary>
        [DataMember(Name = "row", EmitDefaultValue = false)]
        public long Row { get; set; }

        /// <summary>
        /// The visual "column" where the node should be shown in the UI. If negative, the node is hidden.
        /// </summary>
        [DataMember(Name = "column", EmitDefaultValue = false)]
        public long Column { get; set; }

        /// <summary>
        /// Indexes into the DestinyTalentGridDefinition.nodes property for any nodes that must be activated before this one is allowed to be activated.
        /// </summary>
        /// <summary>
        /// I would have liked to change this to hashes for Destiny 2, but we have run out of time.
        /// </summary>
        [DataMember(Name = "prerequisiteNodeIndexes", EmitDefaultValue = false)]
        public List<long> PrerequisiteNodeIndexes { get; set; }

        /// <summary>
        /// At one point, Talent Nodes supported the idea of "Binary Pairs": nodes that overlapped each other visually, and where activating one deactivated the other. They ended up not being used, mostly because Exclusive Sets are *almost* a superset of this concept, but the potential for it to be used still exists in theory.
        /// </summary>
        /// <summary>
        /// If this is ever used, this will be the index into the DestinyTalentGridDefinition.nodes property for the node that is the binary pair match to this node. Activating one deactivates the other.
        /// </summary>
        [DataMember(Name = "binaryPairNodeIndex", EmitDefaultValue = false)]
        public long BinaryPairNodeIndex { get; set; }

        /// <summary>
        /// If true, this node will automatically unlock when the Talent Grid's level reaches the required level of the current step of this node.
        /// </summary>
        [DataMember(Name = "autoUnlocks", EmitDefaultValue = false)]
        public bool AutoUnlocks { get; set; }

        /// <summary>
        /// At one point, Nodes were going to be able to be activated multiple times, changing the current step and potentially piling on multiple effects from the previously activated steps. This property would indicate if the last step could be activated multiple times. 
        /// </summary>
        /// <summary>
        /// This is not currently used, but it isn't out of the question that this could end up being used again in a theoretical future.
        /// </summary>
        [DataMember(Name = "lastStepRepeats", EmitDefaultValue = false)]
        public bool LastStepRepeats { get; set; }

        /// <summary>
        /// If this is true, the node's step is determined randomly rather than the first step being chosen.
        /// </summary>
        [DataMember(Name = "isRandom", EmitDefaultValue = false)]
        public bool IsRandom { get; set; }

        /// <summary>
        /// At one point, you were going to be able to repurchase talent nodes that had random steps, to "re-roll" the current step of the node (and thus change the properties of your item). This was to be the activation requirement for performing that re-roll.
        /// </summary>
        /// <summary>
        /// The system still exists to do this, as far as I know, so it may yet come back around!
        /// </summary>
        [DataMember(Name = "randomActivationRequirement", EmitDefaultValue = false)]
        public DestinyNodeActivationRequirement RandomActivationRequirement { get; set; }

        /// <summary>
        /// If this is true, the node can be "re-rolled" to acquire a different random current step. This is not used, but still exists for a theoretical future of talent grids.
        /// </summary>
        [DataMember(Name = "isRandomRepurchasable", EmitDefaultValue = false)]
        public bool IsRandomRepurchasable { get; set; }

        /// <summary>
        /// At this point, "steps" have been obfuscated into conceptual entities, aggregating the underlying notions of "properties" and "true steps".
        /// </summary>
        /// <summary>
        /// If you need to know a step as it truly exists - such as when recreating Node logic when processing Vendor data - you'll have to use the "realSteps" property below.
        /// </summary>
        [DataMember(Name = "steps", EmitDefaultValue = false)]
        public List<DestinyNodeStepDefinition> Steps { get; set; }

        /// <summary>
        /// The nodeHash values for nodes that are in an Exclusive Set with this node.
        /// </summary>
        /// <summary>
        /// See DestinyTalentGridDefinition.exclusiveSets for more info about exclusive sets.
        /// </summary>
        /// <summary>
        /// Again, note that these are nodeHashes and *not* nodeIndexes.
        /// </summary>
        [DataMember(Name = "exclusiveWithNodeHashes", EmitDefaultValue = false)]
        public List<uint> ExclusiveWithNodeHashes { get; set; }

        /// <summary>
        /// If the node's step is randomly selected, this is the amount of the Talent Grid's progression experience at which the progression bar for the node should be shown.
        /// </summary>
        [DataMember(Name = "randomStartProgressionBarAtProgression", EmitDefaultValue = false)]
        public long RandomStartProgressionBarAtProgression { get; set; }

        /// <summary>
        /// A string identifier for a custom visual layout to apply to this talent node. Unfortunately, we do not have any data for rendering these custom layouts. It will be up to you to interpret these strings and change your UI if you want to have custom UI matching these layouts.
        /// </summary>
        [DataMember(Name = "layoutIdentifier", EmitDefaultValue = false)]
        public string LayoutIdentifier { get; set; }

        /// <summary>
        /// As of Destiny 2, nodes can exist as part of "Exclusive Groups". These differ from exclusive sets in that, within the group, many nodes can be activated. But the act of activating any node in the group will cause "opposing" nodes (nodes in groups that are not allowed to be activated at the same time as this group) to deactivate.
        /// </summary>
        /// <summary>
        /// See DestinyTalentExclusiveGroup for more information on the details. This is an identifier for this node's group, if it is part of one.
        /// </summary>
        [DataMember(Name = "groupHash", EmitDefaultValue = false)]
        public uint GroupHash { get; set; }

        /// <summary>
        /// Talent nodes can be associated with a piece of Lore, generally rendered in a tooltip. This is the hash identifier of the lore element to show, if there is one to be show.
        /// </summary>
        [DataMember(Name = "loreHash", EmitDefaultValue = false)]
        public uint LoreHash { get; set; }

        /// <summary>
        /// Comes from the talent grid node style: this identifier should be used to determine how to render the node in the UI.
        /// </summary>
        [DataMember(Name = "nodeStyleIdentifier", EmitDefaultValue = false)]
        public string NodeStyleIdentifier { get; set; }

        /// <summary>
        /// Comes from the talent grid node style: if true, then this node should be ignored for determining whether the grid is complete.
        /// </summary>
        [DataMember(Name = "ignoreForCompletion", EmitDefaultValue = false)]
        public bool IgnoreForCompletion { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyTalentNodeDefinition);
        }

        public bool Equals(DestinyTalentNodeDefinition input)
        {
            if (input == null) return false;

            return
                (
                    NodeIndex == input.NodeIndex ||
                    (NodeIndex.Equals(input.NodeIndex))
                ) &&
                (
                    NodeHash == input.NodeHash ||
                    (NodeHash.Equals(input.NodeHash))
                ) &&
                (
                    Row == input.Row ||
                    (Row.Equals(input.Row))
                ) &&
                (
                    Column == input.Column ||
                    (Column.Equals(input.Column))
                ) &&
                (
                    PrerequisiteNodeIndexes == input.PrerequisiteNodeIndexes ||
                    (PrerequisiteNodeIndexes != null && PrerequisiteNodeIndexes.SequenceEqual(input.PrerequisiteNodeIndexes))
                ) &&
                (
                    BinaryPairNodeIndex == input.BinaryPairNodeIndex ||
                    (BinaryPairNodeIndex.Equals(input.BinaryPairNodeIndex))
                ) &&
                (
                    AutoUnlocks == input.AutoUnlocks ||
                    (AutoUnlocks != null && AutoUnlocks.Equals(input.AutoUnlocks))
                ) &&
                (
                    LastStepRepeats == input.LastStepRepeats ||
                    (LastStepRepeats != null && LastStepRepeats.Equals(input.LastStepRepeats))
                ) &&
                (
                    IsRandom == input.IsRandom ||
                    (IsRandom != null && IsRandom.Equals(input.IsRandom))
                ) &&
                (
                    RandomActivationRequirement == input.RandomActivationRequirement ||
                    (RandomActivationRequirement != null && RandomActivationRequirement.Equals(input.RandomActivationRequirement))
                ) &&
                (
                    IsRandomRepurchasable == input.IsRandomRepurchasable ||
                    (IsRandomRepurchasable != null && IsRandomRepurchasable.Equals(input.IsRandomRepurchasable))
                ) &&
                (
                    Steps == input.Steps ||
                    (Steps != null && Steps.SequenceEqual(input.Steps))
                ) &&
                (
                    ExclusiveWithNodeHashes == input.ExclusiveWithNodeHashes ||
                    (ExclusiveWithNodeHashes != null && ExclusiveWithNodeHashes.SequenceEqual(input.ExclusiveWithNodeHashes))
                ) &&
                (
                    RandomStartProgressionBarAtProgression == input.RandomStartProgressionBarAtProgression ||
                    (RandomStartProgressionBarAtProgression.Equals(input.RandomStartProgressionBarAtProgression))
                ) &&
                (
                    LayoutIdentifier == input.LayoutIdentifier ||
                    (LayoutIdentifier != null && LayoutIdentifier.Equals(input.LayoutIdentifier))
                ) &&
                (
                    GroupHash == input.GroupHash ||
                    (GroupHash.Equals(input.GroupHash))
                ) &&
                (
                    LoreHash == input.LoreHash ||
                    (LoreHash.Equals(input.LoreHash))
                ) &&
                (
                    NodeStyleIdentifier == input.NodeStyleIdentifier ||
                    (NodeStyleIdentifier != null && NodeStyleIdentifier.Equals(input.NodeStyleIdentifier))
                ) &&
                (
                    IgnoreForCompletion == input.IgnoreForCompletion ||
                    (IgnoreForCompletion != null && IgnoreForCompletion.Equals(input.IgnoreForCompletion))
                ) ;
        }
    }
}

