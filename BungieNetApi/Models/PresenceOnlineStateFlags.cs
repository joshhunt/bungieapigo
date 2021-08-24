using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum PresenceOnlineStateFlags
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Destiny1 = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Destiny1 = 1,

        /// <summary>
        /// Destiny2 = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Destiny2 = 2,

    }
}