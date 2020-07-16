using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class PostSearchResponse
    {
        [DataMember(Name = "relatedPosts", EmitDefaultValue = false)]
        public List<PostResponse> RelatedPosts { get; set; }

        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public List<GeneralUser> Authors { get; set; }

        [DataMember(Name = "groups", EmitDefaultValue = false)]
        public List<GroupResponse> Groups { get; set; }

        [DataMember(Name = "searchedTags", EmitDefaultValue = false)]
        public List<TagResponse> SearchedTags { get; set; }

        [DataMember(Name = "polls", EmitDefaultValue = false)]
        public List<PollResponse> Polls { get; set; }

        [DataMember(Name = "recruitmentDetails", EmitDefaultValue = false)]
        public List<ForumRecruitmentDetail> RecruitmentDetails { get; set; }

        [DataMember(Name = "availablePages", EmitDefaultValue = false)]
        public long AvailablePages { get; set; }

        [DataMember(Name = "results", EmitDefaultValue = false)]
        public List<PostResponse> Results { get; set; }

        [DataMember(Name = "totalResults", EmitDefaultValue = false)]
        public long TotalResults { get; set; }

        [DataMember(Name = "hasMore", EmitDefaultValue = false)]
        public bool HasMore { get; set; }

        [DataMember(Name = "query", EmitDefaultValue = false)]
        public PagedQuery Query { get; set; }

        [DataMember(Name = "replacementContinuationToken", EmitDefaultValue = false)]
        public string ReplacementContinuationToken { get; set; }

        /// <summary>
        /// If useTotalResults is true, then totalResults represents an accurate count.
        /// </summary>
        /// <summary>
        /// If False, it does not, and may be estimated/only the size of the current page.
        /// </summary>
        /// <summary>
        /// Either way, you should probably always only trust hasMore.
        /// </summary>
        /// <summary>
        /// This is a long-held historical throwback to when we used to do paging with known total results. Those queries toasted our database, and we were left to hastily alter our endpoints and create backward- compatible shims, of which useTotalResults is one.
        /// </summary>
        [DataMember(Name = "useTotalResults", EmitDefaultValue = false)]
        public bool UseTotalResults { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as PostSearchResponse);
        }

        public bool Equals(PostSearchResponse input)
        {
            if (input == null) return false;

            return
                (
                    RelatedPosts == input.RelatedPosts ||
                    (RelatedPosts != null && RelatedPosts.Equals(input.RelatedPosts))
                ) &&
                (
                    Authors == input.Authors ||
                    (Authors != null && Authors.Equals(input.Authors))
                ) &&
                (
                    Groups == input.Groups ||
                    (Groups != null && Groups.Equals(input.Groups))
                ) &&
                (
                    SearchedTags == input.SearchedTags ||
                    (SearchedTags != null && SearchedTags.Equals(input.SearchedTags))
                ) &&
                (
                    Polls == input.Polls ||
                    (Polls != null && Polls.Equals(input.Polls))
                ) &&
                (
                    RecruitmentDetails == input.RecruitmentDetails ||
                    (RecruitmentDetails != null && RecruitmentDetails.Equals(input.RecruitmentDetails))
                ) &&
                (
                    AvailablePages == input.AvailablePages ||
                    (AvailablePages != null && AvailablePages.Equals(input.AvailablePages))
                ) &&
                (
                    Results == input.Results ||
                    (Results != null && Results.Equals(input.Results))
                ) &&
                (
                    TotalResults == input.TotalResults ||
                    (TotalResults != null && TotalResults.Equals(input.TotalResults))
                ) &&
                (
                    HasMore == input.HasMore ||
                    (HasMore != null && HasMore.Equals(input.HasMore))
                ) &&
                (
                    Query == input.Query ||
                    (Query != null && Query.Equals(input.Query))
                ) &&
                (
                    ReplacementContinuationToken == input.ReplacementContinuationToken ||
                    (ReplacementContinuationToken != null && ReplacementContinuationToken.Equals(input.ReplacementContinuationToken))
                ) &&
                (
                    UseTotalResults == input.UseTotalResults ||
                    (UseTotalResults != null && UseTotalResults.Equals(input.UseTotalResults))
                ) ;
        }
    }
}

