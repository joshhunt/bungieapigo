import 'destiny_objective_progress.dart';
class DestinyKioskItem{
	int index;
	bool canAcquire;
	List<int> failureIndexes;
	DestinyObjectiveProgress flavorObjective;
	DestinyKioskItem(
		this.index,
		this.canAcquire,
		this.failureIndexes,
		this.flavorObjective,
	);

	static DestinyKioskItem fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new DestinyKioskItem(
				data['index'],
				data['canAcquire'],
				data['failureIndexes'] != null ? data['failureIndexes']?.cast<int>() ?? null : null,
				data['flavorObjective'] != null ? DestinyObjectiveProgress.fromMap(data['flavorObjective']) : null,
		);
	}

	static List<DestinyKioskItem> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<DestinyKioskItem> list = new List();
    data.forEach((item) {
      list.add(DestinyKioskItem.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['index'] = this.index;
			data['canAcquire'] = this.canAcquire;
			data['failureIndexes'] = this.failureIndexes;
			data['flavorObjective'] = this.flavorObjective;
		return data;
	}
}