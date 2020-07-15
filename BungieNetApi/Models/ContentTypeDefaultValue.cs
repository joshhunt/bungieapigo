using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class ContentTypeDefaultValue
    {
        [DataMember(Name = "whenClause", EmitDefaultValue = false)]
        public string WhenClause { get; set; }

        [DataMember(Name = "whenValue", EmitDefaultValue = false)]
        public string WhenValue { get; set; }

        [DataMember(Name = "defaultValue", EmitDefaultValue = false)]
        public string DefaultValue { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as ContentTypeDefaultValue);
        }

        public bool Equals(ContentTypeDefaultValue input)
        {
            if (input == null) return false;

            return
                (
                    WhenClause == input.WhenClause ||
                    (WhenClause != null && WhenClause.Equals(input.WhenClause))
                ) &&
                (
                    WhenValue == input.WhenValue ||
                    (WhenValue != null && WhenValue.Equals(input.WhenValue))
                ) &&
                (
                    DefaultValue == input.DefaultValue ||
                    (DefaultValue != null && DefaultValue.Equals(input.DefaultValue))
                ) ;
        }
    }
}

