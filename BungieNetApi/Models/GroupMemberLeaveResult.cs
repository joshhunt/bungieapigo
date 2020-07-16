using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class GroupMemberLeaveResult
    {
        [DataMember(Name = "group", EmitDefaultValue = false)]
        public GroupV2 Group { get; set; }

        [DataMember(Name = "groupDeleted", EmitDefaultValue = false)]
        public bool GroupDeleted { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMemberLeaveResult);
        }

        public bool Equals(GroupMemberLeaveResult input)
        {
            if (input == null) return false;

            return
                (
                    Group == input.Group ||
                    (Group != null && Group.Equals(input.Group))
                ) &&
                (
                    GroupDeleted == input.GroupDeleted ||
                    (GroupDeleted != null && GroupDeleted.Equals(input.GroupDeleted))
                ) ;
        }
    }
}

