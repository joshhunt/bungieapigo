using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class ApiUsage
    {
        /// <summary>
        /// Counts for on API calls made for the time range.
        /// </summary>
        [DataMember(Name = "apiCalls", EmitDefaultValue = false)]
        public List<Series> ApiCalls { get; set; }

        /// <summary>
        /// Instances of blocked requests or requests that crossed the warn threshold during the time range.
        /// </summary>
        [DataMember(Name = "throttledRequests", EmitDefaultValue = false)]
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
                    ApiCalls == input.ApiCalls ||
                    (ApiCalls != null && ApiCalls.SequenceEqual(input.ApiCalls))
                ) &&
                (
                    ThrottledRequests == input.ThrottledRequests ||
                    (ThrottledRequests != null && ThrottledRequests.SequenceEqual(input.ThrottledRequests))
                ) ;
        }
    }
}

