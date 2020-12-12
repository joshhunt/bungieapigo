using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupHomepage
    {
        /// <summary>
        /// Wall = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Wall = 0,

        /// <summary>
        /// Forum = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Forum = 1,

        /// <summary>
        /// AllianceForum = 2
        /// </summary>
        [EnumMember(Value = "2")]
        AllianceForum = 2,

    }
}