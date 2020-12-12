using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum ForumTopicsQuickDateEnum
    {
        /// <summary>
        /// All = 0
        /// </summary>
        [EnumMember(Value = "0")]
        All = 0,

        /// <summary>
        /// LastYear = 1
        /// </summary>
        [EnumMember(Value = "1")]
        LastYear = 1,

        /// <summary>
        /// LastMonth = 2
        /// </summary>
        [EnumMember(Value = "2")]
        LastMonth = 2,

        /// <summary>
        /// LastWeek = 3
        /// </summary>
        [EnumMember(Value = "3")]
        LastWeek = 3,

        /// <summary>
        /// LastDay = 4
        /// </summary>
        [EnumMember(Value = "4")]
        LastDay = 4,

    }
}