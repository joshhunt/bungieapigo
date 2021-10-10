package bungieAPI

type HardLinkedUserMembership struct {
	MembershipType                  BungieMembershipType `json:"membershipType"`
	MembershipId                    int64                `json:"membershipId"`
	CrossSaveOverriddenType         BungieMembershipType `json:"CrossSaveOverriddenType"`
	CrossSaveOverriddenMembershipId int64                `json:"CrossSaveOverriddenMembershipId"`
}
