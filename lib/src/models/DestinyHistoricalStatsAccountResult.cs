using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyHistoricalStatsAccountResult{

		[DataMember(Name="mergedDeletedCharacters", EmitDefaultValue=false)]
		public DestinyHistoricalStatsWithMerged MergedDeletedCharacters { get; set; }

		[DataMember(Name="mergedAllCharacters", EmitDefaultValue=false)]
		public DestinyHistoricalStatsWithMerged MergedAllCharacters { get; set; }

		[DataMember(Name="characters", EmitDefaultValue=false)]
		public List<DestinyHistoricalStatsPerCharacter> Characters { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyHistoricalStatsAccountResult);
        }

		public bool Equals(DestinyHistoricalStatsAccountResult input)
		{
			if (input == null) return false;

			return
				(
                    MergedDeletedCharacters == input.MergedDeletedCharacters ||
                    (MergedDeletedCharacters != null && MergedDeletedCharacters.Equals(input.MergedDeletedCharacters))
                ) &&
				(
                    MergedAllCharacters == input.MergedAllCharacters ||
                    (MergedAllCharacters != null && MergedAllCharacters.Equals(input.MergedAllCharacters))
                ) &&
				(
                    Characters == input.Characters ||
                    (Characters != null && Characters.Equals(input.Characters))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.MergedDeletedCharacters.GetHashCode();
				hashCode = hashCode * 59 + this.MergedAllCharacters.GetHashCode();
				hashCode = hashCode * 59 + this.Characters.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

