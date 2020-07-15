using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// This represents a single "thing" being tracked by the player.
    /// </summary>
    /// <summary>
    /// This can point to many types of entities, but only a subset of them will actually have a valid hash identifier for whatever it is being pointed to.
    /// </summary>
    /// <summary>
    /// It's up to you to interpret what it means when various combinations of these entries have values being tracked.
    /// </summary>
    [DataContract]
    public class DestinyProfileTransitoryTrackingEntry
    {
        /// <summary>
        /// OPTIONAL - If this is tracking a DestinyLocationDefinition, this is the identifier for that location.
        /// </summary>
        [DataMember(Name = "locationHash", EmitDefaultValue = false)]
        public uint LocationHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyInventoryItemDefinition, this is the identifier for that item.
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyObjectiveDefinition, this is the identifier for that objective.
        /// </summary>
        [DataMember(Name = "objectiveHash", EmitDefaultValue = false)]
        public uint ObjectiveHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a DestinyActivityDefinition, this is the identifier for that activity.
        /// </summary>
        [DataMember(Name = "activityHash", EmitDefaultValue = false)]
        public uint ActivityHash { get; set; }

        /// <summary>
        /// OPTIONAL - If this is tracking the status of a quest, this is the identifier for the DestinyInventoryItemDefinition that containst that questline data.
        /// </summary>
        [DataMember(Name = "questlineItemHash", EmitDefaultValue = false)]
        public uint QuestlineItemHash { get; set; }

        /// <summary>
        /// OPTIONAL - I've got to level with you, I don't really know what this is. Is it when you started tracking it? Is it only populated for tracked items that have time limits?
        /// </summary>
        /// <summary>
        /// I don't know, but we can get at it - when I get time to actually test what it is, I'll update this. In the meantime, bask in the mysterious data.
        /// </summary>
        [DataMember(Name = "trackedDate", EmitDefaultValue = false)]
        public string TrackedDate { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyProfileTransitoryTrackingEntry);
        }

        public bool Equals(DestinyProfileTransitoryTrackingEntry input)
        {
            if (input == null) return false;

            return
                (
                    LocationHash == input.LocationHash ||
                    (LocationHash != null && LocationHash.Equals(input.LocationHash))
                ) &&
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    ObjectiveHash == input.ObjectiveHash ||
                    (ObjectiveHash != null && ObjectiveHash.Equals(input.ObjectiveHash))
                ) &&
                (
                    ActivityHash == input.ActivityHash ||
                    (ActivityHash != null && ActivityHash.Equals(input.ActivityHash))
                ) &&
                (
                    QuestlineItemHash == input.QuestlineItemHash ||
                    (QuestlineItemHash != null && QuestlineItemHash.Equals(input.QuestlineItemHash))
                ) &&
                (
                    TrackedDate == input.TrackedDate ||
                    (TrackedDate != null && TrackedDate.Equals(input.TrackedDate))
                ) ;
        }
    }
}

