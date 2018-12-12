import '../models/post_search_response.dart';
class PostSearchResponseResponse{
    PostSearchResponse response;
    int errorCode;
    int throttleSeconds;
    String errorStatus;
    String message;
    Map<String, dynamic> messageData;
    String detailedErrorTrace;

    PostSearchResponseResponse(
		PostSearchResponse this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, dynamic> this.messageData,
		String this.detailedErrorTrace,
	);

    static PostSearchResponseResponse fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new PostSearchResponseResponse(
				PostSearchResponse.fromMap(data['Response']),
				data['ErrorCode'],
				data['ThrottleSeconds'],
				data['ErrorStatus'],
				data['Message'],
				data['MessageData'],
				data['DetailedErrorTrace'],
		);
	}

	static List<PostSearchResponseResponse> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<PostSearchResponseResponse> list = new List();
    data.forEach((item) {
      list.add(PostSearchResponseResponse.fromMap(item));
    });
    return list;
	}
}