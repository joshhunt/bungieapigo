import '../models/entity_action_result.dart';
class ListOfEntityActionResultResponse{
    List<EntityActionResult> response;
    int errorCode;
    int throttleSeconds;
    String errorStatus;
    String message;
    Map<String, dynamic> messageData;
    String detailedErrorTrace;

    ListOfEntityActionResultResponse(
		List<EntityActionResult> this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, dynamic> this.messageData,
		String this.detailedErrorTrace,
	);

    static ListOfEntityActionResultResponse fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new ListOfEntityActionResultResponse(
				EntityActionResult.fromList(data['Response']),
				data['ErrorCode'],
				data['ThrottleSeconds'],
				data['ErrorStatus'],
				data['Message'],
				data['MessageData'],
				data['DetailedErrorTrace'],
		);
	}

	static List<ListOfEntityActionResultResponse> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<ListOfEntityActionResultResponse> list = new List();
    data.forEach((item) {
      list.add(ListOfEntityActionResultResponse.fromMap(item));
    });
    return list;
	}
}