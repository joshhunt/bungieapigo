using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class GearAssetDataBaseDefinition
    {
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public long Version { get; set; }

        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GearAssetDataBaseDefinition);
        }

        public bool Equals(GearAssetDataBaseDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Version == input.Version ||
                    (Version.Equals(input.Version))
                ) &&
                (
                    Path == input.Path ||
                    (Path != null && Path.Equals(input.Path))
                ) ;
        }
    }
}

