using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class UserSearchResponse
    {
        [DataMember(Name = "searchResults", EmitDefaultValue = false)]
        public List<UserSearchResponseDetail> SearchResults { get; set; }

        [DataMember(Name = "page", EmitDefaultValue = false)]
        public long Page { get; set; }

        [DataMember(Name = "hasMore", EmitDefaultValue = false)]
        public bool HasMore { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as UserSearchResponse);
        }

        public bool Equals(UserSearchResponse input)
        {
            if (input == null) return false;

            return
                (
                    SearchResults == input.SearchResults ||
                    (SearchResults != null && SearchResults.SequenceEqual(input.SearchResults))
                ) &&
                (
                    Page == input.Page ||
                    (Page.Equals(input.Page))
                ) &&
                (
                    HasMore == input.HasMore ||
                    (HasMore != null && HasMore.Equals(input.HasMore))
                ) ;
        }
    }
}

