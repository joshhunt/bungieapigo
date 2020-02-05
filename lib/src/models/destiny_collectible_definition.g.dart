// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_collectible_definition.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyCollectibleDefinition _$DestinyCollectibleDefinitionFromJson(
    Map<String, dynamic> json) {
  return DestinyCollectibleDefinition()
    ..displayProperties = json['displayProperties'] == null
        ? null
        : DestinyDisplayPropertiesDefinition.fromJson(
            json['displayProperties'] as Map<String, dynamic>)
    ..scope = _$enumDecodeNullable(_$DestinyScopeEnumMap, json['scope'],
        unknownValue: DestinyScope.Profile)
    ..sourceString = json['sourceString'] as String
    ..sourceHash = json['sourceHash'] as int
    ..itemHash = json['itemHash'] as int
    ..acquisitionInfo = json['acquisitionInfo'] == null
        ? null
        : DestinyCollectibleAcquisitionBlock.fromJson(
            json['acquisitionInfo'] as Map<String, dynamic>)
    ..stateInfo = json['stateInfo'] == null
        ? null
        : DestinyCollectibleStateBlock.fromJson(
            json['stateInfo'] as Map<String, dynamic>)
    ..presentationInfo = json['presentationInfo'] == null
        ? null
        : DestinyPresentationChildBlock.fromJson(
            json['presentationInfo'] as Map<String, dynamic>)
    ..hash = json['hash'] as int
    ..index = json['index'] as int
    ..redacted = json['redacted'] as bool;
}

Map<String, dynamic> _$DestinyCollectibleDefinitionToJson(
        DestinyCollectibleDefinition instance) =>
    <String, dynamic>{
      'displayProperties': instance.displayProperties,
      'scope': _$DestinyScopeEnumMap[instance.scope],
      'sourceString': instance.sourceString,
      'sourceHash': instance.sourceHash,
      'itemHash': instance.itemHash,
      'acquisitionInfo': instance.acquisitionInfo,
      'stateInfo': instance.stateInfo,
      'presentationInfo': instance.presentationInfo,
      'hash': instance.hash,
      'index': instance.index,
      'redacted': instance.redacted,
    };

T _$enumDecode<T>(
  Map<T, dynamic> enumValues,
  dynamic source, {
  T unknownValue,
}) {
  if (source == null) {
    throw ArgumentError('A value must be provided. Supported values: '
        '${enumValues.values.join(', ')}');
  }

  final value = enumValues.entries
      .singleWhere((e) => e.value == source, orElse: () => null)
      ?.key;

  if (value == null && unknownValue == null) {
    throw ArgumentError('`$source` is not one of the supported values: '
        '${enumValues.values.join(', ')}');
  }
  return value ?? unknownValue;
}

T _$enumDecodeNullable<T>(
  Map<T, dynamic> enumValues,
  dynamic source, {
  T unknownValue,
}) {
  if (source == null) {
    return null;
  }
  return _$enumDecode<T>(enumValues, source, unknownValue: unknownValue);
}

const _$DestinyScopeEnumMap = {
  DestinyScope.Profile: 0,
  DestinyScope.Character: 1,
};
