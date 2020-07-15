using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyCharacterRecordsComponent{

		[DataMember(Name="featuredRecordHashes", EmitDefaultValue=false)]
		public List<uint> FeaturedRecordHashes { get; set; }

		[DataMember(Name="records", EmitDefaultValue=false)]
		public Map<String, DestinyRecordComponent> Records { get; set; }

		/// <summary>
		/// The hash for the root presentation node definition of Triumph categories.
		/// </summary>
		[DataMember(Name="recordCategoriesRootNodeHash", EmitDefaultValue=false)]
		public uint RecordCategoriesRootNodeHash { get; set; }

		/// <summary>
		/// The hash for the root presentation node definition of Triumph Seals.
		/// </summary>
		[DataMember(Name="recordSealsRootNodeHash", EmitDefaultValue=false)]
		public uint RecordSealsRootNodeHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterRecordsComponent);
        }

		public bool Equals(DestinyCharacterRecordsComponent input)
		{
			if (input == null) return false;

			return
				(
                    FeaturedRecordHashes == input.FeaturedRecordHashes ||
                    (FeaturedRecordHashes != null && FeaturedRecordHashes.Equals(input.FeaturedRecordHashes))
                ) &&
				(
                    Records == input.Records ||
                    (Records != null && Records.Equals(input.Records))
                ) &&
				(
                    RecordCategoriesRootNodeHash == input.RecordCategoriesRootNodeHash ||
                    (RecordCategoriesRootNodeHash != null && RecordCategoriesRootNodeHash.Equals(input.RecordCategoriesRootNodeHash))
                ) &&
				(
                    RecordSealsRootNodeHash == input.RecordSealsRootNodeHash ||
                    (RecordSealsRootNodeHash != null && RecordSealsRootNodeHash.Equals(input.RecordSealsRootNodeHash))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.FeaturedRecordHashes.GetHashCode();
				hashCode = hashCode * 59 + this.Records.GetHashCode();
				hashCode = hashCode * 59 + this.RecordCategoriesRootNodeHash.GetHashCode();
				hashCode = hashCode * 59 + this.RecordSealsRootNodeHash.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

