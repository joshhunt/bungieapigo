using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// This component contains base properties of the character. You'll probably want to always request this component, but hey you do you.
    /// </summary>
    [DataContract]
    public class DestinyCharacterComponent
    {
        /// <summary>
        /// Every Destiny Profile has a membershipId. This is provided on the character as well for convenience.
        /// </summary>
        [DataMember(Name = "membershipId", EmitDefaultValue = false)]
        public long MembershipId { get; set; }

        /// <summary>
        /// membershipType tells you the platform on which the character plays. Examine the BungieMembershipType enumeration for possible values.
        /// </summary>
        [DataMember(Name = "membershipType", EmitDefaultValue = false)]
        public BungieMembershipType MembershipType { get; set; }

        /// <summary>
        /// The unique identifier for the character.
        /// </summary>
        [DataMember(Name = "characterId", EmitDefaultValue = false)]
        public long CharacterId { get; set; }

        /// <summary>
        /// The last date that the user played Destiny.
        /// </summary>
        [DataMember(Name = "dateLastPlayed", EmitDefaultValue = false)]
        public DateTime DateLastPlayed { get; set; }

        /// <summary>
        /// If the user is currently playing, this is how long they've been playing.
        /// </summary>
        [DataMember(Name = "minutesPlayedThisSession", EmitDefaultValue = false)]
        public long MinutesPlayedThisSession { get; set; }

        /// <summary>
        /// If this value is 525,600, then they played Destiny for a year. Or they're a very dedicated Rent fan. Note that this includes idle time, not just time spent actually in activities shooting things.
        /// </summary>
        [DataMember(Name = "minutesPlayedTotal", EmitDefaultValue = false)]
        public long MinutesPlayedTotal { get; set; }

        /// <summary>
        /// The user's calculated "Light Level". Light level is an indicator of your power that mostly matters in the end game, once you've reached the maximum character level: it's a level that's dependent on the average Attack/Defense power of your items.
        /// </summary>
        [DataMember(Name = "light", EmitDefaultValue = false)]
        public long Light { get; set; }

        /// <summary>
        /// Your character's stats, such as Agility, Resilience, etc... *not* historical stats.
        /// </summary>
        /// <summary>
        /// You'll have to call a different endpoint for those.
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public Dictionary<string, long> Stats { get; set; }

        /// <summary>
        /// Use this hash to look up the character's DestinyRaceDefinition.
        /// </summary>
        [DataMember(Name = "raceHash", EmitDefaultValue = false)]
        public uint RaceHash { get; set; }

        /// <summary>
        /// Use this hash to look up the character's DestinyGenderDefinition.
        /// </summary>
        [DataMember(Name = "genderHash", EmitDefaultValue = false)]
        public uint GenderHash { get; set; }

        /// <summary>
        /// Use this hash to look up the character's DestinyClassDefinition.
        /// </summary>
        [DataMember(Name = "classHash", EmitDefaultValue = false)]
        public uint ClassHash { get; set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character's race.
        /// </summary>
        /// <summary>
        /// It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
        /// </summary>
        [DataMember(Name = "raceType", EmitDefaultValue = false)]
        public DestinyRace RaceType { get; set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character's class.
        /// </summary>
        /// <summary>
        /// It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove.
        /// </summary>
        [DataMember(Name = "classType", EmitDefaultValue = false)]
        public DestinyClass ClassType { get; set; }

        /// <summary>
        /// Mostly for historical purposes at this point, this is an enumeration for the character's Gender.
        /// </summary>
        /// <summary>
        /// It'll be preferable in the general case to look up the related definition: but for some people this was too convenient to remove. And yeah, it's an enumeration and not a boolean. Fight me.
        /// </summary>
        [DataMember(Name = "genderType", EmitDefaultValue = false)]
        public DestinyGender GenderType { get; set; }

        /// <summary>
        /// A shortcut path to the user's currently equipped emblem image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        [DataMember(Name = "emblemPath", EmitDefaultValue = false)]
        public string EmblemPath { get; set; }

        /// <summary>
        /// A shortcut path to the user's currently equipped emblem background image. If you're just showing summary info for a user, this is more convenient than examining their equipped emblem and looking up the definition.
        /// </summary>
        [DataMember(Name = "emblemBackgroundPath", EmitDefaultValue = false)]
        public string EmblemBackgroundPath { get; set; }

        /// <summary>
        /// The hash of the currently equipped emblem for the user. Can be used to look up the DestinyInventoryItemDefinition.
        /// </summary>
        [DataMember(Name = "emblemHash", EmitDefaultValue = false)]
        public uint EmblemHash { get; set; }

        /// <summary>
        /// A shortcut for getting the background color of the user's currently equipped emblem without having to do a DestinyInventoryItemDefinition lookup.
        /// </summary>
        [DataMember(Name = "emblemColor", EmitDefaultValue = false)]
        public DestinyColor EmblemColor { get; set; }

        /// <summary>
        /// The progression that indicates your character's level. Not their light level, but their character level: you know, the thing you max out a couple hours in and then ignore for the sake of light level.
        /// </summary>
        [DataMember(Name = "levelProgression", EmitDefaultValue = false)]
        public DestinyProgression LevelProgression { get; set; }

        /// <summary>
        /// The "base" level of your character, not accounting for any light level.
        /// </summary>
        [DataMember(Name = "baseCharacterLevel", EmitDefaultValue = false)]
        public long BaseCharacterLevel { get; set; }

        /// <summary>
        /// A number between 0 and 100, indicating the whole and fractional % remaining to get to the next character level.
        /// </summary>
        [DataMember(Name = "percentToNextLevel", EmitDefaultValue = false)]
        public double PercentToNextLevel { get; set; }

        /// <summary>
        /// If this Character has a title assigned to it, this is the identifier of the DestinyRecordDefinition that has that title information.
        /// </summary>
        [DataMember(Name = "titleRecordHash", EmitDefaultValue = false)]
        public uint TitleRecordHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterComponent);
        }

        public bool Equals(DestinyCharacterComponent input)
        {
            if (input == null) return false;

            return
                (
                    MembershipId == input.MembershipId ||
                    (MembershipId.Equals(input.MembershipId))
                ) &&
                (
                    MembershipType == input.MembershipType ||
                    (MembershipType != null && MembershipType.Equals(input.MembershipType))
                ) &&
                (
                    CharacterId == input.CharacterId ||
                    (CharacterId.Equals(input.CharacterId))
                ) &&
                (
                    DateLastPlayed == input.DateLastPlayed ||
                    (DateLastPlayed != null && DateLastPlayed.Equals(input.DateLastPlayed))
                ) &&
                (
                    MinutesPlayedThisSession == input.MinutesPlayedThisSession ||
                    (MinutesPlayedThisSession.Equals(input.MinutesPlayedThisSession))
                ) &&
                (
                    MinutesPlayedTotal == input.MinutesPlayedTotal ||
                    (MinutesPlayedTotal.Equals(input.MinutesPlayedTotal))
                ) &&
                (
                    Light == input.Light ||
                    (Light.Equals(input.Light))
                ) &&
                (
                    Stats == input.Stats ||
                    (Stats != null && Stats.SequenceEqual(input.Stats))
                ) &&
                (
                    RaceHash == input.RaceHash ||
                    (RaceHash.Equals(input.RaceHash))
                ) &&
                (
                    GenderHash == input.GenderHash ||
                    (GenderHash.Equals(input.GenderHash))
                ) &&
                (
                    ClassHash == input.ClassHash ||
                    (ClassHash.Equals(input.ClassHash))
                ) &&
                (
                    RaceType == input.RaceType ||
                    (RaceType != null && RaceType.Equals(input.RaceType))
                ) &&
                (
                    ClassType == input.ClassType ||
                    (ClassType != null && ClassType.Equals(input.ClassType))
                ) &&
                (
                    GenderType == input.GenderType ||
                    (GenderType != null && GenderType.Equals(input.GenderType))
                ) &&
                (
                    EmblemPath == input.EmblemPath ||
                    (EmblemPath != null && EmblemPath.Equals(input.EmblemPath))
                ) &&
                (
                    EmblemBackgroundPath == input.EmblemBackgroundPath ||
                    (EmblemBackgroundPath != null && EmblemBackgroundPath.Equals(input.EmblemBackgroundPath))
                ) &&
                (
                    EmblemHash == input.EmblemHash ||
                    (EmblemHash.Equals(input.EmblemHash))
                ) &&
                (
                    EmblemColor == input.EmblemColor ||
                    (EmblemColor != null && EmblemColor.Equals(input.EmblemColor))
                ) &&
                (
                    LevelProgression == input.LevelProgression ||
                    (LevelProgression != null && LevelProgression.Equals(input.LevelProgression))
                ) &&
                (
                    BaseCharacterLevel == input.BaseCharacterLevel ||
                    (BaseCharacterLevel.Equals(input.BaseCharacterLevel))
                ) &&
                (
                    PercentToNextLevel == input.PercentToNextLevel ||
                    (PercentToNextLevel.Equals(input.PercentToNextLevel))
                ) &&
                (
                    TitleRecordHash == input.TitleRecordHash ||
                    (TitleRecordHash.Equals(input.TitleRecordHash))
                ) ;
        }
    }
}

