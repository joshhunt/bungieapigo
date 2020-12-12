using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// This determines the type of reply that a Vendor will have during an Interaction.
    /// </summary>
    
    public enum DestinyVendorReplyType
    {
        /// <summary>
        /// Accept = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Accept = 0,

        /// <summary>
        /// Decline = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Decline = 1,

        /// <summary>
        /// Complete = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Complete = 2,

    }
}