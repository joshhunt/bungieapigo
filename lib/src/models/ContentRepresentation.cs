using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class ContentRepresentation{

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="path", EmitDefaultValue=false)]
		public string Path { get; set; }

		[DataMember(Name="validationString", EmitDefaultValue=false)]
		public string ValidationString { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ContentRepresentation);
        }

		public bool Equals(ContentRepresentation input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Path == input.Path ||
                    (Path != null && Path.Equals(input.Path))
                ) &&
				(
                    ValidationString == input.ValidationString ||
                    (ValidationString != null && ValidationString.Equals(input.ValidationString))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Name.GetHashCode();
				hashCode = hashCode * 59 + this.Path.GetHashCode();
				hashCode = hashCode * 59 + this.ValidationString.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

