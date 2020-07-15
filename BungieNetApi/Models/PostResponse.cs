using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class PostResponse{

		[DataMember(Name="lastReplyTimestamp", EmitDefaultValue=false)]
		public string LastReplyTimestamp { get; set; }

		[DataMember(Name="IsPinned", EmitDefaultValue=false)]
		public bool IsPinned { get; set; }

		[DataMember(Name="urlMediaType", EmitDefaultValue=false)]
		public ForumMediaType UrlMediaType { get; set; }

		[DataMember(Name="thumbnail", EmitDefaultValue=false)]
		public string Thumbnail { get; set; }

		[DataMember(Name="popularity", EmitDefaultValue=false)]
		public ForumPostPopularity Popularity { get; set; }

		[DataMember(Name="isActive", EmitDefaultValue=false)]
		public bool IsActive { get; set; }

		[DataMember(Name="isAnnouncement", EmitDefaultValue=false)]
		public bool IsAnnouncement { get; set; }

		[DataMember(Name="userRating", EmitDefaultValue=false)]
		public long UserRating { get; set; }

		[DataMember(Name="userHasRated", EmitDefaultValue=false)]
		public bool UserHasRated { get; set; }

		[DataMember(Name="userHasMutedPost", EmitDefaultValue=false)]
		public bool UserHasMutedPost { get; set; }

		[DataMember(Name="latestReplyPostId", EmitDefaultValue=false)]
		public long LatestReplyPostId { get; set; }

		[DataMember(Name="latestReplyAuthorId", EmitDefaultValue=false)]
		public long LatestReplyAuthorId { get; set; }

		[DataMember(Name="ignoreStatus", EmitDefaultValue=false)]
		public IgnoreResponse IgnoreStatus { get; set; }

		[DataMember(Name="locale", EmitDefaultValue=false)]
		public string Locale { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as PostResponse);
        }

		public bool Equals(PostResponse input)
		{
			if (input == null) return false;

			return
				(
                    LastReplyTimestamp == input.LastReplyTimestamp ||
                    (LastReplyTimestamp != null && LastReplyTimestamp.Equals(input.LastReplyTimestamp))
                ) &&
				(
                    IsPinned == input.IsPinned ||
                    (IsPinned != null && IsPinned.Equals(input.IsPinned))
                ) &&
				(
                    UrlMediaType == input.UrlMediaType ||
                    (UrlMediaType != null && UrlMediaType.Equals(input.UrlMediaType))
                ) &&
				(
                    Thumbnail == input.Thumbnail ||
                    (Thumbnail != null && Thumbnail.Equals(input.Thumbnail))
                ) &&
				(
                    Popularity == input.Popularity ||
                    (Popularity != null && Popularity.Equals(input.Popularity))
                ) &&
				(
                    IsActive == input.IsActive ||
                    (IsActive != null && IsActive.Equals(input.IsActive))
                ) &&
				(
                    IsAnnouncement == input.IsAnnouncement ||
                    (IsAnnouncement != null && IsAnnouncement.Equals(input.IsAnnouncement))
                ) &&
				(
                    UserRating == input.UserRating ||
                    (UserRating != null && UserRating.Equals(input.UserRating))
                ) &&
				(
                    UserHasRated == input.UserHasRated ||
                    (UserHasRated != null && UserHasRated.Equals(input.UserHasRated))
                ) &&
				(
                    UserHasMutedPost == input.UserHasMutedPost ||
                    (UserHasMutedPost != null && UserHasMutedPost.Equals(input.UserHasMutedPost))
                ) &&
				(
                    LatestReplyPostId == input.LatestReplyPostId ||
                    (LatestReplyPostId != null && LatestReplyPostId.Equals(input.LatestReplyPostId))
                ) &&
				(
                    LatestReplyAuthorId == input.LatestReplyAuthorId ||
                    (LatestReplyAuthorId != null && LatestReplyAuthorId.Equals(input.LatestReplyAuthorId))
                ) &&
				(
                    IgnoreStatus == input.IgnoreStatus ||
                    (IgnoreStatus != null && IgnoreStatus.Equals(input.IgnoreStatus))
                ) &&
				(
                    Locale == input.Locale ||
                    (Locale != null && Locale.Equals(input.Locale))
                ) ;
		}
	}
}

