using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class ForumRecruitmentDetail{

		[DataMember(Name="topicId", EmitDefaultValue=false)]
		public long TopicId { get; set; }

		[DataMember(Name="microphoneRequired", EmitDefaultValue=false)]
		public bool MicrophoneRequired { get; set; }

		[DataMember(Name="intensity", EmitDefaultValue=false)]
		public ForumRecruitmentIntensityLabel Intensity { get; set; }

		[DataMember(Name="tone", EmitDefaultValue=false)]
		public ForumRecruitmentToneLabel Tone { get; set; }

		[DataMember(Name="approved", EmitDefaultValue=false)]
		public bool Approved { get; set; }

		[DataMember(Name="conversationId", EmitDefaultValue=false)]
		public long ConversationId { get; set; }

		[DataMember(Name="playerSlotsTotal", EmitDefaultValue=false)]
		public long PlayerSlotsTotal { get; set; }

		[DataMember(Name="playerSlotsRemaining", EmitDefaultValue=false)]
		public long PlayerSlotsRemaining { get; set; }

		[DataMember(Name="Fireteam", EmitDefaultValue=false)]
		public List<GeneralUser> Fireteam { get; set; }

		[DataMember(Name="kickedPlayerIds", EmitDefaultValue=false)]
		public List<long> KickedPlayerIds { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as ForumRecruitmentDetail);
        }

		public bool Equals(ForumRecruitmentDetail input)
		{
			if (input == null) return false;

			return
				(
                    TopicId == input.TopicId ||
                    (TopicId != null && TopicId.Equals(input.TopicId))
                ) &&
				(
                    MicrophoneRequired == input.MicrophoneRequired ||
                    (MicrophoneRequired != null && MicrophoneRequired.Equals(input.MicrophoneRequired))
                ) &&
				(
                    Intensity == input.Intensity ||
                    (Intensity != null && Intensity.Equals(input.Intensity))
                ) &&
				(
                    Tone == input.Tone ||
                    (Tone != null && Tone.Equals(input.Tone))
                ) &&
				(
                    Approved == input.Approved ||
                    (Approved != null && Approved.Equals(input.Approved))
                ) &&
				(
                    ConversationId == input.ConversationId ||
                    (ConversationId != null && ConversationId.Equals(input.ConversationId))
                ) &&
				(
                    PlayerSlotsTotal == input.PlayerSlotsTotal ||
                    (PlayerSlotsTotal != null && PlayerSlotsTotal.Equals(input.PlayerSlotsTotal))
                ) &&
				(
                    PlayerSlotsRemaining == input.PlayerSlotsRemaining ||
                    (PlayerSlotsRemaining != null && PlayerSlotsRemaining.Equals(input.PlayerSlotsRemaining))
                ) &&
				(
                    Fireteam == input.Fireteam ||
                    (Fireteam != null && Fireteam.Equals(input.Fireteam))
                ) &&
				(
                    KickedPlayerIds == input.KickedPlayerIds ||
                    (KickedPlayerIds != null && KickedPlayerIds.Equals(input.KickedPlayerIds))
                ) ;
		}
	}
}

