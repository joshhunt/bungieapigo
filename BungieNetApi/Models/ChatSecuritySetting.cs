using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum ChatSecuritySetting
    {
        /// <summary>
        /// Group = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Group = 0,

        /// <summary>
        /// Admins = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Admins = 1,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}