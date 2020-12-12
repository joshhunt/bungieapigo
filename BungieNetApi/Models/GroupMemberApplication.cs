using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [DataContract]
    public class GroupMemberApplication
    {
        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public long GroupId { get; set; }

        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; set; }

        [DataMember(Name = "resolveState", EmitDefaultValue = false)]
        public GroupApplicationResolveState ResolveState { get; set; }

        [DataMember(Name = "resolveDate", EmitDefaultValue = false)]
        public DateTime ResolveDate { get; set; }

        [DataMember(Name = "resolvedByMembershipId", EmitDefaultValue = false)]
        public long ResolvedByMembershipId { get; set; }

        [DataMember(Name = "requestMessage", EmitDefaultValue = false)]
        public string RequestMessage { get; set; }

        [DataMember(Name = "resolveMessage", EmitDefaultValue = false)]
        public string ResolveMessage { get; set; }

        [DataMember(Name = "destinyUserInfo", EmitDefaultValue = false)]
        public GroupUserInfoCard DestinyUserInfo { get; set; }

        /// <summary>
        /// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
        /// </summary>
        [DataMember(Name = "bungieNetUserInfo", EmitDefaultValue = false)]
        public UserInfoCard BungieNetUserInfo { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMemberApplication);
        }

        public bool Equals(GroupMemberApplication input)
        {
            if (input == null) return false;

            return
                (
                    GroupId == input.GroupId ||
                    (GroupId.Equals(input.GroupId))
                ) &&
                (
                    CreationDate == input.CreationDate ||
                    (CreationDate != null && CreationDate.Equals(input.CreationDate))
                ) &&
                (
                    ResolveState == input.ResolveState ||
                    (ResolveState != null && ResolveState.Equals(input.ResolveState))
                ) &&
                (
                    ResolveDate == input.ResolveDate ||
                    (ResolveDate != null && ResolveDate.Equals(input.ResolveDate))
                ) &&
                (
                    ResolvedByMembershipId == input.ResolvedByMembershipId ||
                    (ResolvedByMembershipId.Equals(input.ResolvedByMembershipId))
                ) &&
                (
                    RequestMessage == input.RequestMessage ||
                    (RequestMessage != null && RequestMessage.Equals(input.RequestMessage))
                ) &&
                (
                    ResolveMessage == input.ResolveMessage ||
                    (ResolveMessage != null && ResolveMessage.Equals(input.ResolveMessage))
                ) &&
                (
                    DestinyUserInfo == input.DestinyUserInfo ||
                    (DestinyUserInfo != null && DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) &&
                (
                    BungieNetUserInfo == input.BungieNetUserInfo ||
                    (BungieNetUserInfo != null && BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) ;
        }
    }
}

