using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyRecordDefinition
    {
        /// <summary>
        /// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// Indicates whether this Record's state is determined on a per-character or on an account-wide basis.
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public DestinyScope Scope { get; set; }

        [DataMember(Name = "presentationInfo", EmitDefaultValue = false)]
        public DestinyPresentationChildBlock PresentationInfo { get; set; }

        [DataMember(Name = "loreHash", EmitDefaultValue = false)]
        public uint LoreHash { get; set; }

        [DataMember(Name = "objectiveHashes", EmitDefaultValue = false)]
        public List<uint> ObjectiveHashes { get; set; }

        [DataMember(Name = "recordValueStyle", EmitDefaultValue = false)]
        public DestinyRecordValueStyle RecordValueStyle { get; set; }

        [DataMember(Name = "titleInfo", EmitDefaultValue = false)]
        public DestinyRecordTitleBlock TitleInfo { get; set; }

        [DataMember(Name = "completionInfo", EmitDefaultValue = false)]
        public DestinyRecordCompletionBlock CompletionInfo { get; set; }

        [DataMember(Name = "stateInfo", EmitDefaultValue = false)]
        public SchemaRecordStateBlock StateInfo { get; set; }

        /// <summary>
        /// Presentation nodes can be restricted by various requirements. This defines the rules of those requirements, and the message(s) to be shown if these requirements aren't met.
        /// </summary>
        [DataMember(Name = "requirements", EmitDefaultValue = false)]
        public DestinyPresentationNodeRequirementsBlock Requirements { get; set; }

        /// <summary>
        /// If this record has an expiration after which it cannot be earned, this is some information about that expiration.
        /// </summary>
        [DataMember(Name = "expirationInfo", EmitDefaultValue = false)]
        public DestinyRecordExpirationBlock ExpirationInfo { get; set; }

        /// <summary>
        /// Some records have multiple 'interval' objectives, and the record may be claimed at each completed interval
        /// </summary>
        [DataMember(Name = "intervalInfo", EmitDefaultValue = false)]
        public DestinyRecordIntervalBlock IntervalInfo { get; set; }

        /// <summary>
        /// If there is any publicly available information about rewards earned for achieving this record, this is the list of those items.
        /// </summary>
        /// <summary>
        ///  However, note that some records intentionally have "hidden" rewards. These will not be returned in this list.
        /// </summary>
        [DataMember(Name = "rewardItems", EmitDefaultValue = false)]
        public List<DestinyItemQuantity> RewardItems { get; set; }

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
            return this.Equals(input as DestinyRecordDefinition);
        }

        public bool Equals(DestinyRecordDefinition input)
        {
            if (input == null) return false;

            return
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) &&
                (
                    PresentationInfo == input.PresentationInfo ||
                    (PresentationInfo != null && PresentationInfo.Equals(input.PresentationInfo))
                ) &&
                (
                    LoreHash == input.LoreHash ||
                    (LoreHash.Equals(input.LoreHash))
                ) &&
                (
                    ObjectiveHashes == input.ObjectiveHashes ||
                    (ObjectiveHashes != null && ObjectiveHashes.SequenceEqual(input.ObjectiveHashes))
                ) &&
                (
                    RecordValueStyle == input.RecordValueStyle ||
                    (RecordValueStyle != null && RecordValueStyle.Equals(input.RecordValueStyle))
                ) &&
                (
                    TitleInfo == input.TitleInfo ||
                    (TitleInfo != null && TitleInfo.Equals(input.TitleInfo))
                ) &&
                (
                    CompletionInfo == input.CompletionInfo ||
                    (CompletionInfo != null && CompletionInfo.Equals(input.CompletionInfo))
                ) &&
                (
                    StateInfo == input.StateInfo ||
                    (StateInfo != null && StateInfo.Equals(input.StateInfo))
                ) &&
                (
                    Requirements == input.Requirements ||
                    (Requirements != null && Requirements.Equals(input.Requirements))
                ) &&
                (
                    ExpirationInfo == input.ExpirationInfo ||
                    (ExpirationInfo != null && ExpirationInfo.Equals(input.ExpirationInfo))
                ) &&
                (
                    IntervalInfo == input.IntervalInfo ||
                    (IntervalInfo != null && IntervalInfo.Equals(input.IntervalInfo))
                ) &&
                (
                    RewardItems == input.RewardItems ||
                    (RewardItems != null && RewardItems.SequenceEqual(input.RewardItems))
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

