class AwaInitializeResponse{
	String correlationId;
	bool sentToSelf;
	AwaInitializeResponse(
		this.correlationId,
		this.sentToSelf,
	);

	static AwaInitializeResponse fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new AwaInitializeResponse(
				data['correlationId'],
				data['sentToSelf'],
		);
	}

	static List<AwaInitializeResponse> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<AwaInitializeResponse> list = new List();
    data.forEach((item) {
      list.add(AwaInitializeResponse.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['correlationId'] = this.correlationId;
			data['sentToSelf'] = this.sentToSelf;
		return data;
	}
}