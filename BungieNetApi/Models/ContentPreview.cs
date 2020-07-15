using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class ContentPreview
    {
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        [DataMember(Name = "itemInSet", EmitDefaultValue = false)]
        public bool ItemInSet { get; set; }

        [DataMember(Name = "setTag", EmitDefaultValue = false)]
        public string SetTag { get; set; }

        [DataMember(Name = "setNesting", EmitDefaultValue = false)]
        public long SetNesting { get; set; }

        [DataMember(Name = "useSetId", EmitDefaultValue = false)]
        public long UseSetId { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as ContentPreview);
        }

        public bool Equals(ContentPreview input)
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
                    ItemInSet == input.ItemInSet ||
                    (ItemInSet != null && ItemInSet.Equals(input.ItemInSet))
                ) &&
                (
                    SetTag == input.SetTag ||
                    (SetTag != null && SetTag.Equals(input.SetTag))
                ) &&
                (
                    SetNesting == input.SetNesting ||
                    (SetNesting != null && SetNesting.Equals(input.SetNesting))
                ) &&
                (
                    UseSetId == input.UseSetId ||
                    (UseSetId != null && UseSetId.Equals(input.UseSetId))
                ) ;
        }
    }
}

