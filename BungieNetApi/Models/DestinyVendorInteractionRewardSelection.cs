using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// When a Vendor Interaction provides rewards, they'll either let you choose one or let you have all of them. This determines which it will be.
    /// </summary>
    
    public enum DestinyVendorInteractionRewardSelection
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// One = 1
        /// </summary>
        [EnumMember(Value = "1")]
        One = 1,

        /// <summary>
        /// All = 2
        /// </summary>
        [EnumMember(Value = "2")]
        All = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}