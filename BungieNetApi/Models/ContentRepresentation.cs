using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class ContentRepresentation
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        [DataMember(Name = "validationString", EmitDefaultValue = false)]
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
    }
}

