import 'package:json_annotation/json_annotation.dart';

import 'destiny_item_render_component.dart';
import '../enums/component_privacy_setting.dart';

part 'dictionary_component_response_ofint64_and_destiny_item_render_component.g.dart';

@JsonSerializable()
class DictionaryComponentResponseOfint64AndDestinyItemRenderComponent{
	
	DictionaryComponentResponseOfint64AndDestinyItemRenderComponent();

	factory DictionaryComponentResponseOfint64AndDestinyItemRenderComponent.fromJson(Map<String, dynamic> json) => _$DictionaryComponentResponseOfint64AndDestinyItemRenderComponentFromJson(json);

	@JsonKey(name:'data')
	Map<String, DestinyItemRenderComponent> data;
	@JsonKey(name:'privacy',unknownEnumValue:ComponentPrivacySetting.None)
	ComponentPrivacySetting privacy;

	
	
	Map<String, dynamic> toJson() => _$DictionaryComponentResponseOfint64AndDestinyItemRenderComponentToJson(this);
}