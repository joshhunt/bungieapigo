using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// Data regarding the progress of a Quest for a specific character. Quests are composed of multiple steps, each with potentially multiple objectives: this QuestStatus will return Objective data for the *currently active* step in this quest.
    /// </summary>
    [DataContract]
    public class DestinyQuestStatus
    {
        /// <summary>
        /// The hash identifier for the Quest Item. (Note: Quests are defined as Items, and thus you would use this to look up the quest's DestinyInventoryItemDefinition). For information on all steps in the quest, you can then examine its DestinyInventoryItemDefinition.setData property for Quest Steps (which are *also* items). You can use the Item Definition to display human readable data about the overall quest.
        /// </summary>
        [DataMember(Name = "questHash", EmitDefaultValue = false)]
        public uint QuestHash { get; set; }

        /// <summary>
        /// The hash identifier of the current Quest Step, which is also a DestinyInventoryItemDefinition. You can use this to get human readable data about the current step and what to do in that step.
        /// </summary>
        [DataMember(Name = "stepHash", EmitDefaultValue = false)]
        public uint StepHash { get; set; }

        /// <summary>
        /// A step can have multiple objectives. This will give you the progress for each objective in the current step, in the order in which they are rendered in-game.
        /// </summary>
        [DataMember(Name = "stepObjectives", EmitDefaultValue = false)]
        public List<DestinyObjectiveProgress> StepObjectives { get; set; }

        /// <summary>
        /// Whether or not the quest is tracked
        /// </summary>
        [DataMember(Name = "tracked", EmitDefaultValue = false)]
        public bool Tracked { get; set; }

        /// <summary>
        /// The current Quest Step will be an instanced item in the player's inventory. If you care about that, this is the instance ID of that item.
        /// </summary>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// Whether or not the whole quest has been completed, regardless of whether or not you have redeemed the rewards for the quest.
        /// </summary>
        [DataMember(Name = "completed", EmitDefaultValue = false)]
        public bool Completed { get; set; }

        /// <summary>
        /// Whether or not you have redeemed rewards for this quest.
        /// </summary>
        [DataMember(Name = "redeemed", EmitDefaultValue = false)]
        public bool Redeemed { get; set; }

        /// <summary>
        /// Whether or not you have started this quest.
        /// </summary>
        [DataMember(Name = "started", EmitDefaultValue = false)]
        public bool Started { get; set; }

        /// <summary>
        /// If the quest has a related Vendor that you should talk to in order to initiate the quest/earn rewards/continue the quest, this will be the hash identifier of that Vendor. Look it up its DestinyVendorDefinition.
        /// </summary>
        [DataMember(Name = "vendorHash", EmitDefaultValue = false)]
        public uint VendorHash { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyQuestStatus);
        }

        public bool Equals(DestinyQuestStatus input)
        {
            if (input == null) return false;

            return
                (
                    QuestHash == input.QuestHash ||
                    (QuestHash != null && QuestHash.Equals(input.QuestHash))
                ) &&
                (
                    StepHash == input.StepHash ||
                    (StepHash != null && StepHash.Equals(input.StepHash))
                ) &&
                (
                    StepObjectives == input.StepObjectives ||
                    (StepObjectives != null && StepObjectives.Equals(input.StepObjectives))
                ) &&
                (
                    Tracked == input.Tracked ||
                    (Tracked != null && Tracked.Equals(input.Tracked))
                ) &&
                (
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId != null && ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
                (
                    Completed == input.Completed ||
                    (Completed != null && Completed.Equals(input.Completed))
                ) &&
                (
                    Redeemed == input.Redeemed ||
                    (Redeemed != null && Redeemed.Equals(input.Redeemed))
                ) &&
                (
                    Started == input.Started ||
                    (Started != null && Started.Equals(input.Started))
                ) &&
                (
                    VendorHash == input.VendorHash ||
                    (VendorHash != null && VendorHash.Equals(input.VendorHash))
                ) ;
        }
    }
}

