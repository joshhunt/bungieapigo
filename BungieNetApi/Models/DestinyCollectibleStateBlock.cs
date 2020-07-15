using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyCollectibleStateBlock
    {
        [DataMember(Name = "obscuredOverrideItemHash", EmitDefaultValue = false)]
        public uint ObscuredOverrideItemHash { get; set; }

        /// <summary>
        /// Presentation nodes can be restricted by various requirements. This defines the rules of those requirements, and the message(s) to be shown if these requirements aren't met.
        /// </summary>
        [DataMember(Name = "requirements", EmitDefaultValue = false)]
        public DestinyPresentationNodeRequirementsBlock Requirements { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCollectibleStateBlock);
        }

        public bool Equals(DestinyCollectibleStateBlock input)
        {
            if (input == null) return false;

            return
                (
                    ObscuredOverrideItemHash == input.ObscuredOverrideItemHash ||
                    (ObscuredOverrideItemHash != null && ObscuredOverrideItemHash.Equals(input.ObscuredOverrideItemHash))
                ) &&
                (
                    Requirements == input.Requirements ||
                    (Requirements != null && Requirements.Equals(input.Requirements))
                ) ;
        }
    }
}

