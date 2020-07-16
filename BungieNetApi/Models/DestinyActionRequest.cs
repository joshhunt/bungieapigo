using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyActionRequest
    {
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public BungieMembershipType MembershipType { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActionRequest);
        }

        public bool Equals(DestinyActionRequest input)
        {
            if (input == null) return false;

            return
                (
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) ;
        }
    }
}

