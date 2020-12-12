using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum ForumRecruitmentIntensityLabel
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Casual = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Casual = 1,

        /// <summary>
        /// Professional = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Professional = 2,

    }
}