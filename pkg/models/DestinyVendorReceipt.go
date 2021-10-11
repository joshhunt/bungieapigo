package bungieapigo

import "time"

// If a character purchased an item that is refundable, a Vendor Receipt will be created on the
// user's Destiny Profile. These expire after a configurable period of time, but until then can be
// used to get refunds on items. BNet does not provide the ability to refund a purchase *yet*, but
// you know.
type DestinyVendorReceipt struct {

	// The amount paid for the item, in terms of items that were consumed in the purchase and their
	// quantity.
	CurrencyPaid []DestinyItemQuantity `json:"currencyPaid"`

	// The item that was received, and its quantity.
	ItemReceived DestinyItemQuantity `json:"itemReceived"`

	// The unlock flag used to determine whether you still have the purchased item.
	LicenseUnlockHash int `json:"licenseUnlockHash"`

	// The ID of the character who made the purchase.
	PurchasedByCharacterId int64 `json:"purchasedByCharacterId,string"`

	// Whether you can get a refund, and what happens in order for the refund to be received. See the
	// DestinyVendorItemRefundPolicy enum for details.
	RefundPolicy DestinyVendorItemRefundPolicy `json:"refundPolicy"`

	// The identifier of this receipt.
	SequenceNumber int `json:"sequenceNumber"`

	// The seconds since epoch at which this receipt is rendered invalid.
	TimeToExpiration int64 `json:"timeToExpiration,string"`

	// The date at which this receipt is rendered invalid.
	ExpiresOn time.Time `json:"expiresOn"`
}
