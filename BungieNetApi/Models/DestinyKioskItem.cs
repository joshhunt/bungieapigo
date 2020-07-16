using System.Runtime.Serialization;
using System.Collections.Generic;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyKioskItem
    {
        /// <summary>
        /// The index of the item in the related DestinyVendorDefintion's itemList property, representing the sale.
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public long Index { get; set; }

        /// <summary>
        /// If true, the user can not only see the item, but they can acquire it. It is possible that a user can see a kiosk item and not be able to acquire it.
        /// </summary>
        [DataMember(Name = "canAcquire", EmitDefaultValue = false)]
        public bool CanAcquire { get; set; }

        /// <summary>
        /// Indexes into failureStrings for the Vendor, indicating the reasons why it failed if any.
        /// </summary>
        [DataMember(Name = "failureIndexes", EmitDefaultValue = false)]
        public List<long> FailureIndexes { get; set; }

        /// <summary>
        /// I may regret naming it this way - but this represents when an item has an objective that doesn't serve a beneficial purpose, but rather is used for "flavor" or additional information. For instance, when Emblems track specific stats, those stats are represented as Objectives on the item.
        /// </summary>
        [DataMember(Name = "flavorObjective", EmitDefaultValue = false)]
        public DestinyObjectiveProgress FlavorObjective { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyKioskItem);
        }

        public bool Equals(DestinyKioskItem input)
        {
            if (input == null) return false;

            return
                (
                    Index == input.Index ||
                    (Index != null && Index.Equals(input.Index))
                ) &&
                (
                    CanAcquire == input.CanAcquire ||
                    (CanAcquire != null && CanAcquire.Equals(input.CanAcquire))
                ) &&
                (
                    FailureIndexes == input.FailureIndexes ||
                    (FailureIndexes != null && FailureIndexes.Equals(input.FailureIndexes))
                ) &&
                (
                    FlavorObjective == input.FlavorObjective ||
                    (FlavorObjective != null && FlavorObjective.Equals(input.FlavorObjective))
                ) ;
        }
    }
}

