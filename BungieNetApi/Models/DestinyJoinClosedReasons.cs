using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    /// <summary>
    /// A Flags enumeration representing the reasons why a person can't join this user's fireteam.
    /// </summary>
    [Flags]
    public enum DestinyJoinClosedReasons
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// InMatchmaking = 1
        /// The user is currently in matchmaking.
        /// </summary>
        [EnumMember(Value = "1")]
        InMatchmaking = 1,

        /// <summary>
        /// Loading = 2
        /// The user is currently in a loading screen.
        /// </summary>
        [EnumMember(Value = "2")]
        Loading = 2,

        /// <summary>
        /// SoloMode = 4
        /// The user is in an activity that requires solo play.
        /// </summary>
        [EnumMember(Value = "4")]
        SoloMode = 4,

        /// <summary>
        /// InternalReasons = 8
        /// The user can&#39;t be joined for one of a variety of internal reasons. Basically, the game can&#39;t let you join at this time, but for reasons that aren&#39;t under the control of this user.
        /// </summary>
        [EnumMember(Value = "8")]
        InternalReasons = 8,

        /// <summary>
        /// DisallowedByGameState = 16
        /// The user&#39;s current activity&#x2F;quest&#x2F;other transitory game state is preventing joining.
        /// </summary>
        [EnumMember(Value = "16")]
        DisallowedByGameState = 16,

        /// <summary>
        /// Offline = 32768
        /// The user appears to be offline.
        /// </summary>
        [EnumMember(Value = "32768")]
        Offline = 32768,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}