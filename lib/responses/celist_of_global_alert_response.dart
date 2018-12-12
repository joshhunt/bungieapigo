import '../models/global_alert.dart';
class CEListOfGlobalAlertResponse{
    List<GlobalAlert> response;
    int errorCode;
    int throttleSeconds;
    String errorStatus;
    String message;
    Map<String, dynamic> messageData;
    String detailedErrorTrace;

    CEListOfGlobalAlertResponse(
		List<GlobalAlert> this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, dynamic> this.messageData,
		String this.detailedErrorTrace,
	);

    static CEListOfGlobalAlertResponse fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new CEListOfGlobalAlertResponse(
				GlobalAlert.fromList(data['Response']),
				data['ErrorCode'],
				data['ThrottleSeconds'],
				data['ErrorStatus'],
				data['Message'],
				data['MessageData'],
				data['DetailedErrorTrace'],
		);
	}

	static List<CEListOfGlobalAlertResponse> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<CEListOfGlobalAlertResponse> list = new List();
    data.forEach((item) {
      list.add(CEListOfGlobalAlertResponse.fromMap(item));
    });
    return list;
	}
}