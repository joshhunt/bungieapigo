using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DestinyMilestoneChallengeActivity{

		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }

		[DataMember(Name="challenges", EmitDefaultValue=false)]
		public List<DestinyChallengeStatus> Challenges { get; set; }

		/// <summary>
		/// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.
		/// </summary>
		/// <summary>
		/// Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
		/// </summary>
		[DataMember(Name="modifierHashes", EmitDefaultValue=false)]
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
		[DataMember(Name="booleanActivityOptions", EmitDefaultValue=false)]
		public Map<String, bool> BooleanActivityOptions { get; set; }

		/// <summary>
		/// If returned, this is the index into the DestinyActivityDefinition's "loadouts" property, indicating the currently active loadout requirements.
		/// </summary>
		[DataMember(Name="loadoutRequirementIndex", EmitDefaultValue=false)]
		public long LoadoutRequirementIndex { get; set; }

		/// <summary>
		/// If the Activity has discrete "phases" that we can track, that info will be here. Otherwise, this value will be NULL. Note that this is a list and not a dictionary: the order implies the ascending order of phases or progression in this activity.
		/// </summary>
		[DataMember(Name="phases", EmitDefaultValue=false)]
		public List<DestinyMilestoneActivityPhase> Phases { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneChallengeActivity);
        }

		public bool Equals(DestinyMilestoneChallengeActivity input)
		{
			if (input == null) return false;

			return
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
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
                ) &&
				(
                    Phases == input.Phases ||
                    (Phases != null && Phases.Equals(input.Phases))
                ) ;
		}
	}
}

