using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// This component holds activity data for a character. It will tell you about the character's current activity status, as well as activities that are available to the user.
    /// </summary>
    [DataContract]
    public class DestinyCharacterActivitiesComponent
    {
        /// <summary>
        /// The last date that the user started playing an activity.
        /// </summary>
        [DataMember(Name = "dateActivityStarted", EmitDefaultValue = false)]
        public string DateActivityStarted { get; set; }

        /// <summary>
        /// The list of activities that the user can play.
        /// </summary>
        [DataMember(Name = "availableActivities", EmitDefaultValue = false)]
        public List<DestinyActivity> AvailableActivities { get; set; }

        /// <summary>
        /// If the user is in an activity, this will be the hash of the Activity being played. Note that you must combine this info with currentActivityModeHash to get a real picture of what the user is doing right now. For instance, PVP "Activities" are just maps: it's the ActivityMode that determines what type of PVP game they're playing.
        /// </summary>
        [DataMember(Name = "currentActivityHash", EmitDefaultValue = false)]
        public uint CurrentActivityHash { get; set; }

        /// <summary>
        /// If the user is in an activity, this will be the hash of the activity mode being played. Combine with currentActivityHash to give a person a full picture of what they're doing right now.
        /// </summary>
        [DataMember(Name = "currentActivityModeHash", EmitDefaultValue = false)]
        public uint CurrentActivityModeHash { get; set; }

        /// <summary>
        /// And the current activity's most specific mode type, if it can be found.
        /// </summary>
        [DataMember(Name = "currentActivityModeType", EmitDefaultValue = false)]
        public long CurrentActivityModeType { get; set; }

        /// <summary>
        /// If the user is in an activity, this will be the hashes of the DestinyActivityModeDefinition being played. Combine with currentActivityHash to give a person a full picture of what they're doing right now.
        /// </summary>
        [DataMember(Name = "currentActivityModeHashes", EmitDefaultValue = false)]
        public List<uint> CurrentActivityModeHashes { get; set; }

        /// <summary>
        /// All Activity Modes that apply to the current activity being played, in enum form.
        /// </summary>
        [DataMember(Name = "currentActivityModeTypes", EmitDefaultValue = false)]
        public List<DestinyActivityModeType> CurrentActivityModeTypes { get; set; }

        /// <summary>
        /// If the user is in a playlist, this is the hash identifier for the playlist that they chose.
        /// </summary>
        [DataMember(Name = "currentPlaylistActivityHash", EmitDefaultValue = false)]
        public uint CurrentPlaylistActivityHash { get; set; }

        /// <summary>
        /// This will have the activity hash of the last completed story/campaign mission, in case you care about that.
        /// </summary>
        [DataMember(Name = "lastCompletedStoryHash", EmitDefaultValue = false)]
        public uint LastCompletedStoryHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyCharacterActivitiesComponent);
        }

        public bool Equals(DestinyCharacterActivitiesComponent input)
        {
            if (input == null) return false;

            return
                (
                    DateActivityStarted == input.DateActivityStarted ||
                    (DateActivityStarted != null && DateActivityStarted.Equals(input.DateActivityStarted))
                ) &&
                (
                    AvailableActivities == input.AvailableActivities ||
                    (AvailableActivities != null && AvailableActivities.Equals(input.AvailableActivities))
                ) &&
                (
                    CurrentActivityHash == input.CurrentActivityHash ||
                    (CurrentActivityHash != null && CurrentActivityHash.Equals(input.CurrentActivityHash))
                ) &&
                (
                    CurrentActivityModeHash == input.CurrentActivityModeHash ||
                    (CurrentActivityModeHash != null && CurrentActivityModeHash.Equals(input.CurrentActivityModeHash))
                ) &&
                (
                    CurrentActivityModeType == input.CurrentActivityModeType ||
                    (CurrentActivityModeType != null && CurrentActivityModeType.Equals(input.CurrentActivityModeType))
                ) &&
                (
                    CurrentActivityModeHashes == input.CurrentActivityModeHashes ||
                    (CurrentActivityModeHashes != null && CurrentActivityModeHashes.Equals(input.CurrentActivityModeHashes))
                ) &&
                (
                    CurrentActivityModeTypes == input.CurrentActivityModeTypes ||
                    (CurrentActivityModeTypes != null && CurrentActivityModeTypes.Equals(input.CurrentActivityModeTypes))
                ) &&
                (
                    CurrentPlaylistActivityHash == input.CurrentPlaylistActivityHash ||
                    (CurrentPlaylistActivityHash != null && CurrentPlaylistActivityHash.Equals(input.CurrentPlaylistActivityHash))
                ) &&
                (
                    LastCompletedStoryHash == input.LastCompletedStoryHash ||
                    (LastCompletedStoryHash != null && LastCompletedStoryHash.Equals(input.LastCompletedStoryHash))
                ) ;
        }
    }
}

