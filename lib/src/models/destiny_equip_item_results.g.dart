// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_equip_item_results.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyEquipItemResults _$DestinyEquipItemResultsFromJson(
    Map<String, dynamic> json) {
  return DestinyEquipItemResults()
    ..equipResults = (json['equipResults'] as List)
        ?.map((e) => e == null
            ? null
            : DestinyEquipItemResult.fromJson(e as Map<String, dynamic>))
        ?.toList();
}

Map<String, dynamic> _$DestinyEquipItemResultsToJson(
        DestinyEquipItemResults instance) =>
    <String, dynamic>{
      'equipResults': instance.equipResults,
    };
