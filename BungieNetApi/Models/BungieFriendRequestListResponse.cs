using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class BungieFriendRequestListResponse
    {
        [DataMember(Name = "incomingRequests", EmitDefaultValue = false)]
        public List<BungieFriend> IncomingRequests { get; set; }

        [DataMember(Name = "outgoingRequests", EmitDefaultValue = false)]
        public List<BungieFriend> OutgoingRequests { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as BungieFriendRequestListResponse);
        }

        public bool Equals(BungieFriendRequestListResponse input)
        {
            if (input == null) return false;

            return
                (
                    IncomingRequests == input.IncomingRequests ||
                    (IncomingRequests != null && IncomingRequests.SequenceEqual(input.IncomingRequests))
                ) &&
                (
                    OutgoingRequests == input.OutgoingRequests ||
                    (OutgoingRequests != null && OutgoingRequests.SequenceEqual(input.OutgoingRequests))
                ) ;
        }
    }
}

