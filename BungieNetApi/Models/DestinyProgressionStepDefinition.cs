using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// This defines a single Step in a progression (which roughly equates to a level. See DestinyProgressionDefinition for caveats).
	/// </summary>
	[DataContract]
	public class DestinyProgressionStepDefinition{

		/// <summary>
		/// Very rarely, Progressions will have localized text describing the Level of the progression. This will be that localized text, if it exists. Otherwise, the standard appears to be to simply show the level numerically.
		/// </summary>
		[DataMember(Name="stepName", EmitDefaultValue=false)]
		public string StepName { get; set; }

		/// <summary>
		/// This appears to be, when you "level up", whether a visual effect will display and on what entity. See DestinyProgressionStepDisplayEffect for slightly more info.
		/// </summary>
		[DataMember(Name="displayEffectType", EmitDefaultValue=false)]
		public DestinyProgressionStepDisplayEffect DisplayEffectType { get; set; }

		/// <summary>
		/// The total amount of progression points/"experience" you will need to initially reach this step. If this is the last step and the progression is repeating indefinitely (DestinyProgressionDefinition.repeatLastStep), this will also be the progress needed to level it up further by repeating this step again.
		/// </summary>
		[DataMember(Name="progressTotal", EmitDefaultValue=false)]
		public long ProgressTotal { get; set; }

		/// <summary>
		/// A listing of items rewarded as a result of reaching this level.
		/// </summary>
		[DataMember(Name="rewardItems", EmitDefaultValue=false)]
		public List<DestinyItemQuantity> RewardItems { get; set; }

		/// <summary>
		/// If this progression step has a specific icon related to it, this is the icon to show.
		/// </summary>
		[DataMember(Name="icon", EmitDefaultValue=false)]
		public string Icon { get; set; }


		public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProgressionStepDefinition);
        }

		public bool Equals(DestinyProgressionStepDefinition input)
		{
			if (input == null) return false;

			return
				(
                    StepName == input.StepName ||
                    (StepName != null && StepName.Equals(input.StepName))
                ) &&
				(
                    DisplayEffectType == input.DisplayEffectType ||
                    (DisplayEffectType != null && DisplayEffectType.Equals(input.DisplayEffectType))
                ) &&
				(
                    ProgressTotal == input.ProgressTotal ||
                    (ProgressTotal != null && ProgressTotal.Equals(input.ProgressTotal))
                ) &&
				(
                    RewardItems == input.RewardItems ||
                    (RewardItems != null && RewardItems.Equals(input.RewardItems))
                ) &&
				(
                    Icon == input.Icon ||
                    (Icon != null && Icon.Equals(input.Icon))
                ) ;
		}
	}
}

