package bungieAPI

type OptInFlags int64

const (
	OptInFlagsNone            = 0
	OptInFlagsNewsletter      = 1
	OptInFlagsSystem          = 2
	OptInFlagsMarketing       = 4
	OptInFlagsUserResearch    = 8
	OptInFlagsCustomerService = 16
	OptInFlagsSocial          = 32
	OptInFlagsPlayTests       = 64
	OptInFlagsPlayTestsLocal  = 128
	OptInFlagsCareers         = 256
)
