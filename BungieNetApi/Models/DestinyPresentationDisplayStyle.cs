using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// A hint for how the presentation node should be displayed when shown in a list. How you use this is your UI is up to you.
    /// </summary>
    
    public enum DestinyPresentationDisplayStyle
    {
        /// <summary>
        /// Category = 0
        /// Display the item as a category, through which sub-items are filtered.
        /// </summary>
        [EnumMember(Value = "0")]
        Category = 0,

        /// <summary>
        /// Badge = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Badge = 1,

        /// <summary>
        /// Medals = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Medals = 2,

        /// <summary>
        /// Collectible = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Collectible = 3,

        /// <summary>
        /// Record = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Record = 4,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}