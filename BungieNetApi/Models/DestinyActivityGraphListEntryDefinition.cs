using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Destinations and Activities may have default Activity Graphs that should be shown when you bring up the Director and are playing in either.
    /// </summary>
    /// <summary>
    /// This contract defines the graph referred to and the gating for when it is relevant.
    /// </summary>
    [DataContract]
    public class DestinyActivityGraphListEntryDefinition
    {
        /// <summary>
        /// The hash identifier of the DestinyActivityGraphDefinition that should be shown when opening the director.
        /// </summary>
        [DataMember(Name = "activityGraphHash", EmitDefaultValue = false)]
        public uint ActivityGraphHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityGraphListEntryDefinition);
        }

        public bool Equals(DestinyActivityGraphListEntryDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ActivityGraphHash == input.ActivityGraphHash ||
                    (ActivityGraphHash != null && ActivityGraphHash.Equals(input.ActivityGraphHash))
                ) ;
        }
    }
}

