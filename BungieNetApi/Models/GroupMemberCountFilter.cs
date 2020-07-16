using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupMemberCountFilter
    {
        /// <summary>
        /// All = 0
        /// </summary>
        [EnumMember(Value = "0")]
        All = 0,

        /// <summary>
        /// OneToTen = 1
        /// </summary>
        [EnumMember(Value = "1")]
        OneToTen = 1,

        /// <summary>
        /// ElevenToOneHundred = 2
        /// </summary>
        [EnumMember(Value = "2")]
        ElevenToOneHundred = 2,

        /// <summary>
        /// GreaterThanOneHundred = 3
        /// </summary>
        [EnumMember(Value = "3")]
        GreaterThanOneHundred = 3,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}