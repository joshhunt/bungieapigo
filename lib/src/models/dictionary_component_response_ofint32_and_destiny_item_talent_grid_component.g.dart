// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'dictionary_component_response_ofint32_and_destiny_item_talent_grid_component.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent
    _$DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentFromJson(
        Map<String, dynamic> json) {
  return DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent()
    ..data = (json['data'] as Map<String, dynamic>)?.map(
      (k, e) => MapEntry(
          k,
          e == null
              ? null
              : DestinyItemTalentGridComponent.fromJson(
                  e as Map<String, dynamic>)),
    )
    ..privacy = json['privacy'] as int;
}

Map<String, dynamic>
    _$DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponentToJson(
            DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent
                instance) =>
        <String, dynamic>{'data': instance.data, 'privacy': instance.privacy};