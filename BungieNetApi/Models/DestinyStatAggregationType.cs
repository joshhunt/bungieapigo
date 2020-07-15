using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// When a Stat (DestinyStatDefinition) is aggregated, this is the rules used for determining the level and formula used for aggregation.
    /// </summary>
    /// <summary>
    /// * CharacterAverage = apply a weighted average using the related DestinyStatGroupDefinition on the DestinyInventoryItemDefinition across the character's equipped items. See both of those definitions for details. * Character = don't aggregate: the stat should be located and used directly on the character. * Item = don't aggregate: the stat should be located and used directly on the item.
    /// </summary>
    
    public enum DestinyStatAggregationType
    {
        /// <summary>
        /// CharacterAverage = 0
        /// </summary>
        [EnumMember(Value = "0")]
        CharacterAverage = 0,

        /// <summary>
        /// Character = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Character = 1,

        /// <summary>
        /// Item = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Item = 2,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}