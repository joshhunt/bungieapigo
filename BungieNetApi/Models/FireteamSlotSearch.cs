using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum FireteamSlotSearch
    {
        /// <summary>
        /// NoSlotRestriction = 0
        /// </summary>
        [EnumMember(Value = "0")]
        NoSlotRestriction = 0,

        /// <summary>
        /// HasOpenPlayerSlots = 1
        /// </summary>
        [EnumMember(Value = "1")]
        HasOpenPlayerSlots = 1,

        /// <summary>
        /// HasOpenPlayerOrAltSlots = 2
        /// </summary>
        [EnumMember(Value = "2")]
        HasOpenPlayerOrAltSlots = 2,

    }
}