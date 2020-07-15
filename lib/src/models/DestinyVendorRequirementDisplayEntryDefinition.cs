using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// The localized properties of the requirementsDisplay, allowing information about the requirement or item being featured to be seen.
	[DataContract]
	public class DestinyVendorRequirementDisplayEntryDefinition{

		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="source", EmitDefaultValue=false)]
		public string Source { get; set; }

		[DataMember(Name="type", EmitDefaultValue=false)]
		public string Type { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorRequirementDisplayEntryDefinition);
        }

		public bool Equals(DestinyVendorRequirementDisplayEntryDefinition input)
		{
			if (input == null) return false;

			return
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Source == input.Source ||
                    (Source != null && Source.Equals(input.Source))
                ) &&
				(
                    Type == input.Type ||
                    (Type != null && Type.Equals(input.Type))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Icon.GetHashCode();
				hashCode = hashCode * 59 + this.Name.GetHashCode();
				hashCode = hashCode * 59 + this.Source.GetHashCode();
				hashCode = hashCode * 59 + this.Type.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

