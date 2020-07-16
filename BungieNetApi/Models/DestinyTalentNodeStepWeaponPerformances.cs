using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum DestinyTalentNodeStepWeaponPerformances
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// RateOfFire = 1
        /// </summary>
        [EnumMember(Value = "1")]
        RateOfFire = 1,

        /// <summary>
        /// Damage = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Damage = 2,

        /// <summary>
        /// Accuracy = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Accuracy = 4,

        /// <summary>
        /// Range = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Range = 8,

        /// <summary>
        /// Zoom = 16
        /// </summary>
        [EnumMember(Value = "16")]
        Zoom = 16,

        /// <summary>
        /// Recoil = 32
        /// </summary>
        [EnumMember(Value = "32")]
        Recoil = 32,

        /// <summary>
        /// Ready = 64
        /// </summary>
        [EnumMember(Value = "64")]
        Ready = 64,

        /// <summary>
        /// Reload = 128
        /// </summary>
        [EnumMember(Value = "128")]
        Reload = 128,

        /// <summary>
        /// HairTrigger = 256
        /// </summary>
        [EnumMember(Value = "256")]
        HairTrigger = 256,

        /// <summary>
        /// AmmoAndMagazine = 512
        /// </summary>
        [EnumMember(Value = "512")]
        AmmoAndMagazine = 512,

        /// <summary>
        /// TrackingAndDetonation = 1024
        /// </summary>
        [EnumMember(Value = "1024")]
        TrackingAndDetonation = 1024,

        /// <summary>
        /// ShotgunSpread = 2048
        /// </summary>
        [EnumMember(Value = "2048")]
        ShotgunSpread = 2048,

        /// <summary>
        /// ChargeTime = 4096
        /// </summary>
        [EnumMember(Value = "4096")]
        ChargeTime = 4096,

        /// <summary>
        /// All = 8191
        /// </summary>
        [EnumMember(Value = "8191")]
        All = 8191,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}