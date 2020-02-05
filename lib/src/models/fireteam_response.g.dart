// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'fireteam_response.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

FireteamResponse _$FireteamResponseFromJson(Map<String, dynamic> json) {
  return FireteamResponse()
    ..summary = json['Summary'] == null
        ? null
        : FireteamSummary.fromJson(json['Summary'] as Map<String, dynamic>)
    ..members = (json['Members'] as List)
        ?.map((e) => e == null
            ? null
            : FireteamMember.fromJson(e as Map<String, dynamic>))
        ?.toList()
    ..alternates = (json['Alternates'] as List)
        ?.map((e) => e == null
            ? null
            : FireteamMember.fromJson(e as Map<String, dynamic>))
        ?.toList();
}

Map<String, dynamic> _$FireteamResponseToJson(FireteamResponse instance) =>
    <String, dynamic>{
      'Summary': instance.summary,
      'Members': instance.members,
      'Alternates': instance.alternates,
    };
