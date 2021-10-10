package bungieAPI

type ForumPostCategoryEnums int

const (
	ForumPostCategoryEnumsNone           = 0
	ForumPostCategoryEnumsTextOnly       = 1
	ForumPostCategoryEnumsMedia          = 2
	ForumPostCategoryEnumsLink           = 4
	ForumPostCategoryEnumsPoll           = 8
	ForumPostCategoryEnumsQuestion       = 16
	ForumPostCategoryEnumsAnswered       = 32
	ForumPostCategoryEnumsAnnouncement   = 64
	ForumPostCategoryEnumsContentComment = 128
	ForumPostCategoryEnumsBungieOfficial = 256
	ForumPostCategoryEnumsNinjaOfficial  = 512
	ForumPostCategoryEnumsRecruitment    = 1024
)
