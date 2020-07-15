using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The static data about Activities in Destiny 2.
    /// </summary>
    /// <summary>
    /// Note that an Activity must be combined with an ActivityMode to know - from a Gameplay perspective - what the user is "Playing".
    /// </summary>
    /// <summary>
    /// In most PvE activities, this is fairly straightforward. A Story Activity can only be played in the Story Activity Mode.
    /// </summary>
    /// <summary>
    /// However, in PvP activities, the Activity alone only tells you the map being played, or the Playlist that the user chose to enter. You'll need to know the Activity Mode they're playing to know that they're playing Mode X on Map Y.
    /// </summary>
    /// <summary>
    /// Activity Definitions tell a great deal of information about what *could* be relevant to a user: what rewards they can earn, what challenges could be performed, what modifiers could be applied. To figure out which of these properties is actually live, you'll need to combine the definition with "Live" data from one of the Destiny endpoints.
    /// </summary>
    /// <summary>
    /// Activities also have Activity Types, but unfortunately in Destiny 2 these are even less reliable of a source of information than they were in Destiny 1. I will be looking into ways to provide more reliable sources for type information as time goes on, but for now we're going to have to deal with the limitations. See DestinyActivityTypeDefinition for more information.
    /// </summary>
    [DataContract]
    public class DestinyActivityDefinition
    {
        /// <summary>
        /// The title, subtitle, and icon for the activity. We do a little post-processing on this to try and account for Activities where the designers have left this data too minimal to determine what activity is actually being played.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// The unadulterated form of the display properties, as they ought to be shown in the Director (if the activity appears in the director).
        /// </summary>
        [DataMember(Name = "originalDisplayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition OriginalDisplayProperties { get; set; }

        /// <summary>
        /// The title, subtitle, and icon for the activity as determined by Selection Screen data, if there is any for this activity. There won't be data in this field if the activity is never shown in a selection/options screen.
        /// </summary>
        [DataMember(Name = "selectionScreenDisplayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition SelectionScreenDisplayProperties { get; set; }

        /// <summary>
        /// If the activity has an icon associated with a specific release (such as a DLC), this is the path to that release's icon.
        /// </summary>
        [DataMember(Name = "releaseIcon", EmitDefaultValue = false)]
        public string ReleaseIcon { get; set; }

        /// <summary>
        /// If the activity will not be visible until a specific and known time, this will be the seconds since the Epoch when it will become visible.
        /// </summary>
        [DataMember(Name = "releaseTime", EmitDefaultValue = false)]
        public long ReleaseTime { get; set; }

        /// <summary>
        /// The difficulty level of the activity.
        /// </summary>
        [DataMember(Name = "activityLevel", EmitDefaultValue = false)]
        public long ActivityLevel { get; set; }

        /// <summary>
        /// The recommended light level for this activity.
        /// </summary>
        [DataMember(Name = "activityLightLevel", EmitDefaultValue = false)]
        public long ActivityLightLevel { get; set; }

        /// <summary>
        /// The hash identifier for the Destination on which this Activity is played. Use it to look up the DestinyDestinationDefinition for human readable info about the destination. A Destination can be thought of as a more specific location than a "Place". For instance, if the "Place" is Earth, the "Destination" would be a specific city or region on Earth.
        /// </summary>
        [DataMember(Name = "destinationHash", EmitDefaultValue = false)]
        public uint DestinationHash { get; set; }

        /// <summary>
        /// The hash identifier for the "Place" on which this Activity is played. Use it to look up the DestinyPlaceDefinition for human readable info about the Place. A Place is the largest-scoped concept for location information. For instance, if the "Place" is Earth, the "Destination" would be a specific city or region on Earth.
        /// </summary>
        [DataMember(Name = "placeHash", EmitDefaultValue = false)]
        public uint PlaceHash { get; set; }

        /// <summary>
        /// The hash identifier for the Activity Type of this Activity. You may use it to look up the DestinyActivityTypeDefinition for human readable info, but be forewarned: Playlists and many PVP Map Activities will map to generic Activity Types. You'll have to use your knowledge of the Activity Mode being played to get more specific information about what the user is playing.
        /// </summary>
        [DataMember(Name = "activityTypeHash", EmitDefaultValue = false)]
        public uint ActivityTypeHash { get; set; }

        /// <summary>
        /// The difficulty tier of the activity.
        /// </summary>
        [DataMember(Name = "tier", EmitDefaultValue = false)]
        public long Tier { get; set; }

        /// <summary>
        /// When Activities are completed, we generate a "Post-Game Carnage Report", or PGCR, with details about what happened in that activity (how many kills someone got, which team won, etc...) We use this image as the background when displaying PGCR information, and often use it when we refer to the Activity in general.
        /// </summary>
        [DataMember(Name = "pgcrImage", EmitDefaultValue = false)]
        public string PgcrImage { get; set; }

        /// <summary>
        /// The expected possible rewards for the activity. These rewards may or may not be accessible for an individual player based on their character state, the account state, and even the game's state overall. But it is a useful reference for possible rewards you can earn in the activity. These match up to rewards displayed when you hover over the Activity in the in-game Director, and often refer to Placeholder or "Dummy" items: items that tell you what you can earn in vague terms rather than what you'll specifically be earning (partly because the game doesn't even know what you'll earn specifically until you roll for it at the end)
        /// </summary>
        [DataMember(Name = "rewards", EmitDefaultValue = false)]
        public List<DestinyActivityRewardDefinition> Rewards { get; set; }

        /// <summary>
        /// Activities can have Modifiers, as defined in DestinyActivityModifierDefinition. These are references to the modifiers that *can* be applied to that activity, along with data that we use to determine if that modifier is actually active at any given point in time.
        /// </summary>
        [DataMember(Name = "modifiers", EmitDefaultValue = false)]
        public List<DestinyActivityModifierReferenceDefinition> Modifiers { get; set; }

        /// <summary>
        /// If True, this Activity is actually a Playlist that refers to multiple possible specific Activities and Activity Modes. For instance, a Crucible Playlist may have references to multiple Activities (Maps) with multiple Activity Modes (specific PvP gameplay modes). If this is true, refer to the playlistItems property for the specific entries in the playlist.
        /// </summary>
        [DataMember(Name = "isPlaylist", EmitDefaultValue = false)]
        public bool IsPlaylist { get; set; }

        /// <summary>
        /// An activity can have many Challenges, of which any subset of them may be active for play at any given period of time. This gives the information about the challenges and data that we use to understand when they're active and what rewards they provide. Sadly, at the moment there's no central definition for challenges: much like "Skulls" were in Destiny 1, these are defined on individual activities and there can be many duplicates/near duplicates across the Destiny 2 ecosystem. I have it in mind to centralize these in a future revision of the API, but we are out of time.
        /// </summary>
        [DataMember(Name = "challenges", EmitDefaultValue = false)]
        public List<DestinyActivityChallengeDefinition> Challenges { get; set; }

        /// <summary>
        /// If there are status strings related to the activity and based on internal state of the game, account, or character, then this will be the definition of those strings and the states needed in order for the strings to be shown.
        /// </summary>
        [DataMember(Name = "optionalUnlockStrings", EmitDefaultValue = false)]
        public List<DestinyActivityUnlockStringDefinition> OptionalUnlockStrings { get; set; }

        /// <summary>
        /// Represents all of the possible activities that could be played in the Playlist, along with information that we can use to determine if they are active at the present time.
        /// </summary>
        [DataMember(Name = "playlistItems", EmitDefaultValue = false)]
        public List<DestinyActivityPlaylistItemDefinition> PlaylistItems { get; set; }

        /// <summary>
        /// Unfortunately, in practice this is almost never populated. In theory, this is supposed to tell which Activity Graph to show if you bring up the director while in this activity.
        /// </summary>
        [DataMember(Name = "activityGraphList", EmitDefaultValue = false)]
        public List<DestinyActivityGraphListEntryDefinition> ActivityGraphList { get; set; }

        /// <summary>
        /// This block of data provides information about the Activity's matchmaking attributes: how many people can join and such.
        /// </summary>
        [DataMember(Name = "matchmaking", EmitDefaultValue = false)]
        public DestinyActivityMatchmakingBlockDefinition Matchmaking { get; set; }

        /// <summary>
        /// This block of data, if it exists, provides information about the guided game experience and restrictions for this activity. If it doesn't exist, the game is not able to be played as a guided game.
        /// </summary>
        [DataMember(Name = "guidedGame", EmitDefaultValue = false)]
        public DestinyActivityGuidedBlockDefinition GuidedGame { get; set; }

        /// <summary>
        /// If this activity had an activity mode directly defined on it, this will be the hash of that mode.
        /// </summary>
        [DataMember(Name = "directActivityModeHash", EmitDefaultValue = false)]
        public uint DirectActivityModeHash { get; set; }

        /// <summary>
        /// If the activity had an activity mode directly defined on it, this will be the enum value of that mode.
        /// </summary>
        [DataMember(Name = "directActivityModeType", EmitDefaultValue = false)]
        public long DirectActivityModeType { get; set; }

        /// <summary>
        /// The set of all possible loadout requirements that could be active for this activity. Only one will be active at any given time, and you can discover which one through activity-associated data such as Milestones that have activity info on them.
        /// </summary>
        [DataMember(Name = "loadouts", EmitDefaultValue = false)]
        public List<DestinyActivityLoadoutRequirementSet> Loadouts { get; set; }

        /// <summary>
        /// The hash identifiers for Activity Modes relevant to this activity.  Note that if this is a playlist, the specific playlist entry chosen will determine the actual activity modes that end up being relevant.
        /// </summary>
        [DataMember(Name = "activityModeHashes", EmitDefaultValue = false)]
        public List<uint> ActivityModeHashes { get; set; }

        /// <summary>
        /// The activity modes - if any - in enum form. Because we can't seem to escape the enums.
        /// </summary>
        [DataMember(Name = "activityModeTypes", EmitDefaultValue = false)]
        public List<DestinyActivityModeType> ActivityModeTypes { get; set; }

        /// <summary>
        /// If true, this activity is a PVP activity or playlist.
        /// </summary>
        [DataMember(Name = "isPvP", EmitDefaultValue = false)]
        public bool IsPvP { get; set; }

        /// <summary>
        /// The list of phases or points of entry into an activity, along with information we can use to determine their gating and availability.
        /// </summary>
        [DataMember(Name = "insertionPoints", EmitDefaultValue = false)]
        public List<DestinyActivityInsertionPointDefinition> InsertionPoints { get; set; }

        /// <summary>
        /// A list of location mappings that are affected by this activity. Pulled out of DestinyLocationDefinitions for our/your lookup convenience.
        /// </summary>
        [DataMember(Name = "activityLocationMappings", EmitDefaultValue = false)]
        public List<DestinyEnvironmentLocationMapping> ActivityLocationMappings { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.
        /// </summary>
        /// <summary>
        /// When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        [DataMember(Name = "hash", EmitDefaultValue = false)]
        public uint Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public long Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        [DataMember(Name = "redacted", EmitDefaultValue = false)]
        public bool Redacted { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityDefinition);
        }

        public bool Equals(DestinyActivityDefinition input)
        {
            if (input == null) return false;

            return
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) &&
                (
                    OriginalDisplayProperties == input.OriginalDisplayProperties ||
                    (OriginalDisplayProperties != null && OriginalDisplayProperties.Equals(input.OriginalDisplayProperties))
                ) &&
                (
                    SelectionScreenDisplayProperties == input.SelectionScreenDisplayProperties ||
                    (SelectionScreenDisplayProperties != null && SelectionScreenDisplayProperties.Equals(input.SelectionScreenDisplayProperties))
                ) &&
                (
                    ReleaseIcon == input.ReleaseIcon ||
                    (ReleaseIcon != null && ReleaseIcon.Equals(input.ReleaseIcon))
                ) &&
                (
                    ReleaseTime == input.ReleaseTime ||
                    (ReleaseTime != null && ReleaseTime.Equals(input.ReleaseTime))
                ) &&
                (
                    ActivityLevel == input.ActivityLevel ||
                    (ActivityLevel != null && ActivityLevel.Equals(input.ActivityLevel))
                ) &&
                (
                    ActivityLightLevel == input.ActivityLightLevel ||
                    (ActivityLightLevel != null && ActivityLightLevel.Equals(input.ActivityLightLevel))
                ) &&
                (
                    DestinationHash == input.DestinationHash ||
                    (DestinationHash != null && DestinationHash.Equals(input.DestinationHash))
                ) &&
                (
                    PlaceHash == input.PlaceHash ||
                    (PlaceHash != null && PlaceHash.Equals(input.PlaceHash))
                ) &&
                (
                    ActivityTypeHash == input.ActivityTypeHash ||
                    (ActivityTypeHash != null && ActivityTypeHash.Equals(input.ActivityTypeHash))
                ) &&
                (
                    Tier == input.Tier ||
                    (Tier != null && Tier.Equals(input.Tier))
                ) &&
                (
                    PgcrImage == input.PgcrImage ||
                    (PgcrImage != null && PgcrImage.Equals(input.PgcrImage))
                ) &&
                (
                    Rewards == input.Rewards ||
                    (Rewards != null && Rewards.Equals(input.Rewards))
                ) &&
                (
                    Modifiers == input.Modifiers ||
                    (Modifiers != null && Modifiers.Equals(input.Modifiers))
                ) &&
                (
                    IsPlaylist == input.IsPlaylist ||
                    (IsPlaylist != null && IsPlaylist.Equals(input.IsPlaylist))
                ) &&
                (
                    Challenges == input.Challenges ||
                    (Challenges != null && Challenges.Equals(input.Challenges))
                ) &&
                (
                    OptionalUnlockStrings == input.OptionalUnlockStrings ||
                    (OptionalUnlockStrings != null && OptionalUnlockStrings.Equals(input.OptionalUnlockStrings))
                ) &&
                (
                    PlaylistItems == input.PlaylistItems ||
                    (PlaylistItems != null && PlaylistItems.Equals(input.PlaylistItems))
                ) &&
                (
                    ActivityGraphList == input.ActivityGraphList ||
                    (ActivityGraphList != null && ActivityGraphList.Equals(input.ActivityGraphList))
                ) &&
                (
                    Matchmaking == input.Matchmaking ||
                    (Matchmaking != null && Matchmaking.Equals(input.Matchmaking))
                ) &&
                (
                    GuidedGame == input.GuidedGame ||
                    (GuidedGame != null && GuidedGame.Equals(input.GuidedGame))
                ) &&
                (
                    DirectActivityModeHash == input.DirectActivityModeHash ||
                    (DirectActivityModeHash != null && DirectActivityModeHash.Equals(input.DirectActivityModeHash))
                ) &&
                (
                    DirectActivityModeType == input.DirectActivityModeType ||
                    (DirectActivityModeType != null && DirectActivityModeType.Equals(input.DirectActivityModeType))
                ) &&
                (
                    Loadouts == input.Loadouts ||
                    (Loadouts != null && Loadouts.Equals(input.Loadouts))
                ) &&
                (
                    ActivityModeHashes == input.ActivityModeHashes ||
                    (ActivityModeHashes != null && ActivityModeHashes.Equals(input.ActivityModeHashes))
                ) &&
                (
                    ActivityModeTypes == input.ActivityModeTypes ||
                    (ActivityModeTypes != null && ActivityModeTypes.Equals(input.ActivityModeTypes))
                ) &&
                (
                    IsPvP == input.IsPvP ||
                    (IsPvP != null && IsPvP.Equals(input.IsPvP))
                ) &&
                (
                    InsertionPoints == input.InsertionPoints ||
                    (InsertionPoints != null && InsertionPoints.Equals(input.InsertionPoints))
                ) &&
                (
                    ActivityLocationMappings == input.ActivityLocationMappings ||
                    (ActivityLocationMappings != null && ActivityLocationMappings.Equals(input.ActivityLocationMappings))
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

