using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class GroupOptionalConversationAddRequest
    {
        [DataMember(Name = "chatName", EmitDefaultValue = false)]
        public string ChatName { get; set; }

        [DataMember(Name = "chatSecurity", EmitDefaultValue = false)]
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
    }
}

