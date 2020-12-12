using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents a data-driven view for Email settings. Web/Mobile UI can use this data to show new EMail settings consistently without further manual work.
    /// </summary>
    [DataContract]
    public class EmailViewDefinition
    {
        /// <summary>
        /// The identifier for this view.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The ordered list of settings to show in this view.
        /// </summary>
        [DataMember(Name = "viewSettings", EmitDefaultValue = false)]
        public List<EmailViewDefinitionSetting> ViewSettings { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as EmailViewDefinition);
        }

        public bool Equals(EmailViewDefinition input)
        {
            if (input == null) return false;

            return
                (
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
                (
                    ViewSettings == input.ViewSettings ||
                    (ViewSettings != null && ViewSettings.SequenceEqual(input.ViewSettings))
                ) ;
        }
    }
}

