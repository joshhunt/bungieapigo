using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class SingleComponentResponseOfDestinyItemComponent{

		/// <summary>
		/// The base item component, filled with properties that are generally useful to know in any item request or that don't feel worthwhile to put in their own component.
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DestinyItemComponent Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyItemComponent);
        }

		public bool Equals(SingleComponentResponseOfDestinyItemComponent input)
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

