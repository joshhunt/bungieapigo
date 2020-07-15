using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// Represents whatever information we can return about an explicit phase in an activity. In the future, I hope we&#39;ll have more than just &quot;guh, you done gone and did something,&quot; but for the forseeable future that&#39;s all we&#39;ve got. I&#39;m making it more than just a list of booleans out of that overly-optimistic hope.
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Complete.GetHashCode();
				hashCode = hashCode * 59 + this.PhaseHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

