using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum AwaUserSelection
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Rejected = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Rejected = 1,

        /// <summary>
        /// Approved = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Approved = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}