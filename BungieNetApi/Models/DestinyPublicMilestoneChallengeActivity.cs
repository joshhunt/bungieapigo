using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DestinyPublicMilestoneChallengeActivity{

		[DataMember(Name="activityHash", EmitDefaultValue=false)]
		public uint ActivityHash { get; set; }

		[DataMember(Name="challengeObjectiveHashes", EmitDefaultValue=false)]
		public List<uint> ChallengeObjectiveHashes { get; set; }

		/// <summary>
		/// If the activity has modifiers, this will be the list of modifiers that all variants have in common. Perform lookups against DestinyActivityModifierDefinition which defines the modifier being applied to get at the modifier data.
		/// </summary>
		/// <summary>
		/// Note that, in the DestiyActivityDefinition, you will see many more modifiers than this being referred to: those are all *possible* modifiers for the activity, not the active ones. Use only the active ones to match what's really live.
		/// </summary>
		[DataMember(Name="modifierHashes", EmitDefaultValue=false)]
		public List<uint> ModifierHashes { get; set; }

		/// <summary>
		/// If returned, this is the index into the DestinyActivityDefinition's "loadouts" property, indicating the currently active loadout requirements.
		/// </summary>
		[DataMember(Name="loadoutRequirementIndex", EmitDefaultValue=false)]
		public long LoadoutRequirementIndex { get; set; }

		/// <summary>
		/// The ordered list of phases for this activity, if any. Note that we have no human readable info for phases, nor any entities to relate them to: relating these hashes to something human readable is up to you unfortunately.
		/// </summary>
		[DataMember(Name="phaseHashes", EmitDefaultValue=false)]
		public List<uint> PhaseHashes { get; set; }

		/// <summary>
		/// The set of activity options for this activity, keyed by an identifier that's unique for this activity (not guaranteed to be unique between or across all activities, though should be unique for every *variant* of a given *conceptual* activity: for instance, the original D2 Raid has many variant DestinyActivityDefinitions. While other activities could potentially have the same option hashes, for any given D2 base Raid variant the hash will be unique).
		/// </summary>
		/// <summary>
		/// As a concrete example of this data, the hashes you get for Raids will correspond to the currently active "Challenge Mode".
		/// </summary>
		/// <summary>
		/// We have no human readable information for this data, so it's up to you if you want to associate it with such info to show it.
		/// </summary>
		[DataMember(Name="booleanActivityOptions", EmitDefaultValue=false)]
		public Dictionary<string, bool> BooleanActivityOptions { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyPublicMilestoneChallengeActivity);
        }

		public bool Equals(DestinyPublicMilestoneChallengeActivity input)
		{
			if (input == null) return false;

			return
				(
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
				(
                    ChallengeObjectiveHashes == input.ChallengeObjectiveHashes ||
                    (ChallengeObjectiveHashes != null && ChallengeObjectiveHashes.Equals(input.ChallengeObjectiveHashes))
                ) &&
				(
                    ModifierHashes == input.ModifierHashes ||
                    (ModifierHashes != null && ModifierHashes.Equals(input.ModifierHashes))
                ) &&
				(
                    LoadoutRequirementIndex == input.LoadoutRequirementIndex ||
                    (LoadoutRequirementIndex != null && LoadoutRequirementIndex.Equals(input.LoadoutRequirementIndex))
                ) &&
				(
                    PhaseHashes == input.PhaseHashes ||
                    (PhaseHashes != null && PhaseHashes.Equals(input.PhaseHashes))
                ) &&
				(
                    BooleanActivityOptions == input.BooleanActivityOptions ||
                    (BooleanActivityOptions != null && BooleanActivityOptions.Equals(input.BooleanActivityOptions))
                ) ;
		}
	}
}

