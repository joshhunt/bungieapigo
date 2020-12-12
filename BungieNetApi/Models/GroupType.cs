using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum GroupType
    {
        /// <summary>
        /// General = 0
        /// </summary>
        [EnumMember(Value = "0")]
        General = 0,

        /// <summary>
        /// Clan = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Clan = 1,

    }
}