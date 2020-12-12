using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum DamageType
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
        /// Thermal = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Thermal = 3,

        /// <summary>
        /// Void = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Void = 4,

        /// <summary>
        /// Raid = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Raid = 5,

    }
}