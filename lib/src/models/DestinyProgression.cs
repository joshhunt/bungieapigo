using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// Information about a current character&#39;s status with a Progression. A progression is a value that can increase with activity and has levels. Think Character Level and Reputation Levels. Combine this &quot;live&quot; data with the related DestinyProgressionDefinition for a full picture of the Progression.
	[DataContract]
	public class DestinyProgression{

		/// <summary>
		/// The hash identifier of the Progression in question. Use it to look up the DestinyProgressionDefinition in static data.
		/// </summary>
		[DataMember(Name="progressionHash", EmitDefaultValue=false)]
		public uint ProgressionHash { get; set; }

		/// <summary>
		/// The amount of progress earned today for this progression.
		/// </summary>
		[DataMember(Name="dailyProgress", EmitDefaultValue=false)]
		public long DailyProgress { get; set; }

		/// <summary>
		/// If this progression has a daily limit, this is that limit.
		/// </summary>
		[DataMember(Name="dailyLimit", EmitDefaultValue=false)]
		public long DailyLimit { get; set; }

		/// <summary>
		/// The amount of progress earned toward this progression in the current week.
		/// </summary>
		[DataMember(Name="weeklyProgress", EmitDefaultValue=false)]
		public long WeeklyProgress { get; set; }

		/// <summary>
		/// If this progression has a weekly limit, this is that limit.
		/// </summary>
		[DataMember(Name="weeklyLimit", EmitDefaultValue=false)]
		public long WeeklyLimit { get; set; }

		/// <summary>
		/// This is the total amount of progress obtained overall for this progression (for instance, the total amount of Character Level experience earned)
		/// </summary>
		[DataMember(Name="currentProgress", EmitDefaultValue=false)]
		public long CurrentProgress { get; set; }

		/// <summary>
		/// This is the level of the progression (for instance, the Character Level).
		/// </summary>
		[DataMember(Name="level", EmitDefaultValue=false)]
		public long Level { get; set; }

		/// <summary>
		/// This is the maximum possible level you can achieve for this progression (for example, the maximum character level obtainable)
		/// </summary>
		[DataMember(Name="levelCap", EmitDefaultValue=false)]
		public long LevelCap { get; set; }

		/// <summary>
		/// Progressions define their levels in "steps". Since the last step may be repeatable, the user may be at a higher level than the actual Step achieved in the progression. Not necessarily useful, but potentially interesting for those cruising the API. Relate this to the "steps" property of the DestinyProgression to see which step the user is on, if you care about that. (Note that this is Content Version dependent since it refers to indexes.)
		/// </summary>
		[DataMember(Name="stepIndex", EmitDefaultValue=false)]
		public long StepIndex { get; set; }

		/// <summary>
		/// The amount of progression (i.e. "Experience") needed to reach the next level of this Progression. Jeez, progression is such an overloaded word.
		/// </summary>
		[DataMember(Name="progressToNextLevel", EmitDefaultValue=false)]
		public long ProgressToNextLevel { get; set; }

		/// <summary>
		/// The total amount of progression (i.e. "Experience") needed in order to reach the next level.
		/// </summary>
		[DataMember(Name="nextLevelAt", EmitDefaultValue=false)]
		public long NextLevelAt { get; set; }

		/// <summary>
		/// The number of resets of this progression you've executed this season, if applicable to this progression.
		/// </summary>
		[DataMember(Name="currentResetCount", EmitDefaultValue=false)]
		public long CurrentResetCount { get; set; }

		/// <summary>
		/// Information about historical resets of this progression, if there is any data for it.
		/// </summary>
		[DataMember(Name="seasonResets", EmitDefaultValue=false)]
		public List<DestinyProgressionResetEntry> SeasonResets { get; set; }

		/// <summary>
		/// Information about historical rewards for this progression, if there is any data for it.
		/// </summary>
		[DataMember(Name="rewardItemStates", EmitDefaultValue=false)]
		public List<DestinyProgressionRewardItemState> RewardItemStates { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProgression);
        }

		public bool Equals(DestinyProgression input)
		{
			if (input == null) return false;

			return
				(
                    ProgressionHash == input.ProgressionHash ||
                    (ProgressionHash != null && ProgressionHash.Equals(input.ProgressionHash))
                ) &&
				(
                    DailyProgress == input.DailyProgress ||
                    (DailyProgress != null && DailyProgress.Equals(input.DailyProgress))
                ) &&
				(
                    DailyLimit == input.DailyLimit ||
                    (DailyLimit != null && DailyLimit.Equals(input.DailyLimit))
                ) &&
				(
                    WeeklyProgress == input.WeeklyProgress ||
                    (WeeklyProgress != null && WeeklyProgress.Equals(input.WeeklyProgress))
                ) &&
				(
                    WeeklyLimit == input.WeeklyLimit ||
                    (WeeklyLimit != null && WeeklyLimit.Equals(input.WeeklyLimit))
                ) &&
				(
                    CurrentProgress == input.CurrentProgress ||
                    (CurrentProgress != null && CurrentProgress.Equals(input.CurrentProgress))
                ) &&
				(
                    Level == input.Level ||
                    (Level != null && Level.Equals(input.Level))
                ) &&
				(
                    LevelCap == input.LevelCap ||
                    (LevelCap != null && LevelCap.Equals(input.LevelCap))
                ) &&
				(
                    StepIndex == input.StepIndex ||
                    (StepIndex != null && StepIndex.Equals(input.StepIndex))
                ) &&
				(
                    ProgressToNextLevel == input.ProgressToNextLevel ||
                    (ProgressToNextLevel != null && ProgressToNextLevel.Equals(input.ProgressToNextLevel))
                ) &&
				(
                    NextLevelAt == input.NextLevelAt ||
                    (NextLevelAt != null && NextLevelAt.Equals(input.NextLevelAt))
                ) &&
				(
                    CurrentResetCount == input.CurrentResetCount ||
                    (CurrentResetCount != null && CurrentResetCount.Equals(input.CurrentResetCount))
                ) &&
				(
                    SeasonResets == input.SeasonResets ||
                    (SeasonResets != null && SeasonResets.Equals(input.SeasonResets))
                ) &&
				(
                    RewardItemStates == input.RewardItemStates ||
                    (RewardItemStates != null && RewardItemStates.Equals(input.RewardItemStates))
                ) ;
		}

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.ProgressionHash.GetHashCode();
				hashCode = hashCode * 59 + this.DailyProgress.GetHashCode();
				hashCode = hashCode * 59 + this.DailyLimit.GetHashCode();
				hashCode = hashCode * 59 + this.WeeklyProgress.GetHashCode();
				hashCode = hashCode * 59 + this.WeeklyLimit.GetHashCode();
				hashCode = hashCode * 59 + this.CurrentProgress.GetHashCode();
				hashCode = hashCode * 59 + this.Level.GetHashCode();
				hashCode = hashCode * 59 + this.LevelCap.GetHashCode();
				hashCode = hashCode * 59 + this.StepIndex.GetHashCode();
				hashCode = hashCode * 59 + this.ProgressToNextLevel.GetHashCode();
				hashCode = hashCode * 59 + this.NextLevelAt.GetHashCode();
				hashCode = hashCode * 59 + this.CurrentResetCount.GetHashCode();
				hashCode = hashCode * 59 + this.SeasonResets.GetHashCode();
				hashCode = hashCode * 59 + this.RewardItemStates.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

