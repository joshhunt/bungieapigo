using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupPostPublicity
    {
        /// <summary>
        /// Public = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Public = 0,

        /// <summary>
        /// Alliance = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Alliance = 1,

        /// <summary>
        /// Private = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Private = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}