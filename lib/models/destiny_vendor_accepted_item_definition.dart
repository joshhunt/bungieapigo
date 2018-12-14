class DestinyVendorAcceptedItemDefinition{
	int acceptedInventoryBucketHash;
	int destinationInventoryBucketHash;
	DestinyVendorAcceptedItemDefinition(
		this.acceptedInventoryBucketHash,
		this.destinationInventoryBucketHash,
	);

	static DestinyVendorAcceptedItemDefinition fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyVendorAcceptedItemDefinition(
				data['acceptedInventoryBucketHash'],
				data['destinationInventoryBucketHash'],
		);
	}

	static List<DestinyVendorAcceptedItemDefinition> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyVendorAcceptedItemDefinition> list = new List();
    data.forEach((item) {
      list.add(DestinyVendorAcceptedItemDefinition.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['acceptedInventoryBucketHash'] = this.acceptedInventoryBucketHash;
			data['destinationInventoryBucketHash'] = this.destinationInventoryBucketHash;
		return data;
	}
}