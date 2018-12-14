import '../models/destiny_historical_stats_account_result.dart';
class DestinyHistoricalStatsAccountResultResponse{
    DestinyHistoricalStatsAccountResult response;
    int errorCode;
    int throttleSeconds;
    String errorStatus;
    String message;
    Map<String, String> messageData;
    String detailedErrorTrace;

    DestinyHistoricalStatsAccountResultResponse(
		DestinyHistoricalStatsAccountResult this.response,
		int this.errorCode,
		int this.throttleSeconds,
		String this.errorStatus,
		String this.message,
		Map<String, String> this.messageData,
		String this.detailedErrorTrace,
	);

    static DestinyHistoricalStatsAccountResultResponse fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyHistoricalStatsAccountResultResponse(
				data['Response'] != null ? DestinyHistoricalStatsAccountResult.fromMap(data['Response']) : null,
				data['ErrorCode'],
				data['ThrottleSeconds'],
				data['ErrorStatus'],
				data['Message'],
				data['MessageData'] != null ? Map<String, String>.from(data['MessageData'].map((k, v)=>MapEntry(k, v))) : null,
				data['DetailedErrorTrace'],
		);
	}

	static List<DestinyHistoricalStatsAccountResultResponse> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyHistoricalStatsAccountResultResponse> list = new List();
    data.forEach((item) {
      list.add(DestinyHistoricalStatsAccountResultResponse.fromMap(item));
    });
    return list;
	}
}