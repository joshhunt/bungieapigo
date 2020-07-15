using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class GroupMembershipBase
    {
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public GroupV2 Group { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMembershipBase);
        }

        public bool Equals(GroupMembershipBase input)
        {
            if (input == null) return false;

            return
                (
                    Group == input.Group ||
                    (Group != null && Group.Equals(input.Group))
                ) ;
        }
    }
}

