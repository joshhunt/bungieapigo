using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum DestinyStatsMergeMethod
    {
        /// <summary>
        /// Add = 0
        /// When collapsing multiple instances of the stat together, add the values.
        /// </summary>
        [EnumMember(Value = "0")]
        Add = 0,

        /// <summary>
        /// Min = 1
        /// When collapsing multiple instances of the stat together, take the lower value.
        /// </summary>
        [EnumMember(Value = "1")]
        Min = 1,

        /// <summary>
        /// Max = 2
        /// When collapsing multiple instances of the stat together, take the higher value.
        /// </summary>
        [EnumMember(Value = "2")]
        Max = 2,

    }
}