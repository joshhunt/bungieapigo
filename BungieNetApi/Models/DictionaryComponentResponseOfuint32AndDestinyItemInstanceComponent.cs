using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent
    {
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, DestinyItemInstanceComponent> Data { get; set; }

        [DataMember(Name = "privacy", EmitDefaultValue = false)]
        public ComponentPrivacySetting Privacy { get; set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        [DataMember(Name = "disabled", EmitDefaultValue = false)]
        public bool Disabled { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent);
        }

        public bool Equals(DictionaryComponentResponseOfuint32AndDestinyItemInstanceComponent input)
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

