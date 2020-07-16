using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum DeveloperRole
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Owner = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Owner = 1,

        /// <summary>
        /// TeamMember = 2
        /// </summary>
        [EnumMember(Value = "2")]
        TeamMember = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}