using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// This definition represents an "Activity Mode" as it exists in the Historical Stats endpoints. An individual Activity Mode represents a collection of activities that are played in a certain way. For example, Nightfall Strikes are part of a "Nightfall" activity mode, and any activities played as the PVP mode "Clash" are part of the "Clash activity mode.
	/// </summary>
	/// <summary>
	/// Activity modes are nested under each other in a hierarchy, so that if you ask for - for example - "AllPvP", you will get any PVP activities that the user has played, regardless of what specific PVP mode was being played.
	/// </summary>
	[DataContract]
	public class DestinyActivityModeDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// If this activity mode has a related PGCR image, this will be the path to said image.
		/// </summary>
		[DataMember(Name="pgcrImage", EmitDefaultValue=false)]
		public string PgcrImage { get; set; }

		/// <summary>
		/// The Enumeration value for this Activity Mode. Pass this identifier into Stats endpoints to get aggregate stats for this mode.
		/// </summary>
		[DataMember(Name="modeType", EmitDefaultValue=false)]
		public DestinyActivityModeType ModeType { get; set; }

		/// <summary>
		/// The type of play being performed in broad terms (PVP, PVE)
		/// </summary>
		[DataMember(Name="activityModeCategory", EmitDefaultValue=false)]
		public DestinyActivityModeCategory ActivityModeCategory { get; set; }

		/// <summary>
		/// If True, this mode has oppositional teams fighting against each other rather than "Free-For-All" or Co-operative modes of play.
		/// </summary>
		/// <summary>
		/// Note that Aggregate modes are never marked as team based, even if they happen to be team based at the moment. At any time, an aggregate whose subordinates are only team based could be changed so that one or more aren't team based, and then this boolean won't make much sense (the aggregation would become "sometimes team based"). Let's not deal with that right now.
		/// </summary>
		[DataMember(Name="isTeamBased", EmitDefaultValue=false)]
		public bool IsTeamBased { get; set; }

		/// <summary>
		/// If true, this mode is an aggregation of other, more specific modes rather than being a mode in itself. This includes modes that group Features/Events rather than Gameplay, such as Trials of The Nine: Trials of the Nine being an Event that is interesting to see aggregate data for, but when you play the activities within Trials of the Nine they are more specific activity modes such as Clash.
		/// </summary>
		[DataMember(Name="isAggregateMode", EmitDefaultValue=false)]
		public bool IsAggregateMode { get; set; }

		/// <summary>
		/// The hash identifiers of the DestinyActivityModeDefinitions that represent all of the "parent" modes for this mode. For instance, the Nightfall Mode is also a member of AllStrikes and AllPvE.
		/// </summary>
		[DataMember(Name="parentHashes", EmitDefaultValue=false)]
		public List<uint> ParentHashes { get; set; }

		/// <summary>
		/// A Friendly identifier you can use for referring to this Activity Mode. We really only used this in our URLs, so... you know, take that for whatever it's worth.
		/// </summary>
		[DataMember(Name="friendlyName", EmitDefaultValue=false)]
		public string FriendlyName { get; set; }

		/// <summary>
		/// If this exists, the mode has specific Activities (referred to by the Key) that should instead map to other Activity Modes when they are played. This was useful in D1 for Private Matches, where we wanted to have Private Matches as an activity mode while still referring to the specific mode being played.
		/// </summary>
		[DataMember(Name="activityModeMappings", EmitDefaultValue=false)]
		public Map<String, DestinyActivityModeType> ActivityModeMappings { get; set; }

		/// <summary>
		/// If FALSE, we want to ignore this type when we're showing activity modes in BNet UI. It will still be returned in case 3rd parties want to use it for any purpose.
		/// </summary>
		[DataMember(Name="display", EmitDefaultValue=false)]
		public bool Display { get; set; }

		/// <summary>
		/// The relative ordering of activity modes.
		/// </summary>
		[DataMember(Name="order", EmitDefaultValue=false)]
		public long Order { get; set; }

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
            return this.Equals(input as DestinyActivityModeDefinition);
        }

		public bool Equals(DestinyActivityModeDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    PgcrImage == input.PgcrImage ||
                    (PgcrImage != null && PgcrImage.Equals(input.PgcrImage))
                ) &&
				(
                    ModeType == input.ModeType ||
                    (ModeType != null && ModeType.Equals(input.ModeType))
                ) &&
				(
                    ActivityModeCategory == input.ActivityModeCategory ||
                    (ActivityModeCategory != null && ActivityModeCategory.Equals(input.ActivityModeCategory))
                ) &&
				(
                    IsTeamBased == input.IsTeamBased ||
                    (IsTeamBased != null && IsTeamBased.Equals(input.IsTeamBased))
                ) &&
				(
                    IsAggregateMode == input.IsAggregateMode ||
                    (IsAggregateMode != null && IsAggregateMode.Equals(input.IsAggregateMode))
                ) &&
				(
                    ParentHashes == input.ParentHashes ||
                    (ParentHashes != null && ParentHashes.Equals(input.ParentHashes))
                ) &&
				(
                    FriendlyName == input.FriendlyName ||
                    (FriendlyName != null && FriendlyName.Equals(input.FriendlyName))
                ) &&
				(
                    ActivityModeMappings == input.ActivityModeMappings ||
                    (ActivityModeMappings != null && ActivityModeMappings.Equals(input.ActivityModeMappings))
                ) &&
				(
                    Display == input.Display ||
                    (Display != null && Display.Equals(input.Display))
                ) &&
				(
                    Order == input.Order ||
                    (Order != null && Order.Equals(input.Order))
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

