using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Indicates how a perk should be shown, or if it should be, in the game UI. Maybe useful for those of you trying to filter out internal-use-only perks (or for those of you trying to figure out what they do!)
    /// </summary>
    
    public enum ItemPerkVisibility
    {
        /// <summary>
        /// Visible = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Visible = 0,

        /// <summary>
        /// Disabled = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Disabled = 1,

        /// <summary>
        /// Hidden = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Hidden = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}