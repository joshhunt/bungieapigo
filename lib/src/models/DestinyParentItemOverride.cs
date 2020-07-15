using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyParentItemOverride{

		[DataMember(Name="additionalEquipRequirementsDisplayStrings", EmitDefaultValue=false)]
		public List<string> AdditionalEquipRequirementsDisplayStrings { get; set; }

		[DataMember(Name="pipIcon", EmitDefaultValue=false)]
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
                    (AdditionalEquipRequirementsDisplayStrings != null && AdditionalEquipRequirementsDisplayStrings.Equals(input.AdditionalEquipRequirementsDisplayStrings))
                ) &&
				(
                    PipIcon == input.PipIcon ||
                    (PipIcon != null && PipIcon.Equals(input.PipIcon))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.AdditionalEquipRequirementsDisplayStrings.GetHashCode();
				hashCode = hashCode * 59 + this.PipIcon.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

