using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// If progression is earned, this determines whether the progression shows visual effects on the character or its item - or neither.
    /// </summary>
    
    public enum DestinyProgressionStepDisplayEffect
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

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

    }
}