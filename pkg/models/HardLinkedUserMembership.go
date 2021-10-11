package bungieapigo

type HardLinkedUserMembership struct {
	MembershipType                  BungieMembershipType `json:"membershipType"`
	MembershipId                    int64                `json:"membershipId,string"`
	CrossSaveOverriddenType         BungieMembershipType `json:"CrossSaveOverriddenType"`
	CrossSaveOverriddenMembershipId int64                `json:"CrossSaveOverriddenMembershipId,string"`
}
