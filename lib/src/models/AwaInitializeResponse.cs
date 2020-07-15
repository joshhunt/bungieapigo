using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Model
{
	[DataContract]
	public class AwaInitializeResponse{

		/// <summary>
		/// ID used to get the token. Present this ID to the user as it will identify this specific request on their device.
		/// </summary>
		[DataMember(Name="correlationId", EmitDefaultValue=false)]
		public string CorrelationId { get; set; }

		/// <summary>
		/// True if the PUSH message will only be sent to the device that made this request.
		/// </summary>
		[DataMember(Name="sentToSelf", EmitDefaultValue=false)]
		public bool SentToSelf { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as AwaInitializeResponse);
        }

		public bool Equals(AwaInitializeResponse input)
		{
			if (input == null) return false;

			return
				(
                    CorrelationId == input.CorrelationId ||
                    (CorrelationId != null && CorrelationId.Equals(input.CorrelationId))
                ) &&
				(
                    SentToSelf == input.SentToSelf ||
                    (SentToSelf != null && SentToSelf.Equals(input.SentToSelf))
                ) ;
		}
	}
}

