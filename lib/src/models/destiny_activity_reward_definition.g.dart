// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_activity_reward_definition.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyActivityRewardDefinition _$DestinyActivityRewardDefinitionFromJson(
    Map<String, dynamic> json) {
  return DestinyActivityRewardDefinition()
    ..rewardText = json['rewardText'] as String
    ..rewardItems = (json['rewardItems'] as List)
        ?.map((e) => e == null
            ? null
            : DestinyItemQuantity.fromJson(e as Map<String, dynamic>))
        ?.toList();
}

Map<String, dynamic> _$DestinyActivityRewardDefinitionToJson(
        DestinyActivityRewardDefinition instance) =>
    <String, dynamic>{
      'rewardText': instance.rewardText,
      'rewardItems': instance.rewardItems,
    };
