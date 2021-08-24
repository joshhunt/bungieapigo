using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class PlatformFriendResponse
    {
        [DataMember(Name = "itemsPerPage", EmitDefaultValue = false)]
        public long ItemsPerPage { get; set; }

        [DataMember(Name = "currentPage", EmitDefaultValue = false)]
        public long CurrentPage { get; set; }

        [DataMember(Name = "hasMore", EmitDefaultValue = false)]
        public bool HasMore { get; set; }

        [DataMember(Name = "platformFriends", EmitDefaultValue = false)]
        public List<PlatformFriend> PlatformFriends { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as PlatformFriendResponse);
        }

        public bool Equals(PlatformFriendResponse input)
        {
            if (input == null) return false;

            return
                (
                    ItemsPerPage == input.ItemsPerPage ||
                    (ItemsPerPage.Equals(input.ItemsPerPage))
                ) &&
                (
                    CurrentPage == input.CurrentPage ||
                    (CurrentPage.Equals(input.CurrentPage))
                ) &&
                (
                    HasMore == input.HasMore ||
                    (HasMore != null && HasMore.Equals(input.HasMore))
                ) &&
                (
                    PlatformFriends == input.PlatformFriends ||
                    (PlatformFriends != null && PlatformFriends.SequenceEqual(input.PlatformFriends))
                ) ;
        }
    }
}

