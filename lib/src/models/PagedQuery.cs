using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class PagedQuery{

		[DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
		public long ItemsPerPage { get; set; }

		[DataMember(Name="currentPage", EmitDefaultValue=false)]
		public long CurrentPage { get; set; }

		[DataMember(Name="requestContinuationToken", EmitDefaultValue=false)]
		public string RequestContinuationToken { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as PagedQuery);
        }

		public bool Equals(PagedQuery input)
		{
			if (input == null) return false;

			return
				(
                    ItemsPerPage == input.ItemsPerPage ||
                    (ItemsPerPage != null && ItemsPerPage.Equals(input.ItemsPerPage))
                ) &&
				(
                    CurrentPage == input.CurrentPage ||
                    (CurrentPage != null && CurrentPage.Equals(input.CurrentPage))
                ) &&
				(
                    RequestContinuationToken == input.RequestContinuationToken ||
                    (RequestContinuationToken != null && RequestContinuationToken.Equals(input.RequestContinuationToken))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ItemsPerPage.GetHashCode();
				hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
				hashCode = hashCode * 59 + this.RequestContinuationToken.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

