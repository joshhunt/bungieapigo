using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupAllianceStatus
    {
        /// <summary>
        /// Unallied = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Unallied = 0,

        /// <summary>
        /// Parent = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Parent = 1,

        /// <summary>
        /// Child = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Child = 2,

    }
}