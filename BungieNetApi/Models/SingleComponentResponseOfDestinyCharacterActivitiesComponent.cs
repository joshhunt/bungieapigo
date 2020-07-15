using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class SingleComponentResponseOfDestinyCharacterActivitiesComponent{

		/// <summary>
		/// This component holds activity data for a character. It will tell you about the character's current activity status, as well as activities that are available to the user.
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DestinyCharacterActivitiesComponent Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyCharacterActivitiesComponent);
        }

		public bool Equals(SingleComponentResponseOfDestinyCharacterActivitiesComponent input)
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

