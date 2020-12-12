using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyParentItemOverride
    {
        [DataMember(Name = "additionalEquipRequirementsDisplayStrings", EmitDefaultValue = false)]
        public List<string> AdditionalEquipRequirementsDisplayStrings { get; set; }

        [DataMember(Name = "pipIcon", EmitDefaultValue = false)]
        public string PipIcon { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyParentItemOverride);
        }

        public bool Equals(DestinyParentItemOverride input)
        {
            if (input == null) return false;

            return
                (
                    AdditionalEquipRequirementsDisplayStrings == input.AdditionalEquipRequirementsDisplayStrings ||
                    (AdditionalEquipRequirementsDisplayStrings != null && AdditionalEquipRequirementsDisplayStrings.SequenceEqual(input.AdditionalEquipRequirementsDisplayStrings))
                ) &&
                (
                    PipIcon == input.PipIcon ||
                    (PipIcon != null && PipIcon.Equals(input.PipIcon))
                ) ;
        }
    }
}

