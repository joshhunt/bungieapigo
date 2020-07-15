using System.Runtime.Serialization;

namespace BungieNetApi.Model {
	[DataContract]
	public class PartnerOfferHistoryResponse{

		[DataMember(Name="PartnerOfferKey", EmitDefaultValue=false)]
		public string PartnerOfferKey { get; set; }

		[DataMember(Name="MembershipId", EmitDefaultValue=false)]
		public long MembershipId { get; set; }

		[DataMember(Name="MembershipType", EmitDefaultValue=false)]
		public long MembershipType { get; set; }

		[DataMember(Name="LocalizedName", EmitDefaultValue=false)]
		public string LocalizedName { get; set; }

		[DataMember(Name="LocalizedDescription", EmitDefaultValue=false)]
		public string LocalizedDescription { get; set; }

		[DataMember(Name="IsConsumable", EmitDefaultValue=false)]
		public bool IsConsumable { get; set; }

		[DataMember(Name="QuantityApplied", EmitDefaultValue=false)]
		public long QuantityApplied { get; set; }

		[DataMember(Name="ApplyDate", EmitDefaultValue=false)]
		public string ApplyDate { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as PartnerOfferHistoryResponse);
        }

		public bool Equals(PartnerOfferHistoryResponse input)
		{
			if (input == null) return false;

			return
				(
                    PartnerOfferKey == input.PartnerOfferKey ||
                    (PartnerOfferKey != null && PartnerOfferKey.Equals(input.PartnerOfferKey))
                ) &&
				(
                    MembershipId == input.MembershipId ||
                    (MembershipId != null && MembershipId.Equals(input.MembershipId))
                ) &&
				(
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
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
                    IsConsumable == input.IsConsumable ||
                    (IsConsumable != null && IsConsumable.Equals(input.IsConsumable))
                ) &&
				(
                    QuantityApplied == input.QuantityApplied ||
                    (QuantityApplied != null && QuantityApplied.Equals(input.QuantityApplied))
                ) &&
				(
                    ApplyDate == input.ApplyDate ||
                    (ApplyDate != null && ApplyDate.Equals(input.ApplyDate))
                ) ;
		}
	}
}

