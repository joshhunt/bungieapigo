// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_entity_search_result_item.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyEntitySearchResultItem _$DestinyEntitySearchResultItemFromJson(
    Map<String, dynamic> json) {
  return DestinyEntitySearchResultItem()
    ..hash = json['hash'] as int
    ..entityType = json['entityType'] as String
    ..displayProperties = json['displayProperties'] == null
        ? null
        : DestinyDisplayPropertiesDefinition.fromJson(
            json['displayProperties'] as Map<String, dynamic>)
    ..weight = json['weight'] as int;
}

Map<String, dynamic> _$DestinyEntitySearchResultItemToJson(
        DestinyEntitySearchResultItem instance) =>
    <String, dynamic>{
      'hash': instance.hash,
      'entityType': instance.entityType,
      'displayProperties': instance.displayProperties,
      'weight': instance.weight,
    };
