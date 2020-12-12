using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    [DataContract]
    public class DestinyItemTierTypeInfusionBlock
    {
        /// <summary>
        /// The default portion of quality that will transfer from the infuser to the infusee item. (InfuserQuality - InfuseeQuality) * baseQualityTransferRatio = base quality transferred.
        /// </summary>
        [DataMember(Name = "baseQualityTransferRatio", EmitDefaultValue = false)]
        public double BaseQualityTransferRatio { get; set; }

        /// <summary>
        /// As long as InfuserQuality > InfuseeQuality, the amount of quality bestowed is guaranteed to be at least this value, even if the transferRatio would dictate that it should be less. The total amount of quality that ends up in the Infusee cannot exceed the Infuser's quality however (for instance, if you infuse a 300 item with a 301 item and the minimum quality increment is 10, the infused item will not end up with 310 quality)
        /// </summary>
        [DataMember(Name = "minimumQualityIncrement", EmitDefaultValue = false)]
        public long MinimumQualityIncrement { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyItemTierTypeInfusionBlock);
        }

        public bool Equals(DestinyItemTierTypeInfusionBlock input)
        {
            if (input == null) return false;

            return
                (
                    BaseQualityTransferRatio == input.BaseQualityTransferRatio ||
                    (BaseQualityTransferRatio.Equals(input.BaseQualityTransferRatio))
                ) &&
                (
                    MinimumQualityIncrement == input.MinimumQualityIncrement ||
                    (MinimumQualityIncrement.Equals(input.MinimumQualityIncrement))
                ) ;
        }
    }
}

