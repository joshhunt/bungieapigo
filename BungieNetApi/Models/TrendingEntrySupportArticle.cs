using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class TrendingEntrySupportArticle
    {
        [DataMember(Name = "article", EmitDefaultValue = false)]
        public ContentItemPublicContract Article { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as TrendingEntrySupportArticle);
        }

        public bool Equals(TrendingEntrySupportArticle input)
        {
            if (input == null) return false;

            return
                (
                    Article == input.Article ||
                    (Article != null && Article.Equals(input.Article))
                ) ;
        }
    }
}

