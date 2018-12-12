import 'destiny_display_properties_definition.dart';
class DestinyClassDefinition{
	int classType;
	DestinyDisplayPropertiesDefinition displayProperties;
	Map<String, dynamic> genderedClassNames;
	int mentorVendorHash;
	int hash;
	int index;
	bool redacted;
	DestinyClassDefinition(
		int this.classType,
		DestinyDisplayPropertiesDefinition this.displayProperties,
		Map<String, dynamic> this.genderedClassNames,
		int this.mentorVendorHash,
		int this.hash,
		int this.index,
		bool this.redacted,
	);

	static DestinyClassDefinition fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyClassDefinition(
				data['classType'],
				DestinyDisplayPropertiesDefinition.fromMap(data['displayProperties']),
				data['genderedClassNames'],
				data['mentorVendorHash'],
				data['hash'],
				data['index'],
				data['redacted'],
		);
	}

	static List<DestinyClassDefinition> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyClassDefinition> list = new List();
    data.forEach((item) {
      list.add(DestinyClassDefinition.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['classType'] = this.classType;
			data['displayProperties'] = this.displayProperties.toMap();
			data['genderedClassNames'] = this.genderedClassNames;
			data['mentorVendorHash'] = this.mentorVendorHash;
			data['hash'] = this.hash;
			data['index'] = this.index;
			data['redacted'] = this.redacted;
		return data;
	}
}