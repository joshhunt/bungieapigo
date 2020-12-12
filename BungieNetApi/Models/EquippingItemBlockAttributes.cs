using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum EquippingItemBlockAttributes
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// EquipOnAcquire = 1
        /// </summary>
        [EnumMember(Value = "1")]
        EquipOnAcquire = 1,

    }
}