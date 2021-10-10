package bungieAPI

// Information about a current character's status with a Progression. A progression is a value
// that can increase with activity and has levels. Think Character Level and Reputation Levels.
// Combine this "live" data with the related DestinyProgressionDefinition for a full picture of
// the Progression.
type DestinyProgression struct {

	// The hash identifier of the Progression in question. Use it to look up the
	// DestinyProgressionDefinition in static data.
	ProgressionHash int `json:"progressionHash"`

	// The amount of progress earned today for this progression.
	DailyProgress int `json:"dailyProgress"`

	// If this progression has a daily limit, this is that limit.
	DailyLimit int `json:"dailyLimit"`

	// The amount of progress earned toward this progression in the current week.
	WeeklyProgress int `json:"weeklyProgress"`

	// If this progression has a weekly limit, this is that limit.
	WeeklyLimit int `json:"weeklyLimit"`

	// This is the total amount of progress obtained overall for this progression (for instance, the
	// total amount of Character Level experience earned)
	CurrentProgress int `json:"currentProgress"`

	// This is the level of the progression (for instance, the Character Level).
	Level int `json:"level"`

	// This is the maximum possible level you can achieve for this progression (for example, the
	// maximum character level obtainable)
	LevelCap int `json:"levelCap"`

	// Progressions define their levels in "steps". Since the last step may be repeatable, the user
	// may be at a higher level than the actual Step achieved in the progression. Not necessarily
	// useful, but potentially interesting for those cruising the API. Relate this to the "steps"
	// property of the DestinyProgression to see which step the user is on, if you care about that.
	// (Note that this is Content Version dependent since it refers to indexes.)
	StepIndex int `json:"stepIndex"`

	// The amount of progression (i.e. "Experience") needed to reach the next level of this
	// Progression. Jeez, progression is such an overloaded word.
	ProgressToNextLevel int `json:"progressToNextLevel"`

	// The total amount of progression (i.e. "Experience") needed in order to reach the next level.
	NextLevelAt int `json:"nextLevelAt"`

	// The number of resets of this progression you've executed this season, if applicable to this
	// progression.
	CurrentResetCount int `json:"currentResetCount"`

	// Information about historical resets of this progression, if there is any data for it.
	SeasonResets []DestinyProgressionResetEntry `json:"seasonResets"`

	// Information about historical rewards for this progression, if there is any data for it.
	RewardItemStates []DestinyProgressionRewardItemState `json:"rewardItemStates"`
}
