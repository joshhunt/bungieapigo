import 'destiny_public_activity_status.dart';
class TrendingEntryDestinyActivity{
	int activityHash;
	DestinyPublicActivityStatus status;
	TrendingEntryDestinyActivity(
		this.activityHash,
		this.status,
	);

	static TrendingEntryDestinyActivity fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new TrendingEntryDestinyActivity(
				data['activityHash'],
				data['status'] != null ? DestinyPublicActivityStatus.fromMap(data['status']) : null,
		);
	}

	static List<TrendingEntryDestinyActivity> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<TrendingEntryDestinyActivity> list = new List();
    data.forEach((item) {
      list.add(TrendingEntryDestinyActivity.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['activityHash'] = this.activityHash;
			data['status'] = this.status.toMap();
		return data;
	}
}