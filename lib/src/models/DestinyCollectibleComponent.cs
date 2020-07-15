using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class DestinyCollectibleComponent{

		[DataMember(Name="state", EmitDefaultValue=false)]
		public DestinyCollectibleState State { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCollectibleComponent);
        }

		public bool Equals(DestinyCollectibleComponent input)
		{
			if (input == null) return false;

			return
				(
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) ;
		}
	}
}

