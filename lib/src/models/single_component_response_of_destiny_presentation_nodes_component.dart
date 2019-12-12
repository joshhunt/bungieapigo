import 'package:json_annotation/json_annotation.dart';

import 'destiny_presentation_nodes_component.dart';

part 'single_component_response_of_destiny_presentation_nodes_component.g.dart';

@JsonSerializable()
class SingleComponentResponseOfDestinyPresentationNodesComponent{
	
	SingleComponentResponseOfDestinyPresentationNodesComponent();

	factory SingleComponentResponseOfDestinyPresentationNodesComponent.fromJson(Map<String, dynamic> json) => _$SingleComponentResponseOfDestinyPresentationNodesComponentFromJson(json);

	@JsonKey(name:'data')
	DestinyPresentationNodesComponent data;
	@JsonKey(name:'privacy')
	int privacy;

	
	
	Map<String, dynamic> toJson() => _$SingleComponentResponseOfDestinyPresentationNodesComponentToJson(this);
}