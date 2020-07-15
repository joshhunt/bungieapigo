using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class StreamInfo{

		[DataMember(Name="ChannelName", EmitDefaultValue=false)]
		public string ChannelName { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as StreamInfo);
        }

		public bool Equals(StreamInfo input)
		{
			if (input == null) return false;

			return
				(
                    ChannelName == input.ChannelName ||
                    (ChannelName != null && ChannelName.Equals(input.ChannelName))
                ) ;
		}
	}
}

