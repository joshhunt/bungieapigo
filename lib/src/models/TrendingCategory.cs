using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class TrendingCategory{

		[DataMember(Name="categoryName", EmitDefaultValue=false)]
		public string CategoryName { get; set; }

		[DataMember(Name="entries", EmitDefaultValue=false)]
		public SearchResultOfTrendingEntry Entries { get; set; }

		[DataMember(Name="categoryId", EmitDefaultValue=false)]
		public string CategoryId { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingCategory);
        }

		public bool Equals(TrendingCategory input)
		{
			if (input == null) return false;

			return
				(
                    CategoryName == input.CategoryName ||
                    (CategoryName != null && CategoryName.Equals(input.CategoryName))
                ) &&
				(
                    Entries == input.Entries ||
                    (Entries != null && Entries.Equals(input.Entries))
                ) &&
				(
                    CategoryId == input.CategoryId ||
                    (CategoryId != null && CategoryId.Equals(input.CategoryId))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
				hashCode = hashCode * 59 + this.Entries.GetHashCode();
				hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

