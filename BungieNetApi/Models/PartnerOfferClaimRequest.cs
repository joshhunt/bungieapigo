using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	[DataContract]
	public class PartnerOfferClaimRequest{

		[DataMember(Name="PartnerOfferId", EmitDefaultValue=false)]
		public string PartnerOfferId { get; set; }

		[DataMember(Name="BungieNetMembershipId", EmitDefaultValue=false)]
		public long BungieNetMembershipId { get; set; }

		[DataMember(Name="TransactionId", EmitDefaultValue=false)]
		public string TransactionId { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as PartnerOfferClaimRequest);
        }

		public bool Equals(PartnerOfferClaimRequest input)
		{
			if (input == null) return false;

			return
				(
                    PartnerOfferId == input.PartnerOfferId ||
                    (PartnerOfferId != null && PartnerOfferId.Equals(input.PartnerOfferId))
                ) &&
				(
                    BungieNetMembershipId == input.BungieNetMembershipId ||
                    (BungieNetMembershipId != null && BungieNetMembershipId.Equals(input.BungieNetMembershipId))
                ) &&
				(
                    TransactionId == input.TransactionId ||
                    (TransactionId != null && TransactionId.Equals(input.TransactionId))
                ) ;
		}
	}
}

