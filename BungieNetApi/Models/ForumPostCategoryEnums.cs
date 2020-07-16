using System.Runtime.Serialization;
using System;

namespace GhostSharper.Models
{
    [Flags]
    public enum ForumPostCategoryEnums
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// TextOnly = 1
        /// </summary>
        [EnumMember(Value = "1")]
        TextOnly = 1,

        /// <summary>
        /// Media = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Media = 2,

        /// <summary>
        /// Link = 4
        /// </summary>
        [EnumMember(Value = "4")]
        Link = 4,

        /// <summary>
        /// Poll = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Poll = 8,

        /// <summary>
        /// Question = 16
        /// </summary>
        [EnumMember(Value = "16")]
        Question = 16,

        /// <summary>
        /// Answered = 32
        /// </summary>
        [EnumMember(Value = "32")]
        Answered = 32,

        /// <summary>
        /// Announcement = 64
        /// </summary>
        [EnumMember(Value = "64")]
        Announcement = 64,

        /// <summary>
        /// ContentComment = 128
        /// </summary>
        [EnumMember(Value = "128")]
        ContentComment = 128,

        /// <summary>
        /// BungieOfficial = 256
        /// </summary>
        [EnumMember(Value = "256")]
        BungieOfficial = 256,

        /// <summary>
        /// NinjaOfficial = 512
        /// </summary>
        [EnumMember(Value = "512")]
        NinjaOfficial = 512,

        /// <summary>
        /// Recruitment = 1024
        /// </summary>
        [EnumMember(Value = "1024")]
        Recruitment = 1024,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}