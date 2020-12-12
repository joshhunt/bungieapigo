using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// If the activity is a playlist, this is the definition for a specific entry in the playlist: a single possible combination of Activity and Activity Mode that can be chosen.
    /// </summary>
    [DataContract]
    public class DestinyActivityPlaylistItemDefinition
    {
        /// <summary>
        /// The hash identifier of the Activity that can be played. Use it to look up the DestinyActivityDefinition.
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        /// <summary>
        /// If this playlist entry had an activity mode directly defined on it, this will be the hash of that mode.
        /// </summary>
        [DataMember(Name = "directActivityModeHash", EmitDefaultValue = false)]
        public uint DirectActivityModeHash { get; set; }

        /// <summary>
        /// If the playlist entry had an activity mode directly defined on it, this will be the enum value of that mode.
        /// </summary>
        [DataMember(Name = "directActivityModeType", EmitDefaultValue = false)]
        public long DirectActivityModeType { get; set; }

        /// <summary>
        /// The hash identifiers for Activity Modes relevant to this entry.
        /// </summary>
        [DataMember(Name = "activityModeHashes", EmitDefaultValue = false)]
        public List<uint> ActivityModeHashes { get; set; }

        /// <summary>
        /// The activity modes - if any - in enum form. Because we can't seem to escape the enums.
        /// </summary>
        [DataMember(Name = "activityModeTypes", EmitDefaultValue = false)]
        public List<DestinyActivityModeType> ActivityModeTypes { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyActivityPlaylistItemDefinition);
        }

        public bool Equals(DestinyActivityPlaylistItemDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    DirectActivityModeHash == input.DirectActivityModeHash ||
                    (DirectActivityModeHash.Equals(input.DirectActivityModeHash))
                ) &&
                (
                    DirectActivityModeType == input.DirectActivityModeType ||
                    (DirectActivityModeType.Equals(input.DirectActivityModeType))
                ) &&
                (
                    ActivityModeHashes == input.ActivityModeHashes ||
                    (ActivityModeHashes != null && ActivityModeHashes.SequenceEqual(input.ActivityModeHashes))
                ) &&
                (
                    ActivityModeTypes == input.ActivityModeTypes ||
                    (ActivityModeTypes != null && ActivityModeTypes.SequenceEqual(input.ActivityModeTypes))
                ) ;
        }
    }
}

