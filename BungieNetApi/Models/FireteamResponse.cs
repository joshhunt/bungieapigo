using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class FireteamResponse
    {
        [DataMember(Name = "Summary", EmitDefaultValue = false)]
        public FireteamSummary Summary { get; set; }

        [DataMember(Name = "Members", EmitDefaultValue = false)]
        public List<FireteamMember> Members { get; set; }

        [DataMember(Name = "Alternates", EmitDefaultValue = false)]
        public List<FireteamMember> Alternates { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as FireteamResponse);
        }

        public bool Equals(FireteamResponse input)
        {
            if (input == null) return false;

            return
                (
                    Summary == input.Summary ||
                    (Summary != null && Summary.Equals(input.Summary))
                ) &&
                (
                    Members == input.Members ||
                    (Members != null && Members.Equals(input.Members))
                ) &&
                (
                    Alternates == input.Alternates ||
                    (Alternates != null && Alternates.Equals(input.Alternates))
                ) ;
        }
    }
}

