import 'destiny_item_quantity.dart';
import 'destiny_item_quantity.dart';
class DestinyVendorReceipt{
	List<DestinyItemQuantity> currencyPaid;
	DestinyItemQuantity itemReceived;
	int licenseUnlockHash;
	String purchasedByCharacterId;
	int refundPolicy;
	int sequenceNumber;
	String timeToExpiration;
	String expiresOn;
	DestinyVendorReceipt(
		List<DestinyItemQuantity> this.currencyPaid,
		DestinyItemQuantity this.itemReceived,
		int this.licenseUnlockHash,
		String this.purchasedByCharacterId,
		int this.refundPolicy,
		int this.sequenceNumber,
		String this.timeToExpiration,
		String this.expiresOn,
	);

	static DestinyVendorReceipt fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyVendorReceipt(
				DestinyItemQuantity.fromList(data['currencyPaid']),
				data['itemReceived'],
				data['licenseUnlockHash'],
				data['purchasedByCharacterId'],
				data['refundPolicy'],
				data['sequenceNumber'],
				data['timeToExpiration'],
				data['expiresOn'],
		);
	}

	static List<DestinyVendorReceipt> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyVendorReceipt> list = new List();
    data.forEach((item) {
      list.add(DestinyVendorReceipt.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['currencyPaid'] = this.currencyPaid.map((item)=>item.toMap());
			data['itemReceived'] = this.itemReceived;
			data['licenseUnlockHash'] = this.licenseUnlockHash;
			data['purchasedByCharacterId'] = this.purchasedByCharacterId;
			data['refundPolicy'] = this.refundPolicy;
			data['sequenceNumber'] = this.sequenceNumber;
			data['timeToExpiration'] = this.timeToExpiration;
			data['expiresOn'] = this.expiresOn;
		return data;
	}
}