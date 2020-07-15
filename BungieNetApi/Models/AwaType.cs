using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum AwaType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// InsertPlugs = 1
        /// Insert plugs into sockets.
        /// </summary>
        [EnumMember(Value = "1")]
        InsertPlugs = 1,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}