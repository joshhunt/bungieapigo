// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_item_action_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyItemActionRequest _$DestinyItemActionRequestFromJson(
    Map<String, dynamic> json) {
  return DestinyItemActionRequest()
    ..itemId = json['itemId'] as String
    ..characterId = json['characterId'] as String
    ..membershipType = json['membershipType'] as int;
}

Map<String, dynamic> _$DestinyItemActionRequestToJson(
        DestinyItemActionRequest instance) =>
    <String, dynamic>{
      'itemId': instance.itemId,
      'characterId': instance.characterId,
      'membershipType': instance.membershipType
    };