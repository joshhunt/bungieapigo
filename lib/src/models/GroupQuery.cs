using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	/// NOTE: GroupQuery, as of Destiny 2, has essentially two totally different and incompatible &quot;modes&quot;.
	/// If you are querying for a group, you can pass any of the properties below.
	/// If you are querying for a Clan, you MUST NOT pass any of the following properties (they must be null or undefined in your request, not just empty string&#x2F;default values):
	/// - groupMemberCountFilter - localeFilter - tagText
	/// If you pass these, you will get a useless InvalidParameters error.
	[DataContract]
	public class GroupQuery{

		[DataMember(Name="name", EmitDefaultValue=false)]
		public string Name { get; set; }

		[DataMember(Name="groupType", EmitDefaultValue=false)]
		public GroupType GroupType { get; set; }

		[DataMember(Name="creationDate", EmitDefaultValue=false)]
		public GroupDateRange CreationDate { get; set; }

		[DataMember(Name="sortBy", EmitDefaultValue=false)]
		public GroupSortBy SortBy { get; set; }

		[DataMember(Name="groupMemberCountFilter", EmitDefaultValue=false)]
		public long GroupMemberCountFilter { get; set; }

		[DataMember(Name="localeFilter", EmitDefaultValue=false)]
		public string LocaleFilter { get; set; }

		[DataMember(Name="tagText", EmitDefaultValue=false)]
		public string TagText { get; set; }

		[DataMember(Name="itemsPerPage", EmitDefaultValue=false)]
		public long ItemsPerPage { get; set; }

		[DataMember(Name="currentPage", EmitDefaultValue=false)]
		public long CurrentPage { get; set; }

		[DataMember(Name="requestContinuationToken", EmitDefaultValue=false)]
		public string RequestContinuationToken { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as GroupQuery);
        }

		public bool Equals(GroupQuery input)
		{
			if (input == null) return false;

			return
				(
                    Name == input.Name ||
                    (Name != null && Name.Equals(input.Name))
                ) &&
				(
                    GroupType == input.GroupType ||
                    (GroupType != null && GroupType.Equals(input.GroupType))
                ) &&
				(
                    CreationDate == input.CreationDate ||
                    (CreationDate != null && CreationDate.Equals(input.CreationDate))
                ) &&
				(
                    SortBy == input.SortBy ||
                    (SortBy != null && SortBy.Equals(input.SortBy))
                ) &&
				(
                    GroupMemberCountFilter == input.GroupMemberCountFilter ||
                    (GroupMemberCountFilter != null && GroupMemberCountFilter.Equals(input.GroupMemberCountFilter))
                ) &&
				(
                    LocaleFilter == input.LocaleFilter ||
                    (LocaleFilter != null && LocaleFilter.Equals(input.LocaleFilter))
                ) &&
				(
                    TagText == input.TagText ||
                    (TagText != null && TagText.Equals(input.TagText))
                ) &&
				(
                    ItemsPerPage == input.ItemsPerPage ||
                    (ItemsPerPage != null && ItemsPerPage.Equals(input.ItemsPerPage))
                ) &&
				(
                    CurrentPage == input.CurrentPage ||
                    (CurrentPage != null && CurrentPage.Equals(input.CurrentPage))
                ) &&
				(
                    RequestContinuationToken == input.RequestContinuationToken ||
                    (RequestContinuationToken != null && RequestContinuationToken.Equals(input.RequestContinuationToken))
                ) ;
		}
	}
}

