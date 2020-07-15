using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupTheme{

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="folder", EmitDefaultValue=false)]
		public string Folder { get; set; }

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupTheme);
        }

		public bool Equals(GroupTheme input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    Folder == input.Folder ||
                    (Folder != null && Folder.Equals(input.Folder))
                ) &&
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Name.GetHashCode();
				hashCode = hashCode * 59 + this.Folder.GetHashCode();
				hashCode = hashCode * 59 + this.Description.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

