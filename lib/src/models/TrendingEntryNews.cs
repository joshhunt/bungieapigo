using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class TrendingEntryNews{

		[DataMember(Name="article", EmitDefaultValue=false)]
		public ContentItemPublicContract Article { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingEntryNews);
        }

		public bool Equals(TrendingEntryNews input)
		{
			if (input == null) return false;

			return
				(
                    Article == input.Article ||
                    (Article != null && Article.Equals(input.Article))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Article.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

