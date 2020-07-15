using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class GroupPotentialMembership{

		[DataMember(Name="member", EmitDefaultValue=false)]
		public GroupPotentialMember Member { get; set; }

		[DataMember(Name="group", EmitDefaultValue=false)]
		public GroupV2 Group { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupPotentialMembership);
        }

		public bool Equals(GroupPotentialMembership input)
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

