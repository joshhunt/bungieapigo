using System.Runtime.Serialization;

namespace GhostSharper.Models
{
    /// <summary>
    /// This enum determines whether the plug is available to be inserted.
    /// </summary>
    /// <summary>
    /// - Normal means that all existing rules for plug insertion apply.
    /// </summary>
    /// <summary>
    /// - UnavailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket does NOT match the plug category.
    /// </summary>
    /// <summary>
    /// - AvailableIfSocketContainsMatchingPlugCategory means that the plug is only available if the socket DOES match the plug category.
    /// </summary>
    /// <summary>
    /// For category matching, use the plug's "plugCategoryIdentifier" property, comparing it to
    /// </summary>
    
    public enum PlugAvailabilityMode
    {
        /// <summary>
        /// Normal = 0
        /// </summary>
        [EnumMember(Value = "0")]
        Normal = 0,

        /// <summary>
        /// UnavailableIfSocketContainsMatchingPlugCategory = 1
        /// </summary>
        [EnumMember(Value = "1")]
        UnavailableIfSocketContainsMatchingPlugCategory = 1,

        /// <summary>
        /// AvailableIfSocketContainsMatchingPlugCategory = 2
        /// </summary>
        [EnumMember(Value = "2")]
        AvailableIfSocketContainsMatchingPlugCategory = 2,

    }
}