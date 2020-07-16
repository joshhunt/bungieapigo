using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class IgnoreResponse
    {
        [DataMember(Name = "isIgnored", EmitDefaultValue = false)]
        public bool IsIgnored { get; set; }

        [DataMember(Name = "ignoreFlags", EmitDefaultValue = false)]
        public IgnoreStatus IgnoreFlags { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as IgnoreResponse);
        }

        public bool Equals(IgnoreResponse input)
        {
            if (input == null) return false;

            return
                (
                    IsIgnored == input.IsIgnored ||
                    (IsIgnored != null && IsIgnored.Equals(input.IsIgnored))
                ) &&
                (
                    IgnoreFlags == input.IgnoreFlags ||
                    (IgnoreFlags != null && IgnoreFlags.Equals(input.IgnoreFlags))
                ) ;
        }
    }
}

