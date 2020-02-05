// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'group_member.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

GroupMember _$GroupMemberFromJson(Map<String, dynamic> json) {
  return GroupMember()
    ..memberType = _$enumDecodeNullable(
        _$RuntimeGroupMemberTypeEnumMap, json['memberType'],
        unknownValue: RuntimeGroupMemberType.None)
    ..isOnline = json['isOnline'] as bool
    ..lastOnlineStatusChange = json['lastOnlineStatusChange'] as String
    ..groupId = json['groupId'] as String
    ..destinyUserInfo = json['destinyUserInfo'] == null
        ? null
        : GroupUserInfoCard.fromJson(
            json['destinyUserInfo'] as Map<String, dynamic>)
    ..bungieNetUserInfo = json['bungieNetUserInfo'] == null
        ? null
        : UserInfoCard.fromJson(
            json['bungieNetUserInfo'] as Map<String, dynamic>)
    ..joinDate = json['joinDate'] as String;
}

Map<String, dynamic> _$GroupMemberToJson(GroupMember instance) =>
    <String, dynamic>{
      'memberType': _$RuntimeGroupMemberTypeEnumMap[instance.memberType],
      'isOnline': instance.isOnline,
      'lastOnlineStatusChange': instance.lastOnlineStatusChange,
      'groupId': instance.groupId,
      'destinyUserInfo': instance.destinyUserInfo,
      'bungieNetUserInfo': instance.bungieNetUserInfo,
      'joinDate': instance.joinDate,
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

const _$RuntimeGroupMemberTypeEnumMap = {
  RuntimeGroupMemberType.None: 0,
  RuntimeGroupMemberType.Beginner: 1,
  RuntimeGroupMemberType.Member: 2,
  RuntimeGroupMemberType.Admin: 3,
  RuntimeGroupMemberType.ActingFounder: 4,
  RuntimeGroupMemberType.Founder: 5,
};
