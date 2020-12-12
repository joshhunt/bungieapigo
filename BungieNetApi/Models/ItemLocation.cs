using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum ItemLocation
    {
        /// <summary>
        /// Unknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unknown = 0,

        /// <summary>
        /// Inventory = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Inventory = 1,

        /// <summary>
        /// Vault = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Vault = 2,

        /// <summary>
        /// Vendor = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Vendor = 3,

        /// <summary>
        /// Postmaster = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Postmaster = 4,

    }
}