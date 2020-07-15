using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class SingleComponentResponseOfDestinyCharacterComponent{

		/// <summary>
		/// This component contains base properties of the character. You'll probably want to always request this component, but hey you do you.
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DestinyCharacterComponent Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyCharacterComponent);
        }

		public bool Equals(SingleComponentResponseOfDestinyCharacterComponent input)
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Data.GetHashCode();
				hashCode = hashCode * 59 + this.Privacy.GetHashCode();
				hashCode = hashCode * 59 + this.Disabled.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

