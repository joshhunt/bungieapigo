using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum FireteamPublicSearchOption
    {
        /// <summary>
        /// PublicAndPrivate = 0
        /// </summary>
        [EnumMember(Value = "0")]
        PublicAndPrivate = 0,

        /// <summary>
        /// PublicOnly = 1
        /// </summary>
        [EnumMember(Value = "1")]
        PublicOnly = 1,

        /// <summary>
        /// PrivateOnly = 2
        /// </summary>
        [EnumMember(Value = "2")]
        PrivateOnly = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}