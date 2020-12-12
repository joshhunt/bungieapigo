using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [DataContract]
    public class GroupMember
    {
        [DataMember(Name = "memberType", EmitDefaultValue = false)]
        public RuntimeGroupMemberType MemberType { get; set; }

        [DataMember(Name = "isOnline", EmitDefaultValue = false)]
        public bool IsOnline { get; set; }

        [DataMember(Name = "lastOnlineStatusChange", EmitDefaultValue = false)]
        public long LastOnlineStatusChange { get; set; }

        [DataMember(Name = "groupId", EmitDefaultValue = false)]
        public long GroupId { get; set; }

        [DataMember(Name = "destinyUserInfo", EmitDefaultValue = false)]
        public GroupUserInfoCard DestinyUserInfo { get; set; }

        /// <summary>
        /// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
        /// </summary>
        [DataMember(Name = "bungieNetUserInfo", EmitDefaultValue = false)]
        public UserInfoCard BungieNetUserInfo { get; set; }

        [DataMember(Name = "joinDate", EmitDefaultValue = false)]
        public DateTime JoinDate { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as GroupMember);
        }

        public bool Equals(GroupMember input)
        {
            if (input == null) return false;

            return
                (
                    MemberType == input.MemberType ||
                    (MemberType != null && MemberType.Equals(input.MemberType))
                ) &&
                (
                    IsOnline == input.IsOnline ||
                    (IsOnline != null && IsOnline.Equals(input.IsOnline))
                ) &&
                (
                    LastOnlineStatusChange == input.LastOnlineStatusChange ||
                    (LastOnlineStatusChange.Equals(input.LastOnlineStatusChange))
                ) &&
                (
                    GroupId == input.GroupId ||
                    (GroupId.Equals(input.GroupId))
                ) &&
                (
                    DestinyUserInfo == input.DestinyUserInfo ||
                    (DestinyUserInfo != null && DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) &&
                (
                    BungieNetUserInfo == input.BungieNetUserInfo ||
                    (BungieNetUserInfo != null && BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) &&
                (
                    JoinDate == input.JoinDate ||
                    (JoinDate != null && JoinDate.Equals(input.JoinDate))
                ) ;
        }
    }
}

