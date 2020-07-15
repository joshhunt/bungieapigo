using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class TagMetadataDefinition
    {
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "order", EmitDefaultValue = false)]
        public long Order { get; set; }

        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<TagMetadataItem> Items { get; set; }

        [DataMember(Name = "datatype", EmitDefaultValue = false)]
        public string Datatype { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "isRequired", EmitDefaultValue = false)]
        public bool IsRequired { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as TagMetadataDefinition);
        }

        public bool Equals(TagMetadataDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Description == input.Description ||
                    (Description != null && Description.Equals(input.Description))
                ) &&
                (
                    Order == input.Order ||
                    (Order != null && Order.Equals(input.Order))
                ) &&
                (
                    Items == input.Items ||
                    (Items != null && Items.Equals(input.Items))
                ) &&
                (
                    Datatype == input.Datatype ||
                    (Datatype != null && Datatype.Equals(input.Datatype))
                ) &&
                (
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
                (
                    IsRequired == input.IsRequired ||
                    (IsRequired != null && IsRequired.Equals(input.IsRequired))
                ) ;
        }
    }
}

