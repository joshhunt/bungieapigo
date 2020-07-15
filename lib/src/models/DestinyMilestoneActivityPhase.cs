using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Represents whatever information we can return about an explicit phase in an activity. In the future, I hope we'll have more than just "guh, you done gone and did something," but for the forseeable future that's all we've got. I'm making it more than just a list of booleans out of that overly-optimistic hope.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneActivityPhase{

		/// <summary>
		/// Indicates if the phase has been completed.
		/// </summary>
		[DataMember(Name="complete", EmitDefaultValue=false)]
		public bool Complete { get; set; }

		/// <summary>
		/// In DestinyActivityDefinition, if the activity has phases, there will be a set of phases defined in the "insertionPoints" property. This is the hash that maps to that phase.
		/// </summary>
		[DataMember(Name="phaseHash", EmitDefaultValue=false)]
		public uint PhaseHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneActivityPhase);
        }

		public bool Equals(DestinyMilestoneActivityPhase input)
		{
			if (input == null) return false;

			return
				(
                    Complete == input.Complete ||
                    (Complete != null && Complete.Equals(input.Complete))
                ) &&
				(
                    PhaseHash == input.PhaseHash ||
                    (PhaseHash != null && PhaseHash.Equals(input.PhaseHash))
                ) ;
		}
	}
}

