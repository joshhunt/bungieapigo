// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'group_name_search_request.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

GroupNameSearchRequest _$GroupNameSearchRequestFromJson(
    Map<String, dynamic> json) {
  return GroupNameSearchRequest()
    ..groupName = json['groupName'] as String
    ..groupType = _$enumDecodeNullable(_$GroupTypeEnumMap, json['groupType'],
        unknownValue: GroupType.General);
}

Map<String, dynamic> _$GroupNameSearchRequestToJson(
        GroupNameSearchRequest instance) =>
    <String, dynamic>{
      'groupName': instance.groupName,
      'groupType': _$GroupTypeEnumMap[instance.groupType],
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

const _$GroupTypeEnumMap = {
  GroupType.General: 0,
  GroupType.Clan: 1,
};
