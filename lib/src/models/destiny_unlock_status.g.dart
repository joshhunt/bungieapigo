// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_unlock_status.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyUnlockStatus _$DestinyUnlockStatusFromJson(Map<String, dynamic> json) {
  return DestinyUnlockStatus()
    ..unlockHash = json['unlockHash'] as int
    ..isSet = json['isSet'] as bool;
}

Map<String, dynamic> _$DestinyUnlockStatusToJson(
        DestinyUnlockStatus instance) =>
    <String, dynamic>{
      'unlockHash': instance.unlockHash,
      'isSet': instance.isSet,
    };
