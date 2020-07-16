using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// I know this doesn't look like a Flags Enumeration/bitmask right now, but I assure you it is. This is the possible states that a Presentation Node can be in, and it is almost certain that its potential states will increase in the future. So don't treat it like a straight up enumeration.
    /// </summary>
    [Flags]
    public enum DestinyPresentationNodeState
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Invisible = 1
        /// If this is set, the game recommends that you not show this node. But you know your life, do what you&#39;ve got to do.
        /// </summary>
        [EnumMember(Value = "1")]
        Invisible = 1,

        /// <summary>
        /// Obscured = 2
        /// Turns out Presentation Nodes can also be obscured. If they are, this is set.
        /// </summary>
        [EnumMember(Value = "2")]
        Obscured = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}