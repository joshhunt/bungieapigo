using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class CommentSummary{

		[DataMember(Name="topicId", EmitDefaultValue=false)]
		public long TopicId { get; set; }

		[DataMember(Name="commentCount", EmitDefaultValue=false)]
		public long CommentCount { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as CommentSummary);
        }

		public bool Equals(CommentSummary input)
		{
			if (input == null) return false;

			return
				(
                    TopicId == input.TopicId ||
                    (TopicId != null && TopicId.Equals(input.TopicId))
                ) &&
				(
                    CommentCount == input.CommentCount ||
                    (CommentCount != null && CommentCount.Equals(input.CommentCount))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.TopicId.GetHashCode();
				hashCode = hashCode * 59 + this.CommentCount.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

