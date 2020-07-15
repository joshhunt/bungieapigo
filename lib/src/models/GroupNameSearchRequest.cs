using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupNameSearchRequest{

		[DataMember(Name="groupName", EmitDefaultValue=false)]
		public string GroupName { get; set; }

		[DataMember(Name="groupType", EmitDefaultValue=false)]
		public GroupType GroupType { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupNameSearchRequest);
        }

		public bool Equals(GroupNameSearchRequest input)
		{
			if (input == null) return false;

			return
				(
                    GroupName == input.GroupName ||
                    (GroupName != null && GroupName.Equals(input.GroupName))
                ) &&
				(
                    GroupType == input.GroupType ||
                    (GroupType != null && GroupType.Equals(input.GroupType))
                ) ;
		}
	}
}

