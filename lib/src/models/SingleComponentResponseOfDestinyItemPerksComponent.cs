using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class SingleComponentResponseOfDestinyItemPerksComponent{

		/// <summary>
		/// Instanced items can have perks: benefits that the item bestows.
		/// </summary>
		/// <summary>
		/// These are related to DestinySandboxPerkDefinition, and sometimes - but not always - have human readable info. When they do, they are the icons and text that you see in an item's tooltip.
		/// </summary>
		/// <summary>
		/// Talent Grids, Sockets, and the item itself can apply Perks, which are then summarized here for your convenience.
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public DestinyItemPerksComponent Data { get; set; }

		[DataMember(Name="privacy", EmitDefaultValue=false)]
		public ComponentPrivacySetting Privacy { get; set; }

		/// <summary>
		/// If true, this component is disabled.
		/// </summary>
		[DataMember(Name="disabled", EmitDefaultValue=false)]
		public bool Disabled { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as SingleComponentResponseOfDestinyItemPerksComponent);
        }

		public bool Equals(SingleComponentResponseOfDestinyItemPerksComponent input)
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

