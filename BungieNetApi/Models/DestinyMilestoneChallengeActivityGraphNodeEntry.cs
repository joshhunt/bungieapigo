using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyMilestoneChallengeActivityGraphNodeEntry
    {
        [DataMember(Name = "activityGraphHash", EmitDefaultValue = false)]
        public uint ActivityGraphHash { get; set; }

        [DataMember(Name = "activityGraphNodeHash", EmitDefaultValue = false)]
        public uint ActivityGraphNodeHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyMilestoneChallengeActivityGraphNodeEntry);
        }

        public bool Equals(DestinyMilestoneChallengeActivityGraphNodeEntry input)
        {
            if (input == null) return false;

            return
                (
                    ActivityGraphHash == input.ActivityGraphHash ||
                    (ActivityGraphHash.Equals(input.ActivityGraphHash))
                ) &&
                (
                    ActivityGraphNodeHash == input.ActivityGraphNodeHash ||
                    (ActivityGraphNodeHash.Equals(input.ActivityGraphNodeHash))
                ) ;
        }
    }
}

