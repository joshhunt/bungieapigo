using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// The results of a bulk Equipping operation performed through the Destiny API.
	[DataContract]
	public class DestinyEquipItemResults{

		[DataMember(Name="equipResults", EmitDefaultValue=false)]
		public List<DestinyEquipItemResult> EquipResults { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEquipItemResults);
        }

		public bool Equals(DestinyEquipItemResults input)
		{
			if (input == null) return false;

			return
				(
                    EquipResults == input.EquipResults ||
                    (EquipResults != null && EquipResults.Equals(input.EquipResults))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.EquipResults.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

