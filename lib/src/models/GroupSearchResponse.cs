using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupSearchResponse{

		[DataMember(Name="results", EmitDefaultValue=false)]
		public List<GroupV2Card> Results { get; set; }

		[DataMember(Name="totalResults", EmitDefaultValue=false)]
		public long TotalResults { get; set; }

		[DataMember(Name="hasMore", EmitDefaultValue=false)]
		public bool HasMore { get; set; }

		[DataMember(Name="query", EmitDefaultValue=false)]
		public PagedQuery Query { get; set; }

		[DataMember(Name="replacementContinuationToken", EmitDefaultValue=false)]
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
		[DataMember(Name="useTotalResults", EmitDefaultValue=false)]
		public bool UseTotalResults { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupSearchResponse);
        }

		public bool Equals(GroupSearchResponse input)
		{
			if (input == null) return false;

			return
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Results.GetHashCode();
				hashCode = hashCode * 59 + this.TotalResults.GetHashCode();
				hashCode = hashCode * 59 + this.HasMore.GetHashCode();
				hashCode = hashCode * 59 + this.Query.GetHashCode();
				hashCode = hashCode * 59 + this.ReplacementContinuationToken.GetHashCode();
				hashCode = hashCode * 59 + this.UseTotalResults.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

