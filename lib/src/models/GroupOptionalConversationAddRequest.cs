using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupOptionalConversationAddRequest{

		[DataMember(Name="chatName", EmitDefaultValue=false)]
		public string ChatName { get; set; }

		[DataMember(Name="chatSecurity", EmitDefaultValue=false)]
		public ChatSecuritySetting ChatSecurity { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupOptionalConversationAddRequest);
        }

		public bool Equals(GroupOptionalConversationAddRequest input)
		{
			if (input == null) return false;

			return
				(
                    ChatName == input.ChatName ||
                    (ChatName != null && ChatName.Equals(input.ChatName))
                ) &&
				(
                    ChatSecurity == input.ChatSecurity ||
                    (ChatSecurity != null && ChatSecurity.Equals(input.ChatSecurity))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ChatName.GetHashCode();
				hashCode = hashCode * 59 + this.ChatSecurity.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

