using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyActivityLoadoutRequirementSet
    {
        /// <summary>
        /// The set of requirements that will be applied on the activity if this requirement set is active.
        /// </summary>
        [DataMember(Name = "requirements", EmitDefaultValue = false)]
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
                    (Requirements != null && Requirements.SequenceEqual(input.Requirements))
                ) ;
        }
    }
}

