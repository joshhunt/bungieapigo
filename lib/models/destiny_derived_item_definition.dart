class DestinyDerivedItemDefinition{
	int itemHash;
	String itemName;
	String itemDetail;
	String itemDescription;
	String iconPath;
	int vendorItemIndex;
	DestinyDerivedItemDefinition(
		this.itemHash,
		this.itemName,
		this.itemDetail,
		this.itemDescription,
		this.iconPath,
		this.vendorItemIndex,
	);

	static DestinyDerivedItemDefinition fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyDerivedItemDefinition(
				data['itemHash'],
				data['itemName'],
				data['itemDetail'],
				data['itemDescription'],
				data['iconPath'],
				data['vendorItemIndex'],
		);
	}

	static List<DestinyDerivedItemDefinition> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyDerivedItemDefinition> list = new List();
    data.forEach((item) {
      list.add(DestinyDerivedItemDefinition.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['itemHash'] = this.itemHash;
			data['itemName'] = this.itemName;
			data['itemDetail'] = this.itemDetail;
			data['itemDescription'] = this.itemDescription;
			data['iconPath'] = this.iconPath;
			data['vendorItemIndex'] = this.vendorItemIndex;
		return data;
	}
}