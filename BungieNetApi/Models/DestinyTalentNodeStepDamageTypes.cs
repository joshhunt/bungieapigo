using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum DestinyTalentNodeStepDamageTypes
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Kinetic = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Kinetic = 1,

        /// <summary>
        /// Arc = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Arc = 2,

        /// <summary>
        /// Solar = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Solar = 4,

        /// <summary>
        /// Void = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Void = 8,

        /// <summary>
        /// All = 15
        /// </summary>
        [EnumMember(Value = "15")]
        All = 15,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}