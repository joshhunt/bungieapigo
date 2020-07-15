using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyActivityLoadoutRequirementSet{

		/// <summary>
		/// The set of requirements that will be applied on the activity if this requirement set is active.
		/// </summary>
		[DataMember(Name="requirements", EmitDefaultValue=false)]
		public List<DestinyActivityLoadoutRequirement> Requirements { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityLoadoutRequirementSet);
        }

		public bool Equals(DestinyActivityLoadoutRequirementSet input)
		{
			if (input == null) return false;

			return
				(
                    Requirements == input.Requirements ||
                    (Requirements != null && Requirements.Equals(input.Requirements))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Requirements.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

