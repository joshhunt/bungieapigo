using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class PollResponse{

		[DataMember(Name="topicId", EmitDefaultValue=false)]
		public long TopicId { get; set; }

		[DataMember(Name="results", EmitDefaultValue=false)]
		public List<PollResult> Results { get; set; }

		[DataMember(Name="totalVotes", EmitDefaultValue=false)]
		public long TotalVotes { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as PollResponse);
        }

		public bool Equals(PollResponse input)
		{
			if (input == null) return false;

			return
				(
                    TopicId == input.TopicId ||
                    (TopicId != null && TopicId.Equals(input.TopicId))
                ) &&
				(
                    Results == input.Results ||
                    (Results != null && Results.Equals(input.Results))
                ) &&
				(
                    TotalVotes == input.TotalVotes ||
                    (TotalVotes != null && TotalVotes.Equals(input.TotalVotes))
                ) ;
		}
	}
}

