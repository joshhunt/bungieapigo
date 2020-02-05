import 'package:json_annotation/json_annotation.dart';

import 'destiny_item_instance_component.dart';
import '../enums/component_privacy_setting.dart';

part 'dictionary_component_response_ofint64_and_destiny_item_instance_component.g.dart';

@JsonSerializable()
class DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent{
	
	DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent();

	factory DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent.fromJson(Map<String, dynamic> json) => _$DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentFromJson(json);

	@JsonKey(name:'data')
	Map<String, DestinyItemInstanceComponent> data;
	@JsonKey(name:'privacy',unknownEnumValue:ComponentPrivacySetting.None)
	ComponentPrivacySetting privacy;

	
	
	Map<String, dynamic> toJson() => _$DictionaryComponentResponseOfint64AndDestinyItemInstanceComponentToJson(this);
}