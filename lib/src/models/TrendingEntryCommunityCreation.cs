using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class TrendingEntryCommunityCreation{

		[DataMember(Name="media", EmitDefaultValue=false)]
		public string Media { get; set; }

		[DataMember(Name="title", EmitDefaultValue=false)]
		public string Title { get; set; }

		[DataMember(Name="author", EmitDefaultValue=false)]
		public string Author { get; set; }

		[DataMember(Name="authorMembershipId", EmitDefaultValue=false)]
		public long AuthorMembershipId { get; set; }

		[DataMember(Name="postId", EmitDefaultValue=false)]
		public long PostId { get; set; }

		[DataMember(Name="body", EmitDefaultValue=false)]
		public string Body { get; set; }

		[DataMember(Name="upvotes", EmitDefaultValue=false)]
		public long Upvotes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as TrendingEntryCommunityCreation);
        }

		public bool Equals(TrendingEntryCommunityCreation input)
		{
			if (input == null) return false;

			return
				(
                    Media == input.Media ||
                    (Media != null && Media.Equals(input.Media))
                ) &&
				(
                    Title == input.Title ||
                    (Title != null && Title.Equals(input.Title))
                ) &&
				(
                    Author == input.Author ||
                    (Author != null && Author.Equals(input.Author))
                ) &&
				(
                    AuthorMembershipId == input.AuthorMembershipId ||
                    (AuthorMembershipId != null && AuthorMembershipId.Equals(input.AuthorMembershipId))
                ) &&
				(
                    PostId == input.PostId ||
                    (PostId != null && PostId.Equals(input.PostId))
                ) &&
				(
                    Body == input.Body ||
                    (Body != null && Body.Equals(input.Body))
                ) &&
				(
                    Upvotes == input.Upvotes ||
                    (Upvotes != null && Upvotes.Equals(input.Upvotes))
                ) ;
		}
	}
}

