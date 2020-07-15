using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent{

		[DataMember(Name="data", EmitDefaultValue=false)]
		public Map<String, DestinyItemPlugObjectivesComponent> Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent);
        }

		public bool Equals(DictionaryComponentResponseOfint32AndDestinyItemPlugObjectivesComponent input)
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

