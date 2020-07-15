using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    
    public enum UnitType
    {
        /// <summary>
        /// None = 0
        /// </summary>
        [EnumMember(Value = "0")]
        None = 0,

        /// <summary>
        /// Count = 1
        /// Indicates the statistic is a simple count of something.
        /// </summary>
        [EnumMember(Value = "1")]
        Count = 1,

        /// <summary>
        /// PerGame = 2
        /// Indicates the statistic is a per game average.
        /// </summary>
        [EnumMember(Value = "2")]
        PerGame = 2,

        /// <summary>
        /// Seconds = 3
        /// Indicates the number of seconds
        /// </summary>
        [EnumMember(Value = "3")]
        Seconds = 3,

        /// <summary>
        /// Points = 4
        /// Indicates the number of points earned
        /// </summary>
        [EnumMember(Value = "4")]
        Points = 4,

        /// <summary>
        /// Team = 5
        /// Values represents a team ID
        /// </summary>
        [EnumMember(Value = "5")]
        Team = 5,

        /// <summary>
        /// Distance = 6
        /// Values represents a distance (units to-be-determined)
        /// </summary>
        [EnumMember(Value = "6")]
        Distance = 6,

        /// <summary>
        /// Percent = 7
        /// Ratio represented as a whole value from 0 to 100.
        /// </summary>
        [EnumMember(Value = "7")]
        Percent = 7,

        /// <summary>
        /// Ratio = 8
        /// Ratio of something, shown with decimal places
        /// </summary>
        [EnumMember(Value = "8")]
        Ratio = 8,

        /// <summary>
        /// Boolean = 9
        /// True or false
        /// </summary>
        [EnumMember(Value = "9")]
        Boolean = 9,

        /// <summary>
        /// WeaponType = 10
        /// The stat is actually a weapon type.
        /// </summary>
        [EnumMember(Value = "10")]
        WeaponType = 10,

        /// <summary>
        /// Standing = 11
        /// Indicates victory, defeat, or something in between.
        /// </summary>
        [EnumMember(Value = "11")]
        Standing = 11,

        /// <summary>
        /// Milliseconds = 12
        /// Number of milliseconds some event spanned. For example, race time, or lap time.
        /// </summary>
        [EnumMember(Value = "12")]
        Milliseconds = 12,

        /// <summary>
        /// CompletionReason = 13
        /// The value is a enumeration of the Completion Reason type.
        /// </summary>
        [EnumMember(Value = "13")]
        CompletionReason = 13,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}