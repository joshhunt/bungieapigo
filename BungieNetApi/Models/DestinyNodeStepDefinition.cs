using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// This defines the properties of a "Talent Node Step". When you see a talent node in game, the actual visible properties that you see (its icon, description, the perks and stats it provides) are not provided by the Node itself, but rather by the currently active Step on the node.
    /// </summary>
    /// <summary>
    /// When a Talent Node is activated, the currently active step's benefits are conferred upon the item and character.
    /// </summary>
    /// <summary>
    /// The currently active step on talent nodes are determined when an item is first instantiated. Sometimes it is random, sometimes it is more deterministic (particularly when a node has only a single step).
    /// </summary>
    /// <summary>
    /// Note that, when dealing with Talent Node Steps, you must ensure that you have the latest version of content. stepIndex and nodeStepHash - two ways of identifying the step within a node - are both content version dependent, and thus are subject to change between content updates.
    /// </summary>
    [DataContract]
    public class DestinyNodeStepDefinition
    {
        /// <summary>
        /// These are the display properties actually used to render the Talent Node. The currently active step's displayProperties are shown.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// The index of this step in the list of Steps on the Talent Node.
        /// </summary>
        /// <summary>
        /// Unfortunately, this is the closest thing we have to an identifier for the Step: steps are not provided a content version agnostic identifier. This means that, when you are dealing with talent nodes, you will need to first ensure that you have the latest version of content.
        /// </summary>
        [DataMember(Name = "stepIndex", EmitDefaultValue = false)]
        public long StepIndex { get; set; }

        /// <summary>
        /// The hash of this node step. Unfortunately, while it can be used to uniquely identify the step within a node, it is also content version dependent and should not be relied on without ensuring you have the latest vesion of content.
        /// </summary>
        [DataMember(Name = "nodeStepHash", EmitDefaultValue = false)]
        public uint NodeStepHash { get; set; }

        /// <summary>
        /// If you can interact with this node in some way, this is the localized description of that interaction.
        /// </summary>
        [DataMember(Name = "interactionDescription", EmitDefaultValue = false)]
        public string InteractionDescription { get; set; }

        /// <summary>
        /// An enum representing a damage type granted by activating this step, if any.
        /// </summary>
        [DataMember(Name = "damageType", EmitDefaultValue = false)]
        public DamageType DamageType { get; set; }

        /// <summary>
        /// If the step provides a damage type, this will be the hash identifier used to look up the damage type's DestinyDamageTypeDefinition.
        /// </summary>
        [DataMember(Name = "damageTypeHash", EmitDefaultValue = false)]
        public uint DamageTypeHash { get; set; }

        /// <summary>
        /// If the step has requirements for activation (they almost always do, if nothing else than for the Talent Grid's Progression to have reached a certain level), they will be defined here.
        /// </summary>
        [DataMember(Name = "activationRequirement", EmitDefaultValue = false)]
        public DestinyNodeActivationRequirement ActivationRequirement { get; set; }

        /// <summary>
        /// There was a time when talent nodes could be activated multiple times, and the effects of subsequent Steps would be compounded on each other, essentially "upgrading" the node. We have moved away from this, but theoretically the capability still exists.
        /// </summary>
        /// <summary>
        /// I continue to return this in case it is used in the future: if true and this step is the current step in the node, you are allowed to activate the node a second time to receive the benefits of the next step in the node, which will then become the active step.
        /// </summary>
        [DataMember(Name = "canActivateNextStep", EmitDefaultValue = false)]
        public bool CanActivateNextStep { get; set; }

        /// <summary>
        /// The stepIndex of the next step in the talent node, or -1 if this is the last step or if the next step to be chosen is random.
        /// </summary>
        /// <summary>
        /// This doesn't really matter anymore unless canActivateNextStep begins to be used again.
        /// </summary>
        [DataMember(Name = "nextStepIndex", EmitDefaultValue = false)]
        public long NextStepIndex { get; set; }

        /// <summary>
        /// If true, the next step to be chosen is random, and if you're allowed to activate the next step. (if canActivateNextStep = true)
        /// </summary>
        [DataMember(Name = "isNextStepRandom", EmitDefaultValue = false)]
        public bool IsNextStepRandom { get; set; }

        /// <summary>
        /// The list of hash identifiers for Perks (DestinySandboxPerkDefinition) that are applied when this step is active. Perks provide a variety of benefits and modifications - examine DestinySandboxPerkDefinition to learn more.
        /// </summary>
        [DataMember(Name = "perkHashes", EmitDefaultValue = false)]
        public List<uint> PerkHashes { get; set; }

        /// <summary>
        /// When the Talent Grid's progression reaches this value, the circular "progress bar" that surrounds the talent node should be shown.
        /// </summary>
        /// <summary>
        /// This also indicates the lower bound of said progress bar, with the upper bound being the progress required to reach activationRequirement.gridLevel. (at some point I should precalculate the upper bound and put it in the definition to save people time)
        /// </summary>
        [DataMember(Name = "startProgressionBarAtProgress", EmitDefaultValue = false)]
        public long StartProgressionBarAtProgress { get; set; }

        /// <summary>
        /// When the step provides stat benefits on the item or character, this is the list of hash identifiers for stats (DestinyStatDefinition) that are provided.
        /// </summary>
        [DataMember(Name = "statHashes", EmitDefaultValue = false)]
        public List<uint> StatHashes { get; set; }

        /// <summary>
        /// If this is true, the step affects the item's Quality in some way. See DestinyInventoryItemDefinition for more information about the meaning of Quality. I already made a joke about Zen and the Art of Motorcycle Maintenance elsewhere in the documentation, so I will avoid doing it again. Oops too late
        /// </summary>
        [DataMember(Name = "affectsQuality", EmitDefaultValue = false)]
        public bool AffectsQuality { get; set; }

        /// <summary>
        /// In Destiny 1, the Armory's Perk Filtering was driven by a concept of TalentNodeStepGroups: categorizations of talent nodes based on their functionality. While the Armory isn't a BNet-facing thing for now, and the new Armory will need to account for Sockets rather than Talent Nodes, this categorization capability feels useful enough to still keep around.
        /// </summary>
        [DataMember(Name = "stepGroups", EmitDefaultValue = false)]
        public DestinyTalentNodeStepGroups StepGroups { get; set; }

        /// <summary>
        /// If true, this step can affect the level of the item. See DestinyInventoryItemDefintion for more information about item levels and their effect on stats.
        /// </summary>
        [DataMember(Name = "affectsLevel", EmitDefaultValue = false)]
        public bool AffectsLevel { get; set; }

        /// <summary>
        /// If this step is activated, this will be a list of information used to replace socket items with new Plugs. See DestinyInventoryItemDefinition for more information about sockets and plugs.
        /// </summary>
        [DataMember(Name = "socketReplacements", EmitDefaultValue = false)]
        public List<DestinyNodeSocketReplaceResponse> SocketReplacements { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyNodeStepDefinition);
        }

        public bool Equals(DestinyNodeStepDefinition input)
        {
            if (input == null) return false;

            return
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    StepIndex == input.StepIndex ||
                    (StepIndex != null && StepIndex.Equals(input.StepIndex))
                ) &&
                (
                    NodeStepHash == input.NodeStepHash ||
                    (NodeStepHash != null && NodeStepHash.Equals(input.NodeStepHash))
                ) &&
                (
                    InteractionDescription == input.InteractionDescription ||
                    (InteractionDescription != null && InteractionDescription.Equals(input.InteractionDescription))
                ) &&
                (
                    DamageType == input.DamageType ||
                    (DamageType != null && DamageType.Equals(input.DamageType))
                ) &&
                (
                    DamageTypeHash == input.DamageTypeHash ||
                    (DamageTypeHash != null && DamageTypeHash.Equals(input.DamageTypeHash))
                ) &&
                (
                    ActivationRequirement == input.ActivationRequirement ||
                    (ActivationRequirement != null && ActivationRequirement.Equals(input.ActivationRequirement))
                ) &&
                (
                    CanActivateNextStep == input.CanActivateNextStep ||
                    (CanActivateNextStep != null && CanActivateNextStep.Equals(input.CanActivateNextStep))
                ) &&
                (
                    NextStepIndex == input.NextStepIndex ||
                    (NextStepIndex != null && NextStepIndex.Equals(input.NextStepIndex))
                ) &&
                (
                    IsNextStepRandom == input.IsNextStepRandom ||
                    (IsNextStepRandom != null && IsNextStepRandom.Equals(input.IsNextStepRandom))
                ) &&
                (
                    PerkHashes == input.PerkHashes ||
                    (PerkHashes != null && PerkHashes.Equals(input.PerkHashes))
                ) &&
                (
                    StartProgressionBarAtProgress == input.StartProgressionBarAtProgress ||
                    (StartProgressionBarAtProgress != null && StartProgressionBarAtProgress.Equals(input.StartProgressionBarAtProgress))
                ) &&
                (
                    StatHashes == input.StatHashes ||
                    (StatHashes != null && StatHashes.Equals(input.StatHashes))
                ) &&
                (
                    AffectsQuality == input.AffectsQuality ||
                    (AffectsQuality != null && AffectsQuality.Equals(input.AffectsQuality))
                ) &&
                (
                    StepGroups == input.StepGroups ||
                    (StepGroups != null && StepGroups.Equals(input.StepGroups))
                ) &&
                (
                    AffectsLevel == input.AffectsLevel ||
                    (AffectsLevel != null && AffectsLevel.Equals(input.AffectsLevel))
                ) &&
                (
                    SocketReplacements == input.SocketReplacements ||
                    (SocketReplacements != null && SocketReplacements.Equals(input.SocketReplacements))
                ) ;
        }
    }
}

