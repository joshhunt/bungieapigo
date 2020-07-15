using System.Runtime.Serialization;

namespace GhostSharp.BungieNetApi.Models
{
    /// <summary>
    /// If you're showing an unlock value in the UI, this is the format in which it should be shown. You'll have to build your own algorithms on the client side to determine how best to render these options.
    /// </summary>
    
    public enum DestinyUnlockValueUIStyle
    {
        /// <summary>
        /// Automatic = 0
        /// Generally, Automatic means &quot;Just show the number&quot;
        /// </summary>
        [EnumMember(Value = "0")]
        Automatic = 0,

        /// <summary>
        /// Fraction = 1
        /// Show the number as a fractional value. For this to make sense, the value being displayed should have a comparable upper bound, like the progress to the next level of a Progression.
        /// </summary>
        [EnumMember(Value = "1")]
        Fraction = 1,

        /// <summary>
        /// Checkbox = 2
        /// Show the number as a checkbox. 0 Will mean unchecked, any other value will mean checked.
        /// </summary>
        [EnumMember(Value = "2")]
        Checkbox = 2,

        /// <summary>
        /// Percentage = 3
        /// Show the number as a percentage. For this to make sense, the value being displayed should have a comparable upper bound, like the progress to the next level of a Progression.
        /// </summary>
        [EnumMember(Value = "3")]
        Percentage = 3,

        /// <summary>
        /// DateTime = 4
        /// Show the number as a date and time. The number will be the number of seconds since the Unix Epoch (January 1st, 1970 at midnight UTC). It&#39;ll be up to you to convert this into a date and time format understandable to the user in their time zone.
        /// </summary>
        [EnumMember(Value = "4")]
        DateTime = 4,

        /// <summary>
        /// FractionFloat = 5
        /// Show the number as a floating point value that represents a fraction, where 0 is min and 1 is max. For this to make sense, the value being displayed should have a comparable upper bound, like the progress to the next level of a Progression.
        /// </summary>
        [EnumMember(Value = "5")]
        FractionFloat = 5,

        /// <summary>
        /// Integer = 6
        /// Show the number as a straight-up integer.
        /// </summary>
        [EnumMember(Value = "6")]
        Integer = 6,

        /// <summary>
        /// TimeDuration = 7
        /// Show the number as a time duration. The value will be returned as seconds.
        /// </summary>
        [EnumMember(Value = "7")]
        TimeDuration = 7,

        /// <summary>
        /// Hidden = 8
        /// Don&#39;t bother showing the value at all, it&#39;s not easily human-interpretable, and used for some internal purpose.
        /// </summary>
        [EnumMember(Value = "8")]
        Hidden = 8,

        /// <summary>
        /// Multiplier = 9
        /// Example: &quot;1.5x&quot;
        /// </summary>
        [EnumMember(Value = "9")]
        Multiplier = 9,

        /// <summary>
        /// GreenPips = 10
        /// Show the value as a series of green pips, like the wins in a Trials of Osiris score card.
        /// </summary>
        [EnumMember(Value = "10")]
        GreenPips = 10,

        /// <summary>
        /// RedPips = 11
        /// Show the value as a series of red pips, like the losses in a Trials of Osiris score card.
        /// </summary>
        [EnumMember(Value = "11")]
        RedPips = 11,

        /// <summary>
        /// ExplicitPercentage = 12
        /// Show the value as a percentage. For example: &quot;51%&quot; - Does no division, only appends &#39;%&#39;
        /// </summary>
        [EnumMember(Value = "12")]
        ExplicitPercentage = 12,

        /// <summary>
        /// RawFloat = 13
        /// Show the value as a floating-point number. For example: &quot;4.52&quot; NOTE: Passed along from Investment as whole number with last two digits as decimal values (452 -&gt; 4.52)
        /// </summary>
        [EnumMember(Value = "13")]
        RawFloat = 13,

        ///value not found fallback
        [EnumMember(Value = "999999999")]
        ProtectedInvalidEnumValue = 999999999
    }
}