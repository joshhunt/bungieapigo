using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class SingleComponentResponseOfDestinyItemObjectivesComponent
    {
        /// <summary>
        /// Items can have objectives and progression. When you request this block, you will obtain information about any Objectives and progression tied to this item.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public DestinyItemObjectivesComponent Data { get; set; }

        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public ComponentPrivacySetting Privacy { get; set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
        public bool Disabled { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyItemObjectivesComponent);
        }

        public bool Equals(SingleComponentResponseOfDestinyItemObjectivesComponent input)
        {
            if (input == null) return false;

            return
                (
                    Data == input.Data ||
                    (Data != null && Data.Equals(input.Data))
                ) &&
                (
                    Privacy == input.Privacy ||
                    (Privacy != null && Privacy.Equals(input.Privacy))
                ) &&
                (
                    Disabled == input.Disabled ||
                    (Disabled != null && Disabled.Equals(input.Disabled))
                ) ;
        }
    }
}

