using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class GroupBan{

		[DataMember(Name="groupId", EmitDefaultValue=false)]
		public long GroupId { get; set; }

		/// <summary>
		/// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
		/// </summary>
		[DataMember(Name="lastModifiedBy", EmitDefaultValue=false)]
		public UserInfoCard LastModifiedBy { get; set; }

		/// <summary>
		/// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
		/// </summary>
		[DataMember(Name="createdBy", EmitDefaultValue=false)]
		public UserInfoCard CreatedBy { get; set; }

		[DataMember(Name="dateBanned", EmitDefaultValue=false)]
		public string DateBanned { get; set; }

		[DataMember(Name="dateExpires", EmitDefaultValue=false)]
		public string DateExpires { get; set; }

		[DataMember(Name="comment", EmitDefaultValue=false)]
		public string Comment { get; set; }

		/// <summary>
		/// This contract supplies basic information commonly used to display a minimal amount of information about a user. Take care to not add more properties here unless the property applies in all (or at least the majority) of the situations where UserInfoCard is used. Avoid adding game specific or platform specific details here. In cases where UserInfoCard is a subset of the data needed in a contract, use UserInfoCard as a property of other contracts.
		/// </summary>
		[DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
		public UserInfoCard BungieNetUserInfo { get; set; }

		[DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
		public GroupUserInfoCard DestinyUserInfo { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupBan);
        }

		public bool Equals(GroupBan input)
		{
			if (input == null) return false;

			return
				(
                    GroupId == input.GroupId ||
                    (GroupId != null && GroupId.Equals(input.GroupId))
                ) &&
				(
                    LastModifiedBy == input.LastModifiedBy ||
                    (LastModifiedBy != null && LastModifiedBy.Equals(input.LastModifiedBy))
                ) &&
				(
                    CreatedBy == input.CreatedBy ||
                    (CreatedBy != null && CreatedBy.Equals(input.CreatedBy))
                ) &&
				(
                    DateBanned == input.DateBanned ||
                    (DateBanned != null && DateBanned.Equals(input.DateBanned))
                ) &&
				(
                    DateExpires == input.DateExpires ||
                    (DateExpires != null && DateExpires.Equals(input.DateExpires))
                ) &&
				(
                    Comment == input.Comment ||
                    (Comment != null && Comment.Equals(input.Comment))
                ) &&
				(
                    BungieNetUserInfo == input.BungieNetUserInfo ||
                    (BungieNetUserInfo != null && BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) &&
				(
                    DestinyUserInfo == input.DestinyUserInfo ||
                    (DestinyUserInfo != null && DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.GroupId.GetHashCode();
				hashCode = hashCode * 59 + this.LastModifiedBy.GetHashCode();
				hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
				hashCode = hashCode * 59 + this.DateBanned.GetHashCode();
				hashCode = hashCode * 59 + this.DateExpires.GetHashCode();
				hashCode = hashCode * 59 + this.Comment.GetHashCode();
				hashCode = hashCode * 59 + this.BungieNetUserInfo.GetHashCode();
				hashCode = hashCode * 59 + this.DestinyUserInfo.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

