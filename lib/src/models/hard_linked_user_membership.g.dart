// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'hard_linked_user_membership.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

HardLinkedUserMembership _$HardLinkedUserMembershipFromJson(
    Map<String, dynamic> json) {
  return HardLinkedUserMembership()
    ..membershipType = _$enumDecodeNullable(
        _$BungieMembershipTypeEnumMap, json['membershipType'],
        unknownValue: BungieMembershipType.None)
    ..membershipId = json['membershipId'] as String
    ..crossSaveOverriddenType = _$enumDecodeNullable(
        _$BungieMembershipTypeEnumMap, json['CrossSaveOverriddenType'],
        unknownValue: BungieMembershipType.None)
    ..crossSaveOverriddenMembershipId =
        json['CrossSaveOverriddenMembershipId'] as String;
}

Map<String, dynamic> _$HardLinkedUserMembershipToJson(
        HardLinkedUserMembership instance) =>
    <String, dynamic>{
      'membershipType': _$BungieMembershipTypeEnumMap[instance.membershipType],
      'membershipId': instance.membershipId,
      'CrossSaveOverriddenType':
          _$BungieMembershipTypeEnumMap[instance.crossSaveOverriddenType],
      'CrossSaveOverriddenMembershipId':
          instance.crossSaveOverriddenMembershipId,
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

const _$BungieMembershipTypeEnumMap = {
  BungieMembershipType.None: 0,
  BungieMembershipType.TigerXbox: 1,
  BungieMembershipType.TigerPsn: 2,
  BungieMembershipType.TigerSteam: 3,
  BungieMembershipType.TigerBlizzard: 4,
  BungieMembershipType.TigerStadia: 5,
  BungieMembershipType.TigerDemon: 10,
  BungieMembershipType.BungieNext: 254,
  BungieMembershipType.All: -1,
};
