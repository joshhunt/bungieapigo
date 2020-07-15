using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupOptionalConversation{

		[DataMember(Name="groupId", EmitDefaultValue=false)]
		public long GroupId { get; set; }

		[DataMember(Name="conversationId", EmitDefaultValue=false)]
		public long ConversationId { get; set; }

		[DataMember(Name="chatEnabled", EmitDefaultValue=false)]
		public bool ChatEnabled { get; set; }

		[DataMember(Name="chatName", EmitDefaultValue=false)]
		public string ChatName { get; set; }

		[DataMember(Name="chatSecurity", EmitDefaultValue=false)]
		public ChatSecuritySetting ChatSecurity { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupOptionalConversation);
        }

		public bool Equals(GroupOptionalConversation input)
		{
			if (input == null) return false;

			return
				(
                    GroupId == input.GroupId ||
                    (GroupId != null && GroupId.Equals(input.GroupId))
                ) &&
				(
                    ConversationId == input.ConversationId ||
                    (ConversationId != null && ConversationId.Equals(input.ConversationId))
                ) &&
				(
                    ChatEnabled == input.ChatEnabled ||
                    (ChatEnabled != null && ChatEnabled.Equals(input.ChatEnabled))
                ) &&
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
				hashCode = hashCode * 59 + this.GroupId.GetHashCode();
				hashCode = hashCode * 59 + this.ConversationId.GetHashCode();
				hashCode = hashCode * 59 + this.ChatEnabled.GetHashCode();
				hashCode = hashCode * 59 + this.ChatName.GetHashCode();
				hashCode = hashCode * 59 + this.ChatSecurity.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

