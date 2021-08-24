using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    [DataContract]
    public class BungieFriendListResponse
    {
        [DataMember(Name = "friends", EmitDefaultValue = false)]
        public List<BungieFriend> Friends { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as BungieFriendListResponse);
        }

        public bool Equals(BungieFriendListResponse input)
        {
            if (input == null) return false;

            return
                (
                    Friends == input.Friends ||
                    (Friends != null && Friends.SequenceEqual(input.Friends))
                ) ;
        }
    }
}

