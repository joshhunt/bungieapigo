using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// A flags enumeration/bitmask where each bit represents a different possible state that the item can be in that may effect how the item is displayed to the user and what actions can be performed against it.
    /// </summary>
    [Flags]
    public enum ItemState
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Locked = 1
        /// If this bit is set, the item has been &quot;locked&quot; by the user and cannot be deleted. You may want to represent this visually with a &quot;lock&quot; icon.
        /// </summary>
        [EnumMember(Value = "1")]
        Locked = 1,

        /// <summary>
        /// Tracked = 2
        /// If this bit is set, the item is a quest that&#39;s being tracked by the user. You may want a visual indicator to show that this is a tracked quest.
        /// </summary>
        [EnumMember(Value = "2")]
        Tracked = 2,

        /// <summary>
        /// Masterwork = 4
        /// If this bit is set, the item has a Masterwork plug inserted. This usually coincides with having a special &quot;glowing&quot; effect applied to the item&#39;s icon.
        /// </summary>
        [EnumMember(Value = "4")]
        Masterwork = 4,

    }
}