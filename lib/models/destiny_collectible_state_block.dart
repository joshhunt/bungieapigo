import 'destiny_presentation_node_requirements_block.dart';
class DestinyCollectibleStateBlock{
	int obscuredOverrideItemHash;
	DestinyPresentationNodeRequirementsBlock requirements;
	DestinyCollectibleStateBlock(
		this.obscuredOverrideItemHash,
		this.requirements,
	);

	static DestinyCollectibleStateBlock fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyCollectibleStateBlock(
				data['obscuredOverrideItemHash'],
				data['requirements'] != null ? DestinyPresentationNodeRequirementsBlock.fromMap(data['requirements']) : null,
		);
	}

	static List<DestinyCollectibleStateBlock> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyCollectibleStateBlock> list = new List();
    data.forEach((item) {
      list.add(DestinyCollectibleStateBlock.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['obscuredOverrideItemHash'] = this.obscuredOverrideItemHash;
			data['requirements'] = this.requirements.toMap();
		return data;
	}
}