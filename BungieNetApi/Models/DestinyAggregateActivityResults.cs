using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyAggregateActivityResults
    {
        /// <summary>
        /// List of all activities the player has participated in.
        /// </summary>
        [DataMember(Name = "activities", EmitDefaultValue = false)]
        public List<DestinyAggregateActivityStats> Activities { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyAggregateActivityResults);
        }

        public bool Equals(DestinyAggregateActivityResults input)
        {
            if (input == null) return false;

            return
                (
                    Activities == input.Activities ||
                    (Activities != null && Activities.SequenceEqual(input.Activities))
                ) ;
        }
    }
}

