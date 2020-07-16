using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents the "Live" data that we can obtain about a Character's status with a specific Activity. This will tell you whether the character can participate in the activity, as well as some other basic mutable information. 
    /// </summary>
    /// <summary>
    /// Meant to be combined with static DestinyActivityDefinition data for a full picture of the Activity.
    /// </summary>
    [DataContract]
    public class DestinyActivity
    {
        /// <summary>
        /// The hash identifier of the Activity. Use this to look up the DestinyActivityDefinition of the activity.
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        /// <summary>
        /// If true, then the activity should have a "new" indicator in the Director UI.
        /// </summary>
        [DataMember(Name = "isNew", EmitDefaultValue = false)]
        public bool IsNew { get; set; }

        /// <summary>
        /// If true, the user is allowed to lead a Fireteam into this activity.
        /// </summary>
        [DataMember(Name = "canLead", EmitDefaultValue = false)]
        public bool CanLead { get; set; }

        /// <summary>
        /// If true, the user is allowed to join with another Fireteam in this activity.
        /// </summary>
        [DataMember(Name = "canJoin", EmitDefaultValue = false)]
        public bool CanJoin { get; set; }

        /// <summary>
        /// If true, we both have the ability to know that the user has completed this activity and they have completed it. Unfortunately, we can't necessarily know this for all activities. As such, this should probably only be used if you already know in advance which specific activities you wish to check.
        /// </summary>
        [DataMember(Name = "isCompleted", EmitDefaultValue = false)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// If true, the user should be able to see this activity.
        /// </summary>
        [DataMember(Name = "isVisible", EmitDefaultValue = false)]
        public bool IsVisible { get; set; }

        /// <summary>
        /// The difficulty level of the activity, if applicable.
        /// </summary>
        [DataMember(Name = "displayLevel", EmitDefaultValue = false)]
        public long DisplayLevel { get; set; }

        /// <summary>
        /// The recommended light level for the activity, if applicable.
        /// </summary>
        [DataMember(Name = "recommendedLight", EmitDefaultValue = false)]
        public long RecommendedLight { get; set; }

        /// <summary>
        /// A DestinyActivityDifficultyTier enum value indicating the difficulty of the activity.
        /// </summary>
        [DataMember(Name = "difficultyTier", EmitDefaultValue = false)]
        public DestinyActivityDifficultyTier DifficultyTier { get; set; }

        [DataMember(Name = "challenges", EmitDefaultValue = false)]
        public List<DestinyChallengeStatus> Challenges { get; set; }

        /// <summary>
        /// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.
        /// </summary>
        /// <summary>
        /// Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
        /// </summary>
        [DataMember(Name = "modifierHashes", EmitDefaultValue = false)]
        public List<uint> ModifierHashes { get; set; }

        /// <summary>
        /// The set of activity options for this activity, keyed by an identifier that's unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).
        /// </summary>
        /// <summary>
        /// As a concrete example of this data, the hashes you get for Raids will correspond to the currently active "Challenge Mode".
        /// </summary>
        /// <summary>
        /// We don't have any human readable information for these, but saavy 3rd party app users could manually associate the key (a hash identifier for the "option" that is enabled/disabled) and the value (whether it's enabled or disabled presently)
        /// </summary>
        /// <summary>
        /// On our side, we don't necessarily even know what these are used for (the game designers know, but we don't), and we have no human readable data for them. In order to use them, you will have to do some experimentation.
        /// </summary>
        [DataMember(Name = "booleanActivityOptions", EmitDefaultValue = false)]
        public Dictionary<string, bool> BooleanActivityOptions { get; set; }

        /// <summary>
        /// If returned, this is the index into the DestinyActivityDefinition's "loadouts" property, indicating the currently active loadout requirements.
        /// </summary>
        [DataMember(Name = "loadoutRequirementIndex", EmitDefaultValue = false)]
        public long LoadoutRequirementIndex { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivity);
        }

        public bool Equals(DestinyActivity input)
        {
            if (input == null) return false;

            return
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    IsNew == input.IsNew ||
                    (IsNew != null && IsNew.Equals(input.IsNew))
                ) &&
                (
                    CanLead == input.CanLead ||
                    (CanLead != null && CanLead.Equals(input.CanLead))
                ) &&
                (
                    CanJoin == input.CanJoin ||
                    (CanJoin != null && CanJoin.Equals(input.CanJoin))
                ) &&
                (
                    IsCompleted == input.IsCompleted ||
                    (IsCompleted != null && IsCompleted.Equals(input.IsCompleted))
                ) &&
                (
                    IsVisible == input.IsVisible ||
                    (IsVisible != null && IsVisible.Equals(input.IsVisible))
                ) &&
                (
                    DisplayLevel == input.DisplayLevel ||
                    (DisplayLevel != null && DisplayLevel.Equals(input.DisplayLevel))
                ) &&
                (
                    RecommendedLight == input.RecommendedLight ||
                    (RecommendedLight != null && RecommendedLight.Equals(input.RecommendedLight))
                ) &&
                (
                    DifficultyTier == input.DifficultyTier ||
                    (DifficultyTier != null && DifficultyTier.Equals(input.DifficultyTier))
                ) &&
                (
                    Challenges == input.Challenges ||
                    (Challenges != null && Challenges.Equals(input.Challenges))
                ) &&
                (
                    ModifierHashes == input.ModifierHashes ||
                    (ModifierHashes != null && ModifierHashes.Equals(input.ModifierHashes))
                ) &&
                (
                    BooleanActivityOptions == input.BooleanActivityOptions ||
                    (BooleanActivityOptions != null && BooleanActivityOptions.Equals(input.BooleanActivityOptions))
                ) &&
                (
                    LoadoutRequirementIndex == input.LoadoutRequirementIndex ||
                    (LoadoutRequirementIndex != null && LoadoutRequirementIndex.Equals(input.LoadoutRequirementIndex))
                ) ;
        }
    }
}

