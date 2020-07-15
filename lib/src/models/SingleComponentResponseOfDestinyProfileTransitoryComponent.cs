using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class SingleComponentResponseOfDestinyProfileTransitoryComponent{

		/// <summary>
		/// This is an experimental set of data that Bungie considers to be "transitory" - information that may be useful for API users, but that is coming from a non-authoritative data source about information that could potentially change at a more frequent pace than Bungie.net will receive updates about it.
		/// </summary>
		/// <summary>
		/// This information is provided exclusively for convenience should any of it be useful to users: we provide no guarantees to the accuracy or timeliness of data that comes from this source. Know that this data can potentially be out-of-date or even wrong entirely if the user disconnected from the game or suddenly changed their status before we can receive refreshed data.
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DestinyProfileTransitoryComponent Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyProfileTransitoryComponent);
        }

		public bool Equals(SingleComponentResponseOfDestinyProfileTransitoryComponent input)
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

