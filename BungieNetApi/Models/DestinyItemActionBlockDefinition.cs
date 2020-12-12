using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

namespace GhostSharper.Models
{
    /// <summary>
    /// If an item can have an action performed on it (like "Dismantle"), it will be defined here if you care.
    /// </summary>
    [DataContract]
    public class DestinyItemActionBlockDefinition
    {
        /// <summary>
        /// Localized text for the verb of the action being performed.
        /// </summary>
        [DataMember(Name = "verbName", EmitDefaultValue = false)]
        public string VerbName { get; set; }

        /// <summary>
        /// Localized text describing the action being performed.
        /// </summary>
        [DataMember(Name = "verbDescription", EmitDefaultValue = false)]
        public string VerbDescription { get; set; }

        /// <summary>
        /// The content has this property, however it's not entirely clear how it is used.
        /// </summary>
        [DataMember(Name = "isPositive", EmitDefaultValue = false)]
        public bool IsPositive { get; set; }

        /// <summary>
        /// If the action has an overlay screen associated with it, this is the name of that screen. Unfortunately, we cannot return the screen's data itself.
        /// </summary>
        [DataMember(Name = "overlayScreenName", EmitDefaultValue = false)]
        public string OverlayScreenName { get; set; }

        /// <summary>
        /// The icon associated with the overlay screen for the action, if any.
        /// </summary>
        [DataMember(Name = "overlayIcon", EmitDefaultValue = false)]
        public string OverlayIcon { get; set; }

        /// <summary>
        /// The number of seconds to delay before allowing this action to be performed again.
        /// </summary>
        [DataMember(Name = "requiredCooldownSeconds", EmitDefaultValue = false)]
        public long RequiredCooldownSeconds { get; set; }

        /// <summary>
        /// If the action requires other items to exist or be destroyed, this is the list of those items and requirements.
        /// </summary>
        [DataMember(Name = "requiredItems", EmitDefaultValue = false)]
        public List<DestinyItemActionRequiredItemDefinition> RequiredItems { get; set; }

        /// <summary>
        /// If performing this action earns you Progression, this is the list of progressions and values granted for those progressions by performing this action.
        /// </summary>
        [DataMember(Name = "progressionRewards", EmitDefaultValue = false)]
        public List<DestinyProgressionRewardDefinition> ProgressionRewards { get; set; }

        /// <summary>
        /// The internal identifier for the action.
        /// </summary>
        [DataMember(Name = "actionTypeLabel", EmitDefaultValue = false)]
        public string ActionTypeLabel { get; set; }

        /// <summary>
        /// Theoretically, an item could have a localized string for a hint about the location in which the action should be performed. In practice, no items yet have this property.
        /// </summary>
        [DataMember(Name = "requiredLocation", EmitDefaultValue = false)]
        public string RequiredLocation { get; set; }

        /// <summary>
        /// The identifier hash for the Cooldown associated with this action. We have not pulled this data yet for you to have more data to use for cooldowns.
        /// </summary>
        [DataMember(Name = "requiredCooldownHash", EmitDefaultValue = false)]
        public uint RequiredCooldownHash { get; set; }

        /// <summary>
        /// If true, the item is deleted when the action completes.
        /// </summary>
        [DataMember(Name = "deleteOnAction", EmitDefaultValue = false)]
        public bool DeleteOnAction { get; set; }

        /// <summary>
        /// If true, the entire stack is deleted when the action completes.
        /// </summary>
        [DataMember(Name = "consumeEntireStack", EmitDefaultValue = false)]
        public bool ConsumeEntireStack { get; set; }

        /// <summary>
        /// If true, this action will be performed as soon as you earn this item. Some rewards work this way, providing you a single item to pick up from a reward-granting vendor in-game and then immediately consuming itself to provide you multiple items.
        /// </summary>
        [DataMember(Name = "useOnAcquire", EmitDefaultValue = false)]
        public bool UseOnAcquire { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemActionBlockDefinition);
        }

        public bool Equals(DestinyItemActionBlockDefinition input)
        {
            if (input == null) return false;

            return
                (
                    VerbName == input.VerbName ||
                    (VerbName != null && VerbName.Equals(input.VerbName))
                ) &&
                (
                    VerbDescription == input.VerbDescription ||
                    (VerbDescription != null && VerbDescription.Equals(input.VerbDescription))
                ) &&
                (
                    IsPositive == input.IsPositive ||
                    (IsPositive != null && IsPositive.Equals(input.IsPositive))
                ) &&
                (
                    OverlayScreenName == input.OverlayScreenName ||
                    (OverlayScreenName != null && OverlayScreenName.Equals(input.OverlayScreenName))
                ) &&
                (
                    OverlayIcon == input.OverlayIcon ||
                    (OverlayIcon != null && OverlayIcon.Equals(input.OverlayIcon))
                ) &&
                (
                    RequiredCooldownSeconds == input.RequiredCooldownSeconds ||
                    (RequiredCooldownSeconds.Equals(input.RequiredCooldownSeconds))
                ) &&
                (
                    RequiredItems == input.RequiredItems ||
                    (RequiredItems != null && RequiredItems.SequenceEqual(input.RequiredItems))
                ) &&
                (
                    ProgressionRewards == input.ProgressionRewards ||
                    (ProgressionRewards != null && ProgressionRewards.SequenceEqual(input.ProgressionRewards))
                ) &&
                (
                    ActionTypeLabel == input.ActionTypeLabel ||
                    (ActionTypeLabel != null && ActionTypeLabel.Equals(input.ActionTypeLabel))
                ) &&
                (
                    RequiredLocation == input.RequiredLocation ||
                    (RequiredLocation != null && RequiredLocation.Equals(input.RequiredLocation))
                ) &&
                (
                    RequiredCooldownHash == input.RequiredCooldownHash ||
                    (RequiredCooldownHash.Equals(input.RequiredCooldownHash))
                ) &&
                (
                    DeleteOnAction == input.DeleteOnAction ||
                    (DeleteOnAction != null && DeleteOnAction.Equals(input.DeleteOnAction))
                ) &&
                (
                    ConsumeEntireStack == input.ConsumeEntireStack ||
                    (ConsumeEntireStack != null && ConsumeEntireStack.Equals(input.ConsumeEntireStack))
                ) &&
                (
                    UseOnAcquire == input.UseOnAcquire ||
                    (UseOnAcquire != null && UseOnAcquire.Equals(input.UseOnAcquire))
                ) ;
        }
    }
}

