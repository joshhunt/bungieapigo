import 'destiny_display_properties_definition.dart';
class DestinyRewardSourceDefinition{
	DestinyDisplayPropertiesDefinition displayProperties;
	int category;
	int hash;
	int index;
	bool redacted;
	DestinyRewardSourceDefinition(
		this.displayProperties,
		this.category,
		this.hash,
		this.index,
		this.redacted,
	);

	static DestinyRewardSourceDefinition fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyRewardSourceDefinition(
				data['displayProperties'] != null ? DestinyDisplayPropertiesDefinition.fromMap(data['displayProperties']) : null,
				data['category'],
				data['hash'],
				data['index'],
				data['redacted'],
		);
	}

	static List<DestinyRewardSourceDefinition> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyRewardSourceDefinition> list = new List();
    data.forEach((item) {
      list.add(DestinyRewardSourceDefinition.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['displayProperties'] = this.displayProperties.toMap();
			data['category'] = this.category;
			data['hash'] = this.hash;
			data['index'] = this.index;
			data['redacted'] = this.redacted;
		return data;
	}
}