import 'package:json_annotation/json_annotation.dart';

import '../enums/capabilities.dart';
import '../enums/bungie_membership_type.dart';
import '../enums/host_guided_games_permission_level.dart';
import '../enums/runtime_group_member_type.dart';

part 'group_features.g.dart';

@JsonSerializable()
class GroupFeatures{
	
	GroupFeatures();

	factory GroupFeatures.fromJson(Map<String, dynamic> json) => _$GroupFeaturesFromJson(json);

	@JsonKey(name:'maximumMembers')
	int maximumMembers;
	/// Maximum number of groups of this type a typical membership may join. For example, a user may join about 50 General groups with their Bungie.net account. They may join one clan per Destiny membership.
	@JsonKey(name:'maximumMembershipsOfGroupType')
	int maximumMembershipsOfGroupType;
	@JsonKey(name:'capabilities')
	Capabilities capabilities;
	@JsonKey(name:'membershipTypes')
	List<BungieMembershipType> membershipTypes;
	/// Minimum Member Level allowed to invite new members to group
	/// Always Allowed: Founder, Acting Founder
	/// True means admins have this power, false means they don't
	/// Default is false for clans, true for groups.
	@JsonKey(name:'invitePermissionOverride')
	bool invitePermissionOverride;
	/// Minimum Member Level allowed to update group culture
	/// Always Allowed: Founder, Acting Founder
	/// True means admins have this power, false means they don't
	/// Default is false for clans, true for groups.
	@JsonKey(name:'updateCulturePermissionOverride')
	bool updateCulturePermissionOverride;
	/// Minimum Member Level allowed to host guided games
	/// Always Allowed: Founder, Acting Founder, Admin
	/// Allowed Overrides: None, Member, Beginner
	/// Default is Member for clans, None for groups, although this means nothing for groups.
	@JsonKey(name:'hostGuidedGamePermissionOverride',unknownEnumValue:HostGuidedGamesPermissionLevel.None)
	HostGuidedGamesPermissionLevel hostGuidedGamePermissionOverride;
	/// Minimum Member Level allowed to update banner
	/// Always Allowed: Founder, Acting Founder
	/// True means admins have this power, false means they don't
	/// Default is false for clans, true for groups.
	@JsonKey(name:'updateBannerPermissionOverride')
	bool updateBannerPermissionOverride;
	/// Level to join a member at when accepting an invite, application, or joining an open clan
	/// Default is Beginner.
	@JsonKey(name:'joinLevel',unknownEnumValue:RuntimeGroupMemberType.None)
	RuntimeGroupMemberType joinLevel;

	
	
	Map<String, dynamic> toJson() => _$GroupFeaturesToJson(this);
}