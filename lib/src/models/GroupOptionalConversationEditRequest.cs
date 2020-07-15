using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupOptionalConversationEditRequest{

		[DataMember(Name="chatEnabled", EmitDefaultValue=false)]
		public bool ChatEnabled { get; set; }

		[DataMember(Name="chatName", EmitDefaultValue=false)]
		public string ChatName { get; set; }

		[DataMember(Name="chatSecurity", EmitDefaultValue=false)]
		public long ChatSecurity { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupOptionalConversationEditRequest);
        }

		public bool Equals(GroupOptionalConversationEditRequest input)
		{
			if (input == null) return false;

			return
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
	}
}

