using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// A specific reason for being banned. Only accessible under the related category (DestinyReportReasonCategoryDefinition) under which it is shown. Note that this means that report reasons' reasonHash are not globally unique: and indeed, entries like "Other" are defined under most categories for example.
    /// </summary>
    [DataContract]
    public class DestinyReportReasonDefinition
    {
        /// <summary>
        /// The identifier for the reason: they are only guaranteed unique under the Category in which they are found.
        /// </summary>
        [DataMember(Name = "reasonHash", EmitDefaultValue = false)]
        public uint ReasonHash { get; set; }

        /// <summary>
        /// Many Destiny*Definition contracts - the "first order" entities of Destiny that have their own tables in the Manifest Database - also have displayable information. This is the base class for that display information.
        /// </summary>
        [DataMember(Name = "displayProperties", EmitDefaultValue = false)]
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }


        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyReportReasonDefinition);
        }

        public bool Equals(DestinyReportReasonDefinition input)
        {
            if (input == null) return false;

            return
                (
                    ReasonHash == input.ReasonHash ||
                    (ReasonHash != null && ReasonHash.Equals(input.ReasonHash))
                ) &&
                (
                    DisplayProperties == input.DisplayProperties ||
                    (DisplayProperties != null && DisplayProperties.Equals(input.DisplayProperties))
                ) ;
        }
    }
}

