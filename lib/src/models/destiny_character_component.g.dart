// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_character_component.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyCharacterComponent _$DestinyCharacterComponentFromJson(
    Map<String, dynamic> json) {
  return DestinyCharacterComponent()
    ..membershipId = json['membershipId'] as String
    ..membershipType = _$enumDecodeNullable(
        _$BungieMembershipTypeEnumMap, json['membershipType'],
        unknownValue: BungieMembershipType.None)
    ..characterId = json['characterId'] as String
    ..dateLastPlayed = json['dateLastPlayed'] as String
    ..minutesPlayedThisSession = json['minutesPlayedThisSession'] as String
    ..minutesPlayedTotal = json['minutesPlayedTotal'] as String
    ..light = json['light'] as int
    ..stats = (json['stats'] as Map<String, dynamic>)?.map(
      (k, e) => MapEntry(k, e as int),
    )
    ..raceHash = json['raceHash'] as int
    ..genderHash = json['genderHash'] as int
    ..classHash = json['classHash'] as int
    ..raceType = _$enumDecodeNullable(_$DestinyRaceEnumMap, json['raceType'],
        unknownValue: DestinyRace.Human)
    ..classType = _$enumDecodeNullable(_$DestinyClassEnumMap, json['classType'],
        unknownValue: DestinyClass.Titan)
    ..genderType = _$enumDecodeNullable(
        _$DestinyGenderEnumMap, json['genderType'],
        unknownValue: DestinyGender.Male)
    ..emblemPath = json['emblemPath'] as String
    ..emblemBackgroundPath = json['emblemBackgroundPath'] as String
    ..emblemHash = json['emblemHash'] as int
    ..emblemColor = json['emblemColor'] == null
        ? null
        : DestinyColor.fromJson(json['emblemColor'] as Map<String, dynamic>)
    ..levelProgression = json['levelProgression'] == null
        ? null
        : DestinyProgression.fromJson(
            json['levelProgression'] as Map<String, dynamic>)
    ..baseCharacterLevel = json['baseCharacterLevel'] as int
    ..percentToNextLevel = (json['percentToNextLevel'] as num)?.toDouble()
    ..titleRecordHash = json['titleRecordHash'] as int;
}

Map<String, dynamic> _$DestinyCharacterComponentToJson(
        DestinyCharacterComponent instance) =>
    <String, dynamic>{
      'membershipId': instance.membershipId,
      'membershipType': _$BungieMembershipTypeEnumMap[instance.membershipType],
      'characterId': instance.characterId,
      'dateLastPlayed': instance.dateLastPlayed,
      'minutesPlayedThisSession': instance.minutesPlayedThisSession,
      'minutesPlayedTotal': instance.minutesPlayedTotal,
      'light': instance.light,
      'stats': instance.stats,
      'raceHash': instance.raceHash,
      'genderHash': instance.genderHash,
      'classHash': instance.classHash,
      'raceType': _$DestinyRaceEnumMap[instance.raceType],
      'classType': _$DestinyClassEnumMap[instance.classType],
      'genderType': _$DestinyGenderEnumMap[instance.genderType],
      'emblemPath': instance.emblemPath,
      'emblemBackgroundPath': instance.emblemBackgroundPath,
      'emblemHash': instance.emblemHash,
      'emblemColor': instance.emblemColor,
      'levelProgression': instance.levelProgression,
      'baseCharacterLevel': instance.baseCharacterLevel,
      'percentToNextLevel': instance.percentToNextLevel,
      'titleRecordHash': instance.titleRecordHash,
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

const _$DestinyRaceEnumMap = {
  DestinyRace.Human: 0,
  DestinyRace.Awoken: 1,
  DestinyRace.Exo: 2,
  DestinyRace.Unknown: 3,
};

const _$DestinyClassEnumMap = {
  DestinyClass.Titan: 0,
  DestinyClass.Hunter: 1,
  DestinyClass.Warlock: 2,
  DestinyClass.Unknown: 3,
};

const _$DestinyGenderEnumMap = {
  DestinyGender.Male: 0,
  DestinyGender.Female: 1,
  DestinyGender.Unknown: 2,
};
