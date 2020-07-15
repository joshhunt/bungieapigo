using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// Used for setting the guided game permission level override (admins and founders can always host guided games).
    /// </summary>
    
    public enum HostGuidedGamesPermissionLevel
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Beginner = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Beginner = 1,

        /// <summary>
        /// Member = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Member = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}