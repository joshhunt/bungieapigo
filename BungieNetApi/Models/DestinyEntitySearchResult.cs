using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// The results of a search for Destiny content. This will be improved on over time, I've been doing some experimenting to see what might be useful.
    /// </summary>
    [DataContract]
    public class DestinyEntitySearchResult
    {
        /// <summary>
        /// A list of suggested words that might make for better search results, based on the text searched for.
        /// </summary>
        [DataMember(Name = "suggestedWords", EmitDefaultValue = false)]
        public List<string> SuggestedWords { get; set; }

        /// <summary>
        /// The items found that are matches/near matches for the searched-for term, sorted by something vaguely resembling "relevance". Hopefully this will get better in the future.
        /// </summary>
        [DataMember(Name = "results", EmitDefaultValue = false)]
        public SearchResultOfDestinyEntitySearchResultItem Results { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyEntitySearchResult);
        }

        public bool Equals(DestinyEntitySearchResult input)
        {
            if (input == null) return false;

            return
                (
                    SuggestedWords == input.SuggestedWords ||
                    (SuggestedWords != null && SuggestedWords.SequenceEqual(input.SuggestedWords))
                ) &&
                (
                    Results == input.Results ||
                    (Results != null && Results.Equals(input.Results))
                ) ;
        }
    }
}

