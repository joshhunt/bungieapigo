using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum DestinyTalentNodeStepLightAbilities
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Grenades = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Grenades = 1,

        /// <summary>
        /// Melee = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Melee = 2,

        /// <summary>
        /// MovementModes = 4
        /// </summary>
        [EnumMember(Value = "4")]
        MovementModes = 4,

        /// <summary>
        /// Orbs = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Orbs = 8,

        /// <summary>
        /// SuperEnergy = 16
        /// </summary>
        [EnumMember(Value = "16")]
        SuperEnergy = 16,

        /// <summary>
        /// SuperMods = 32
        /// </summary>
        [EnumMember(Value = "32")]
        SuperMods = 32,

        /// <summary>
        /// All = 63
        /// </summary>
        [EnumMember(Value = "63")]
        All = 63,

    }
}