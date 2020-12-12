using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum DestinySocketVisibility
    {
        /// <summary>
        /// Visible = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Visible = 0,

        /// <summary>
        /// Hidden = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Hidden = 1,

        /// <summary>
        /// HiddenWhenEmpty = 2
        /// </summary>
        [EnumMember(Value = "2")]
        HiddenWhenEmpty = 2,

        /// <summary>
        /// HiddenIfNoPlugsAvailable = 3
        /// </summary>
        [EnumMember(Value = "3")]
        HiddenIfNoPlugsAvailable = 3,

    }
}