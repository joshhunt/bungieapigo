using System.Runtime.Serialization;

namespace BungieNetApi.Model {
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ChannelName.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

