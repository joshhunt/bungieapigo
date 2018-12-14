class int32Response{
    int response;
    int errorCode;
    int throttleSeconds;
    String errorStatus;
    String message;
    Map<String, String> messageData;
    String detailedErrorTrace;

    int32Response(
		int this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, String> this.messageData,
		String this.detailedErrorTrace,
	);

    static int32Response fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new int32Response(
				data['Response'],
				data['ErrorCode'],
				data['ThrottleSeconds'],
				data['ErrorStatus'],
				data['Message'],
				data['MessageData'] != null ? Map<String, String>.from(data['MessageData'].map((k, v)=>MapEntry(k, v))) : null,
				data['DetailedErrorTrace'],
		);
	}

	static List<int32Response> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<int32Response> list = new List();
    data.forEach((item) {
      list.add(int32Response.fromMap(item));
    });
    return list;
	}
}