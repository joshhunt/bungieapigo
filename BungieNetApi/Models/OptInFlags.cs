using System.Runtime.Serialization;
using System;

namespace GhostSharp.BungieNetApi.Models
{
    [Flags]
    public enum OptInFlags
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Newsletter = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Newsletter = 1,

        /// <summary>
        /// System = 2
        /// </summary>
        [EnumMember(Value = "2")]
        System = 2,

        /// <summary>
        /// Marketing = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Marketing = 4,

        /// <summary>
        /// UserResearch = 8
        /// </summary>
        [EnumMember(Value = "8")]
        UserResearch = 8,

        /// <summary>
        /// CustomerService = 16
        /// </summary>
        [EnumMember(Value = "16")]
        CustomerService = 16,

        /// <summary>
        /// Social = 32
        /// </summary>
        [EnumMember(Value = "32")]
        Social = 32,

        /// <summary>
        /// PlayTests = 64
        /// </summary>
        [EnumMember(Value = "64")]
        PlayTests = 64,

        /// <summary>
        /// PlayTestsLocal = 128
        /// </summary>
        [EnumMember(Value = "128")]
        PlayTestsLocal = 128,

        /// <summary>
        /// Careers = 256
        /// </summary>
        [EnumMember(Value = "256")]
        Careers = 256,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}