using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// If the plug has a specific custom style, this enumeration will represent that style/those styles.
    /// </summary>
    [Flags]
    public enum PlugUiStyles
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Masterwork = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Masterwork = 1,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}