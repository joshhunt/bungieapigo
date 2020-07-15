using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class TrendingCategories{

		[DataMember(Name="categories", EmitDefaultValue=false)]
		public List<TrendingCategory> Categories { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingCategories);
        }

		public bool Equals(TrendingCategories input)
		{
			if (input == null) return false;

			return
				(
                    Categories == input.Categories ||
                    (Categories != null && Categories.Equals(input.Categories))
                ) ;
		}
	}
}

