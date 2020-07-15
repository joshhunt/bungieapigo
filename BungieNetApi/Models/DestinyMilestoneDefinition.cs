using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Model
{
	/// <summary>
	/// Milestones are an in-game concept where they're attempting to tell you what you can do next in-game.
	/// </summary>
	/// <summary>
	/// If that sounds a lot like Advisors in Destiny 1, it is! So we threw out Advisors in the Destiny 2 API and tacked all of the data we would have put on Advisors onto Milestones instead.
	/// </summary>
	/// <summary>
	/// Each Milestone represents something going on in the game right now:
	/// </summary>
	/// <summary>
	/// - A "ritual activity" you can perform, like nightfall
	/// </summary>
	/// <summary>
	/// - A "special event" that may have activities related to it, like Taco Tuesday (there's no Taco Tuesday in Destiny 2)
	/// </summary>
	/// <summary>
	/// - A checklist you can fulfill, like helping your Clan complete all of its weekly objectives
	/// </summary>
	/// <summary>
	/// - A tutorial quest you can play through, like the introduction to the Crucible.
	/// </summary>
	/// <summary>
	/// Most of these milestones appear in game as well. Some of them are BNet only, because we're so extra. You're welcome.
	/// </summary>
	/// <summary>
	/// There are some important caveats to understand about how we currently render Milestones and their deficiencies. The game currently doesn't have any content that actually tells you oughtright *what* the Milestone is: that is to say, what you'll be doing. The best we get is either a description of the overall Milestone, or of the Quest that the Milestone is having you partake in: which is usually something that assumes you already know what it's talking about, like "Complete 5 Challenges". 5 Challenges for what? What's a challenge? These are not questions that the Milestone data will answer for you unfortunately.
	/// </summary>
	/// <summary>
	/// This isn't great, and in the future I'd like to add some custom text to give you more contextual information to pass on to your users. But for now, you can do what we do to render what little display info we do have:
	/// </summary>
	/// <summary>
	/// Start by looking at the currently active quest (ideally, you've fetched DestinyMilestone or DestinyPublicMilestone data from the API, so you know the currently active quest for the Milestone in question). Look up the Quests property in the Milestone Definition, and check if it has display properties. If it does, show that as the description of the Milestone. If it doesn't, fall back on the Milestone's description.
	/// </summary>
	/// <summary>
	/// This approach will let you avoid, whenever possible, the even less useful (and sometimes nonexistant) milestone-level names and descriptions.
	/// </summary>
	[DataContract]
	public class DestinyMilestoneDefinition{

		/// <summary>
		/// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
		/// </summary>
		[DataMember(Name="displayProperties", EmitDefaultValue=false)]
		public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

		/// <summary>
		/// A hint to the UI to indicate what to show as the display properties for this Milestone when showing "Live" milestone data. Feel free to show more than this if desired: this hint is meant to simplify our own UI, but it may prove useful to you as well.
		/// </summary>
		[DataMember(Name="displayPreference", EmitDefaultValue=false)]
		public DestinyMilestoneDisplayPreference DisplayPreference { get; set; }

		/// <summary>
		/// A custom image someone made just for the milestone. Isn't that special?
		/// </summary>
		[DataMember(Name="image", EmitDefaultValue=false)]
		public string Image { get; set; }

		/// <summary>
		/// An enumeration listing one of the possible types of milestones. Check out the DestinyMilestoneType enum for more info!
		/// </summary>
		[DataMember(Name="milestoneType", EmitDefaultValue=false)]
		public DestinyMilestoneType MilestoneType { get; set; }

		/// <summary>
		/// If True, then the Milestone has been integrated with BNet's recruiting feature.
		/// </summary>
		[DataMember(Name="recruitable", EmitDefaultValue=false)]
		public bool Recruitable { get; set; }

		/// <summary>
		/// If the milestone has a friendly identifier for association with other features - such as Recruiting - that identifier can be found here. This is "friendly" in that it looks better in a URL than whatever the identifier for the Milestone actually is.
		/// </summary>
		[DataMember(Name="friendlyName", EmitDefaultValue=false)]
		public string FriendlyName { get; set; }

		/// <summary>
		/// If TRUE, this entry should be returned in the list of milestones for the "Explore Destiny" (i.e. new BNet homepage) features of Bungie.net (as long as the underlying event is active) Note that this is a property specifically used by BNet and the companion app for the "Live Events" feature of the front page/welcome view: it's not a reflection of what you see in-game.
		/// </summary>
		[DataMember(Name="showInExplorer", EmitDefaultValue=false)]
		public bool ShowInExplorer { get; set; }

		/// <summary>
		/// Determines whether we'll show this Milestone in the user's personal Milestones list.
		/// </summary>
		[DataMember(Name="showInMilestones", EmitDefaultValue=false)]
		public bool ShowInMilestones { get; set; }

		/// <summary>
		/// If TRUE, "Explore Destiny" (the front page of BNet and the companion app) prioritize using the activity image over any overriding Quest or Milestone image provided. This unfortunate hack is brought to you by Trials of The Nine.
		/// </summary>
		[DataMember(Name="explorePrioritizesActivityImage", EmitDefaultValue=false)]
		public bool ExplorePrioritizesActivityImage { get; set; }

		/// <summary>
		/// A shortcut for clients - and the server - to understand whether we can predict the start and end dates for this event. In practice, there are multiple ways that an event could have predictable date ranges, but not all events will be able to be predicted via any mechanism (for instance, events that are manually triggered on and off)
		/// </summary>
		[DataMember(Name="hasPredictableDates", EmitDefaultValue=false)]
		public bool HasPredictableDates { get; set; }

		/// <summary>
		/// The full set of possible Quests that give the overview of the Milestone event/activity in question. Only one of these can be active at a time for a given Conceptual Milestone, but many of them may be "available" for the user to choose from. (for instance, with Milestones you can choose from the three available Quests, but only one can be active at a time) Keyed by the quest item.
		/// </summary>
		/// <summary>
		/// As of Forsaken (~September 2018), Quest-style Milestones are being removed for many types of activities. There will likely be further revisions to the Milestone concept in the future.
		/// </summary>
		[DataMember(Name="quests", EmitDefaultValue=false)]
		public Map<String, DestinyMilestoneQuestDefinition> Quests { get; set; }

		/// <summary>
		/// If this milestone can provide rewards, this will define the categories into which the individual reward entries are placed.
		/// </summary>
		/// <summary>
		/// This is keyed by the Category's hash, which is only guaranteed to be unique within a given Milestone.
		/// </summary>
		[DataMember(Name="rewards", EmitDefaultValue=false)]
		public Map<String, DestinyMilestoneRewardCategoryDefinition> Rewards { get; set; }

		/// <summary>
		/// If you're going to show Vendors for the Milestone, you can use this as a localized "header" for the section where you show that vendor data. It'll provide a more context-relevant clue about what the vendor's role is in the Milestone.
		/// </summary>
		[DataMember(Name="vendorsDisplayTitle", EmitDefaultValue=false)]
		public string VendorsDisplayTitle { get; set; }

		/// <summary>
		/// Sometimes, milestones will have rewards provided by Vendors. This definition gives the information needed to understand which vendors are relevant, the order in which they should be returned if order matters, and the conditions under which the Vendor is relevant to the user.
		/// </summary>
		[DataMember(Name="vendors", EmitDefaultValue=false)]
		public List<DestinyMilestoneVendorDefinition> Vendors { get; set; }

		/// <summary>
		/// Sometimes, milestones will have arbitrary values associated with them that are of interest to us or to third party developers. This is the collection of those values' definitions, keyed by the identifier of the value and providing useful definition information such as localizable names and descriptions for the value.
		/// </summary>
		[DataMember(Name="values", EmitDefaultValue=false)]
		public Map<String, DestinyMilestoneValueDefinition> Values { get; set; }

		/// <summary>
		/// Some milestones are explicit objectives that you can see and interact with in the game. Some milestones are more conceptual, built by BNet to help advise you on activities and events that happen in-game but that aren't explicitly shown in game as Milestones. If this is TRUE, you can see this as a milestone in the game. If this is FALSE, it's an event or activity you can participate in, but you won't see it as a Milestone in the game's UI.
		/// </summary>
		[DataMember(Name="isInGameMilestone", EmitDefaultValue=false)]
		public bool IsInGameMilestone { get; set; }

		/// <summary>
		/// A Milestone can now be represented by one or more activities directly (without a backing Quest), and that activity can have many challenges, modifiers, and related to it.
		/// </summary>
		[DataMember(Name="activities", EmitDefaultValue=false)]
		public List<DestinyMilestoneChallengeActivityDefinition> Activities { get; set; }

		[DataMember(Name="defaultOrder", EmitDefaultValue=false)]
		public long DefaultOrder { get; set; }

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
            return this.Equals(input as DestinyMilestoneDefinition);
        }

		public bool Equals(DestinyMilestoneDefinition input)
		{
			if (input == null) return false;

			return
				(
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
				(
                    DisplayPreference == input.DisplayPreference ||
                    (DisplayPreference != null && DisplayPreference.Equals(input.DisplayPreference))
                ) &&
				(
                    Image == input.Image ||
                    (Image != null && Image.Equals(input.Image))
                ) &&
				(
                    MilestoneType == input.MilestoneType ||
                    (MilestoneType != null && MilestoneType.Equals(input.MilestoneType))
                ) &&
				(
                    Recruitable == input.Recruitable ||
                    (Recruitable != null && Recruitable.Equals(input.Recruitable))
                ) &&
				(
                    FriendlyName == input.FriendlyName ||
                    (FriendlyName != null && FriendlyName.Equals(input.FriendlyName))
                ) &&
				(
                    ShowInExplorer == input.ShowInExplorer ||
                    (ShowInExplorer != null && ShowInExplorer.Equals(input.ShowInExplorer))
                ) &&
				(
                    ShowInMilestones == input.ShowInMilestones ||
                    (ShowInMilestones != null && ShowInMilestones.Equals(input.ShowInMilestones))
                ) &&
				(
                    ExplorePrioritizesActivityImage == input.ExplorePrioritizesActivityImage ||
                    (ExplorePrioritizesActivityImage != null && ExplorePrioritizesActivityImage.Equals(input.ExplorePrioritizesActivityImage))
                ) &&
				(
                    HasPredictableDates == input.HasPredictableDates ||
                    (HasPredictableDates != null && HasPredictableDates.Equals(input.HasPredictableDates))
                ) &&
				(
                    Quests == input.Quests ||
                    (Quests != null && Quests.Equals(input.Quests))
                ) &&
				(
                    Rewards == input.Rewards ||
                    (Rewards != null && Rewards.Equals(input.Rewards))
                ) &&
				(
                    VendorsDisplayTitle == input.VendorsDisplayTitle ||
                    (VendorsDisplayTitle != null && VendorsDisplayTitle.Equals(input.VendorsDisplayTitle))
                ) &&
				(
                    Vendors == input.Vendors ||
                    (Vendors != null && Vendors.Equals(input.Vendors))
                ) &&
				(
                    Values == input.Values ||
                    (Values != null && Values.Equals(input.Values))
                ) &&
				(
                    IsInGameMilestone == input.IsInGameMilestone ||
                    (IsInGameMilestone != null && IsInGameMilestone.Equals(input.IsInGameMilestone))
                ) &&
				(
                    Activities == input.Activities ||
                    (Activities != null && Activities.Equals(input.Activities))
                ) &&
				(
                    DefaultOrder == input.DefaultOrder ||
                    (DefaultOrder != null && DefaultOrder.Equals(input.DefaultOrder))
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

