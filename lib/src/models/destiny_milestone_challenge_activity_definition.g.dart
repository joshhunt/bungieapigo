// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_milestone_challenge_activity_definition.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyMilestoneChallengeActivityDefinition
    _$DestinyMilestoneChallengeActivityDefinitionFromJson(
        Map<String, dynamic> json) {
  return DestinyMilestoneChallengeActivityDefinition()
    ..activityHash = json['activityHash'] as int
    ..challenges = (json['challenges'] as List)
        ?.map((e) => e == null
            ? null
            : DestinyMilestoneChallengeDefinition.fromJson(
                e as Map<String, dynamic>))
        ?.toList()
    ..activityGraphNodes = (json['activityGraphNodes'] as List)
        ?.map((e) => e == null
            ? null
            : DestinyMilestoneChallengeActivityGraphNodeEntry.fromJson(
                e as Map<String, dynamic>))
        ?.toList()
    ..phases = (json['phases'] as List)
        ?.map((e) => e == null
            ? null
            : DestinyMilestoneChallengeActivityPhase.fromJson(
                e as Map<String, dynamic>))
        ?.toList();
}

Map<String, dynamic> _$DestinyMilestoneChallengeActivityDefinitionToJson(
        DestinyMilestoneChallengeActivityDefinition instance) =>
    <String, dynamic>{
      'activityHash': instance.activityHash,
      'challenges': instance.challenges,
      'activityGraphNodes': instance.activityGraphNodes,
      'phases': instance.phases,
    };
