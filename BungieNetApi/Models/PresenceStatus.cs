using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum PresenceStatus
    {
        /// <summary>
        /// OfflineOrUnknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        OfflineOrUnknown = 0,

        /// <summary>
        /// Online = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Online = 1,

    }
}