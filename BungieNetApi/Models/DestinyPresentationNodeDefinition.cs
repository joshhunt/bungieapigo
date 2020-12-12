using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// A PresentationNode is an entity that represents a logical grouping of other entities visually/organizationally.
    /// </summary>
    /// <summary>
    /// For now, Presentation Nodes may contain the following... but it may be used for more in the future:
    /// </summary>
    /// <summary>
    /// - Collectibles - Records (Or, as the public will call them, "Triumphs." Don't ask me why we're overloading the term "Triumph", it still hurts me to think about it) - Metrics (aka Stat Trackers) - Other Presentation Nodes, allowing a tree of Presentation Nodes to be created
    /// </summary>
    /// <summary>
    /// Part of me wants to break these into conceptual definitions per entity being collected, but the possibility of these different types being mixed in the same UI and the possibility that it could actually be more useful to return the "bare metal" presentation node concept has resulted in me deciding against that for the time being.
    /// </summary>
    /// <summary>
    /// We'll see if I come to regret this as well.
    /// </summary>
    [DataContract]
    public class DestinyPresentationNodeDefinition
    {
        /// <summary>
        /// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// The original icon for this presentation node, before we futzed with it.
        /// </summary>
        [DataMember(Name = "originalIcon", EmitDefaultValue = false)]
        public string OriginalIcon { get; set; }

        /// <summary>
        /// Some presentation nodes are meant to be explicitly shown on the "root" or "entry" screens for the feature to which they are related. You should use this icon when showing them on such a view, if you have a similar "entry point" view in your UI. If you don't have a UI, then I guess it doesn't matter either way does it?
        /// </summary>
        [DataMember(Name = "rootViewIcon", EmitDefaultValue = false)]
        public string RootViewIcon { get; set; }

        [DataMember(Name = "nodeType", EmitDefaultValue = false)]
        public DestinyPresentationNodeType NodeType { get; set; }

        /// <summary>
        /// Indicates whether this presentation node's state is determined on a per-character or on an account-wide basis.
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public DestinyScope Scope { get; set; }

        /// <summary>
        /// If this presentation node shows a related objective (for instance, if it tracks the progress of its children), the objective being tracked is indicated here.
        /// </summary>
        [DataMember(Name = "objectiveHash", EmitDefaultValue = false)]
        public uint ObjectiveHash { get; set; }

        /// <summary>
        /// If this presentation node has an associated "Record" that you can accomplish for completing its children, this is the identifier of that Record.
        /// </summary>
        [DataMember(Name = "completionRecordHash", EmitDefaultValue = false)]
        public uint CompletionRecordHash { get; set; }

        /// <summary>
        /// The child entities contained by this presentation node.
        /// </summary>
        [DataMember(Name = "children", EmitDefaultValue = false)]
        public DestinyPresentationNodeChildrenBlock Children { get; set; }

        /// <summary>
        /// A hint for how to display this presentation node when it's shown in a list.
        /// </summary>
        [DataMember(Name = "displayStyle", EmitDefaultValue = false)]
        public DestinyPresentationDisplayStyle DisplayStyle { get; set; }

        /// <summary>
        /// A hint for how to display this presentation node when it's shown in its own detail screen.
        /// </summary>
        [DataMember(Name = "screenStyle", EmitDefaultValue = false)]
        public DestinyPresentationScreenStyle ScreenStyle { get; set; }

        /// <summary>
        /// The requirements for being able to interact with this presentation node and its children.
        /// </summary>
        [DataMember(Name = "requirements", EmitDefaultValue = false)]
        public DestinyPresentationNodeRequirementsBlock Requirements { get; set; }

        /// <summary>
        /// If this presentation node has children, but the game doesn't let you inspect the details of those children, that is indicated here.
        /// </summary>
        [DataMember(Name = "disableChildSubscreenNavigation", EmitDefaultValue = false)]
        public bool DisableChildSubscreenNavigation { get; set; }

        [DataMember(Name = "presentationNodeType", EmitDefaultValue = false)]
        public DestinyPresentationNodeType PresentationNodeType { get; set; }

        [DataMember(Name = "traitIds", EmitDefaultValue = false)]
        public List<string> TraitIds { get; set; }

        [DataMember(Name = "traitHashes", EmitDefaultValue = false)]
        public List<uint> TraitHashes { get; set; }

        /// <summary>
        /// A quick reference to presentation nodes that have this node as a child. Presentation nodes can be parented under multiple parents.
        /// </summary>
        [DataMember(Name = "parentNodeHashes", EmitDefaultValue = false)]
        public List<uint> ParentNodeHashes { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
        /// </summary>
        /// <summary>
        /// When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public long Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        [DataMember(Name = "redacted", EmitDefaultValue = false)]
        public bool Redacted { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPresentationNodeDefinition);
        }

        public bool Equals(DestinyPresentationNodeDefinition input)
        {
            if (input == null) return false;

            return
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    OriginalIcon == input.OriginalIcon ||
                    (OriginalIcon != null && OriginalIcon.Equals(input.OriginalIcon))
                ) &&
                (
                    RootViewIcon == input.RootViewIcon ||
                    (RootViewIcon != null && RootViewIcon.Equals(input.RootViewIcon))
                ) &&
                (
                    NodeType == input.NodeType ||
                    (NodeType != null && NodeType.Equals(input.NodeType))
                ) &&
                (
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) &&
                (
                    ObjectiveHash == input.ObjectiveHash ||
                    (ObjectiveHash.Equals(input.ObjectiveHash))
                ) &&
                (
                    CompletionRecordHash == input.CompletionRecordHash ||
                    (CompletionRecordHash.Equals(input.CompletionRecordHash))
                ) &&
                (
                    Children == input.Children ||
                    (Children != null && Children.Equals(input.Children))
                ) &&
                (
                    DisplayStyle == input.DisplayStyle ||
                    (DisplayStyle != null && DisplayStyle.Equals(input.DisplayStyle))
                ) &&
                (
                    ScreenStyle == input.ScreenStyle ||
                    (ScreenStyle != null && ScreenStyle.Equals(input.ScreenStyle))
                ) &&
                (
                    Requirements == input.Requirements ||
                    (Requirements != null && Requirements.Equals(input.Requirements))
                ) &&
                (
                    DisableChildSubscreenNavigation == input.DisableChildSubscreenNavigation ||
                    (DisableChildSubscreenNavigation != null && DisableChildSubscreenNavigation.Equals(input.DisableChildSubscreenNavigation))
                ) &&
                (
                    PresentationNodeType == input.PresentationNodeType ||
                    (PresentationNodeType != null && PresentationNodeType.Equals(input.PresentationNodeType))
                ) &&
                (
                    TraitIds == input.TraitIds ||
                    (TraitIds != null && TraitIds.SequenceEqual(input.TraitIds))
                ) &&
                (
                    TraitHashes == input.TraitHashes ||
                    (TraitHashes != null && TraitHashes.SequenceEqual(input.TraitHashes))
                ) &&
                (
                    ParentNodeHashes == input.ParentNodeHashes ||
                    (ParentNodeHashes != null && ParentNodeHashes.SequenceEqual(input.ParentNodeHashes))
                ) &&
                (
                    Hash == input.Hash ||
                    (Hash.Equals(input.Hash))
                ) &&
                (
                    Index == input.Index ||
                    (Index.Equals(input.Index))
                ) &&
                (
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
        }
    }
}

