using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GlobalAlertLevel
    {
        /// <summary>
        /// Unknown = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unknown = 0,

        /// <summary>
        /// Blue = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Blue = 1,

        /// <summary>
        /// Yellow = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Yellow = 2,

        /// <summary>
        /// Red = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Red = 3,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}