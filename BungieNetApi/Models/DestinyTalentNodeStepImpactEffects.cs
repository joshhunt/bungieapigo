using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum DestinyTalentNodeStepImpactEffects
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// ArmorPiercing = 1
        /// </summary>
        [EnumMember(Value = "1")]
        ArmorPiercing = 1,

        /// <summary>
        /// Ricochet = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Ricochet = 2,

        /// <summary>
        /// Flinch = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Flinch = 4,

        /// <summary>
        /// CollateralDamage = 8
        /// </summary>
        [EnumMember(Value = "8")]
        CollateralDamage = 8,

        /// <summary>
        /// Disorient = 16
        /// </summary>
        [EnumMember(Value = "16")]
        Disorient = 16,

        /// <summary>
        /// HighlightTarget = 32
        /// </summary>
        [EnumMember(Value = "32")]
        HighlightTarget = 32,

        /// <summary>
        /// All = 63
        /// </summary>
        [EnumMember(Value = "63")]
        All = 63,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}