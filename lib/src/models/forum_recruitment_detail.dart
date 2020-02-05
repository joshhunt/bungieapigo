import 'package:json_annotation/json_annotation.dart';

import '../enums/forum_recruitment_intensity_label.dart';
import '../enums/forum_recruitment_tone_label.dart';
import 'general_user.dart';

part 'forum_recruitment_detail.g.dart';

@JsonSerializable()
class ForumRecruitmentDetail{
	
	ForumRecruitmentDetail();

	factory ForumRecruitmentDetail.fromJson(Map<String, dynamic> json) => _$ForumRecruitmentDetailFromJson(json);

	@JsonKey(name:'topicId')
	String topicId;
	@JsonKey(name:'microphoneRequired')
	bool microphoneRequired;
	@JsonKey(name:'intensity',unknownEnumValue:ForumRecruitmentIntensityLabel.None)
	ForumRecruitmentIntensityLabel intensity;
	@JsonKey(name:'tone',unknownEnumValue:ForumRecruitmentToneLabel.None)
	ForumRecruitmentToneLabel tone;
	@JsonKey(name:'approved')
	bool approved;
	@JsonKey(name:'conversationId')
	String conversationId;
	@JsonKey(name:'playerSlotsTotal')
	int playerSlotsTotal;
	@JsonKey(name:'playerSlotsRemaining')
	int playerSlotsRemaining;
	@JsonKey(name:'Fireteam')
	List<GeneralUser> fireteam;
	@JsonKey(name:'kickedPlayerIds')
	List<String> kickedPlayerIds;

	
	
	Map<String, dynamic> toJson() => _$ForumRecruitmentDetailToJson(this);
}