package bungieAPI

type ForumFlagsEnum int

const (
	ForumFlagsEnumNone                       = 0
	ForumFlagsEnumBungieStaffPost            = 1
	ForumFlagsEnumForumNinjaPost             = 2
	ForumFlagsEnumForumMentorPost            = 4
	ForumFlagsEnumTopicBungieStaffPosted     = 8
	ForumFlagsEnumTopicBungieVolunteerPosted = 16
	ForumFlagsEnumQuestionAnsweredByBungie   = 32
	ForumFlagsEnumQuestionAnsweredByNinja    = 64
	ForumFlagsEnumCommunityContent           = 128
)
