using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Describes the type of progression that a vendor has.
    /// </summary>
    
    public enum DestinyVendorProgressionType
    {
        /// <summary>
        /// Default = 0
        /// The original rank progression from token redemption.
        /// </summary>
        [EnumMember(Value = "0")]
        Default = 0,

        /// <summary>
        /// Ritual = 1
        /// Progression from ranks in ritual content. For example: Crucible (Shaxx), Gambit (Drifter), and Season 13 Battlegrounds (War Table).
        /// </summary>
        [EnumMember(Value = "1")]
        Ritual = 1,

    }
}