using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// Represents the socket energy types for Armor 2.0, Ghosts 2.0, and Stasis subclasses.
    /// </summary>
    
    public enum DestinyEnergyType
    {
        /// <summary>
        /// Any = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Any = 0,

        /// <summary>
        /// Arc = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Arc = 1,

        /// <summary>
        /// Thermal = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Thermal = 2,

        /// <summary>
        /// Void = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Void = 3,

        /// <summary>
        /// Ghost = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Ghost = 4,

        /// <summary>
        /// Subclass = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Subclass = 5,

        /// <summary>
        /// Stasis = 6
        /// </summary>
        [EnumMember(Value = "6")]
        Stasis = 6,

    }
}