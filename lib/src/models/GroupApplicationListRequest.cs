using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupApplicationListRequest{

		[DataMember(Name="memberships", EmitDefaultValue=false)]
		public List<UserMembership> Memberships { get; set; }

		[DataMember(Name="message", EmitDefaultValue=false)]
		public string Message { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupApplicationListRequest);
        }

		public bool Equals(GroupApplicationListRequest input)
		{
			if (input == null) return false;

			return
				(
                    Memberships == input.Memberships ||
                    (Memberships != null && Memberships.Equals(input.Memberships))
                ) &&
				(
                    Message == input.Message ||
                    (Message != null && Message.Equals(input.Message))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.Memberships.GetHashCode();
				hashCode = hashCode * 59 + this.Message.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

