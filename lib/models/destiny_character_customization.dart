class DestinyCharacterCustomization{
	int personality;
	int face;
	int skinColor;
	int lipColor;
	int eyeColor;
	List<int> hairColors;
	List<int> featureColors;
	int decalColor;
	bool wearHelmet;
	int hairIndex;
	int featureIndex;
	int decalIndex;
	DestinyCharacterCustomization(
		int this.personality,
		int this.face,
		int this.skinColor,
		int this.lipColor,
		int this.eyeColor,
		List<int> this.hairColors,
		List<int> this.featureColors,
		int this.decalColor,
		bool this.wearHelmet,
		int this.hairIndex,
		int this.featureIndex,
		int this.decalIndex,
	);

	static DestinyCharacterCustomization fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyCharacterCustomization(
				data['personality'],
				data['face'],
				data['skinColor'],
				data['lipColor'],
				data['eyeColor'],
				data['hairColors'],
				data['featureColors'],
				data['decalColor'],
				data['wearHelmet'],
				data['hairIndex'],
				data['featureIndex'],
				data['decalIndex'],
		);
	}

	static List<DestinyCharacterCustomization> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyCharacterCustomization> list = new List();
    data.forEach((item) {
      list.add(DestinyCharacterCustomization.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['personality'] = this.personality;
			data['face'] = this.face;
			data['skinColor'] = this.skinColor;
			data['lipColor'] = this.lipColor;
			data['eyeColor'] = this.eyeColor;
			data['hairColors'] = this.hairColors;
			data['featureColors'] = this.featureColors;
			data['decalColor'] = this.decalColor;
			data['wearHelmet'] = this.wearHelmet;
			data['hairIndex'] = this.hairIndex;
			data['featureIndex'] = this.featureIndex;
			data['decalIndex'] = this.decalIndex;
		return data;
	}
}