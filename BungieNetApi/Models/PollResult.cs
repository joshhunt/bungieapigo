using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    [DataContract]
    public class PollResult
    {
        [DataMember(Name = "answerText", EmitDefaultValue = false)]
        public string AnswerText { get; set; }

        [DataMember(Name = "answerSlot", EmitDefaultValue = false)]
        public long AnswerSlot { get; set; }

        [DataMember(Name = "lastVoteDate", EmitDefaultValue = false)]
        public string LastVoteDate { get; set; }

        [DataMember(Name = "votes", EmitDefaultValue = false)]
        public long Votes { get; set; }

        [DataMember(Name = "requestingUserVoted", EmitDefaultValue = false)]
        public bool RequestingUserVoted { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as PollResult);
        }

        public bool Equals(PollResult input)
        {
            if (input == null) return false;

            return
                (
                    AnswerText == input.AnswerText ||
                    (AnswerText != null && AnswerText.Equals(input.AnswerText))
                ) &&
                (
                    AnswerSlot == input.AnswerSlot ||
                    (AnswerSlot != null && AnswerSlot.Equals(input.AnswerSlot))
                ) &&
                (
                    LastVoteDate == input.LastVoteDate ||
                    (LastVoteDate != null && LastVoteDate.Equals(input.LastVoteDate))
                ) &&
                (
                    Votes == input.Votes ||
                    (Votes != null && Votes.Equals(input.Votes))
                ) &&
                (
                    RequestingUserVoted == input.RequestingUserVoted ||
                    (RequestingUserVoted != null && RequestingUserVoted.Equals(input.RequestingUserVoted))
                ) ;
        }
    }
}

