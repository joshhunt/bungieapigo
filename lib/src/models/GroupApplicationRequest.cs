using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupApplicationRequest{

		[DataMember(Name="message", EmitDefaultValue=false)]
		public string Message { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupApplicationRequest);
        }

		public bool Equals(GroupApplicationRequest input)
		{
			if (input == null) return false;

			return
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
				hashCode = hashCode * 59 + this.Message.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

