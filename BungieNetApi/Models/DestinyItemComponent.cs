using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    /// <summary>
    /// The base item component, filled with properties that are generally useful to know in any item request or that don't feel worthwhile to put in their own component.
    /// </summary>
    [DataContract]
    public class DestinyItemComponent
    {
        /// <summary>
        /// The identifier for the item's definition, which is where most of the useful static information for the item can be found.
        /// </summary>
        [DataMember(Name = "itemHash", EmitDefaultValue = false)]
        public uint ItemHash { get; set; }

        /// <summary>
        /// If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.
        /// </summary>
        [DataMember(Name = "itemInstanceId", EmitDefaultValue = false)]
        public long ItemInstanceId { get; set; }

        /// <summary>
        /// The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)
        /// </summary>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public long Quantity { get; set; }

        /// <summary>
        /// If the item is bound to a location, it will be specified in this enum.
        /// </summary>
        [DataMember(Name = "bindStatus", EmitDefaultValue = false)]
        public ItemBindStatus BindStatus { get; set; }

        /// <summary>
        /// An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public ItemLocation Location { get; set; }

        /// <summary>
        /// The hash identifier for the specific inventory bucket in which the item is located.
        /// </summary>
        [DataMember(Name = "bucketHash", EmitDefaultValue = false)]
        public uint BucketHash { get; set; }

        /// <summary>
        /// If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).
        /// </summary>
        [DataMember(Name = "transferStatus", EmitDefaultValue = false)]
        public TransferStatuses TransferStatus { get; set; }

        /// <summary>
        /// If the item can be locked, this will indicate that state.
        /// </summary>
        [DataMember(Name = "lockable", EmitDefaultValue = false)]
        public bool Lockable { get; set; }

        /// <summary>
        /// A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it's tracked or locked for example, or whether it has a masterwork plug inserted.
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public ItemState State { get; set; }

        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.
        /// </summary>
        /// <summary>
        /// If you don't do this, certain items whose styles are being overridden by socketed items - such as the "Recycle Shader" item - would show whatever their default icon/style is, and it wouldn't be pretty or look accurate.
        /// </summary>
        [DataMember(Name = "overrideStyleItemHash", EmitDefaultValue = false)]
        public uint OverrideStyleItemHash { get; set; }

        /// <summary>
        /// If the item can expire, this is the date at which it will/did expire.
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// If this is true, the object is actually a "wrapper" of the object it's representing. This means that it's not the actual item itself, but rather an item that must be "opened" in game before you have and can use the item.
        /// </summary>
        /// <summary>
        ///  Wrappers are an evolution of "bundles", which give an easy way to let you preview the contents of what you purchased while still letting you get a refund before you "open" it.
        /// </summary>
        [DataMember(Name = "isWrapper", EmitDefaultValue = false)]
        public bool IsWrapper { get; set; }

        /// <summary>
        /// If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.
        /// </summary>
        [DataMember(Name = "tooltipNotificationIndexes", EmitDefaultValue = false)]
        public List<long> TooltipNotificationIndexes { get; set; }

        /// <summary>
        /// The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        [DataMember(Name = "metricHash", EmitDefaultValue = false)]
        public uint MetricHash { get; set; }

        /// <summary>
        /// The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        [DataMember(Name = "metricObjective", EmitDefaultValue = false)]
        public DestinyObjectiveProgress MetricObjective { get; set; }

        /// <summary>
        /// The version of this item, used to index into the versions list in the item definition quality block.
        /// </summary>
        [DataMember(Name = "versionNumber", EmitDefaultValue = false)]
        public long VersionNumber { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemComponent);
        }

        public bool Equals(DestinyItemComponent input)
        {
            if (input == null) return false;

            return
                (
                    ItemHash == input.ItemHash ||
                    (ItemHash != null && ItemHash.Equals(input.ItemHash))
                ) &&
                (
                    ItemInstanceId == input.ItemInstanceId ||
                    (ItemInstanceId != null && ItemInstanceId.Equals(input.ItemInstanceId))
                ) &&
                (
                    Quantity == input.Quantity ||
                    (Quantity != null && Quantity.Equals(input.Quantity))
                ) &&
                (
                    BindStatus == input.BindStatus ||
                    (BindStatus != null && BindStatus.Equals(input.BindStatus))
                ) &&
                (
                    Location == input.Location ||
                    (Location != null && Location.Equals(input.Location))
                ) &&
                (
                    BucketHash == input.BucketHash ||
                    (BucketHash != null && BucketHash.Equals(input.BucketHash))
                ) &&
                (
                    TransferStatus == input.TransferStatus ||
                    (TransferStatus != null && TransferStatus.Equals(input.TransferStatus))
                ) &&
                (
                    Lockable == input.Lockable ||
                    (Lockable != null && Lockable.Equals(input.Lockable))
                ) &&
                (
                    State == input.State ||
                    (State != null && State.Equals(input.State))
                ) &&
                (
                    OverrideStyleItemHash == input.OverrideStyleItemHash ||
                    (OverrideStyleItemHash != null && OverrideStyleItemHash.Equals(input.OverrideStyleItemHash))
                ) &&
                (
                    ExpirationDate == input.ExpirationDate ||
                    (ExpirationDate != null && ExpirationDate.Equals(input.ExpirationDate))
                ) &&
                (
                    IsWrapper == input.IsWrapper ||
                    (IsWrapper != null && IsWrapper.Equals(input.IsWrapper))
                ) &&
                (
                    TooltipNotificationIndexes == input.TooltipNotificationIndexes ||
                    (TooltipNotificationIndexes != null && TooltipNotificationIndexes.Equals(input.TooltipNotificationIndexes))
                ) &&
                (
                    MetricHash == input.MetricHash ||
                    (MetricHash != null && MetricHash.Equals(input.MetricHash))
                ) &&
                (
                    MetricObjective == input.MetricObjective ||
                    (MetricObjective != null && MetricObjective.Equals(input.MetricObjective))
                ) &&
                (
                    VersionNumber == input.VersionNumber ||
                    (VersionNumber != null && VersionNumber.Equals(input.VersionNumber))
                ) ;
        }
    }
}

