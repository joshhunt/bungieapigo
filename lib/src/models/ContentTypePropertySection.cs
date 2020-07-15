using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class ContentTypePropertySection{

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="readableName", EmitDefaultValue=false)]
		public string ReadableName { get; set; }

		[DataMember(Name="collapsed", EmitDefaultValue=false)]
		public bool Collapsed { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ContentTypePropertySection);
        }

		public bool Equals(ContentTypePropertySection input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    ReadableName == input.ReadableName ||
                    (ReadableName != null && ReadableName.Equals(input.ReadableName))
                ) &&
				(
                    Collapsed == input.Collapsed ||
                    (Collapsed != null && Collapsed.Equals(input.Collapsed))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Name.GetHashCode();
				hashCode = hashCode * 59 + this.ReadableName.GetHashCode();
				hashCode = hashCode * 59 + this.Collapsed.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

