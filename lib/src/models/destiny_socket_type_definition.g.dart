// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'destiny_socket_type_definition.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

DestinySocketTypeDefinition _$DestinySocketTypeDefinitionFromJson(
    Map<String, dynamic> json) {
  return DestinySocketTypeDefinition()
    ..displayProperties = json['displayProperties'] == null
        ? null
        : DestinyDisplayPropertiesDefinition.fromJson(
            json['displayProperties'] as Map<String, dynamic>)
    ..insertAction = json['insertAction'] == null
        ? null
        : DestinyInsertPlugActionDefinition.fromJson(
            json['insertAction'] as Map<String, dynamic>)
    ..plugWhitelist = (json['plugWhitelist'] as List)
        ?.map((e) => e == null
            ? null
            : DestinyPlugWhitelistEntryDefinition.fromJson(
                e as Map<String, dynamic>))
        ?.toList()
    ..socketCategoryHash = json['socketCategoryHash'] as int
    ..visibility = json['visibility'] as int
    ..alwaysRandomizeSockets = json['alwaysRandomizeSockets'] as bool
    ..isPreviewEnabled = json['isPreviewEnabled'] as bool
    ..hideDuplicateReusablePlugs = json['hideDuplicateReusablePlugs'] as bool
    ..overridesUiAppearance = json['overridesUiAppearance'] as bool
    ..avoidDuplicatesOnInitialization =
        json['avoidDuplicatesOnInitialization'] as bool
    ..currencyScalars = (json['currencyScalars'] as List)
        ?.map((e) => e == null
            ? null
            : DestinySocketTypeScalarMaterialRequirementEntry.fromJson(
                e as Map<String, dynamic>))
        ?.toList()
    ..hash = json['hash'] as int
    ..index = json['index'] as int
    ..redacted = json['redacted'] as bool;
}

Map<String, dynamic> _$DestinySocketTypeDefinitionToJson(
        DestinySocketTypeDefinition instance) =>
    <String, dynamic>{
      'displayProperties': instance.displayProperties,
      'insertAction': instance.insertAction,
      'plugWhitelist': instance.plugWhitelist,
      'socketCategoryHash': instance.socketCategoryHash,
      'visibility': instance.visibility,
      'alwaysRandomizeSockets': instance.alwaysRandomizeSockets,
      'isPreviewEnabled': instance.isPreviewEnabled,
      'hideDuplicateReusablePlugs': instance.hideDuplicateReusablePlugs,
      'overridesUiAppearance': instance.overridesUiAppearance,
      'avoidDuplicatesOnInitialization':
          instance.avoidDuplicatesOnInitialization,
      'currencyScalars': instance.currencyScalars,
      'hash': instance.hash,
      'index': instance.index,
      'redacted': instance.redacted
    };