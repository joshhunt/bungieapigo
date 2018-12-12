import 'user_info_card.dart';
import 'user_info_card.dart';
class GroupMember{
	int memberType;
	bool isOnline;
	String groupId;
	UserInfoCard destinyUserInfo;
	UserInfoCard bungieNetUserInfo;
	String joinDate;
	GroupMember(
		int this.memberType,
		bool this.isOnline,
		String this.groupId,
		UserInfoCard this.destinyUserInfo,
		UserInfoCard this.bungieNetUserInfo,
		String this.joinDate,
	);

	static GroupMember fromMap(Map<String, dynamic> data){
		if(data == null) {
			return null;
		};
		return new GroupMember(
				data['memberType'],
				data['isOnline'],
				data['groupId'],
				UserInfoCard.fromMap(data['destinyUserInfo']),
				UserInfoCard.fromMap(data['bungieNetUserInfo']),
				data['joinDate'],
		);
	}

	static List<GroupMember> fromList(List<dynamic> data){
		if(data == null) {
			return null;
		};
		List<GroupMember> list = new List();
    data.forEach((item) {
      list.add(GroupMember.fromMap(item));
    });
    return list;
	}

	Map<String, dynamic> toMap(){
		Map<String, dynamic> data = new Map();
			data['memberType'] = this.memberType;
			data['isOnline'] = this.isOnline;
			data['groupId'] = this.groupId;
			data['destinyUserInfo'] = this.destinyUserInfo.toMap();
			data['bungieNetUserInfo'] = this.bungieNetUserInfo.toMap();
			data['joinDate'] = this.joinDate;
		return data;
	}
}