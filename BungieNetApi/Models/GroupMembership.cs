using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class GroupMembership
    {
        [DataMember(Name = "member", EmitDefaultValue = false)]
        public GroupMember Member { get; set; }

        [DataMember(Name = "group", EmitDefaultValue = false)]
        public GroupV2 Group { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMembership);
        }

        public bool Equals(GroupMembership input)
        {
            if (input == null) return false;

            return
                (
                    Member == input.Member ||
                    (Member != null && Member.Equals(input.Member))
                ) &&
                (
                    Group == input.Group ||
                    (Group != null && Group.Equals(input.Group))
                ) ;
        }
    }
}

