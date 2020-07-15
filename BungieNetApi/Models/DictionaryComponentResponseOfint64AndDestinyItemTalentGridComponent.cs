using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent{

		[DataMember(Name="data", EmitDefaultValue=false)]
		public Dictionary<string, DestinyItemTalentGridComponent> Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent);
        }

		public bool Equals(DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent input)
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

