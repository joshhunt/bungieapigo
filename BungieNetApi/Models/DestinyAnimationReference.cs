using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DestinyAnimationReference
    {
        [DataMember(Name = "animName", EmitDefaultValue = false)]
        public string AnimName { get; set; }

        [DataMember(Name = "animIdentifier", EmitDefaultValue = false)]
        public string AnimIdentifier { get; set; }

        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyAnimationReference);
        }

        public bool Equals(DestinyAnimationReference input)
        {
            if (input == null) return false;

            return
                (
                    AnimName == input.AnimName ||
                    (AnimName != null && AnimName.Equals(input.AnimName))
                ) &&
                (
                    AnimIdentifier == input.AnimIdentifier ||
                    (AnimIdentifier != null && AnimIdentifier.Equals(input.AnimIdentifier))
                ) &&
                (
                    Path == input.Path ||
                    (Path != null && Path.Equals(input.Path))
                ) ;
        }
    }
}

