import 'destiny_display_properties_definition.dart';
class DestinyPlaceDefinition{
	DestinyDisplayPropertiesDefinition displayProperties;
	int hash;
	int index;
	bool redacted;
	DestinyPlaceDefinition(
		this.displayProperties,
		this.hash,
		this.index,
		this.redacted,
	);

	static DestinyPlaceDefinition fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyPlaceDefinition(
				data['displayProperties'] != null ? DestinyDisplayPropertiesDefinition.fromMap(data['displayProperties']) : null,
				data['hash'],
				data['index'],
				data['redacted'],
		);
	}

	static List<DestinyPlaceDefinition> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyPlaceDefinition> list = new List();
    data.forEach((item) {
      list.add(DestinyPlaceDefinition.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['displayProperties'] = this.displayProperties.toMap();
			data['hash'] = this.hash;
			data['index'] = this.index;
			data['redacted'] = this.redacted;
		return data;
	}
}