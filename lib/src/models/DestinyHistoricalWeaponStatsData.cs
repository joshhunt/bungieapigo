using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyHistoricalWeaponStatsData{

		/// <summary>
		/// List of weapons and their perspective values.
		/// </summary>
		[DataMember(Name="weapons", EmitDefaultValue=false)]
		public List<DestinyHistoricalWeaponStats> Weapons { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalWeaponStatsData);
        }

		public bool Equals(DestinyHistoricalWeaponStatsData input)
		{
			if (input == null) return false;

			return
				(
                    Weapons == input.Weapons ||
                    (Weapons != null && Weapons.Equals(input.Weapons))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Weapons.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

