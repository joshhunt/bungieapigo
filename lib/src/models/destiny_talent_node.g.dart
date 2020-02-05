// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_talent_node.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinyTalentNode _$DestinyTalentNodeFromJson(Map<String, dynamic> json) {
  return DestinyTalentNode()
    ..nodeIndex = json['nodeIndex'] as int
    ..nodeHash = json['nodeHash'] as int
    ..state = _$enumDecodeNullable(
        _$DestinyTalentNodeStateEnumMap, json['state'],
        unknownValue: DestinyTalentNodeState.Invalid)
    ..isActivated = json['isActivated'] as bool
    ..stepIndex = json['stepIndex'] as int
    ..materialsToUpgrade = (json['materialsToUpgrade'] as List)
        ?.map((e) => e == null
            ? null
            : DestinyMaterialRequirement.fromJson(e as Map<String, dynamic>))
        ?.toList()
    ..activationGridLevel = json['activationGridLevel'] as int
    ..progressPercent = (json['progressPercent'] as num)?.toDouble()
    ..hidden = json['hidden'] as bool
    ..nodeStatsBlock = json['nodeStatsBlock'] == null
        ? null
        : DestinyTalentNodeStatBlock.fromJson(
            json['nodeStatsBlock'] as Map<String, dynamic>);
}

Map<String, dynamic> _$DestinyTalentNodeToJson(DestinyTalentNode instance) =>
    <String, dynamic>{
      'nodeIndex': instance.nodeIndex,
      'nodeHash': instance.nodeHash,
      'state': _$DestinyTalentNodeStateEnumMap[instance.state],
      'isActivated': instance.isActivated,
      'stepIndex': instance.stepIndex,
      'materialsToUpgrade': instance.materialsToUpgrade,
      'activationGridLevel': instance.activationGridLevel,
      'progressPercent': instance.progressPercent,
      'hidden': instance.hidden,
      'nodeStatsBlock': instance.nodeStatsBlock,
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

const _$DestinyTalentNodeStateEnumMap = {
  DestinyTalentNodeState.Invalid: 0,
  DestinyTalentNodeState.CanUpgrade: 1,
  DestinyTalentNodeState.NoPoints: 2,
  DestinyTalentNodeState.NoPrerequisites: 3,
  DestinyTalentNodeState.NoSteps: 4,
  DestinyTalentNodeState.NoUnlock: 5,
  DestinyTalentNodeState.NoMaterial: 6,
  DestinyTalentNodeState.NoGridLevel: 7,
  DestinyTalentNodeState.SwappingLocked: 8,
  DestinyTalentNodeState.MustSwap: 9,
  DestinyTalentNodeState.Complete: 10,
  DestinyTalentNodeState.Unknown: 11,
  DestinyTalentNodeState.CreationOnly: 12,
  DestinyTalentNodeState.Hidden: 13,
};
