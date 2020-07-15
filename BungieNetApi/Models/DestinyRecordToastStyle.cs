using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum DestinyRecordToastStyle
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Record = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Record = 1,

        /// <summary>
        /// Lore = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Lore = 2,

        /// <summary>
        /// Badge = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Badge = 3,

        /// <summary>
        /// MetaRecord = 4
        /// </summary>
        [EnumMember(Value = "4")]
        MetaRecord = 4,

        /// <summary>
        /// MedalComplete = 5
        /// </summary>
        [EnumMember(Value = "5")]
        MedalComplete = 5,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}