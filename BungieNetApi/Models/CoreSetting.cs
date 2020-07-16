using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class CoreSetting
    {
        [DataMember(Name = "identifier", EmitDefaultValue = false)]
        public string Identifier { get; set; }

        [DataMember(Name = "isDefault", EmitDefaultValue = false)]
        public bool IsDefault { get; set; }

        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public string Summary { get; set; }

        [DataMember(Name = "imagePath", EmitDefaultValue = false)]
        public string ImagePath { get; set; }

        [DataMember(Name = "childSettings", EmitDefaultValue = false)]
        public List<CoreSetting> ChildSettings { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as CoreSetting);
        }

        public bool Equals(CoreSetting input)
        {
            if (input == null) return false;

            return
                (
                    Identifier == input.Identifier ||
                    (Identifier != null && Identifier.Equals(input.Identifier))
                ) &&
                (
                    IsDefault == input.IsDefault ||
                    (IsDefault != null && IsDefault.Equals(input.IsDefault))
                ) &&
                (
                    DisplayName == input.DisplayName ||
                    (DisplayName != null && DisplayName.Equals(input.DisplayName))
                ) &&
                (
                    Summary == input.Summary ||
                    (Summary != null && Summary.Equals(input.Summary))
                ) &&
                (
                    ImagePath == input.ImagePath ||
                    (ImagePath != null && ImagePath.Equals(input.ImagePath))
                ) &&
                (
                    ChildSettings == input.ChildSettings ||
                    (ChildSettings != null && ChildSettings.Equals(input.ChildSettings))
                ) ;
        }
    }
}

