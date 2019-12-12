// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'search_result_of_community_live_status_response.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

SearchResultOfCommunityLiveStatusResponse
    _$SearchResultOfCommunityLiveStatusResponseFromJson(
        Map<String, dynamic> json) {
  return SearchResultOfCommunityLiveStatusResponse(
      response: json['Response'] == null
          ? null
          : SearchResultOfCommunityLiveStatus.fromJson(
              json['Response'] as Map<String, dynamic>),
      errorCode: json['ErrorCode'] as int,
      throttleSeconds: json['ThrottleSeconds'] as int,
      errorStatus: json['ErrorStatus'] as String,
      message: json['Message'] as String,
      messageData: (json['MessageData'] as Map<String, dynamic>)?.map(
        (k, e) => MapEntry(k, e as String),
      ),
      detailedErrorTrace: json['DetailedErrorTrace'] as String);
}

Map<String, dynamic> _$SearchResultOfCommunityLiveStatusResponseToJson(
        SearchResultOfCommunityLiveStatusResponse instance) =>
    <String, dynamic>{
      'Response': instance.response,
      'ErrorCode': instance.errorCode,
      'ThrottleSeconds': instance.throttleSeconds,
      'ErrorStatus': instance.errorStatus,
      'Message': instance.message,
      'MessageData': instance.messageData,
      'DetailedErrorTrace': instance.detailedErrorTrace
    };