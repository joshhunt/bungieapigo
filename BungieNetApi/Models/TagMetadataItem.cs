using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class TagMetadataItem{

		[DataMember(Name="description", EmitDefaultValue=false)]
		public string Description { get; set; }

		[DataMember(Name="tagText", EmitDefaultValue=false)]
		public string TagText { get; set; }

		[DataMember(Name="groups", EmitDefaultValue=false)]
		public List<string> Groups { get; set; }

		[DataMember(Name="isDefault", EmitDefaultValue=false)]
		public bool IsDefault { get; set; }

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TagMetadataItem);
        }

		public bool Equals(TagMetadataItem input)
		{
			if (input == null) return false;

			return
				(
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
				(
                    TagText == input.TagText ||
                    (TagText != null && TagText.Equals(input.TagText))
                ) &&
				(
                    Groups == input.Groups ||
                    (Groups != null && Groups.Equals(input.Groups))
                ) &&
				(
                    IsDefault == input.IsDefault ||
                    (IsDefault != null && IsDefault.Equals(input.IsDefault))
                ) &&
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) ;
		}
	}
}

