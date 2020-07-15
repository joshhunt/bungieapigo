using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class ApiUsage{

		/// <summary>
		/// The date range for the data being reported.
		/// </summary>
		[DataMember(Name="range", EmitDefaultValue=false)]
		public DateRange Range { get; set; }

		/// <summary>
		/// Counts for on API calls made for the time range.
		/// </summary>
		[DataMember(Name="apiCalls", EmitDefaultValue=false)]
		public List<Series> ApiCalls { get; set; }

		/// <summary>
		/// Instances of blocked requests or requests that crossed the warn threshold during the time range.
		/// </summary>
		[DataMember(Name="throttledRequests", EmitDefaultValue=false)]
		public List<Series> ThrottledRequests { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ApiUsage);
        }

		public bool Equals(ApiUsage input)
		{
			if (input == null) return false;

			return
				(
                    Range == input.Range ||
                    (Range != null && Range.Equals(input.Range))
                ) &&
				(
                    ApiCalls == input.ApiCalls ||
                    (ApiCalls != null && ApiCalls.Equals(input.ApiCalls))
                ) &&
				(
                    ThrottledRequests == input.ThrottledRequests ||
                    (ThrottledRequests != null && ThrottledRequests.Equals(input.ThrottledRequests))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Range.GetHashCode();
				hashCode = hashCode * 59 + this.ApiCalls.GetHashCode();
				hashCode = hashCode * 59 + this.ThrottledRequests.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

