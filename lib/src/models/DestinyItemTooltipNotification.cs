using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyItemTooltipNotification{

		[DataMember(Name="displayString", EmitDefaultValue=false)]
		public string DisplayString { get; set; }

		[DataMember(Name="displayStyle", EmitDefaultValue=false)]
		public string DisplayStyle { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemTooltipNotification);
        }

		public bool Equals(DestinyItemTooltipNotification input)
		{
			if (input == null) return false;

			return
				(
                    DisplayString == input.DisplayString ||
                    (DisplayString != null && DisplayString.Equals(input.DisplayString))
                ) &&
				(
                    DisplayStyle == input.DisplayStyle ||
                    (DisplayStyle != null && DisplayStyle.Equals(input.DisplayStyle))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.DisplayString.GetHashCode();
				hashCode = hashCode * 59 + this.DisplayStyle.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

