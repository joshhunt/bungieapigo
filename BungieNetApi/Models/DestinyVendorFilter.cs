using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Indicates the type of filter to apply to Vendor results.
    /// </summary>
    
    public enum DestinyVendorFilter
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}