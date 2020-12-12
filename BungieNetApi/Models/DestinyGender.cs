using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum DestinyGender
    {
        /// <summary>
        /// Male = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Male = 0,

        /// <summary>
        /// Female = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Female = 1,

        /// <summary>
        /// Unknown = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Unknown = 2,

    }
}