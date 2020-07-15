using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// If a character purchased an item that is refundable, a Vendor Receipt will be created on the user's Destiny Profile. These expire after a configurable period of time, but until then can be used to get refunds on items. BNet does not provide the ability to refund a purchase *yet*, but you know.
	/// </summary>
	[DataContract]
	public class DestinyVendorReceipt{

		/// <summary>
		/// The amount paid for the item, in terms of items that were consumed in the purchase and their quantity.
		/// </summary>
		[DataMember(Name="currencyPaid", EmitDefaultValue=false)]
		public List<DestinyItemQuantity> CurrencyPaid { get; set; }

		/// <summary>
		/// The item that was received, and its quantity.
		/// </summary>
		[DataMember(Name="itemReceived", EmitDefaultValue=false)]
		public DestinyItemQuantity ItemReceived { get; set; }

		/// <summary>
		/// The unlock flag used to determine whether you still have the purchased item.
		/// </summary>
		[DataMember(Name="licenseUnlockHash", EmitDefaultValue=false)]
		public uint LicenseUnlockHash { get; set; }

		/// <summary>
		/// The ID of the character who made the purchase.
		/// </summary>
		[DataMember(Name="purchasedByCharacterId", EmitDefaultValue=false)]
		public long PurchasedByCharacterId { get; set; }

		/// <summary>
		/// Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details.
		/// </summary>
		[DataMember(Name="refundPolicy", EmitDefaultValue=false)]
		public DestinyVendorItemRefundPolicy RefundPolicy { get; set; }

		/// <summary>
		/// The identifier of this receipt.
		/// </summary>
		[DataMember(Name="sequenceNumber", EmitDefaultValue=false)]
		public long SequenceNumber { get; set; }

		/// <summary>
		/// The seconds since epoch at which this receipt is rendered invalid.
		/// </summary>
		[DataMember(Name="timeToExpiration", EmitDefaultValue=false)]
		public long TimeToExpiration { get; set; }

		/// <summary>
		/// The date at which this receipt is rendered invalid.
		/// </summary>
		[DataMember(Name="expiresOn", EmitDefaultValue=false)]
		public string ExpiresOn { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyVendorReceipt);
        }

		public bool Equals(DestinyVendorReceipt input)
		{
			if (input == null) return false;

			return
				(
                    CurrencyPaid == input.CurrencyPaid ||
                    (CurrencyPaid != null && CurrencyPaid.Equals(input.CurrencyPaid))
                ) &&
				(
                    ItemReceived == input.ItemReceived ||
                    (ItemReceived != null && ItemReceived.Equals(input.ItemReceived))
                ) &&
				(
                    LicenseUnlockHash == input.LicenseUnlockHash ||
                    (LicenseUnlockHash != null && LicenseUnlockHash.Equals(input.LicenseUnlockHash))
                ) &&
				(
                    PurchasedByCharacterId == input.PurchasedByCharacterId ||
                    (PurchasedByCharacterId != null && PurchasedByCharacterId.Equals(input.PurchasedByCharacterId))
                ) &&
				(
                    RefundPolicy == input.RefundPolicy ||
                    (RefundPolicy != null && RefundPolicy.Equals(input.RefundPolicy))
                ) &&
				(
                    SequenceNumber == input.SequenceNumber ||
                    (SequenceNumber != null && SequenceNumber.Equals(input.SequenceNumber))
                ) &&
				(
                    TimeToExpiration == input.TimeToExpiration ||
                    (TimeToExpiration != null && TimeToExpiration.Equals(input.TimeToExpiration))
                ) &&
				(
                    ExpiresOn == input.ExpiresOn ||
                    (ExpiresOn != null && ExpiresOn.Equals(input.ExpiresOn))
                ) ;
		}
	}
}

