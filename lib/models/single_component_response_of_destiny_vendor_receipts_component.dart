import 'destiny_vendor_receipts_component.dart';
class SingleComponentResponseOfDestinyVendorReceiptsComponent{
	DestinyVendorReceiptsComponent data;
	int privacy;
	SingleComponentResponseOfDestinyVendorReceiptsComponent(
		DestinyVendorReceiptsComponent this.data,
		int this.privacy,
	);

	static SingleComponentResponseOfDestinyVendorReceiptsComponent fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new SingleComponentResponseOfDestinyVendorReceiptsComponent(
				DestinyVendorReceiptsComponent.fromMap(data['data']),
				data['privacy'],
		);
	}

	static List<SingleComponentResponseOfDestinyVendorReceiptsComponent> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<SingleComponentResponseOfDestinyVendorReceiptsComponent> list = new List();
    data.forEach((item) {
      list.add(SingleComponentResponseOfDestinyVendorReceiptsComponent.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['data'] = this.data.toMap();
			data['privacy'] = this.privacy;
		return data;
	}
}