using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// A vendor can have many categories of items that they sell. This component will return the category information for available items, as well as the index into those items in the user&#39;s sale item list.
	/// Note that, since both the category and items are indexes, this data is Content Version dependent. Be sure to check that your content is up to date before using this data. This is an unfortunate, but permanent, limitation of Vendor data.
	[DataContract]
	public class DestinyVendorCategoriesComponent{

		/// <summary>
		/// The list of categories for items that the vendor sells, in rendering order.
		/// </summary>
		/// <summary>
		/// These categories each point to a "display category" in the displayCategories property of the DestinyVendorDefinition, as opposed to the other categories.
		/// </summary>
		[DataMember(Name="categories", EmitDefaultValue=false)]
		public List<DestinyVendorCategory> Categories { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorCategoriesComponent);
        }

		public bool Equals(DestinyVendorCategoriesComponent input)
		{
			if (input == null) return false;

			return
				(
                    Categories == input.Categories ||
                    (Categories != null && Categories.Equals(input.Categories))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Categories.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

