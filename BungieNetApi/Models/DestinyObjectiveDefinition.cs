using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
	/// <summary>
	/// Defines an "Objective".
	/// </summary>
	/// <summary>
	/// An objective is a specific task you should accomplish in the game. These are referred to by:
	/// </summary>
	/// <summary>
	/// - Quest Steps (which are DestinyInventoryItemDefinition entities with Objectives)
	/// </summary>
	/// <summary>
	/// - Challenges (which are Objectives defined on an DestinyActivityDefintion)
	/// </summary>
	/// <summary>
	/// - Milestones (which refer to Objectives that are defined on both Quest Steps and Activities)
	/// </summary>
	/// <summary>
	/// - Anything else that the designers decide to do later.
	/// </summary>
	/// <summary>
	/// Objectives have progress, a notion of having been Completed, human readable data describing the task to be accomplished, and a lot of optional tack-on data that can enhance the information provided about the task.
	/// </summary>
	[DataContract]
	public class DestinyObjectiveDefinition{

		/// <summary>
		/// Ideally, this should tell you what your task is. I'm not going to lie to you though. Sometimes this doesn't have useful information at all. Which sucks, but there's nothing either of us can do about it.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// The value that the unlock value defined in unlockValueHash must reach in order for the objective to be considered Completed. Used in calculating progress and completion status.
		/// </summary>
		[DataMember(Name="completionValue", EmitDefaultValue=false)]
		public long CompletionValue { get; set; }

		/// <summary>
		/// A shortcut for determining the most restrictive gating that this Objective is set to use. This includes both the dynamic determination of progress and of completion values. See the DestinyGatingScope enum's documentation for more details.
		/// </summary>
		[DataMember(Name="scope", EmitDefaultValue=false)]
		public DestinyGatingScope Scope { get; set; }

		/// <summary>
		/// OPTIONAL: a hash identifier for the location at which this objective must be accomplished, if there is a location defined. Look up the DestinyLocationDefinition for this hash for that additional location info.
		/// </summary>
		[DataMember(Name="locationHash", EmitDefaultValue=false)]
		public uint LocationHash { get; set; }

		/// <summary>
		/// If true, the value is allowed to go negative.
		/// </summary>
		[DataMember(Name="allowNegativeValue", EmitDefaultValue=false)]
		public bool AllowNegativeValue { get; set; }

		/// <summary>
		/// If true, you can effectively "un-complete" this objective if you lose progress after crossing the completion threshold. 
		/// </summary>
		/// <summary>
		/// If False, once you complete the task it will remain completed forever by locking the value.
		/// </summary>
		[DataMember(Name="allowValueChangeWhenCompleted", EmitDefaultValue=false)]
		public bool AllowValueChangeWhenCompleted { get; set; }

		/// <summary>
		/// If true, completion means having an unlock value less than or equal to the completionValue.
		/// </summary>
		/// <summary>
		/// If False, completion means having an unlock value greater than or equal to the completionValue.
		/// </summary>
		[DataMember(Name="isCountingDownward", EmitDefaultValue=false)]
		public bool IsCountingDownward { get; set; }

		/// <summary>
		/// The UI style applied to the objective. It's an enum, take a look at DestinyUnlockValueUIStyle for details of the possible styles. Use this info as you wish to customize your UI.
		/// </summary>
		[DataMember(Name="valueStyle", EmitDefaultValue=false)]
		public DestinyUnlockValueUIStyle ValueStyle { get; set; }

		/// <summary>
		/// Text to describe the progress bar.
		/// </summary>
		[DataMember(Name="progressDescription", EmitDefaultValue=false)]
		public string ProgressDescription { get; set; }

		/// <summary>
		/// If this objective enables Perks intrinsically, the conditions for that enabling are defined here.
		/// </summary>
		[DataMember(Name="perks", EmitDefaultValue=false)]
		public DestinyObjectivePerkEntryDefinition Perks { get; set; }

		/// <summary>
		/// If this objective enables modifications on a player's stats intrinsically, the conditions are defined here.
		/// </summary>
		[DataMember(Name="stats", EmitDefaultValue=false)]
		public DestinyObjectiveStatEntryDefinition Stats { get; set; }

		/// <summary>
		/// If nonzero, this is the minimum value at which the objective's progression should be shown. Otherwise, don't show it yet.
		/// </summary>
		[DataMember(Name="minimumVisibilityThreshold", EmitDefaultValue=false)]
		public long MinimumVisibilityThreshold { get; set; }

		/// <summary>
		/// If True, the progress will continue even beyond the point where the objective met its minimum completion requirements. Your UI will have to accommodate it.
		/// </summary>
		[DataMember(Name="allowOvercompletion", EmitDefaultValue=false)]
		public bool AllowOvercompletion { get; set; }

		/// <summary>
		/// If True, you should continue showing the progression value in the UI after it's complete. I mean, we already do that in BNet anyways, but if you want to be better behaved than us you could honor this flag.
		/// </summary>
		[DataMember(Name="showValueOnComplete", EmitDefaultValue=false)]
		public bool ShowValueOnComplete { get; set; }

		/// <summary>
		/// The style to use when the objective is completed.
		/// </summary>
		[DataMember(Name="completedValueStyle", EmitDefaultValue=false)]
		public DestinyUnlockValueUIStyle CompletedValueStyle { get; set; }

		/// <summary>
		/// The style to use when the objective is still in progress.
		/// </summary>
		[DataMember(Name="inProgressValueStyle", EmitDefaultValue=false)]
		public DestinyUnlockValueUIStyle InProgressValueStyle { get; set; }

		/// <summary>
		/// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
		/// </summary>
		/// <summary>
		/// When entities refer to each other in Destiny content, it is this hash that they are referring to.
		/// </summary>
		[DataMember(Name="hash", EmitDefaultValue=false)]
		public uint Hash { get; set; }

		/// <summary>
		/// The index of the entity as it was found in the investment tables.
		/// </summary>
		[DataMember(Name="index", EmitDefaultValue=false)]
		public long Index { get; set; }

		/// <summary>
		/// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
		/// </summary>
		[DataMember(Name="redacted", EmitDefaultValue=false)]
		public bool Redacted { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyObjectiveDefinition);
        }

		public bool Equals(DestinyObjectiveDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    CompletionValue == input.CompletionValue ||
                    (CompletionValue != null && CompletionValue.Equals(input.CompletionValue))
                ) &&
				(
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) &&
				(
                    LocationHash == input.LocationHash ||
                    (LocationHash != null && LocationHash.Equals(input.LocationHash))
                ) &&
				(
                    AllowNegativeValue == input.AllowNegativeValue ||
                    (AllowNegativeValue != null && AllowNegativeValue.Equals(input.AllowNegativeValue))
                ) &&
				(
                    AllowValueChangeWhenCompleted == input.AllowValueChangeWhenCompleted ||
                    (AllowValueChangeWhenCompleted != null && AllowValueChangeWhenCompleted.Equals(input.AllowValueChangeWhenCompleted))
                ) &&
				(
                    IsCountingDownward == input.IsCountingDownward ||
                    (IsCountingDownward != null && IsCountingDownward.Equals(input.IsCountingDownward))
                ) &&
				(
                    ValueStyle == input.ValueStyle ||
                    (ValueStyle != null && ValueStyle.Equals(input.ValueStyle))
                ) &&
				(
                    ProgressDescription == input.ProgressDescription ||
                    (ProgressDescription != null && ProgressDescription.Equals(input.ProgressDescription))
                ) &&
				(
                    Perks == input.Perks ||
                    (Perks != null && Perks.Equals(input.Perks))
                ) &&
				(
                    Stats == input.Stats ||
                    (Stats != null && Stats.Equals(input.Stats))
                ) &&
				(
                    MinimumVisibilityThreshold == input.MinimumVisibilityThreshold ||
                    (MinimumVisibilityThreshold != null && MinimumVisibilityThreshold.Equals(input.MinimumVisibilityThreshold))
                ) &&
				(
                    AllowOvercompletion == input.AllowOvercompletion ||
                    (AllowOvercompletion != null && AllowOvercompletion.Equals(input.AllowOvercompletion))
                ) &&
				(
                    ShowValueOnComplete == input.ShowValueOnComplete ||
                    (ShowValueOnComplete != null && ShowValueOnComplete.Equals(input.ShowValueOnComplete))
                ) &&
				(
                    CompletedValueStyle == input.CompletedValueStyle ||
                    (CompletedValueStyle != null && CompletedValueStyle.Equals(input.CompletedValueStyle))
                ) &&
				(
                    InProgressValueStyle == input.InProgressValueStyle ||
                    (InProgressValueStyle != null && InProgressValueStyle.Equals(input.InProgressValueStyle))
                ) &&
				(
                    Hash == input.Hash ||
                    (Hash != null && Hash.Equals(input.Hash))
                ) &&
				(
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
				(
                    Redacted == input.Redacted ||
                    (Redacted != null && Redacted.Equals(input.Redacted))
                ) ;
		}
	}
}

