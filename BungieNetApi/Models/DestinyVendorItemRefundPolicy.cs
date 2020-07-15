using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// The action that happens when the user attempts to refund an item.
    /// </summary>
    
    public enum DestinyVendorItemRefundPolicy
    {
        /// <summary>
        /// NotRefundable = 0
        /// </summary>
        [EnumMember(Value = "0")]
        NotRefundable = 0,

        /// <summary>
        /// DeletesItem = 1
        /// </summary>
        [EnumMember(Value = "1")]
        DeletesItem = 1,

        /// <summary>
        /// RevokesLicense = 2
        /// </summary>
        [EnumMember(Value = "2")]
        RevokesLicense = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}