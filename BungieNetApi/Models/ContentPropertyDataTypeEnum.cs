using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    
    public enum ContentPropertyDataTypeEnum
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Plaintext = 1
        /// </summary>
        [EnumMember(Value = "1")]
        Plaintext = 1,

        /// <summary>
        /// Html = 2
        /// </summary>
        [EnumMember(Value = "2")]
        Html = 2,

        /// <summary>
        /// Dropdown = 3
        /// </summary>
        [EnumMember(Value = "3")]
        Dropdown = 3,

        /// <summary>
        /// List = 4
        /// </summary>
        [EnumMember(Value = "4")]
        List = 4,

        /// <summary>
        /// Json = 5
        /// </summary>
        [EnumMember(Value = "5")]
        Json = 5,

        /// <summary>
        /// Content = 6
        /// </summary>
        [EnumMember(Value = "6")]
        Content = 6,

        /// <summary>
        /// Representation = 7
        /// </summary>
        [EnumMember(Value = "7")]
        Representation = 7,

        /// <summary>
        /// Set = 8
        /// </summary>
        [EnumMember(Value = "8")]
        Set = 8,

        /// <summary>
        /// File = 9
        /// </summary>
        [EnumMember(Value = "9")]
        File = 9,

        /// <summary>
        /// FolderSet = 10
        /// </summary>
        [EnumMember(Value = "10")]
        FolderSet = 10,

        /// <summary>
        /// Date = 11
        /// </summary>
        [EnumMember(Value = "11")]
        Date = 11,

        /// <summary>
        /// MultilinePlaintext = 12
        /// </summary>
        [EnumMember(Value = "12")]
        MultilinePlaintext = 12,

        /// <summary>
        /// DestinyContent = 13
        /// </summary>
        [EnumMember(Value = "13")]
        DestinyContent = 13,

        /// <summary>
        /// Color = 14
        /// </summary>
        [EnumMember(Value = "14")]
        Color = 14,

    }
}