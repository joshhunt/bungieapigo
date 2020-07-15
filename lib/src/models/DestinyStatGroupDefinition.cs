using System.Runtime.Serialization;
using System.Collections.Generic;

namespace BungieNetApi.Model {
	/// When an inventory item (DestinyInventoryItemDefinition) has Stats (such as Attack Power), the item will refer to a Stat Group. This definition enumerates the properties used to transform the item&#39;s &quot;Investment&quot; stats into &quot;Display&quot; stats.
	/// See DestinyStatDefinition&#39;s documentation for information about the transformation of Stats, and the meaning of an Investment vs. a Display stat.
	/// If you don&#39;t want to do these calculations on your own, fear not: pulling live data from the BNet endpoints will return display stat values pre-computed and ready for you to use. I highly recommend this approach, saves a lot of time and also accounts for certain stat modifiers that can&#39;t easily be accounted for without live data (such as stat modifiers on Talent Grids and Socket Plugs)
	[DataContract]
	public class DestinyStatGroupDefinition{

		/// <summary>
		/// The maximum possible value that any stat in this group can be transformed into.
		/// </summary>
		/// <summary>
		/// This is used by stats that *don't* have scaledStats entries below, but that still need to be displayed as a progress bar, in which case this is used as the upper bound for said progress bar. (the lower bound is always 0)
		/// </summary>
		[DataMember(Name="maximumValue", EmitDefaultValue=false)]
		public long MaximumValue { get; set; }

		/// <summary>
		/// This apparently indicates the position of the stats in the UI? I've returned it in case anyone can use it, but it's not of any use to us on BNet. Something's being lost in translation with this value.
		/// </summary>
		[DataMember(Name="uiPosition", EmitDefaultValue=false)]
		public long UiPosition { get; set; }

		/// <summary>
		/// Any stat that requires scaling to be transformed from an "Investment" stat to a "Display" stat will have an entry in this list. For more information on what those types of stats mean and the transformation process, see DestinyStatDefinition.
		/// </summary>
		/// <summary>
		/// In retrospect, I wouldn't mind if this was a dictionary keyed by the stat hash instead. But I'm going to leave it be because [[After Apple Picking]].
		/// </summary>
		[DataMember(Name="scaledStats", EmitDefaultValue=false)]
		public List<DestinyStatDisplayDefinition> ScaledStats { get; set; }

		/// <summary>
		/// The game has the ability to override, based on the stat group, what the localized text is that is displayed for Stats being shown on the item.
		/// </summary>
		/// <summary>
		/// Mercifully, no Stat Groups use this feature currently. If they start using them, we'll all need to start using them (and those of you who are more prudent than I am can go ahead and start pre-checking for this.)
		/// </summary>
		[DataMember(Name="overrides", EmitDefaultValue=false)]
		public Map<String, DestinyStatOverrideDefinition> Overrides { get; set; }

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
            return this.Equals(input as DestinyStatGroupDefinition);
        }

		public bool Equals(DestinyStatGroupDefinition input)
		{
			if (input == null) return false;

			return
				(
                    MaximumValue == input.MaximumValue ||
                    (MaximumValue != null && MaximumValue.Equals(input.MaximumValue))
                ) &&
				(
                    UiPosition == input.UiPosition ||
                    (UiPosition != null && UiPosition.Equals(input.UiPosition))
                ) &&
				(
                    ScaledStats == input.ScaledStats ||
                    (ScaledStats != null && ScaledStats.Equals(input.ScaledStats))
                ) &&
				(
                    Overrides == input.Overrides ||
                    (Overrides != null && Overrides.Equals(input.Overrides))
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
				hashCode = hashCode * 59 + this.MaximumValue.GetHashCode();
				hashCode = hashCode * 59 + this.UiPosition.GetHashCode();
				hashCode = hashCode * 59 + this.ScaledStats.GetHashCode();
				hashCode = hashCode * 59 + this.Overrides.GetHashCode();
				hashCode = hashCode * 59 + this.Hash.GetHashCode();
				hashCode = hashCode * 59 + this.Index.GetHashCode();
				hashCode = hashCode * 59 + this.Redacted.GetHashCode();
				return hashCode;
			}
		}*/
	}
}

