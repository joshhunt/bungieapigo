using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class CommentSummary
    {
        [DataMember(Name = "topicId", EmitDefaultValue = false)]
        public long TopicId { get; set; }

        [DataMember(Name = "commentCount", EmitDefaultValue = false)]
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
    }
}

