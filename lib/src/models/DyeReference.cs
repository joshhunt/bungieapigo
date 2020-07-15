using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DyeReference{

		[DataMember(Name="channelHash", EmitDefaultValue=false)]
		public uint ChannelHash { get; set; }

		[DataMember(Name="dyeHash", EmitDefaultValue=false)]
		public uint DyeHash { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DyeReference);
        }

		public bool Equals(DyeReference input)
		{
			if (input == null) return false;

			return
				(
                    ChannelHash == input.ChannelHash ||
                    (ChannelHash != null && ChannelHash.Equals(input.ChannelHash))
                ) &&
				(
                    DyeHash == input.DyeHash ||
                    (DyeHash != null && DyeHash.Equals(input.DyeHash))
                ) ;
		}
	}
}

