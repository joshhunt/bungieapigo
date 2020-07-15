using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent{

		[DataMember(Name="data", EmitDefaultValue=false)]
		public Map<String, DestinyItemObjectivesComponent> Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent);
        }

		public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent input)
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

