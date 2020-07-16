using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class ContentTypePropertySection
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "readableName", EmitDefaultValue = false)]
        public string ReadableName { get; set; }

        [DataMember(Name = "collapsed", EmitDefaultValue = false)]
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
    }
}

