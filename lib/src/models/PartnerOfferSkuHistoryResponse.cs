using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	[DataContract]
	public class PartnerOfferSkuHistoryResponse{

		[DataMember(Name="SkuIdentifier", EmitDefaultValue=false)]
		public string SkuIdentifier { get; set; }

		[DataMember(Name="LocalizedName", EmitDefaultValue=false)]
		public string LocalizedName { get; set; }

		[DataMember(Name="LocalizedDescription", EmitDefaultValue=false)]
		public string LocalizedDescription { get; set; }

		[DataMember(Name="ClaimDate", EmitDefaultValue=false)]
		public string ClaimDate { get; set; }

		[DataMember(Name="AllOffersApplied", EmitDefaultValue=false)]
		public bool AllOffersApplied { get; set; }

		[DataMember(Name="TransactionId", EmitDefaultValue=false)]
		public string TransactionId { get; set; }

		[DataMember(Name="SkuOffers", EmitDefaultValue=false)]
		public List<PartnerOfferHistoryResponse> SkuOffers { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as PartnerOfferSkuHistoryResponse);
        }

		public bool Equals(PartnerOfferSkuHistoryResponse input)
		{
			if (input == null) return false;

			return
				(
                    SkuIdentifier == input.SkuIdentifier ||
                    (SkuIdentifier != null && SkuIdentifier.Equals(input.SkuIdentifier))
                ) &&
				(
                    LocalizedName == input.LocalizedName ||
                    (LocalizedName != null && LocalizedName.Equals(input.LocalizedName))
                ) &&
				(
                    LocalizedDescription == input.LocalizedDescription ||
                    (LocalizedDescription != null && LocalizedDescription.Equals(input.LocalizedDescription))
                ) &&
				(
                    ClaimDate == input.ClaimDate ||
                    (ClaimDate != null && ClaimDate.Equals(input.ClaimDate))
                ) &&
				(
                    AllOffersApplied == input.AllOffersApplied ||
                    (AllOffersApplied != null && AllOffersApplied.Equals(input.AllOffersApplied))
                ) &&
				(
                    TransactionId == input.TransactionId ||
                    (TransactionId != null && TransactionId.Equals(input.TransactionId))
                ) &&
				(
                    SkuOffers == input.SkuOffers ||
                    (SkuOffers != null && SkuOffers.Equals(input.SkuOffers))
                ) ;
		}
	}
}

