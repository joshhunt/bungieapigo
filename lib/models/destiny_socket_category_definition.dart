import 'destiny_display_properties_definition.dart';
class DestinySocketCategoryDefinition{
	DestinyDisplayPropertiesDefinition displayProperties;
	int uiCategoryStyle;
	int categoryStyle;
	int hash;
	int index;
	bool redacted;
	DestinySocketCategoryDefinition(
		this.displayProperties,
		this.uiCategoryStyle,
		this.categoryStyle,
		this.hash,
		this.index,
		this.redacted,
	);

	static DestinySocketCategoryDefinition fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinySocketCategoryDefinition(
				data['displayProperties'] != null ? DestinyDisplayPropertiesDefinition.fromMap(data['displayProperties']) : null,
				data['uiCategoryStyle'],
				data['categoryStyle'],
				data['hash'],
				data['index'],
				data['redacted'],
		);
	}

	static List<DestinySocketCategoryDefinition> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinySocketCategoryDefinition> list = new List();
    data.forEach((item) {
      list.add(DestinySocketCategoryDefinition.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['displayProperties'] = this.displayProperties.toMap();
			data['uiCategoryStyle'] = this.uiCategoryStyle;
			data['categoryStyle'] = this.categoryStyle;
			data['hash'] = this.hash;
			data['index'] = this.index;
			data['redacted'] = this.redacted;
		return data;
	}
}