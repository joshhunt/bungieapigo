using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// A &quot;Progression&quot; in Destiny is best explained by an example.
	/// A Character&#39;s &quot;Level&quot; is a progression: it has Experience that can be earned, levels that can be gained, and is evaluated and displayed at various points in the game. A Character&#39;s &quot;Faction Reputation&quot; is also a progression for much the same reason.
	/// Progression is used by a variety of systems, and the definition of a Progression will generally only be useful if combining with live data (such as a character&#39;s DestinyCharacterProgressionComponent.progressions property, which holds that character&#39;s live Progression states).
	/// Fundamentally, a Progression measures your &quot;Level&quot; by evaluating the thresholds in its Steps (one step per level, except for the last step which can be repeated indefinitely for &quot;Levels&quot; that have no ceiling) against the total earned &quot;progression points&quot;&#x2F;experience. (for simplicity purposes, we will henceforth refer to earned progression points as experience, though it need not be a mechanic that in any way resembles Experience in a traditional sense).
	/// Earned experience is calculated in a variety of ways, determined by the Progression&#39;s scope. These go from looking up a stored value to performing exceedingly obtuse calculations. This is why we provide live data in DestinyCharacterProgressionComponent.progressions, so you don&#39;t have to worry about those.
	[DataContract]
	public class DestinyProgressionDefinition{

		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyProgressionDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// The "Scope" of the progression indicates the source of the progression's live data.
		/// </summary>
		/// <summary>
		/// See the DestinyProgressionScope enum for more info: but essentially, a Progression can either be backed by a stored value, or it can be a calculated derivative of other values.
		/// </summary>
		[DataMember(Name="scope", EmitDefaultValue=false)]
		public DestinyProgressionScope Scope { get; set; }

		/// <summary>
		/// If this is True, then the progression doesn't have a maximum level.
		/// </summary>
		[DataMember(Name="repeatLastStep", EmitDefaultValue=false)]
		public bool RepeatLastStep { get; set; }

		/// <summary>
		/// If there's a description of how to earn this progression in the local config, this will be that localized description.
		/// </summary>
		[DataMember(Name="source", EmitDefaultValue=false)]
		public string Source { get; set; }

		/// <summary>
		/// Progressions are divided into Steps, which roughly equate to "Levels" in the traditional sense of a Progression. Notably, the last step can be repeated indefinitely if repeatLastStep is true, meaning that the calculation for your level is not as simple as comparing your current progress to the max progress of the steps. 
		/// </summary>
		/// <summary>
		/// These and more calculations are done for you if you grab live character progression data, such as in the DestinyCharacterProgressionComponent.
		/// </summary>
		[DataMember(Name="steps", EmitDefaultValue=false)]
		public List<DestinyProgressionStepDefinition> Steps { get; set; }

		/// <summary>
		/// If true, the Progression is something worth showing to users.
		/// </summary>
		/// <summary>
		/// If false, BNet isn't going to show it. But that doesn't mean you can't. We're all friends here.
		/// </summary>
		[DataMember(Name="visible", EmitDefaultValue=false)]
		public bool Visible { get; set; }

		/// <summary>
		/// If the value exists, this is the hash identifier for the Faction that owns this Progression.
		/// </summary>
		/// <summary>
		/// This is purely for convenience, if you're looking at a progression and want to know if and who it's related to in terms of Faction Reputation.
		/// </summary>
		[DataMember(Name="factionHash", EmitDefaultValue=false)]
		public uint FactionHash { get; set; }

		/// <summary>
		/// The #RGB string value for the color related to this progression, if there is one.
		/// </summary>
		[DataMember(Name="color", EmitDefaultValue=false)]
		public DestinyColor Color { get; set; }

		/// <summary>
		/// For progressions that have it, this is the rank icon we use in the Companion, displayed above the progressions' rank value.
		/// </summary>
		[DataMember(Name="rankIcon", EmitDefaultValue=false)]
		public string RankIcon { get; set; }

		[DataMember(Name="rewardItems", EmitDefaultValue=false)]
		public List<DestinyProgressionRewardItemQuantity> RewardItems { get; set; }

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
            return this.Equals(input as DestinyProgressionDefinition);
        }

		public bool Equals(DestinyProgressionDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    Scope == input.Scope ||
                    (Scope != null && Scope.Equals(input.Scope))
                ) &&
				(
                    RepeatLastStep == input.RepeatLastStep ||
                    (RepeatLastStep != null && RepeatLastStep.Equals(input.RepeatLastStep))
                ) &&
				(
                    Source == input.Source ||
                    (Source != null && Source.Equals(input.Source))
                ) &&
				(
                    Steps == input.Steps ||
                    (Steps != null && Steps.Equals(input.Steps))
                ) &&
				(
                    Visible == input.Visible ||
                    (Visible != null && Visible.Equals(input.Visible))
                ) &&
				(
                    FactionHash == input.FactionHash ||
                    (FactionHash != null && FactionHash.Equals(input.FactionHash))
                ) &&
				(
                    Color == input.Color ||
                    (Color != null && Color.Equals(input.Color))
                ) &&
				(
                    RankIcon == input.RankIcon ||
                    (RankIcon != null && RankIcon.Equals(input.RankIcon))
                ) &&
				(
                    RewardItems == input.RewardItems ||
                    (RewardItems != null && RewardItems.Equals(input.RewardItems))
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

		/* 
		public override int GetHashCode()
		{
			unchecked // Overflow is fine, just wrap
			{
				int hashCode = 41;
				hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
				hashCode = hashCode * 59 + this.Scope.GetHashCode();
				hashCode = hashCode * 59 + this.RepeatLastStep.GetHashCode();
				hashCode = hashCode * 59 + this.Source.GetHashCode();
				hashCode = hashCode * 59 + this.Steps.GetHashCode();
				hashCode = hashCode * 59 + this.Visible.GetHashCode();
				hashCode = hashCode * 59 + this.FactionHash.GetHashCode();
				hashCode = hashCode * 59 + this.Color.GetHashCode();
				hashCode = hashCode * 59 + this.RankIcon.GetHashCode();
				hashCode = hashCode * 59 + this.RewardItems.GetHashCode();
				hashCode = hashCode * 59 + this.Hash.GetHashCode();
				hashCode = hashCode * 59 + this.Index.GetHashCode();
				hashCode = hashCode * 59 + this.Redacted.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

