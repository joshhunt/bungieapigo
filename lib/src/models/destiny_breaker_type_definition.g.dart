// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_breaker_type_definition.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyBreakerTypeDefinition _$DestinyBreakerTypeDefinitionFromJson(
    Map<String, dynamic> json) {
  return DestinyBreakerTypeDefinition()
    ..displayProperties = json['displayProperties'] == null
        ? null
        : DestinyDisplayPropertiesDefinition.fromJson(
            json['displayProperties'] as Map<String, dynamic>)
    ..enumValue = _$enumDecodeNullable(
        _$DestinyBreakerTypeEnumMap, json['enumValue'],
        unknownValue: DestinyBreakerType.None)
    ..hash = json['hash'] as int
    ..index = json['index'] as int
    ..redacted = json['redacted'] as bool;
}

Map<String, dynamic> _$DestinyBreakerTypeDefinitionToJson(
        DestinyBreakerTypeDefinition instance) =>
    <String, dynamic>{
      'displayProperties': instance.displayProperties,
      'enumValue': _$DestinyBreakerTypeEnumMap[instance.enumValue],
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

const _$DestinyBreakerTypeEnumMap = {
  DestinyBreakerType.None: 0,
  DestinyBreakerType.ShieldPiercing: 1,
  DestinyBreakerType.Disruption: 2,
  DestinyBreakerType.Stagger: 3,
};
